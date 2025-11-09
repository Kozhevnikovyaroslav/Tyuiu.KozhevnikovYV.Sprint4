namespace Tyuiu.KozhevnikovYV.Sprint4.Task4.V6.Lib
{
    using tyuiu.cources.programming.interfaces.Sprint4;
    public class DataService : ISprint4Task4V6
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i,j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}
