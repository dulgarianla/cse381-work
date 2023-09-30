# Algorithm Description Document

Author: Lauren Dulgarian

Date: 09/30/23

## 1. Name
Merge Sort

## 2. Abstract
The code contains a Merge Sort implementation called `MergeSort`. This sorting algorithm efficiently arranges elements in a list in ascending order. It does so by dividing the list, sorting smaller parts, and merging them back together. The code uses the `List<IComparable> data` type for elements that can be compared. It provides clear methods for sorting and merging, making it a straightforward and functional Merge Sort implementation.

## 3. Methodology
This code contains a the Merge Sort algorithm within a `MergeSort` class, enabling efficient sorting of elements stored in a `List<IComparable>`. This code features two primary methods: `Merge`, a private function responsible for merging two sorted subarrays within the `data` list, and `Sort`, a public entry point that initiates the sorting process. Input to the code is a `List<IComparable> data` containing the elements to be sorted, with the requirement that these elements implement the `IComparable` interface to enable comparisons. The output is the same `data` list but with elements rearranged in ascending order, following their natural order or a custom ordering defined by the `CompareTo` method.

## 4. Pseudocode
```
MERGE(data, first, mid, last)
    set sa1 data[first, mid]
    set sa2 data[mid, last]

    loop i first to last 
        if next sa1 <= next sa2 
            set data[i] = next sa1
        if next sa1 > next sa2 
            set data[i] = next sa2
        if no sa1 left 
            set data[i] = next sa2
        if no sa2 left 
            set data[i] = next sa1

SORT(data, first, last)
    if first >= last 
        return 

    set mid = (first and last)/2
    SORT(data, first, mid)
    SORT( data, mid + 1, last)
    MERGE(data, first, mid, last)
```

## 5. Inputs & Outputs

List only inputs and outputs for the SORT function.

Inputs: `data`: This is the input list containing elements to be sorted. The elements are of type IComparable, which means they must support comparison operations such as CompareTo.

Outputs: `Sort` method sorts the input list data in ascending order. After the sorting is complete, the data list will contain the same elements, but they will be arranged in ascending order based on their natural order or the order defined by their CompareTo method.

## 6. Analysis Results

* Worst Case: $O(n log n)$

* Best Case: $\Omega(n log n)$

