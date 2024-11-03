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
    public class ProcessData
    {
        private int[] _data;

        public ProcessData(int[] data)
        {
            _data = data ?? throw new ArgumentNullException(nameof(data), "Dane nie mogą być null");
            Sortowanie.Sort(_data);
        }

        public double Avg()
        {
            if (_data.Length == 0)
                return 0;

            int suma = 0;
            foreach (var item in _data)
            {
                suma += item;
            }
            return (double)suma / _data.Length;
        }

        public double Mediana()
        {
            if (_data.Length == 0)
                return 0;

            int mid = _data.Length / 2;
            return _data.Length % 2 == 0 ? (_data[mid - 1] + _data[mid]) / 2.0 : _data[mid];
        }

        public int Max() => _data.Length > 0 ? _data[^1] : throw new InvalidOperationException("Tablica jest pusta");

        public int Min() => _data.Length > 0 ? _data[0] : throw new InvalidOperationException("Tablica jest pusta");
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}