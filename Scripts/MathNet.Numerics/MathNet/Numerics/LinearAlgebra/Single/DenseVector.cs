using System;
using System.Collections.Generic;
using System.Diagnostics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Single
{
	[Serializable]
	[DebuggerDisplay("DenseVector {Count}-Single")]
	public class DenseVector : Vector
	{
		private readonly int _length;

		private readonly float[] _values;

		public float[] Values => null;

		public DenseVector(DenseVectorStorage<float> storage)
			: base(null)
		{
		}

		public DenseVector(int length)
			: base(null)
		{
		}

		public DenseVector(float[] storage)
			: base(null)
		{
		}

		public static DenseVector OfVector(Vector<float> vector)
		{
			return null;
		}

		public static DenseVector OfArray(float[] array)
		{
			return null;
		}

		public static DenseVector OfEnumerable(IEnumerable<float> enumerable)
		{
			return null;
		}

		public static DenseVector OfIndexedEnumerable(int length, IEnumerable<Tuple<int, float>> enumerable)
		{
			return null;
		}

		public static DenseVector OfIndexedEnumerable(int length, IEnumerable<(int, float)> enumerable)
		{
			return null;
		}

		public static DenseVector Create(int length, float value)
		{
			return null;
		}

		public static DenseVector Create(int length, Func<int, float> init)
		{
			return null;
		}

		public static DenseVector CreateRandom(int length, IContinuousDistribution distribution)
		{
			return null;
		}

		public static explicit operator float[](DenseVector vector)
		{
			return null;
		}

		public static implicit operator DenseVector(float[] array)
		{
			return null;
		}

		protected override void DoAdd(float scalar, Vector<float> result)
		{
		}

		protected override void DoAdd(Vector<float> other, Vector<float> result)
		{
		}

		public static DenseVector operator +(DenseVector leftSide, DenseVector rightSide)
		{
			return null;
		}

		protected override void DoSubtract(float scalar, Vector<float> result)
		{
		}

		protected override void DoSubtract(Vector<float> other, Vector<float> result)
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

		public static DenseVector operator *(DenseVector leftSide, float rightSide)
		{
			return null;
		}

		public static DenseVector operator *(float leftSide, DenseVector rightSide)
		{
			return null;
		}

		public static float operator *(DenseVector leftSide, DenseVector rightSide)
		{
			return 0f;
		}

		public static DenseVector operator /(DenseVector leftSide, float rightSide)
		{
			return null;
		}

		protected override void DoModulus(float divisor, Vector<float> result)
		{
		}

		protected override void DoRemainder(float divisor, Vector<float> result)
		{
		}

		public static DenseVector operator %(DenseVector leftSide, float rightSide)
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

		protected override void DoPointwiseMultiply(Vector<float> other, Vector<float> result)
		{
		}

		protected override void DoPointwiseDivide(Vector<float> divisor, Vector<float> result)
		{
		}

		protected override void DoPointwisePower(Vector<float> exponent, Vector<float> result)
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
