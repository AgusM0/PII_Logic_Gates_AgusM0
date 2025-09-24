using NUnit.Framework;   // necesario
using LogicGates;
using System.Collections.Generic;

namespace LogicGates.Tests
{
    public class GarageGateTest
    {
        private Input A;
        private Input B;
        private Input C;
        private Input A2;
        private Input B2;
        private Input C2;
        private List<Input> listaT;
        private List<Input> listaT2;
        private GarageGate G;

        [SetUp]
        public void Setup()
        {
            A = new Input("a", false);
            B = new Input("b", false);
            C = new Input("c", true);

            listaT = new List<Input>();
            listaT2 = new List<Input>();
            
            A2 = new Input("a", true);
            B2 = new Input("b", true);
            C2 = new Input("c", true);
            
            
            listaT2.Add(A2);
            listaT2.Add(B2);
            listaT2.Add(C2);
            G = new GarageGate();
            


        }

        [Test]
        public void ExpectedValuesTrue()
        {
            Assert.IsTrue(G.LogicResult(listaT));
            Assert.IsTrue(G.LogicResult(listaT2));
        }
        
    }
}