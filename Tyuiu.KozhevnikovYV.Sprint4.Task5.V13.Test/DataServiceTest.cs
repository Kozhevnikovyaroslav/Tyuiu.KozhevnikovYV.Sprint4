namespace Tyuiu.KozhevnikovYV.Sprint4.Task5.V13.Test
{
    using Tyuiu.KozhevnikovYV.Sprint4.Task5.V13.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[5, 5] { { -2, -2, -2, -2, -2 },
                                          { -2, -2, -2, -2, -2 },
                                          { -2, -2, 2, -2, -2 },
                                          { -2, -2, -2, -2, -2 },
                                          { -2, -2, -2, -2, -2 } };

            int[,] wait = new int[5, 5] { { 0, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0 },
                                          { 0, 0, 2, 0, 0 },
                                          { 0, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0 } };
            int[,] res = ds.Calculate(mtrx);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
