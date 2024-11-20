using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using Tyuiu.AlshinAF.Sprint4.Task0.V25.Lib;
namespace Tyuiu.AlshinAF.Sprint4.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] Array = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
            int wait = 42;
            int res = ds.GetSumEvenArrEl(Array);
            Assert.AreEqual(res, wait);
        }
    }
}