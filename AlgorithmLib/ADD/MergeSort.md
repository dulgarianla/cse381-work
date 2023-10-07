# Algorithm Description Document

Author: Lauren Dulgarian

Date: 09/30/23

## 1. Name
Merge Sort

## 2. Abstract
The code implements the Merge Sort algorithm in C# as a static class named MergeSort. This sorting algorithm follows a divide-and-conquer strategy to sort a list of elements efficiently.

## 3. Methodology
The code represents an implementation of the Merge Sort algorithm within a static class called `MergeSort`. Merge Sort is a divide-and-conquer sorting algorithm that efficiently sorts a list of elements. The code has two main methods: `Sort` and `Merge`. The `Sort` method serves as a entry point for the elements and use the private `Sort` method to perform the sorting process. The private `Merge` method is responsible for merging two sorted by the parameters `first`, `mid`, and `last`, into a single sorted array. It creates temporary lists, utilizes indices to traverse these subarrays and the merged array, and employs a loop to compare and merge elements into the original list. The `Sort` method begins the sorting process, recursively dividing and sorting the subarrays before merging them using the `Merge` method. This approach continues until the entire list is sorted.

## 4. Pseudocode
```
MERGE(data, first, mid, last)
    set set_1 data[first, mid]
    set set_2 data[mid, last]

    loop middle_Index first to last 
        if next set_1 <= next set_2 
            set data[middle_Index] = next set_1
        if next set_1 > next set_2 
            set data[middle_Index] = next set_2
        if no set_1 left 
            set data[middle_Index] = next set_2
        if no set_2 left 
            set data[middle_Index] = next set_1

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

Input: `data`- This is the list or array of elements that you want to sort. It represents the data to be sorted.

`first`- An integer representing the index of the first element in the subarray to be sorted.

`last` - An integer representing the index of the last element in the subarray to be sorted.

Output: `SORT(data, first, last)` sorts the elements within the specified subarray, which is defined by the first and last indices. 

## 6. Analysis Results

* Worst Case: $O(n log n)$

* Best Case: $\Omega(n)$
