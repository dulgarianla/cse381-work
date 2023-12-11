namespace AlgorithmLib;

public static class StringMatcher
{
    private static List<Dictionary<char, int>> BuildTable(string pattern, List<char> inputs)
    {
        // Initialize an empty list to store the transition table.
        List<Dictionary<char, int>> table = new List<Dictionary<char, int>>();

        // Iterate over the pattern length plus one to include an initial state.
        for (int k = 0; k < pattern.Length + 1; k++)
        {
            // Initialize a dictionary to represent transitions for the current state.
            Dictionary<char, int> map = new Dictionary<char, int>();

            // Iterate over the input characters to compute transitions.
            foreach (char letter in inputs)
            {
                // Build a string that represents the pattern matched so far with the current letter.
                var matchedSoFarLetter = pattern[..k] + letter;

                // Initialize the state variable, ensuring it doesn't exceed the pattern length.
                int i = Math.Min(k + 1, pattern.Length);

                // Find the maximum prefix of 'matchedSoFarLetter' that matches a suffix of 'pattern'.
                while (!matchedSoFarLetter.EndsWith(pattern[..i]))
                {
                    i--;
                }

                // Store the state for the current letter in the map.
                map[letter] = i;
            }

            // Add the map for the current state to the transition table.
            table.Add(map);
        }

        // Return the completed transition table.
        return table;
    }

    public static List<int> Match(string text, string pattern, List<char> inputs)
    {
        // Build the transition table using the pattern and input characters.
        List<Dictionary<char, int>> table = BuildTable(pattern, inputs);

        // Define the final matching state and the current state.
        int matchState = table.Count - 1;
        int state = 0;

        // Initialize a list to store the positions where the pattern is found in the text.
        var results = new List<int>();

        // Iterate through the characters in the text.
        for (int index = 0; index < text.Length; index++)
        {
            // Update the state based on the current character in the text.
            state = table[state][text[index]];

            // If the state matches the final state, add the current index to the results.
            if (state == matchState)
            {
                results.Add(index);
            }
        }

        // Return the list of positions where the pattern is found in the text.
        return results;
    }
}
