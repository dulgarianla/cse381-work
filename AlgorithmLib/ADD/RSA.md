# Algorithm Description Document

Author: Lauren Dulgarian

Date: 11/11/23

## 1. Name
RSA Encryption

## 2. Abstract
In the code it implements the RSA encryption and decryption algorithm. RSA is a widely used public-key cryptosystem that involves the use of two keys: a public key for encryption and a private key for decryption. The code defines a class named RSA with methods for key generation, encryption, and decryption.

## 3. Methodology
In the code it is stating with off with the `Euclid` method is a recursive application of the extended Euclidean algorithm, serving to calculate the greatest common divisor (gcd) of two `BigInteger` numbers. This method finds coefficients such that `gcd(a, b) = a*i + b*j`. It plays a crucial role in the key generation process, specifically in computing the modular multiplicative inverse of the public exponent `e` modulo `(p-1)(q-1)`. The `ModularExponentiation` method is pivotal in both encryption and decryption processes. It efficiently computes `x^y mod n` through a recursive approach, enabling the handling of modular exponentiation with large numbers. The `GeneratePrivateKey` method computes the private key `d` based on two prime numbers `p` and `q`, as well as the public exponent `e`. It involves calculating the function value `r = (p-1)(q-1)` and applying the extended Euclidean algorithm to determine the modular multiplicative inverse of `e` modulo `r`. The result is the private key `d`. Conversely, the `Encrypt` method takes a `BigInteger` value, the public exponent `e`, and the modulus `n`. It utilizes modular exponentiation to encrypt the given value, implementing the public-key encryption aspect of the RSA algorithm. Similarly, the `Decrypt` method takes a `BigInteger` value, the private exponent `d`, and the modulus `n`. Employing modular exponentiation, it decrypts the given value, providing the functionality for private-key decryption in the RSA cryptosystem. In summary, the `RSA` class encapsulates the essential components of the RSA algorithm, offering methods for extended Euclidean calculations, modular exponentiation, key generation, encryption, and decryption. This implementation serves as a comprehensive and functional representation of the RSA cryptographic scheme in C#.

## 4. Pseudocode

Only provide pseudocode for MODULAR-EXPONENTIATION.

```
MODULAR-EXPONENTIATION(x, y, n)
    if y equals 0:
        return 1
    if y is even:
        z = modular_exponentiation(x, y // 2, n)
        return (z * z) mod n
    else:
        z = modular_exponentiation(x, (y - 1) // 2, n)
        return (x * z * z) mod n

```

## 5. Inputs & Outputs

List only inputs and outputs for the MODULAR-EXPONENTIATION function.

**Inputs** - x: Base, y: Exponent, n: Modulus

**Outputs** - result of x^y mod n


## 6. Analysis Results

* Worst Case: $O(log n)$

* Best Case: $\Omega(log n)$


