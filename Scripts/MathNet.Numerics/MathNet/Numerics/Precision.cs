using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime;
using System.Runtime.InteropServices;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics
{
	public static class Precision
	{
		[StructLayout(LayoutKind.Explicit)]
		private struct SingleIntUnion
		{
			public float Single;

			public int Int32;
		}

		private const int DoubleWidth = 53;

		private const int SingleWidth = 24;

		public static readonly double DoublePrecision;

		public static readonly double PositiveDoublePrecision;

		public static readonly double SinglePrecision;

		public static readonly double PositiveSinglePrecision;

		public static readonly double MachineEpsilon;

		public static readonly double PositiveMachineEpsilon;

		public static readonly int DoubleDecimalPlaces;

		public static readonly int SingleDecimalPlaces;

		private static readonly double DefaultDoubleAccuracy;

		private static readonly float DefaultSingleAccuracy;

		private static readonly double[] NegativePowersOf10;

		public static int CompareTo(this double a, double b, double maximumAbsoluteError)
		{
			return 0;
		}

		public static int CompareTo(this double a, double b, int decimalPlaces)
		{
			return 0;
		}

		public static int CompareToRelative(this double a, double b, double maximumError)
		{
			return 0;
		}

		public static int CompareToRelative(this double a, double b, int decimalPlaces)
		{
			return 0;
		}

		public static int CompareToNumbersBetween(this double a, double b, long maxNumbersBetween)
		{
			return 0;
		}

		public static bool IsLarger(this double a, double b, int decimalPlaces)
		{
			return false;
		}

		public static bool IsLarger(this float a, float b, int decimalPlaces)
		{
			return false;
		}

		public static bool IsLarger(this double a, double b, double maximumAbsoluteError)
		{
			return false;
		}

		public static bool IsLarger(this float a, float b, double maximumAbsoluteError)
		{
			return false;
		}

		public static bool IsLargerRelative(this double a, double b, int decimalPlaces)
		{
			return false;
		}

		public static bool IsLargerRelative(this float a, float b, int decimalPlaces)
		{
			return false;
		}

		public static bool IsLargerRelative(this double a, double b, double maximumError)
		{
			return false;
		}

		public static bool IsLargerRelative(this float a, float b, double maximumError)
		{
			return false;
		}

		public static bool IsLargerNumbersBetween(this double a, double b, long maxNumbersBetween)
		{
			return false;
		}

		public static bool IsLargerNumbersBetween(this float a, float b, long maxNumbersBetween)
		{
			return false;
		}

		public static bool IsSmaller(this double a, double b, int decimalPlaces)
		{
			return false;
		}

		public static bool IsSmaller(this float a, float b, int decimalPlaces)
		{
			return false;
		}

		public static bool IsSmaller(this double a, double b, double maximumAbsoluteError)
		{
			return false;
		}

		public static bool IsSmaller(this float a, float b, double maximumAbsoluteError)
		{
			return false;
		}

		public static bool IsSmallerRelative(this double a, double b, int decimalPlaces)
		{
			return false;
		}

		public static bool IsSmallerRelative(this float a, float b, int decimalPlaces)
		{
			return false;
		}

		public static bool IsSmallerRelative(this double a, double b, double maximumError)
		{
			return false;
		}

		public static bool IsSmallerRelative(this float a, float b, double maximumError)
		{
			return false;
		}

		public static bool IsSmallerNumbersBetween(this double a, double b, long maxNumbersBetween)
		{
			return false;
		}

		public static bool IsSmallerNumbersBetween(this float a, float b, long maxNumbersBetween)
		{
			return false;
		}

		public static bool IsFinite(this double value)
		{
			return false;
		}

		public static int Magnitude(this double value)
		{
			return 0;
		}

		public static int Magnitude(this float value)
		{
			return 0;
		}

		public static double ScaleUnitMagnitude(this double value)
		{
			return 0.0;
		}

		private static long AsDirectionalInt64(double value)
		{
			return 0L;
		}

		private static int AsDirectionalInt32(float value)
		{
			return 0;
		}

		public static double Increment(this double value, int count = 1)
		{
			return 0.0;
		}

		public static double Decrement(this double value, int count = 1)
		{
			return 0.0;
		}

		public static double CoerceZero(this double a, int maxNumbersBetween)
		{
			return 0.0;
		}

		public static double CoerceZero(this double a, long maxNumbersBetween)
		{
			return 0.0;
		}

		public static double CoerceZero(this double a, double maximumAbsoluteError)
		{
			return 0.0;
		}

		public static double CoerceZero(this double a)
		{
			return 0.0;
		}

		public static (double, double) RangeOfMatchingFloatingPointNumbers(this double value, long maxNumbersBetween)
		{
			return default((double, double));
		}

		public static double MaximumMatchingFloatingPointNumber(this double value, long maxNumbersBetween)
		{
			return 0.0;
		}

		public static double MinimumMatchingFloatingPointNumber(this double value, long maxNumbersBetween)
		{
			return 0.0;
		}

		public static (long, long) RangeOfMatchingNumbers(this double value, double relativeDifference)
		{
			return default((long, long));
		}

		[CLSCompliant(false)]
		public static ulong NumbersBetween(this double a, double b)
		{
			return 0uL;
		}

		public static double EpsilonOf(this double value)
		{
			return 0.0;
		}

		public static float EpsilonOf(this float value)
		{
			return 0f;
		}

		public static double PositiveEpsilonOf(this double value)
		{
			return 0.0;
		}

		public static float PositiveEpsilonOf(this float value)
		{
			return 0f;
		}

		private static double MeasureMachineEpsilon()
		{
			return 0.0;
		}

		private static double MeasurePositiveMachineEpsilon()
		{
			return 0.0;
		}

		public static double RoundToMultiple(this double number, double basis)
		{
			return 0.0;
		}

		public static float RoundToMultiple(this float number, float basis)
		{
			return 0f;
		}

		public static decimal RoundToMultiple(this decimal number, decimal basis)
		{
			return default(decimal);
		}

		public static double RoundToPower(this double number, double basis)
		{
			return 0.0;
		}

		public static float RoundToPower(this float number, float basis)
		{
			return 0f;
		}

		public static double Round(this double number, int digits)
		{
			return 0.0;
		}

		public static float Round(this float number, int digits)
		{
			return 0f;
		}

		public static decimal Round(this decimal number, int digits)
		{
			return default(decimal);
		}

		public static int Round(this int number, int digits)
		{
			return 0;
		}

		[CLSCompliant(false)]
		public static uint Round(this uint number, int digits)
		{
			return 0u;
		}

		public static long Round(this long number, int digits)
		{
			return 0L;
		}

		[CLSCompliant(false)]
		public static ulong Round(this ulong number, int digits)
		{
			return 0uL;
		}

		public static short Round(this short number, int digits)
		{
			return 0;
		}

		[CLSCompliant(false)]
		public static ushort Round(this ushort number, int digits)
		{
			return 0;
		}

		public static BigInteger Round(this BigInteger number, int digits)
		{
			return default(BigInteger);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		private static double Truncate(double value)
		{
			return 0.0;
		}

		private static int SingleToInt32Bits(float value)
		{
			return 0;
		}

		private static float Int32BitsToSingle(int value)
		{
			return 0f;
		}

		public static bool AlmostEqualNorm(this double a, double b, double diff, double maximumAbsoluteError)
		{
			return false;
		}

		public static bool AlmostEqualNorm<T>(this T a, T b, double maximumAbsoluteError) where T : IPrecisionSupport<T>
		{
			return false;
		}

		public static bool AlmostEqualNormRelative(this double a, double b, double diff, double maximumError)
		{
			return false;
		}

		public static bool AlmostEqualNormRelative<T>(this T a, T b, double maximumError) where T : IPrecisionSupport<T>
		{
			return false;
		}

		public static bool AlmostEqual(this double a, double b, double maximumAbsoluteError)
		{
			return false;
		}

		public static bool AlmostEqual(this float a, float b, double maximumAbsoluteError)
		{
			return false;
		}

		public static bool AlmostEqual(this Complex a, Complex b, double maximumAbsoluteError)
		{
			return false;
		}

		public static bool AlmostEqual(this Complex32 a, Complex32 b, double maximumAbsoluteError)
		{
			return false;
		}

		public static bool AlmostEqualRelative(this double a, double b, double maximumError)
		{
			return false;
		}

		public static bool AlmostEqualRelative(this float a, float b, double maximumError)
		{
			return false;
		}

		public static bool AlmostEqualRelative(this Complex a, Complex b, double maximumError)
		{
			return false;
		}

		public static bool AlmostEqualRelative(this Complex32 a, Complex32 b, double maximumError)
		{
			return false;
		}

		public static bool AlmostEqual(this double a, double b)
		{
			return false;
		}

		public static bool AlmostEqual(this float a, float b)
		{
			return false;
		}

		public static bool AlmostEqual(this Complex a, Complex b)
		{
			return false;
		}

		public static bool AlmostEqual(this Complex32 a, Complex32 b)
		{
			return false;
		}

		public static bool AlmostEqualRelative(this double a, double b)
		{
			return false;
		}

		public static bool AlmostEqualRelative(this float a, float b)
		{
			return false;
		}

		public static bool AlmostEqualRelative(this Complex a, Complex b)
		{
			return false;
		}

		public static bool AlmostEqualRelative(this Complex32 a, Complex32 b)
		{
			return false;
		}

		public static bool AlmostEqualNorm(this double a, double b, double diff, int decimalPlaces)
		{
			return false;
		}

		public static bool AlmostEqualNorm<T>(this T a, T b, int decimalPlaces) where T : IPrecisionSupport<T>
		{
			return false;
		}

		public static bool AlmostEqualNormRelative(this double a, double b, double diff, int decimalPlaces)
		{
			return false;
		}

		public static bool AlmostEqualNormRelative<T>(this T a, T b, int decimalPlaces) where T : IPrecisionSupport<T>
		{
			return false;
		}

		public static bool AlmostEqual(this double a, double b, int decimalPlaces)
		{
			return false;
		}

		public static bool AlmostEqual(this float a, float b, int decimalPlaces)
		{
			return false;
		}

		public static bool AlmostEqual(this Complex a, Complex b, int decimalPlaces)
		{
			return false;
		}

		public static bool AlmostEqual(this Complex32 a, Complex32 b, int decimalPlaces)
		{
			return false;
		}

		public static bool AlmostEqualRelative(this double a, double b, int decimalPlaces)
		{
			return false;
		}

		public static bool AlmostEqualRelative(this float a, float b, int decimalPlaces)
		{
			return false;
		}

		public static bool AlmostEqualRelative(this Complex a, Complex b, int decimalPlaces)
		{
			return false;
		}

		public static bool AlmostEqualRelative(this Complex32 a, Complex32 b, int decimalPlaces)
		{
			return false;
		}

		public static bool AlmostEqualNumbersBetween(this double a, double b, long maxNumbersBetween)
		{
			return false;
		}

		public static bool AlmostEqualNumbersBetween(this float a, float b, int maxNumbersBetween)
		{
			return false;
		}

		public static bool ListAlmostEqual(this IList<double> a, IList<double> b, double maximumAbsoluteError)
		{
			return false;
		}

		public static bool ListAlmostEqual(this IList<float> a, IList<float> b, double maximumAbsoluteError)
		{
			return false;
		}

		public static bool ListAlmostEqual(this IList<Complex> a, IList<Complex> b, double maximumAbsoluteError)
		{
			return false;
		}

		public static bool ListAlmostEqual(this IList<Complex32> a, IList<Complex32> b, double maximumAbsoluteError)
		{
			return false;
		}

		public static bool ListAlmostEqualRelative(this IList<double> a, IList<double> b, double maximumError)
		{
			return false;
		}

		public static bool ListAlmostEqualRelative(this IList<float> a, IList<float> b, double maximumError)
		{
			return false;
		}

		public static bool ListAlmostEqualRelative(this IList<Complex> a, IList<Complex> b, double maximumError)
		{
			return false;
		}

		public static bool ListAlmostEqualRelative(this IList<Complex32> a, IList<Complex32> b, double maximumError)
		{
			return false;
		}

		public static bool ListAlmostEqual(this IList<double> a, IList<double> b, int decimalPlaces)
		{
			return false;
		}

		public static bool ListAlmostEqual(this IList<float> a, IList<float> b, int decimalPlaces)
		{
			return false;
		}

		public static bool ListAlmostEqual(this IList<Complex> a, IList<Complex> b, int decimalPlaces)
		{
			return false;
		}

		public static bool ListAlmostEqual(this IList<Complex32> a, IList<Complex32> b, int decimalPlaces)
		{
			return false;
		}

		public static bool ListAlmostEqualRelative(this IList<double> a, IList<double> b, int decimalPlaces)
		{
			return false;
		}

		public static bool ListAlmostEqualRelative(this IList<float> a, IList<float> b, int decimalPlaces)
		{
			return false;
		}

		public static bool ListAlmostEqualRelative(this IList<Complex> a, IList<Complex> b, int decimalPlaces)
		{
			return false;
		}

		public static bool ListAlmostEqualRelative(this IList<Complex32> a, IList<Complex32> b, int decimalPlaces)
		{
			return false;
		}

		public static bool ListAlmostEqualNorm<T>(this IList<T> a, IList<T> b, double maximumAbsoluteError) where T : IPrecisionSupport<T>
		{
			return false;
		}

		public static bool ListAlmostEqualNormRelative<T>(this IList<T> a, IList<T> b, double maximumError) where T : IPrecisionSupport<T>
		{
			return false;
		}

		private static bool ListForAll<T, TP>(IList<T> a, IList<T> b, Func<T, T, TP, bool> predicate, TP parameter)
		{
			return false;
		}

		public static bool AlmostEqual<T>(this MathNet.Numerics.LinearAlgebra.Vector<T> a, MathNet.Numerics.LinearAlgebra.Vector<T> b, double maximumAbsoluteError) where T : struct, IEquatable<T>, IFormattable
		{
			return false;
		}

		public static bool AlmostEqualRelative<T>(this MathNet.Numerics.LinearAlgebra.Vector<T> a, MathNet.Numerics.LinearAlgebra.Vector<T> b, double maximumError) where T : struct, IEquatable<T>, IFormattable
		{
			return false;
		}

		public static bool AlmostEqual<T>(this MathNet.Numerics.LinearAlgebra.Vector<T> a, MathNet.Numerics.LinearAlgebra.Vector<T> b, int decimalPlaces) where T : struct, IEquatable<T>, IFormattable
		{
			return false;
		}

		public static bool AlmostEqualRelative<T>(this MathNet.Numerics.LinearAlgebra.Vector<T> a, MathNet.Numerics.LinearAlgebra.Vector<T> b, int decimalPlaces) where T : struct, IEquatable<T>, IFormattable
		{
			return false;
		}

		public static bool AlmostEqual<T>(this Matrix<T> a, Matrix<T> b, double maximumAbsoluteError) where T : struct, IEquatable<T>, IFormattable
		{
			return false;
		}

		public static bool AlmostEqualRelative<T>(this Matrix<T> a, Matrix<T> b, double maximumError) where T : struct, IEquatable<T>, IFormattable
		{
			return false;
		}

		public static bool AlmostEqual<T>(this Matrix<T> a, Matrix<T> b, int decimalPlaces) where T : struct, IEquatable<T>, IFormattable
		{
			return false;
		}

		public static bool AlmostEqualRelative<T>(this Matrix<T> a, Matrix<T> b, int decimalPlaces) where T : struct, IEquatable<T>, IFormattable
		{
			return false;
		}

		private static double Pow10(int y)
		{
			return 0.0;
		}
	}
}
