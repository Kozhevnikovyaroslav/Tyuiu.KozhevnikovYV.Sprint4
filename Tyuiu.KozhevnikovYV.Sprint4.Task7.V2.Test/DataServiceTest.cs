namespace Tyuiu.KozhevnikovYV.Sprint4.Task7.V2.Test
{
    using Tyuiu.KozhevnikovYV.Sprint4.Task7.V2.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int rows = 3;
            int colums = 4;
            string value = "597643158942";
            int[,] mtrx = new int[rows, colums];
            int res = ds.Calculate(rows, colums, value);
            int wait = 39;
            Assert.AreEqual(wait, res);
        }
    }
}
