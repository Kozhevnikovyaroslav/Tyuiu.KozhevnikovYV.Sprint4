namespace Tyuiu.KozhevnikovYV.Sprint4.Task2.V29.Test
{
    using Tyuiu.KozhevnikovYV.Sprint4.Task2.V29.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = [1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3];
            int wait = 768;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
