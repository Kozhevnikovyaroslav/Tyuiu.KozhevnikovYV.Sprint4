namespace Tyuiu.KozhevnikovYV.Sprint4.Task0.V28.Test
{ using Tyuiu.KozhevnikovYV.Sprint4.Task0.V28.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int res = ds.GetMultEvenArrEl(array);
            int wait = 9216;
            Assert.AreEqual(wait, res);
        }
    }
}
