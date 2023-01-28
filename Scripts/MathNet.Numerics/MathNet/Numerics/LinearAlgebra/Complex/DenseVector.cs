using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Complex
{
	[Serializable]
	[DebuggerDisplay("DenseVector {Count}-Complex")]
	public class DenseVector : Vector
	{
		private readonly int _length;

		private readonly System.Numerics.Complex[] _values;

		public System.Numerics.Complex[] Values => null;

		public DenseVector(DenseVectorStorage<System.Numerics.Complex> storage)
			: base(null)
		{
		}

		public DenseVector(int length)
			: base(null)
		{
		}

		public DenseVector(System.Numerics.Complex[] storage)
			: base(null)
		{
		}

		public static DenseVector OfVector(Vector<System.Numerics.Complex> vector)
		{
			return null;
		}

		public static DenseVector OfArray(System.Numerics.Complex[] array)
		{
			return null;
		}

		public static DenseVector OfEnumerable(IEnumerable<System.Numerics.Complex> enumerable)
		{
			return null;
		}

		public static DenseVector OfIndexedEnumerable(int length, IEnumerable<Tuple<int, System.Numerics.Complex>> enumerable)
		{
			return null;
		}

		public static DenseVector OfIndexedEnumerable(int length, IEnumerable<(int, System.Numerics.Complex)> enumerable)
		{
			return null;
		}

		public static DenseVector Create(int length, System.Numerics.Complex value)
		{
			return null;
		}

		public static DenseVector Create(int length, Func<int, System.Numerics.Complex> init)
		{
			return null;
		}

		public static DenseVector CreateRandom(int length, IContinuousDistribution distribution)
		{
			return null;
		}

		public static explicit operator System.Numerics.Complex[](DenseVector vector)
		{
			return null;
		}

		public static implicit operator DenseVector(System.Numerics.Complex[] array)
		{
			return null;
		}

		protected override void DoAdd(System.Numerics.Complex scalar, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoAdd(Vector<System.Numerics.Complex> other, Vector<System.Numerics.Complex> result)
		{
		}

		public static Vector<System.Numerics.Complex>operator +(DenseVector leftSide, DenseVector rightSide)
		{
			return null;
		}

		protected override void DoSubtract(System.Numerics.Complex scalar, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoSubtract(Vector<System.Numerics.Complex> other, Vector<System.Numerics.Complex> result)
		{
		}

		public static Vector<System.Numerics.Complex>operator -(DenseVector rightSide)
		{
			return null;
		}

		public static Vector<System.Numerics.Complex>operator -(DenseVector leftSide, DenseVector rightSide)
		{
			return null;
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

		public static DenseVector operator *(DenseVector leftSide, System.Numerics.Complex rightSide)
		{
			return null;
		}

		public static DenseVector operator *(System.Numerics.Complex leftSide, DenseVector rightSide)
		{
			return null;
		}

		public static System.Numerics.Complex operator *(DenseVector leftSide, DenseVector rightSide)
		{
			return default(System.Numerics.Complex);
		}

		public static DenseVector operator /(DenseVector leftSide, System.Numerics.Complex rightSide)
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

		protected override void DoPointwiseMultiply(Vector<System.Numerics.Complex> other, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseDivide(Vector<System.Numerics.Complex> divisor, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwisePower(Vector<System.Numerics.Complex> exponent, Vector<System.Numerics.Complex> result)
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
