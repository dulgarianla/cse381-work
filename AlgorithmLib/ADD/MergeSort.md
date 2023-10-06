# Algorithm Description Document

Author: Lauren Dulgarian

Date: 09/30/23

## 1. Name
Merge Sort

## 2. Abstract


## 3. Methodology


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


## 6. Analysis Results

* Worst Case: $O()$

* Best Case: $\Omega()$

