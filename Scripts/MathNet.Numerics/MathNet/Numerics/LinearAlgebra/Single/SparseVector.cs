using System;
using System.Collections.Generic;
using System.Diagnostics;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Single
{
	[Serializable]
	[DebuggerDisplay("SparseVector {Count}-Single {NonZerosCount}-NonZero")]
	public class SparseVector : Vector
	{
		private readonly SparseVectorStorage<float> _storage;

		public int NonZerosCount => 0;

		public SparseVector(SparseVectorStorage<float> storage)
			: base(null)
		{
		}

		public SparseVector(int length)
			: base(null)
		{
		}

		public static SparseVector OfVector(Vector<float> vector)
		{
			return null;
		}

		public static SparseVector OfEnumerable(IEnumerable<float> enumerable)
		{
			return null;
		}

		public static SparseVector OfIndexedEnumerable(int length, IEnumerable<Tuple<int, float>> enumerable)
		{
			return null;
		}

		public static SparseVector OfIndexedEnumerable(int length, IEnumerable<(int, float)> enumerable)
		{
			return null;
		}

		public static SparseVector Create(int length, float value)
		{
			return null;
		}

		public static SparseVector Create(int length, Func<int, float> init)
		{
			return null;
		}

		protected override void DoAdd(float scalar, Vector<float> result)
		{
		}

		protected override void DoAdd(Vector<float> other, Vector<float> result)
		{
		}

		protected override void DoSubtract(float scalar, Vector<float> result)
		{
		}

		protected override void DoSubtract(Vector<float> other, Vector<float> result)
		{
		}

		protected override void DoNegate(Vector<float> result)
		{
		}

		protected override void DoMultiply(float scalar, Vector<float> result)
		{
		}

		protected override float DoDotProduct(Vector<float> other)
		{
			return 0f;
		}

		protected override void DoModulus(float divisor, Vector<float> result)
		{
		}

		protected override void DoRemainder(float divisor, Vector<float> result)
		{
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

		public static SparseVector operator *(SparseVector leftSide, float rightSide)
		{
			return null;
		}

		public static SparseVector operator *(float leftSide, SparseVector rightSide)
		{
			return null;
		}

		public static float operator *(SparseVector leftSide, SparseVector rightSide)
		{
			return 0f;
		}

		public static SparseVector operator /(SparseVector leftSide, float rightSide)
		{
			return null;
		}

		public static SparseVector operator %(SparseVector leftSide, float rightSide)
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

		public override int MaximumIndex()
		{
			return 0;
		}

		public override int MinimumIndex()
		{
			return 0;
		}

		public override float Sum()
		{
			return 0f;
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

		protected override void DoPointwiseMultiply(Vector<float> other, Vector<float> result)
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
