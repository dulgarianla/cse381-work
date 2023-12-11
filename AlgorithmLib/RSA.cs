using System.Numerics;

namespace AlgorithmLib;

public class RSA
{
    // Method implementing the extended Euclidean algorithm to find the greatest common divisor and coefficients.
    private static (BigInteger, BigInteger, BigInteger) Euclid(BigInteger a, BigInteger b)
    {
        if (b == 0)
        {
            // Base case: if b is 0, return (a, 1, 0) as gcd(a, 0) = a and a*1 + 0*0 = a.
            return (a, 1, 0);
        }
        
        // Recursive step: call Euclid with (b, a % b) to continue the algorithm.
        (BigInteger gcd, BigInteger i, BigInteger j) = Euclid(b, a % b);
        
        // Return the calculated gcd and coefficients.
        return (gcd, j, (i - (a/b) * j));
    }

    // Method implementing modular exponentiation for efficient exponentiation in encryption and decryption.
    private static BigInteger ModularExponentiation(BigInteger x, BigInteger y, BigInteger n)
    {
        if (y == 0)
        {
            // Base case: if y is 0, return 1, as any number raised to the power of 0 is 1.
            return 1;
        }
        
        if (y % 2 == 0)
        {
            // If y is even, use recursive squaring for efficient exponentiation.
            BigInteger z = ModularExponentiation(x, (y / 2), n);
            return (z * z) % n;
        }
        else
        {
            // If y is odd, perform one recursive call with (y - 1) / 2 for efficient exponentiation.
            BigInteger z = ModularExponentiation(x, ((y - 1) / 2), n);
            return (x * z * z) % n;
        }
    }

    // Method to generate the private key 'd' in RSA encryption.
    public static BigInteger GeneratePrivateKey(BigInteger p, BigInteger q, BigInteger e) 
    {
        // Calculate the totient function value r = (p-1)(q-1).
        BigInteger r = (p - 1) * (q - 1);
        
        // Use the extended Euclidean algorithm to find gcd(e, r) and coefficients.
        (BigInteger gcd, BigInteger i, _) = Euclid(e, r);
        
        // If i is negative, add r to make it positive.
        if (i < 0)
        {
            i += r;
        }
        
        // Return the calculated private key 'd'.
        return i % r;
    }

    // Method to encrypt a value using the RSA algorithm.
    public static BigInteger Encrypt(BigInteger value, BigInteger e, BigInteger n)
    {
        // Use modular exponentiation to perform efficient encryption.
        return ModularExponentiation(value, e, n);
    }

    // Method to decrypt a value using the RSA algorithm.
    public static BigInteger Decrypt(BigInteger value, BigInteger d, BigInteger n)
    {
        // Use modular exponentiation to perform efficient decryption.
        return ModularExponentiation(value, d, n);
    }
}
