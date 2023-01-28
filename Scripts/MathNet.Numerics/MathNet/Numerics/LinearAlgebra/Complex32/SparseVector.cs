using System;
using System.Collections.Generic;
using System.Diagnostics;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Complex32
{
	[Serializable]
	[DebuggerDisplay("SparseVector {Count}-Complex32 {NonZerosCount}-NonZero")]
	public class SparseVector : Vector
	{
		private readonly SparseVectorStorage<MathNet.Numerics.Complex32> _storage;

		public int NonZerosCount => 0;

		public SparseVector(SparseVectorStorage<MathNet.Numerics.Complex32> storage)
			: base(null)
		{
		}

		public SparseVector(int length)
			: base(null)
		{
		}

		public static SparseVector OfVector(Vector<MathNet.Numerics.Complex32> vector)
		{
			return null;
		}

		public static SparseVector OfEnumerable(IEnumerable<MathNet.Numerics.Complex32> enumerable)
		{
			return null;
		}

		public static SparseVector OfIndexedEnumerable(int length, IEnumerable<Tuple<int, MathNet.Numerics.Complex32>> enumerable)
		{
			return null;
		}

		public static SparseVector OfIndexedEnumerable(int length, IEnumerable<(int, MathNet.Numerics.Complex32)> enumerable)
		{
			return null;
		}

		public static SparseVector Create(int length, MathNet.Numerics.Complex32 value)
		{
			return null;
		}

		public static SparseVector Create(int length, Func<int, MathNet.Numerics.Complex32> init)
		{
			return null;
		}

		protected override void DoAdd(MathNet.Numerics.Complex32 scalar, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoAdd(Vector<MathNet.Numerics.Complex32> other, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoSubtract(MathNet.Numerics.Complex32 scalar, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoSubtract(Vector<MathNet.Numerics.Complex32> other, Vector<MathNet.Numerics.Complex32> result)
		{
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

		public static SparseVector operator +(SparseVector leftSide, SparseVector rightSide)
		{
			return null;
		}

		public static SparseVector operator -(SparseVector rightSide)
		{
			return null;
		}

		public static SparseVector operator -(SparseVector leftSide, SparseVector rightSide)
		{
			return null;
		}

		public static SparseVector operator *(SparseVector leftSide, MathNet.Numerics.Complex32 rightSide)
		{
			return null;
		}

		public static SparseVector operator *(MathNet.Numerics.Complex32 leftSide, SparseVector rightSide)
		{
			return null;
		}

		public static MathNet.Numerics.Complex32 operator *(SparseVector leftSide, SparseVector rightSide)
		{
			return default(MathNet.Numerics.Complex32);
		}

		public static SparseVector operator /(SparseVector leftSide, MathNet.Numerics.Complex32 rightSide)
		{
			return null;
		}

		public static SparseVector operator %(SparseVector leftSide, MathNet.Numerics.Complex32 rightSide)
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

		public static SparseVector Parse(string value, IFormatProvider formatProvider = null)
		{
			return null;
		}

		public static bool TryParse(string value, out SparseVector result)
		{
			result = null;
			return false;
		}

		public static bool TryParse(string value, IFormatProvider formatProvider, out SparseVector result)
		{
			result = null;
			return false;
		}

		public override string ToTypeString()
		{
			return null;
		}
	}
}
