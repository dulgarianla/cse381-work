# Algorithm Description Document

Author: Lauren Dulgarian  

Date: 10/07/23

## 1. Name

Quick Sort

## 2. Abstract
In this code it implements the QuickSort algorithm as a static class called `QuickSort`. It defines two methods, `Partition` and `Sort`, for sorting a list of elements that implement the `IComparable` interface. The `Partition` method randomly selects a pivot element within a given range and rearranges the list so that elements smaller than the pivot appear on the left, and elements greater than the pivot appear on the right. The `Sort` method initiates the sorting process by calling the private `Sort` method recursively, which continues partitioning the list until it is sorted.

## 3. Methodology
In this code the QuickSort algorithm within a static class called `QuickSort`. This implementation consists of two primary methods: `Partition` and `Sort`. The `Partition` method is responsible for rearranging the input list. It begins by randomly selecting a pivot element within a specified range defined by the `first` and `last` indices and swaps it with the last element in that range. Then, it iterates through the elements in the range, comparing each to the pivot value. Elements less than or equal to the pivot are swapped with the leftmost element greater than the pivot, effectively partitioning the list. Finally, the pivot value is repositioned, and the method returns the pivot's index. The public `Sort` method serves as the entry point for sorting a list of elements implementing the `IComparable` interface. It initiates the sorting process by calling the private `Sort` method with initial indices of `0` and `data.Count - 1`. The private `Sort` method handles the core recursive sorting, checking for the base case when `first` is greater than or equal to `last`, signifying a sorted list. If not, it calls `Partition`, sorts the left and right sublists around the pivot, and continues recursively until the entire list is sorted.

## 4. Pseudocode

```
PARTITION(data, first, last)
    pivot = random.randint(first, last)
    pivot_value = data[pivot]
    data[pivot] = data[last]
    data[last] = pivot_value
    
    left_most_greater_pivot = first
    
    loop index = first to last - 1
        if data[index] <= data[last]
            temp_1 = data[left_most_greater_pivot]
            data[left_most_greater_pivot] = data[index]
            data[index] = temp_1
            
            left_most_greater_pivot += 1
    
    temp_2 = data[left_most_greater_pivot]
    data[left_most_greater_pivot] = data[last]
    data[last] = temp_2
    
    return left_most_greater_pivot
   
SORT(data, first, last)
    if first >= last
        return
    
    pivot_index = Partition(data, first, last)
    SORT(data, first, pivot_index - 1)
    SORT(data, pivot_index + 1, last)

```

## 5. Inputs & Outputs

List only inputs and outputs for the SORT function.

Inputs: `data`- This is the list of elements that you want to sort.

`first`- An integer representing the index of the first element in the current range of elements being sorted.

`last`- An integer representing the index of the last element in the current range of elements being sorted.

Outputs: `Sort(data, first, pivotIndex - 1)` - This is a recursive call to sort the left subarray of elements that are smaller than the pivot.

`Sort(data, pivotIndex + 1, last)`- This is a recursive call to sort the right subarray of elements that are greater than the pivot.

## 6. Analysis Results

* Worst Case: $O(n^2)$

* Best Case: $\Omega(n log n)$

