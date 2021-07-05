using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddIntegers.Models;
using AddIntegers.Calculator;

namespace AddIntegersTests.CalculatorTests
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void AdditionTest1()
        {          
            Addition Add = new Addition();

            Values Value = new Values();
            Value.Number1 = 1;
            Value.Number2 = 2;
 
            double ExpectedResult = 3;
            double ActualResult = Add.Result(Value.Number1, Value.Number2);           
                        
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}
