using System;
using System.Collections.Generic;
using System.Diagnostics;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Double
{
	[Serializable]
	[DebuggerDisplay("SparseVector {Count}-Double {NonZerosCount}-NonZero")]
	public class SparseVector : Vector
	{
		private readonly SparseVectorStorage<double> _storage;

		public int NonZerosCount => 0;

		public SparseVector(SparseVectorStorage<double> storage)
			: base(null)
		{
		}

		public SparseVector(int length)
			: base(null)
		{
		}

		public static SparseVector OfVector(Vector<double> vector)
		{
			return null;
		}

		public static SparseVector OfEnumerable(IEnumerable<double> enumerable)
		{
			return null;
		}

		public static SparseVector OfIndexedEnumerable(int length, IEnumerable<Tuple<int, double>> enumerable)
		{
			return null;
		}

		public static SparseVector OfIndexedEnumerable(int length, IEnumerable<(int, double)> enumerable)
		{
			return null;
		}

		public static SparseVector Create(int length, double value)
		{
			return null;
		}

		public static SparseVector Create(int length, Func<int, double> init)
		{
			return null;
		}

		protected override void DoAdd(double scalar, Vector<double> result)
		{
		}

		protected override void DoAdd(Vector<double> other, Vector<double> result)
		{
		}

		protected override void DoSubtract(double scalar, Vector<double> result)
		{
		}

		protected override void DoSubtract(Vector<double> other, Vector<double> result)
		{
		}

		protected override void DoNegate(Vector<double> result)
		{
		}

		protected override void DoMultiply(double scalar, Vector<double> result)
		{
		}

		protected override double DoDotProduct(Vector<double> other)
		{
			return 0.0;
		}

		protected override void DoModulus(double divisor, Vector<double> result)
		{
		}

		protected override void DoRemainder(double divisor, Vector<double> result)
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

		public static SparseVector operator *(SparseVector leftSide, double rightSide)
		{
			return null;
		}

		public static SparseVector operator *(double leftSide, SparseVector rightSide)
		{
			return null;
		}

		public static double operator *(SparseVector leftSide, SparseVector rightSide)
		{
			return 0.0;
		}

		public static SparseVector operator /(SparseVector leftSide, double rightSide)
		{
			return null;
		}

		public static SparseVector operator %(SparseVector leftSide, double rightSide)
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

		public override double Sum()
		{
			return 0.0;
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

		protected override void DoPointwiseMultiply(Vector<double> other, Vector<double> result)
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
