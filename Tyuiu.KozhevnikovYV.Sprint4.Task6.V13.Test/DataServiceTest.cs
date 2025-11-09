namespace Tyuiu.KozhevnikovYV.Sprint4.Task6.V13.Test
{
    using Tyuiu.KozhevnikovYV.Sprint4.Task6.V13.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] mas = new string [] { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };
            int res = ds.Calculate(mas);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
