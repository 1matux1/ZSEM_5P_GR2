using System.Diagnostics;

namespace Testowanie
{
    public class TestyJednostkowe
    {
        [Fact]
        public void UnsortedArray()
        {
            int[] unsorted = { 64, 25, 12, 22, 11 };
            int[] sorted = { 11, 12, 22, 25, 64 };
            Sortowanie.Sort(unsorted);
            Assert.Equal(sorted, unsorted);
        }

        [Fact]
        public void NullArray()
        {
            int[] empty = null;
            Assert.Throws<ArgumentNullException>(() => Sortowanie.Sort(empty));
        }

        [Fact]
        public void SortedArray()
        {
            int[] sorted = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            Sortowanie.Sort(sorted);
            Assert.Equal(expected, sorted);
        }

        [Fact]
        public void DuplicateValues()
        {
            int[] withDuplicates = { 3, 1, 4, 1, 5 };
            int[] expected = { 1, 1, 3, 4, 5 };
            Sortowanie.Sort(withDuplicates);
            Assert.Equal(expected, withDuplicates);
        }

        [Fact]
        public void SameValues()
        {
            int[] allEqual = { 2, 2, 2, 2, 2 };
            int[] expected = { 2, 2, 2, 2, 2 };
            Sortowanie.Sort(allEqual);
            Assert.Equal(expected, allEqual);
        }
    }
    public class TestyIntegracyjne
    {
        [Fact]
        public void TestMedianOdd()
        {
            int[] dane = { 64, 25, 12, 22, 11 };
            var processor = new ProcessData(dane);

            double expectedMedian = 22;
            double medianResult = processor.Mediana();
            Assert.Equal(expectedMedian, medianResult);
        }

        [Fact]
        public void TestMedianEven()
        {
            int[] dane = { 5, 15, 25, 35, 45, 55 };
            var processor = new ProcessData(dane);

            double expectedMedian = 30;
            double medianResult = processor.Mediana();
            Assert.Equal(expectedMedian, medianResult);
        }

        [Fact]
        public void TestMedianIdenticalValues()
        {
            int[] dane = { 20, 20, 20, 20, 20 };
            var processor = new ProcessData(dane);

            double expectedMedian = 20;
            double medianResult = processor.Mediana();
            Assert.Equal(expectedMedian, medianResult);
        }

        [Fact]
        public void MaxMinValue()
        {
            int[] dane = { 5, 1, 9, 3, 7 };
            var processor = new ProcessData(dane);

            Assert.Equal(1, processor.Min());
            Assert.Equal(9, processor.Max());
        }

        [Fact]
        public void Average()
        {
            int[] dane = { 10, 20, 30, 40, 50 };
            var processor = new ProcessData(dane);

            double expectedAverage = 30;
            double averageResult = processor.Avg();
            Assert.Equal(expectedAverage, averageResult);
        }

        [Fact]
        public void NullArray()
        {
            Assert.Throws<ArgumentNullException>(() => new ProcessData(null));
        }
    }
}