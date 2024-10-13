namespace Testowanie
{
    public class Sortowanie
    {
        public static void Sort(int[] array)
        {
            // Sprawdzenie czy tablica nie jest null. Jeśli jest nowy wyjątek ArgumentNullException.
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Tablica nie może być null");
            }

            int n = array.Length; // Pobranie długości tablicy.

            // Zewnętrzna pętla przechodzi przez każdy element tablicy (oprócz ostatniego).
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i; // Ustawienie początkowego minimalnego indeksu na aktualny element.

                // Wewnętrzna pętla przeszukuje pozostałą część tablicy w poszukiwaniu najmniejszego elementu.
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex]) // Jeśli znaleziono mniejszy element, zaktualizuj minIndex.
                    {
                        minIndex = j;
                    }
                }

                // Jeśli minimalny element znajduje się na innym indeksie, zamień go z bieżącym elementem.
                if (minIndex != i)
                {
                    int temp = array[i];           // Przechowaj bieżący element w zmiennej tymczasowej.
                    array[i] = array[minIndex];    // Umieść najmniejszy element na bieżącej pozycji.
                    array[minIndex] = temp;        // Umieść bieżący element na miejscu najmniejszego.
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            Sortowanie.Sort(arr);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}