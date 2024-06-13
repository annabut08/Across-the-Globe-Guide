using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Across_the_Globe_Guide.Models;
using Across_the_Globe_Guide.Forms;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Data;
using System.ComponentModel;

namespace Across_the_Globe_Guide
{
    public partial class MainForm : Form
    {
        Handbook handbook = new Handbook();

        public MainForm()
        {
            InitializeComponent();

            var newFont = new Font("Courier New", 15, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = newFont;
            dataGridView.RowHeadersDefaultCellStyle.Font = newFont;

            var Font = new Font("Courier New", 14, FontStyle.Regular);
            dataGridView.DefaultCellStyle.Font = Font;
        }

        const string PATH_TO_DATA = ".\\handbook.txt";

        private void InfoEditForm_DataSaved(object sender, EventArgs e)
        {
            handbook.SaveData(PATH_TO_DATA);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handbook.SaveData(PATH_TO_DATA);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете вийти?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Close();
            }
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            handbook = handbook.LoadData(PATH_TO_DATA);
            var result = handbook.Search(countrytextBox.Text);
            regionBindingSource.DataSource = result;
        }

        private void mapToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var mapForm = new MapForm();
            mapForm.Show();
            this.Close();
        }
       
        private void addButton_Click(object sender, EventArgs e)
        {

            var addRegionForm = new AddRegionForm();


            if (addRegionForm.ShowDialog() == DialogResult.OK)
            {

                handbook.Regions.Add(addRegionForm.NewRegion);
                regionBindingSource.ResetBindings(false);
                handbook.SaveData(PATH_TO_DATA);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Ви впевнені, що хочете видалити?", "Попередження", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in dataGridView.SelectedRows)
                    {
                        int rowIndex = item.Index;

                        var regionToRemove = (Models.Region)item.DataBoundItem;
                        handbook.Regions.Remove(regionToRemove);
                        regionBindingSource.RemoveAt(rowIndex);
                    }

                    handbook.SaveData(PATH_TO_DATA);
                }
            }
            else
            {
                MessageBox.Show("Не обрано жодного рядка для видалення.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handbook = handbook.LoadData(PATH_TO_DATA);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            List<Models.Region> regionsToSave = new List<Models.Region>();
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                regionsToSave.Add((Models.Region)row.DataBoundItem);
            }

            if (regionsToSave.Count > 0)
            {
                handbook.SaveToFile(regionsToSave);
            }
            else
            {
                MessageBox.Show("Немає вибраних даних для збереження.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();

        }

        private void dataGridView_DoubleClick_1(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView.Rows[rowIndex];
                if (selectedRow != null)
                {
                    var region = selectedRow.DataBoundItem as Models.Region;
                    if (region != null)
                    {
                        var InfoEditForm = new InfoEditForm(region);
                  
                        InfoEditForm.DataSaved += InfoEditForm_DataSaved;
                        if (InfoEditForm.ShowDialog() == DialogResult.OK)
                        {
                            searchBtn_Click(null, null);
                        }
                    }
                }
            }
        }

        // 

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView.Rows[rowIndex];
                if (selectedRow != null)
                {
                    var region = selectedRow.DataBoundItem as Models.Region;
                    if (region != null)
                    {
                        if (!string.IsNullOrEmpty(region.ImagePath) && File.Exists(region.ImagePath))
                        {
                            pictureBox1.Image = Image.FromFile(region.ImagePath);
                        }
                        else
                        {
                            pictureBox1.Image = null;
                        }
                    }
                }
            }
        }
    }
 
}