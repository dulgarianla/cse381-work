namespace AlgorithmLib;

public static class BinarySearch
{
    public static int Search(List<IComparable> data, IComparable target)
    {
        // Initialize the indices for the first and last elements in the search range.
        int first = 0;
        int last = data.Count - 1;

        // Continue the loop as long as there are elements in the search range.
        while (first <= last)
        {
            // Calculate the middle index to divide the search range in half.
            int middle = first + (last - first) / 2;

            // Compare the target with the element at the middle index.
            int compareResult = target.CompareTo(data[middle]);

            // If the target is equal to the middle element, return its index.
            if (compareResult == 0)
            {
                return middle;
            }
            
            // If the target is smaller than the middle element, adjust the 'last' index
            // to search in the left half of the remaining range.
            if (compareResult < 0)
            {
                last = middle - 1;
            }
            // If the target is larger than the middle element, adjust the 'first' index
            // to search in the right half of the remaining range.
            else if (compareResult > 0)
            {
                first = middle + 1;
            }
        }
        // If the target is not found in the list, return -1 to indicate its absence.
        return -1;

    }
}