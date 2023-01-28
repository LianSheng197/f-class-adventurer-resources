using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Complex
{
	[Serializable]
	[DebuggerDisplay("SparseVector {Count}-Complex {NonZerosCount}-NonZero")]
	public class SparseVector : Vector
	{
		private readonly SparseVectorStorage<System.Numerics.Complex> _storage;

		public int NonZerosCount => 0;

		public SparseVector(SparseVectorStorage<System.Numerics.Complex> storage)
			: base(null)
		{
		}

		public SparseVector(int length)
			: base(null)
		{
		}

		public static SparseVector OfVector(Vector<System.Numerics.Complex> vector)
		{
			return null;
		}

		public static SparseVector OfEnumerable(IEnumerable<System.Numerics.Complex> enumerable)
		{
			return null;
		}

		public static SparseVector OfIndexedEnumerable(int length, IEnumerable<Tuple<int, System.Numerics.Complex>> enumerable)
		{
			return null;
		}

		public static SparseVector OfIndexedEnumerable(int length, IEnumerable<(int, System.Numerics.Complex)> enumerable)
		{
			return null;
		}

		public static SparseVector Create(int length, System.Numerics.Complex value)
		{
			return null;
		}

		public static SparseVector Create(int length, Func<int, System.Numerics.Complex> init)
		{
			return null;
		}

		protected override void DoAdd(System.Numerics.Complex scalar, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoAdd(Vector<System.Numerics.Complex> other, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoSubtract(System.Numerics.Complex scalar, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoSubtract(Vector<System.Numerics.Complex> other, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoNegate(Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoConjugate(Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoMultiply(System.Numerics.Complex scalar, Vector<System.Numerics.Complex> result)
		{
		}

		protected override System.Numerics.Complex DoDotProduct(Vector<System.Numerics.Complex> other)
		{
			return default(System.Numerics.Complex);
		}

		protected override System.Numerics.Complex DoConjugateDotProduct(Vector<System.Numerics.Complex> other)
		{
			return default(System.Numerics.Complex);
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

		public static SparseVector operator *(SparseVector leftSide, System.Numerics.Complex rightSide)
		{
			return null;
		}

		public static SparseVector operator *(System.Numerics.Complex leftSide, SparseVector rightSide)
		{
			return null;
		}

		public static System.Numerics.Complex operator *(SparseVector leftSide, SparseVector rightSide)
		{
			return default(System.Numerics.Complex);
		}

		public static SparseVector operator /(SparseVector leftSide, System.Numerics.Complex rightSide)
		{
			return null;
		}

		public static SparseVector operator %(SparseVector leftSide, System.Numerics.Complex rightSide)
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

		public override System.Numerics.Complex Sum()
		{
			return default(System.Numerics.Complex);
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

		protected override void DoPointwiseMultiply(Vector<System.Numerics.Complex> other, Vector<System.Numerics.Complex> result)
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
