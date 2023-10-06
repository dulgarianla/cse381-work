namespace AlgorithmLib;
public static class MergeSort
{
    // This method is responsible for merging two sorted subarrays (from 'first' to 'mid' and from 'mid + 1' to 'last')
    private static void Merge(List<IComparable> data, int first, int mid, int last)
    {
        // Create two temporary lists to hold the elements of the subarrays to be merged
        IList<IComparable> set_1 = new List<IComparable>(data).GetRange(first, mid - first + 1);
        IList<IComparable> set_2 = new List<IComparable>(data).GetRange(mid + 1, last - mid);

        // Initialize indices for traversing the two subarrays and the merged array
        var index_1 = 0;
        var index_2 = 0;

        // Iterate through the merged array
        for (var middle_Index = first; middle_Index <= last; middle_Index++)
        {
            // If we have exhausted all elements in set_1, use elements from set_2
            if (index_1 >= set_1.Count)
            {
                data[middle_Index] = set_2[index_2];
                index_2++;
            }
            // If we have exhausted all elements in set_2, use elements from set_1
            else if (index_2 >= set_2.Count)
            {
                data[middle_Index] = set_1[index_1];
                index_1++;
            }
            // If the current element in set_1 is smaller than the current element in set_2, use the element from set_1
            else if (set_1[index_1].CompareTo(set_2[index_2]) < 0)
            {
                data[middle_Index] = set_1[index_1];
                index_1++;
            }
            // If the current element in set_2 is smaller or equal to the current element in set_1, use the element from set_2
            else
            {
                data[middle_Index] = set_2[index_2];
                index_2++;
            }
        }
    }

    // Public method to start the sorting process by calling the private 'Sort' method
    public static void Sort(List<IComparable> data)
    {
        Sort(data, 0, data.Count - 1);
    }

    // private method to perform the merge sort
    private static void Sort(List<IComparable> data, int first, int last)
    {
        // Base case: If 'first' is less than 'last', continue dividing the array
        if (first < last)
        {
            // Calculate the middle index
            int mid = (first + last) / 2;

            // Recursively sort the left and right subarrays
            Sort(data, first, mid);
            Sort(data, mid + 1, last);

            // Merge the sorted subarrays
            Merge(data, first, mid, last);
        }
    }

}

