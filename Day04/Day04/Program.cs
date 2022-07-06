using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

namespace Day02
{
    enum Superpower
    {
        Invincible, Strength, Speed, Money, Swimming
    }
    class Superhero
    {
        public string Name { get; set; }
        public string SecretIdentity { get; set; }
        public Superpower Power { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\temp\2207\data.csv";

            char delimiter = '>';
            #region Write CSV
            //1. Open the file
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                //2.Write the data
                sw.Write("Batman was here.");
                sw.Write(delimiter);
                sw.Write(5);
                sw.Write(delimiter);
                sw.Write(true);
                sw.Write(delimiter);
                sw.Write(13.2);
                sw.Write(delimiter);
                sw.Write(571);
            }//3. closes the file 
            #endregion

            #region Read CSV
            //1. open the file
            using (StreamReader sr = new StreamReader(filePath))
            {
                //2. read the file
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] data = line.Split(delimiter);
                    foreach (var item in data)
                    {
                        Console.WriteLine(item);
                    }
                }
            }//3. close the file
            //OR....use File.ReadAllText to read the entire file
            string lineData = File.ReadAllText(filePath);//opens, reads, closes the file
            string[] dataCSV = lineData.Split(delimiter);
            #endregion

            #region Serializing
            List<Superhero> JL = new List<Superhero>();
            JL.Add(new Superhero() { Name = "Batman", SecretIdentity = "Bruce Wayne", Power = Superpower.Money });
            JL.Add(new Superhero() { Name = "Superman", SecretIdentity = "Clark Kent", Power = Superpower.Strength });
            JL.Add(new Superhero() { Name = "Wonder Woman", SecretIdentity = "Diana Prince", Power = Superpower.Strength });
            JL.Add(new Superhero() { Name = "Flash", SecretIdentity = "Barry Allen", Power = Superpower.Speed });
            JL.Add(new Superhero() { Name = "Aquaman", SecretIdentity = "Arthur Curry", Power = Superpower.Swimming });

            //change the extension to .json
            string jsonFile = Path.ChangeExtension(filePath, ".json");
            using (StreamWriter sw = new StreamWriter(jsonFile))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    jtw.Formatting = Formatting.Indented;
                    //serialize the list
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    jsonSerializer.Serialize(jtw, JL);
                }
            }
            #endregion


            WriteData(filePath);
            ReadData(filePath);
        }

        private static void ReadData(string filePath)
        {
            char delimiter = '>';
            string fileText = File.ReadAllText(filePath);
            string[] nums = fileText.Split(delimiter);
            List<int> numbers = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (int.TryParse(nums[i], out int num))
                    numbers.Add(num);
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        static void WriteData(string fPath)
        {
            List<int> nums = new() { 5, 4, 3, 2, 1 };

            char delimiter = '>';
            //1. Open the file
            using (StreamWriter sw = new StreamWriter(fPath))
            {
                bool isFirst = true;
                for (int i = 0; i < nums.Count; i++)
                {
                    if(!isFirst)
                        sw.Write(delimiter);
                    sw.Write(nums[i]);
                    isFirst = false;
                }
            }
        }
    }
}
