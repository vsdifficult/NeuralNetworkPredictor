using System;
using NeuralNetworkPredictor.Models;

namespace NeuralNetworkPredictor.Predictions
{
    public class Predictor
    {
        public double Predict(NeuralNetwork model, double[] inputs)
        {
            return model.Predict(inputs);
        }
    }
}