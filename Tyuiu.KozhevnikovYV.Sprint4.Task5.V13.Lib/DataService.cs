namespace Tyuiu.KozhevnikovYV.Sprint4.Task5.V13.Lib
{
    using tyuiu.cources.programming.interfaces.Sprint4;
    public class DataService : ISprint4Task5V13
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int colums = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}
