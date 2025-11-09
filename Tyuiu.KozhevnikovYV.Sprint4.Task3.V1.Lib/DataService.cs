namespace Tyuiu.KozhevnikovYV.Sprint4.Task3.V1.Lib
{
    using tyuiu.cources.programming.interfaces.Sprint4;
    public class DataService : ISprint4Task3V1
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int lastcol = array.GetLength(1) - 1;
            int p = 0;
            for (int i = 0; i < rows; i++)
            {
                p += array[i, lastcol];
            }
            return p;
        }
    }
}
