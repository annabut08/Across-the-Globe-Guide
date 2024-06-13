using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Across_the_Globe_Guide.Models;
using System.Text.Json;
using System.Text.RegularExpressions;



namespace Across_the_Globe_Guide.Models
{
    public class Handbook
    {
        public Handbook()
        {
            Regions = new List<Region>();
        }

        public List<Region> Regions { get; set; }

        // Пошук
        public List<Region> Search(string query)
        {
            var result = new List<Region>();

            try
            {
                bool found = false;

                foreach (var region in Regions)
                {
                    bool countryMatches = region.Country.Contains(query, StringComparison.OrdinalIgnoreCase);
                    bool capitalMatches = region.Capital.Contains(query, StringComparison.OrdinalIgnoreCase);
                    bool languageMatches = region.Language.Contains(query, StringComparison.OrdinalIgnoreCase);
                    bool currencyMatches = region.Currency.Contains(query, StringComparison.OrdinalIgnoreCase);
             
                    bool areaMatches = region.Area.ToString().Contains(query, StringComparison.OrdinalIgnoreCase);
                    bool continentMatches = region.Continent.Contains(query, StringComparison.OrdinalIgnoreCase);
                    bool presidentMatches = region.President.Contains(query, StringComparison.OrdinalIgnoreCase);

                    if (countryMatches || capitalMatches || languageMatches || currencyMatches ||
                         areaMatches || continentMatches || presidentMatches)
                    {
                        result.Add(region);
                        found = true;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Не знайдено відповідної країни або столиці.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Виникла помилка: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }
 
    

        // Збереження обраних рядків
        public void SaveToFile(List<Region> regions)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {
                        writer.WriteLine("Country\tCapital\tContinent\tPopulation\tArea\tInfo\tCurrency\tPresident\tPolitic\tAge\tWork\tProduct\tImagePath\tLanguage");

                        foreach (var region in regions)
                        {
                            writer.WriteLine($"{region.Country}\t{region.Capital}\t{region.Continent}\t{region.Population}\t{region.Area}\t{region.Info}\t{region.Currency}\t{region.President}\t{region.Politic}\t{region.Age}\t{region.Work}\t{region.Product}\t{region.ImagePath}\t{region.Language}");
                        }
                    }
                }
            }
        }

        public void SaveData(string path)
        {
            var jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText(path, jsonString);
        }

        public Handbook LoadData(string path)
        {
            var jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<Handbook>(jsonString);
        }
    }
}
