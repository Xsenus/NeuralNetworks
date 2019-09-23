using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace NeuralNetworks.Tests
{
    [TestClass()]
    public class NeuralNetworksTests
    {
        [TestMethod()]
        public void FeddForwardTest()
        {
            var topology = new Topology(4, 1, 2);

            var neuralNetwork = new NeuralNetworks(topology);

            neuralNetwork.Layers[1].Neurons[0].SetWeights(0.5, -0.1, 0.3, -0.1);
            neuralNetwork.Layers[1].Neurons[1].SetWeights(0.1, -0.3, 0.7, -0.3);
            neuralNetwork.Layers[2].Neurons[0].SetWeights(1.2, 0.8);

            var result = neuralNetwork.FeddForward(new List<double> { 1, 0, 0, 0 });
        }
    }
}