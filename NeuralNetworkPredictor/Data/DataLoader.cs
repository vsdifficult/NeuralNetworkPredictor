using System;
using System.Collections.Generic;
using System.IO;

namespace NeuralNetworkPredictor.Data
{
    public class DataLoader
    {
        public List<double[]> LoadData(string filePath)
        {
            var data = new List<double[]>();
            foreach (var line in File.ReadLines(filePath))
            {
                var values = line.Split(',');
                var numbers = Array.ConvertAll(values, double.Parse);
                data.Add(numbers);
            }
            return data;
        }
    }
}