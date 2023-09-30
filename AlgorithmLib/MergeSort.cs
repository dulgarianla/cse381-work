namespace AlgorithmLib;
public static class MergeSort
{
    // This method performs the merging of two sorted subarrays within 'data'.
    private static void Merge(List<IComparable> data, int first, int mid, int last)
    {
        int leftIndex = first;   // Index for the left subarray.
        int rightIndex = mid + 1; // Index for the right subarray.

        while (leftIndex <= mid && rightIndex <= last)
        {
            if (data[leftIndex].CompareTo(data[rightIndex]) > 0)
            {
                // If the element on the left is greater than the element on the right,
                // we shift elements from left to right to maintain order.

                IComparable temp = data[rightIndex];
                for (int i = rightIndex; i > leftIndex; i--)
                {
                    data[i] = data[i - 1];
                }

                data[leftIndex] = temp;

                // Update indices for the next iteration.
                leftIndex++;
                mid++;
                rightIndex++;
            }
            else
            {
                // Move to the next element in the left subarray.
                leftIndex++;
            }
        }
    }

    // Public method to start the sorting process.
    public static void Sort(List<IComparable> data)
    {
        Sort(data, 0, data.Count - 1);
    }
    
    // Add another sort that included int first and int last and this helper method for recursive sorting.
    private static void Sort(List<IComparable> data, int first, int last)
    {
        if (first < last)
        {
            int mid = (first + last) / 2;

            // Recursively sort the left and right halves.
            Sort(data, first, mid);
            Sort(data, mid + 1, last);

            // Merge the sorted halves.
            Merge(data, first, mid, last);
        }
    }
}
