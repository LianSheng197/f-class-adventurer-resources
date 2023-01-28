using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime;

namespace MathNet.Numerics
{
	public static class ComplexExtensions
	{
		public static double MagnitudeSquared(this Complex32 complex)
		{
			return 0.0;
		}

		public static double MagnitudeSquared(this Complex complex)
		{
			return 0.0;
		}

		public static Complex Sign(this Complex complex)
		{
			return default(Complex);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static Complex Conjugate(this Complex complex)
		{
			return default(Complex);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static Complex Reciprocal(this Complex complex)
		{
			return default(Complex);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static Complex Exp(this Complex complex)
		{
			return default(Complex);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static Complex Ln(this Complex complex)
		{
			return default(Complex);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static Complex Log10(this Complex complex)
		{
			return default(Complex);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static Complex Log(this Complex complex, double baseValue)
		{
			return default(Complex);
		}

		public static Complex Power(this Complex complex, Complex exponent)
		{
			return default(Complex);
		}

		public static Complex Root(this Complex complex, Complex rootExponent)
		{
			return default(Complex);
		}

		public static Complex Square(this Complex complex)
		{
			return default(Complex);
		}

		public static Complex SquareRoot(this Complex complex)
		{
			return default(Complex);
		}

		public static (Complex, Complex) SquareRoots(this Complex complex)
		{
			return default((Complex, Complex));
		}

		public static (Complex, Complex, Complex) CubicRoots(this Complex complex)
		{
			return default((Complex, Complex, Complex));
		}

		public static bool IsZero(this Complex complex)
		{
			return false;
		}

		public static bool IsOne(this Complex complex)
		{
			return false;
		}

		public static bool IsImaginaryOne(this Complex complex)
		{
			return false;
		}

		public static bool IsNaN(this Complex complex)
		{
			return false;
		}

		public static bool IsInfinity(this Complex complex)
		{
			return false;
		}

		public static bool IsReal(this Complex complex)
		{
			return false;
		}

		public static bool IsRealNonNegative(this Complex complex)
		{
			return false;
		}

		public static double Norm(this Complex complex)
		{
			return 0.0;
		}

		public static double Norm(this Complex32 complex)
		{
			return 0.0;
		}

		public static double NormOfDifference(this Complex complex, Complex otherValue)
		{
			return 0.0;
		}

		public static double NormOfDifference(this Complex32 complex, Complex32 otherValue)
		{
			return 0.0;
		}

		public static Complex ToComplex(this string value)
		{
			return default(Complex);
		}

		public static Complex ToComplex(this string value, IFormatProvider formatProvider)
		{
			return default(Complex);
		}

		private static double ParsePart(ref LinkedListNode<string> token, out bool imaginary, IFormatProvider format)
		{
			imaginary = default(bool);
			return 0.0;
		}

		public static bool TryToComplex(this string value, out Complex result)
		{
			result = default(Complex);
			return false;
		}

		public static bool TryToComplex(this string value, IFormatProvider formatProvider, out Complex result)
		{
			result = default(Complex);
			return false;
		}

		public static Complex32 ToComplex32(this string value)
		{
			return default(Complex32);
		}

		public static Complex32 ToComplex32(this string value, IFormatProvider formatProvider)
		{
			return default(Complex32);
		}

		public static bool TryToComplex32(this string value, out Complex32 result)
		{
			result = default(Complex32);
			return false;
		}

		public static bool TryToComplex32(this string value, IFormatProvider formatProvider, out Complex32 result)
		{
			result = default(Complex32);
			return false;
		}
	}
}
