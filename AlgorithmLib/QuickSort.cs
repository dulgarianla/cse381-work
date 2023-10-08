namespace AlgorithmLib
{
    public static class QuickSort
    {
        // Partition method takes a list of IComparable, and two indices (first and last)
        private static int Partition(List<IComparable> data, int first, int last)
        {
            // Create a new Random instance for selecting a pivot element
            Random random = new Random();

            // Select a pivot index randomly between 'first' and 'last'
            int pivot = random.Next(first, last + 1);

            // Store the value at the pivot index
            var pivot_Value = data[pivot];

            // Swap the pivot value with the last element in the range
            data[pivot] = data[last];
            data[last] = pivot_Value;

            // Initialize a variable to keep track of the leftmost element greater than the pivot
            int leftMostGreaterPivot = first;

            // Iterate through the range from 'first' to 'last - 1'
            for (int index = first; index < last; index++)
            {
                // Compare the current element with the pivot value
                if (data[index].CompareTo(data[last]) <= 0)
                {
                    // Swap the current element with the leftmost element greater than the pivot
                    var temp_1 = data[leftMostGreaterPivot];
                    data[leftMostGreaterPivot] = data[index];
                    data[index] = temp_1;

                    // Increment the leftMostGreaterPivot index
                    leftMostGreaterPivot++;
                }
            }

            // Swap the pivot value back to its correct position
            var temp_2 = data[leftMostGreaterPivot];
            data[leftMostGreaterPivot] = data[last];
            data[last] = temp_2;

            // Return the index where the pivot value is now located
            return leftMostGreaterPivot;
        }

        // Public Sort method that takes a list of IComparable
        public static void Sort(List<IComparable> data)
        {
            // Call the private Sort method with initial values for 'first' and 'last'
            Sort(data, 0, data.Count - 1);
        }

        // Private Sort method that takes a list of IComparable, 'first' and 'last' indices
        private static void Sort(List<IComparable> data, int first, int last)
        {
            // Base case: if 'first' is greater than or equal to 'last', the list is already sorted
            if (first >= last)
            {
                return;
            }

            // Partition the list and get the pivot index
            int pivot_Index = Partition(data, first, last);

            // Recursively sort the left and right sublists
            Sort(data, first, pivot_Index - 1);
            Sort(data, pivot_Index + 1, last);
        }
    }
}
