namespace System.Numerics
{
	public struct BigDecimal
	{
		private enum ParseState
		{
			Start = 0,
			Integer = 1,
			Decimal = 2,
			E = 3,
			Exponent = 4
		}

		private readonly BigInteger value;

		private readonly ushort scale;

		public BigDecimal(float value)
		{
		}

		public BigDecimal(double value)
		{
		}

		public BigDecimal(decimal value)
		{
		}

		public BigDecimal(long value)
		{
		}

		public BigDecimal(ulong value)
		{
		}

		public BigDecimal(BigInteger value)
		{
		}

		public BigDecimal(BigInteger value, ushort scale)
		{
		}

		public static BigDecimal Parse(string str)
		{
			return default(BigDecimal);
		}

		private BigDecimal Upscale(ushort newScale)
		{
			return default(BigDecimal);
		}

		private static ushort SameScale(ref BigDecimal left, ref BigDecimal right)
		{
			return 0;
		}

		public static BigDecimal operator +(BigDecimal left, BigDecimal right)
		{
			return default(BigDecimal);
		}

		public static BigDecimal operator -(BigDecimal left, BigDecimal right)
		{
			return default(BigDecimal);
		}

		public static BigDecimal operator *(BigDecimal left, BigDecimal right)
		{
			return default(BigDecimal);
		}

		public static implicit operator BigDecimal(sbyte value)
		{
			return default(BigDecimal);
		}

		public static implicit operator BigDecimal(byte value)
		{
			return default(BigDecimal);
		}

		public static implicit operator BigDecimal(short value)
		{
			return default(BigDecimal);
		}

		public static implicit operator BigDecimal(ushort value)
		{
			return default(BigDecimal);
		}

		public static implicit operator BigDecimal(int value)
		{
			return default(BigDecimal);
		}

		public static implicit operator BigDecimal(uint value)
		{
			return default(BigDecimal);
		}

		public static implicit operator BigDecimal(long value)
		{
			return default(BigDecimal);
		}

		public static implicit operator BigDecimal(ulong value)
		{
			return default(BigDecimal);
		}

		public static implicit operator BigDecimal(decimal value)
		{
			return default(BigDecimal);
		}

		public static implicit operator BigDecimal(BigInteger value)
		{
			return default(BigDecimal);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
