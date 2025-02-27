using System;

namespace NeuralNetworkPredictor.Models
{
    public class NeuralNetwork
    {
        private double[] weights;
        private double learningRate;

        public NeuralNetwork(int inputSize, double learningRate = 0.01)
        {
            weights = new double[inputSize];
            this.learningRate = learningRate;
            InitializeWeights();
        }

        private void InitializeWeights()
        {
            Random rand = new Random();
            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] = rand.NextDouble();
            }
        }

        public double Predict(double[] inputs)
        {
            double sum = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                sum += inputs[i] * weights[i];
            }
            return sum; 
        }

        public void Train(double[][] trainingData, double[] expectedOutputs, int epochs)
        {
            for (int epoch = 0; epoch < epochs; epoch++)
            {
                for (int i = 0; i < trainingData.Length; i++)
                {
                    double prediction = Predict(trainingData[i]);
                    double error = expectedOutputs[i] - prediction;

                    for (int j = 0; j < weights.Length; j++)
                    {
                        weights[j] += learningRate * error * trainingData[i][j];
                    }
                }
            }
        }
    }
}