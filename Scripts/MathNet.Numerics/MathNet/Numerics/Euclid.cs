using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics
{
	public static class Euclid
	{
		private static readonly int[] MultiplyDeBruijnBitPosition;

		[MethodImpl(256)]
		public static double Modulus(double dividend, double divisor)
		{
			return 0.0;
		}

		[MethodImpl(256)]
		public static float Modulus(float dividend, float divisor)
		{
			return 0f;
		}

		[MethodImpl(256)]
		public static int Modulus(int dividend, int divisor)
		{
			return 0;
		}

		[MethodImpl(256)]
		public static long Modulus(long dividend, long divisor)
		{
			return 0L;
		}

		[MethodImpl(256)]
		public static BigInteger Modulus(BigInteger dividend, BigInteger divisor)
		{
			return default(BigInteger);
		}

		[MethodImpl(256)]
		public static double Remainder(double dividend, double divisor)
		{
			return 0.0;
		}

		[MethodImpl(256)]
		public static float Remainder(float dividend, float divisor)
		{
			return 0f;
		}

		[MethodImpl(256)]
		public static int Remainder(int dividend, int divisor)
		{
			return 0;
		}

		[MethodImpl(256)]
		public static long Remainder(long dividend, long divisor)
		{
			return 0L;
		}

		[MethodImpl(256)]
		public static BigInteger Remainder(BigInteger dividend, BigInteger divisor)
		{
			return default(BigInteger);
		}

		[MethodImpl(256)]
		public static bool IsEven(this int number)
		{
			return false;
		}

		[MethodImpl(256)]
		public static bool IsEven(this long number)
		{
			return false;
		}

		[MethodImpl(256)]
		public static bool IsOdd(this int number)
		{
			return false;
		}

		[MethodImpl(256)]
		public static bool IsOdd(this long number)
		{
			return false;
		}

		[MethodImpl(256)]
		public static bool IsPowerOfTwo(this int number)
		{
			return false;
		}

		[MethodImpl(256)]
		public static bool IsPowerOfTwo(this long number)
		{
			return false;
		}

		public static bool IsPerfectSquare(this int number)
		{
			return false;
		}

		public static bool IsPerfectSquare(this long number)
		{
			return false;
		}

		public static int PowerOfTwo(this int exponent)
		{
			return 0;
		}

		public static long PowerOfTwo(this long exponent)
		{
			return 0L;
		}

		public static int Log2(this int number)
		{
			return 0;
		}

		public static int CeilingToPowerOfTwo(this int number)
		{
			return 0;
		}

		public static long CeilingToPowerOfTwo(this long number)
		{
			return 0L;
		}

		public static long GreatestCommonDivisor(long a, long b)
		{
			return 0L;
		}

		public static long GreatestCommonDivisor(IList<long> integers)
		{
			return 0L;
		}

		public static long GreatestCommonDivisor(params long[] integers)
		{
			return 0L;
		}

		public static long ExtendedGreatestCommonDivisor(long a, long b, out long x, out long y)
		{
			x = default(long);
			y = default(long);
			return 0L;
		}

		public static long LeastCommonMultiple(long a, long b)
		{
			return 0L;
		}

		public static long LeastCommonMultiple(IList<long> integers)
		{
			return 0L;
		}

		public static long LeastCommonMultiple(params long[] integers)
		{
			return 0L;
		}

		public static BigInteger GreatestCommonDivisor(BigInteger a, BigInteger b)
		{
			return default(BigInteger);
		}

		public static BigInteger GreatestCommonDivisor(IList<BigInteger> integers)
		{
			return default(BigInteger);
		}

		public static BigInteger GreatestCommonDivisor(params BigInteger[] integers)
		{
			return default(BigInteger);
		}

		public static BigInteger ExtendedGreatestCommonDivisor(BigInteger a, BigInteger b, out BigInteger x, out BigInteger y)
		{
			x = default(BigInteger);
			y = default(BigInteger);
			return default(BigInteger);
		}

		public static BigInteger LeastCommonMultiple(BigInteger a, BigInteger b)
		{
			return default(BigInteger);
		}

		public static BigInteger LeastCommonMultiple(IList<BigInteger> integers)
		{
			return default(BigInteger);
		}

		public static BigInteger LeastCommonMultiple(params BigInteger[] integers)
		{
			return default(BigInteger);
		}
	}
}
