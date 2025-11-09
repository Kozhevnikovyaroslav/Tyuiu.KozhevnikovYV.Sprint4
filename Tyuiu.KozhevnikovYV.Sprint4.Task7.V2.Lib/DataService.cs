namespace Tyuiu.KozhevnikovYV.Sprint4.Task7.V2.Lib
{
    using tyuiu.cources.programming.interfaces.Sprint4;
    public class DataService : ISprint4Task7V2
    {
        public int Calculate(int n, int m, string value)
        {
            int p = 0;
            int[,] mtrx = new int[n, m];
            for ( int i = 0; i < n; i++ )
            {
                for ( int j = 0; j < m; j++ )
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }

            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i,j] % 2 != 0)
                    {
                        p += mtrx[i, j];
                    }
                }

            }
            return p;
        }
    }
}
