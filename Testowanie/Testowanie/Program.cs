namespace Testowanie
{
    public class SortowanieWstawianie
    {
        public static void Sort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array cannot be null");
            }

            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            SortowanieWstawianie.Sort(arr);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}