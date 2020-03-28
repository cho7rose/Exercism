using System;
using System.Numerics;

namespace MyCode
{
    public class DiffieHellman
    {
        public static BigInteger PrivateKey(BigInteger p)
        {
            Random r = new Random();
            BigInteger a=r.Next((int)p);
            return(a);
        }

        public static BigInteger PublicKey(BigInteger p, BigInteger g, BigInteger privatekey)
        {
            BigInteger A = (BigInteger)(Math.Pow((double)g, (double)privatekey)%(double)p);
            return(A);
        }

        public static BigInteger Secret(BigInteger p, BigInteger theirPublicKey, BigInteger myPrivateKey)
        {
            BigInteger secret = (BigInteger)(Math.Pow((double)theirPublicKey, (double)myPrivateKey)%(double)p);
            return(secret);
        }

    }
}
