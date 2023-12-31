# Algorithm Description Document

Author: Lauren Dulgarian 

Date: 9/20/23

## 1. Name
Binary Search

## 2. Abstract

> In this code it an algorithm implemented as a static method named `Search`. It takes in a sorted list (`data`) and a target element (`target`) to find, and it returns the index of the target in the list if found. The algorithm repeatedly divides the search range in half, comparing the target with the middle element, and adjusting the search range until the target is found or determined to be absent. If the target is not in the list, it returns -1.

## 3. Methodology
> This code contains a binary search algorithm in the `BinarySearch` class, designed to find the index of a target element in a sorted list. It begins by establishing a search range by initializing two indices, `first` and `last`, to the start and end of the list. Inside a loop, it calculates the middle index, compares the target element with the middle element, and adjusts the search range accordingly. If a match is found, it returns the index where the target is located. If not, it continues dividing the search range until the target is found or determined to be absent. If the loop finishes without finding the target, it returns -1 to signify its absence in the sorted list. This algorithm efficiently locates items in a sorted list by systematically narrowing down the search range.

## 4. Pseudocode

```
BINARY-SEARCH(data, target)
    left = 0
    right = len(data) - 1
    while left <= right:

        mid = (left + right) // 2
        if data[mid] == target:
            return mid
        if data[mid] < target:
            left = mid + 1
        else:
            right = mid - 1

    return -1
```

## 5. Inputs & Outputs

**Inputs**:
`data` : This is the sorted list of elements in which you want to search for the target.

`target` : This is the element you want to find within the data list. It should implement the IComparable interface, which allows for comparison between elements.

**Outputs**: 
`int`: The function returns an integer value, which represents the index of the `target` element within the `data` list if it is found. If the `target` is not present in the list, it returns -1 to indicate its absence.

## 6. Analysis Results

* Worst Case: $O(log n)$

* Best Case: $\Omega(1)$

