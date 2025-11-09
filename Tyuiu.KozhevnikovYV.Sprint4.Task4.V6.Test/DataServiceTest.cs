namespace Tyuiu.KozhevnikovYV.Sprint4.Task4.V6.Test
{
    using Tyuiu.KozhevnikovYV.Sprint4.Task4.V6.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 7, 6, 6, 6, 9 }, 
                                           { 4, 4, 4, 9, 4 },
                                           { 5, 5, 5, 6, 5 },
                                           { 4, 9, 5, 9, 7 },
                                           { 6, 9, 5, 6, 7 } };

            int[,] wait = new int[5, 5] {  { 1, 6, 6, 6, 1 },
                                           { 4, 4, 4, 1, 4 },
                                           { 1, 1, 1, 6, 1 },
                                           { 4, 1, 1, 1, 1 },
                                           { 6, 1, 1, 6, 1 } };
            int[,] res = ds.Calculate(array);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
