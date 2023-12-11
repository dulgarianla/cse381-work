# Algorithm Description Document

Author: Lauren Dulgarian 

Date: 11/18/23

## 1. Name
Huffman Tree Compression

## 2. Abstract
The code defines a class named HuffmanTree that implements Huffman coding. Huffman coding assigns variable-length codes to input characters, with shorter codes given to more frequently occurring characters. The code includes methods for generating a frequency profile of characters in a given text, building a Huffman tree based on the frequency profile, creating an encoding map, encoding a text using the generated map, and decoding an encoded text using the Huffman tree.

## 3. Methodology
The `HuffmanTree` class implements Huffman coding for lossless data compression. Each node in the Huffman tree, represented by the `Node` class, contains a character, its frequency, and references to left and right children. The `Profile` method generates a frequency profile for characters in a given text. The `BuildTree` method constructs the Huffman tree by iteratively combining nodes with the lowest frequencies until a single root node remains. The `CreateEncodingMap` and `CreateEncodingMapHelper` methods generate a mapping of characters to Huffman codes using a recursive approach. The `Encode` method encodes a text based on the provided Huffman encoding map, creating a binary string with variable-length codes. Conversely, the `Decode` method decodes a Huffman-encoded text using the Huffman tree, reconstructing the original text by traversing the tree based on '0' and '1' characters. This comprehensive implementation enables efficient compression and decompression of text while considering the frequency distribution of characters.

## 4. Pseudocode

```
PROFILE(text)
  profile = {}
    for each character in text:
        if character is in profile:
            increment profile[character]
        else:
            profile[character] = 1
    return profile

BUILD-TREE(profile)
  priority_queue = []
    for each letter in profile.keys():
        node = Node(letter=letter, count=profile[letter])
        append node to priority_queue
    while length of priority_queue > 1:
        sort priority_queue by the count attribute of each node

        left = first node in priority_queue
        right = second node in priority_queue

        internal_node = Node(count=left.count + right.count, left=left, right=right)

        remove left from priority_queue
        remove right from priority_queue

        append internal_node to priority_queue
    return the first node in priority_queue

CREATE-ENCODING-MAP(node, code, map)
    map = {}  
        create_encoding_map_helper(root, "", map)
    return map

create_encoding_map_helper(node, code, map): //I add this
    if node is null:
        return
    if node.left is null and node.right is null:
        map[node.letter] = code 
        create_encoding_map_helper(node.left, code + "0", map)
        create_encoding_map_helper(node.right, code + "1", map)

ENCODE(text, map)
 result = ""
    for each letter in text:
        append mapping[letter] to result
    return

DECODE(text, tree)
curr_node = tree
result = ""
index = 0
    while index < length of text:
        if text[index] is '0':
            curr_node = curr_node.left
        else:
            curr_node = curr_node.right

        if curr_node.left is null and curr_node.right is null:
            append curr_node.letter to result
            curr_node = tree

        increment index
        
    return result
```

## 5. Inputs & Outputs

List only inputs and outputs for Encode and Decode functions.
### Encode function 
**Inputs:**  `text`- The input text to be encoded.

`map`- A dictionary mapping characters to their corresponding Huffman codes.

**Outputs:** `result` - The encoded text, where each character in the input text is replaced with its Huffman code.

### Decode function 
**Inputs:** `text` - The Huffman-encoded text to be decoded.

`tree` - The Huffman tree used for decoding.

**Outputs:** `result` - The decoded text, where each Huffman code in the input text is replaced with its corresponding character, reconstructed by traversing the Huffman tree.

## 6. Analysis Results

Encode Function:
* Worst Case: $O(n \log n)$

* Best Case: $\Omega(n \log n)$


Decode Function:
* Worst Case: $O(m \log n)$

* Best Case: $\Omega(m)$


