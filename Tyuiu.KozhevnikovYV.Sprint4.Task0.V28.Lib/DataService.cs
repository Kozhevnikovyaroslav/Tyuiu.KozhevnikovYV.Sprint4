namespace Tyuiu.KozhevnikovYV.Sprint4.Task0.V28.Lib
{
    using tyuiu.cources.programming.interfaces.Sprint4;
    public class DataService : ISprint4Task0V28
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int p = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    p *= array[i];
                }
            }
            return p;
        }
    }
}
