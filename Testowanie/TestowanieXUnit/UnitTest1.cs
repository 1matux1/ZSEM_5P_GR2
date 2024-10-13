namespace Testowanie
{
    public class UnitTest1
    {
        [Fact]
        public void UnsortedArray()
        {
            int[] unsorted = { 64, 25, 12, 22, 11 };
            int[] sorted = { 11, 12, 22, 25, 64 };
            SortowanieWstawianie.Sort(unsorted);
            Assert.Equal(sorted, unsorted);
        }

        [Fact]
        public void NullArray()
        {
            int[] empty = null;
            Assert.Throws<ArgumentNullException>(() => SortowanieWstawianie.Sort(empty));
        }

        [Fact]
        public void SortedArray()
        {
            int[] sorted = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            SortowanieWstawianie.Sort(sorted);
            Assert.Equal(expected, sorted);
        }

        [Fact]
        public void DuplicateValues()
        {
            int[] withDuplicates = { 3, 1, 4, 1, 5 };
            int[] expected = { 1, 1, 3, 4, 5 };
            SortowanieWstawianie.Sort(withDuplicates);
            Assert.Equal(expected, withDuplicates);
        }

        [Fact]
        public void SameValues()
        {
            int[] allEqual = { 2, 2, 2, 2, 2 };
            int[] expected = { 2, 2, 2, 2, 2 };
            SortowanieWstawianie.Sort(allEqual);
            Assert.Equal(expected, allEqual);
        }
    }
}