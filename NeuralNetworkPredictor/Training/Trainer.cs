using System;
using NeuralNetworkPredictor.Models; 

namespace NeuralNetworkPredictor.Training
{
    public class Trainer
    {
        public void Train(NeuralNetwork model, double[][] trainingData, double[] expectedOutputs, int epochs)
        {
            model.Train(trainingData, expectedOutputs, epochs);
        }
    }
}