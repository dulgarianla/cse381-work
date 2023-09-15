namespace AlgorithmLib;

public static class BetterLinearSearch
{
    public static int Search(List<IComparable> data, IComparable target)
    {
        // Loop through the elements of the List
        for (int i = 0; i < data.Count; i++)
        {
            // Check if the current element is equal to the target using the Equals method
            if (data[i].Equals(target))
            {
                // If a match is found, return the index i
                return i;
            }
        }
        // If no match is found in the entire List, return -1
        return -1;
    }
}