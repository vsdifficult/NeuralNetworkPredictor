using System;
using NeuralNetworkPredictor.Data;
using NeuralNetworkPredictor.Models;
using NeuralNetworkPredictor.Training;
using NeuralNetworkPredictor.Predictions;

namespace NeuralNetworkPredictor
{
    class Program
    {
        static void Main(string[] args)
        {

            var dataLoader = new DataLoader();
            var trainingData = dataLoader.LoadData("Data/data.csv"); 

            
            double[][] inputs = new double[trainingData.Count][];
            double[] outputs = new double[trainingData.Count];

            for (int i = 0; i < trainingData.Count; i++)
            {
                inputs[i] = new double[] { trainingData[i][0], trainingData[i][1] }; 
                outputs[i] = trainingData[i][2];
            }

            var model = new NeuralNetwork(2); 
            var trainer = new Trainer();
            trainer.Train(model, inputs, outputs, 1000); 

           
            var predictor = new Predictor();
            double[] newInput = { 1.0, 2.0 }; 
            double prediction = predictor.Predict(model, newInput);
            Console.WriteLine($"Value {string.Join(", ", newInput)}: {prediction}");
        }
    }
}