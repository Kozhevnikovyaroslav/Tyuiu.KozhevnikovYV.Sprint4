namespace Tyuiu.KozhevnikovYV.Sprint4.Task1.V10.Test
{
    using Tyuiu.KozhevnikovYV.Sprint4.Task1.V10.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 5, 6, 8, 3, 5, 2, 4, 4, 1, 3, 5 };
            int wait = 1125;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
