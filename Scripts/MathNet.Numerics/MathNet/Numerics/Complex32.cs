using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime;
using System.Runtime.Serialization;

namespace MathNet.Numerics
{
	[Serializable]
	[DataContract(Namespace = "urn:MathNet/Numerics")]
	public readonly struct Complex32 : IFormattable, IEquatable<Complex32>
	{
		[DataMember(Order = 1)]
		private readonly float _real;

		[DataMember(Order = 2)]
		private readonly float _imag;

		public static readonly Complex32 Zero;

		public static readonly Complex32 One;

		public static readonly Complex32 ImaginaryOne;

		public static readonly Complex32 PositiveInfinity;

		public static readonly Complex32 NaN;

		public float Real
		{
			[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
			get
			{
				return 0f;
			}
		}

		public float Imaginary
		{
			[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
			get
			{
				return 0f;
			}
		}

		public float Phase
		{
			[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
			get
			{
				return 0f;
			}
		}

		public float Magnitude
		{
			[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
			get
			{
				return 0f;
			}
		}

		public float MagnitudeSquared => 0f;

		public Complex32 Sign => default(Complex32);

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public Complex32(float real, float imaginary)
		{
		}

		public static Complex32 FromPolarCoordinates(float magnitude, float phase)
		{
			return default(Complex32);
		}

		public bool IsZero()
		{
			return false;
		}

		public bool IsOne()
		{
			return false;
		}

		public bool IsImaginaryOne()
		{
			return false;
		}

		public bool IsNaN()
		{
			return false;
		}

		public bool IsInfinity()
		{
			return false;
		}

		public bool IsReal()
		{
			return false;
		}

		public bool IsRealNonNegative()
		{
			return false;
		}

		public Complex32 Exponential()
		{
			return default(Complex32);
		}

		public Complex32 NaturalLogarithm()
		{
			return default(Complex32);
		}

		public Complex32 CommonLogarithm()
		{
			return default(Complex32);
		}

		public Complex32 Logarithm(float baseValue)
		{
			return default(Complex32);
		}

		public Complex32 Power(Complex32 exponent)
		{
			return default(Complex32);
		}

		public Complex32 Root(Complex32 rootExponent)
		{
			return default(Complex32);
		}

		public Complex32 Square()
		{
			return default(Complex32);
		}

		public Complex32 SquareRoot()
		{
			return default(Complex32);
		}

		public (Complex32, Complex32) SquareRoots()
		{
			return default((Complex32, Complex32));
		}

		public (Complex32, Complex32, Complex32) CubicRoots()
		{
			return default((Complex32, Complex32, Complex32));
		}

		public static bool operator ==(Complex32 complex1, Complex32 complex2)
		{
			return false;
		}

		public static bool operator !=(Complex32 complex1, Complex32 complex2)
		{
			return false;
		}

		public static Complex32 operator +(Complex32 summand)
		{
			return default(Complex32);
		}

		public static Complex32 operator -(Complex32 subtrahend)
		{
			return default(Complex32);
		}

		public static Complex32 operator +(Complex32 summand1, Complex32 summand2)
		{
			return default(Complex32);
		}

		public static Complex32 operator -(Complex32 minuend, Complex32 subtrahend)
		{
			return default(Complex32);
		}

		public static Complex32 operator +(Complex32 summand1, float summand2)
		{
			return default(Complex32);
		}

		public static Complex32 operator -(Complex32 minuend, float subtrahend)
		{
			return default(Complex32);
		}

		public static Complex32 operator +(float summand1, Complex32 summand2)
		{
			return default(Complex32);
		}

		public static Complex32 operator -(float minuend, Complex32 subtrahend)
		{
			return default(Complex32);
		}

		public static Complex32 operator *(Complex32 multiplicand, Complex32 multiplier)
		{
			return default(Complex32);
		}

		public static Complex32 operator *(float multiplicand, Complex32 multiplier)
		{
			return default(Complex32);
		}

		public static Complex32 operator *(Complex32 multiplicand, float multiplier)
		{
			return default(Complex32);
		}

		public static Complex32 operator /(Complex32 dividend, Complex32 divisor)
		{
			return default(Complex32);
		}

		private static Complex32 InternalDiv(float a, float b, float c, float d, bool swapped)
		{
			return default(Complex32);
		}

		public static Complex32 operator /(float dividend, Complex32 divisor)
		{
			return default(Complex32);
		}

		public static Complex32 operator /(Complex32 dividend, float divisor)
		{
			return default(Complex32);
		}

		public Complex32 Conjugate()
		{
			return default(Complex32);
		}

		public Complex32 Reciprocal()
		{
			return default(Complex32);
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(string format)
		{
			return null;
		}

		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		public bool Equals(Complex32 other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public static Complex32 Parse(string value, IFormatProvider formatProvider = null)
		{
			return default(Complex32);
		}

		private static float ParsePart(ref LinkedListNode<string> token, out bool imaginary, IFormatProvider format)
		{
			imaginary = default(bool);
			return 0f;
		}

		public static bool TryParse(string value, out Complex32 result)
		{
			result = default(Complex32);
			return false;
		}

		public static bool TryParse(string value, IFormatProvider formatProvider, out Complex32 result)
		{
			result = default(Complex32);
			return false;
		}

		public static explicit operator Complex32(decimal value)
		{
			return default(Complex32);
		}

		public static explicit operator Complex32(Complex value)
		{
			return default(Complex32);
		}

		public static implicit operator Complex32(byte value)
		{
			return default(Complex32);
		}

		public static implicit operator Complex32(short value)
		{
			return default(Complex32);
		}

		[CLSCompliant(false)]
		public static implicit operator Complex32(sbyte value)
		{
			return default(Complex32);
		}

		[CLSCompliant(false)]
		public static implicit operator Complex32(ushort value)
		{
			return default(Complex32);
		}

		public static implicit operator Complex32(int value)
		{
			return default(Complex32);
		}

		public static implicit operator Complex32(BigInteger value)
		{
			return default(Complex32);
		}

		public static implicit operator Complex32(long value)
		{
			return default(Complex32);
		}

		[CLSCompliant(false)]
		public static implicit operator Complex32(uint value)
		{
			return default(Complex32);
		}

		[CLSCompliant(false)]
		public static implicit operator Complex32(ulong value)
		{
			return default(Complex32);
		}

		public static implicit operator Complex32(float value)
		{
			return default(Complex32);
		}

		public static explicit operator Complex32(double value)
		{
			return default(Complex32);
		}

		public Complex ToComplex()
		{
			return default(Complex);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static Complex32 Negate(Complex32 value)
		{
			return default(Complex32);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static Complex32 Conjugate(Complex32 value)
		{
			return default(Complex32);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static Complex32 Add(Complex32 left, Complex32 right)
		{
			return default(Complex32);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static Complex32 Subtract(Complex32 left, Complex32 right)
		{
			return default(Complex32);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static Complex32 Multiply(Complex32 left, Complex32 right)
		{
			return default(Complex32);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static Complex32 Divide(Complex32 dividend, Complex32 divisor)
		{
			return default(Complex32);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static Complex32 Reciprocal(Complex32 value)
		{
			return default(Complex32);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static Complex32 Sqrt(Complex32 value)
		{
			return default(Complex32);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static double Abs(Complex32 value)
		{
			return 0.0;
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static Complex32 Exp(Complex32 value)
		{
			return default(Complex32);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static Complex32 Pow(Complex32 value, Complex32 power)
		{
			return default(Complex32);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static Complex32 Pow(Complex32 value, float power)
		{
			return default(Complex32);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static Complex32 Log(Complex32 value)
		{
			return default(Complex32);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static Complex32 Log(Complex32 value, float baseValue)
		{
			return default(Complex32);
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static Complex32 Log10(Complex32 value)
		{
			return default(Complex32);
		}

		public static Complex32 Sin(Complex32 value)
		{
			return default(Complex32);
		}

		public static Complex32 Cos(Complex32 value)
		{
			return default(Complex32);
		}

		public static Complex32 Tan(Complex32 value)
		{
			return default(Complex32);
		}

		public static Complex32 Asin(Complex32 value)
		{
			return default(Complex32);
		}

		public static Complex32 Acos(Complex32 value)
		{
			return default(Complex32);
		}

		public static Complex32 Atan(Complex32 value)
		{
			return default(Complex32);
		}

		public static Complex32 Sinh(Complex32 value)
		{
			return default(Complex32);
		}

		public static Complex32 Cosh(Complex32 value)
		{
			return default(Complex32);
		}

		public static Complex32 Tanh(Complex32 value)
		{
			return default(Complex32);
		}
	}
}
