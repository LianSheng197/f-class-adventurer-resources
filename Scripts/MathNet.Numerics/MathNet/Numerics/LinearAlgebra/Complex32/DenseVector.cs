using System;
using System.Collections.Generic;
using System.Diagnostics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Complex32
{
	[Serializable]
	[DebuggerDisplay("DenseVector {Count}-Complex32")]
	public class DenseVector : Vector
	{
		private readonly int _length;

		private readonly MathNet.Numerics.Complex32[] _values;

		public MathNet.Numerics.Complex32[] Values => null;

		public DenseVector(DenseVectorStorage<MathNet.Numerics.Complex32> storage)
			: base(null)
		{
		}

		public DenseVector(int length)
			: base(null)
		{
		}

		public DenseVector(MathNet.Numerics.Complex32[] storage)
			: base(null)
		{
		}

		public static DenseVector OfVector(Vector<MathNet.Numerics.Complex32> vector)
		{
			return null;
		}

		public static DenseVector OfArray(MathNet.Numerics.Complex32[] array)
		{
			return null;
		}

		public static DenseVector OfEnumerable(IEnumerable<MathNet.Numerics.Complex32> enumerable)
		{
			return null;
		}

		public static DenseVector OfIndexedEnumerable(int length, IEnumerable<Tuple<int, MathNet.Numerics.Complex32>> enumerable)
		{
			return null;
		}

		public static DenseVector OfIndexedEnumerable(int length, IEnumerable<(int, MathNet.Numerics.Complex32)> enumerable)
		{
			return null;
		}

		public static DenseVector Create(int length, MathNet.Numerics.Complex32 value)
		{
			return null;
		}

		public static DenseVector Create(int length, Func<int, MathNet.Numerics.Complex32> init)
		{
			return null;
		}

		public static DenseVector CreateRandom(int length, IContinuousDistribution distribution)
		{
			return null;
		}

		public static explicit operator MathNet.Numerics.Complex32[](DenseVector vector)
		{
			return null;
		}

		public static implicit operator DenseVector(MathNet.Numerics.Complex32[] array)
		{
			return null;
		}

		protected override void DoAdd(MathNet.Numerics.Complex32 scalar, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoAdd(Vector<MathNet.Numerics.Complex32> other, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		public static DenseVector operator +(DenseVector leftSide, DenseVector rightSide)
		{
			return null;
		}

		protected override void DoSubtract(MathNet.Numerics.Complex32 scalar, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoSubtract(Vector<MathNet.Numerics.Complex32> other, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		public static DenseVector operator -(DenseVector rightSide)
		{
			return null;
		}

		public static DenseVector operator -(DenseVector leftSide, DenseVector rightSide)
		{
			return null;
		}

		protected override void DoNegate(Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoConjugate(Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoMultiply(MathNet.Numerics.Complex32 scalar, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override MathNet.Numerics.Complex32 DoDotProduct(Vector<MathNet.Numerics.Complex32> other)
		{
			return default(MathNet.Numerics.Complex32);
		}

		protected override MathNet.Numerics.Complex32 DoConjugateDotProduct(Vector<MathNet.Numerics.Complex32> other)
		{
			return default(MathNet.Numerics.Complex32);
		}

		public static DenseVector operator *(DenseVector leftSide, MathNet.Numerics.Complex32 rightSide)
		{
			return null;
		}

		public static DenseVector operator *(MathNet.Numerics.Complex32 leftSide, DenseVector rightSide)
		{
			return null;
		}

		public static MathNet.Numerics.Complex32 operator *(DenseVector leftSide, DenseVector rightSide)
		{
			return default(MathNet.Numerics.Complex32);
		}

		public static DenseVector operator /(DenseVector leftSide, MathNet.Numerics.Complex32 rightSide)
		{
			return null;
		}

		public override int AbsoluteMinimumIndex()
		{
			return 0;
		}

		public override int AbsoluteMaximumIndex()
		{
			return 0;
		}

		public override MathNet.Numerics.Complex32 Sum()
		{
			return default(MathNet.Numerics.Complex32);
		}

		public override double L1Norm()
		{
			return 0.0;
		}

		public override double L2Norm()
		{
			return 0.0;
		}

		public override double InfinityNorm()
		{
			return 0.0;
		}

		public override double Norm(double p)
		{
			return 0.0;
		}

		protected override void DoPointwiseMultiply(Vector<MathNet.Numerics.Complex32> other, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseDivide(Vector<MathNet.Numerics.Complex32> divisor, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwisePower(Vector<MathNet.Numerics.Complex32> exponent, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		public static DenseVector Parse(string value, IFormatProvider formatProvider = null)
		{
			return null;
		}

		public static bool TryParse(string value, out DenseVector result)
		{
			result = null;
			return false;
		}

		public static bool TryParse(string value, IFormatProvider formatProvider, out DenseVector result)
		{
			result = null;
			return false;
		}
	}
}
