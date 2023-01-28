using System;
using System.Collections.Generic;
using System.Diagnostics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Double
{
	[Serializable]
	[DebuggerDisplay("DenseVector {Count}-Double")]
	public class DenseVector : Vector
	{
		private readonly int _length;

		private readonly double[] _values;

		public double[] Values => null;

		public DenseVector(DenseVectorStorage<double> storage)
			: base(null)
		{
		}

		public DenseVector(int length)
			: base(null)
		{
		}

		public DenseVector(double[] storage)
			: base(null)
		{
		}

		public static DenseVector OfVector(Vector<double> vector)
		{
			return null;
		}

		public static DenseVector OfArray(double[] array)
		{
			return null;
		}

		public static DenseVector OfEnumerable(IEnumerable<double> enumerable)
		{
			return null;
		}

		public static DenseVector OfIndexedEnumerable(int length, IEnumerable<Tuple<int, double>> enumerable)
		{
			return null;
		}

		public static DenseVector OfIndexedEnumerable(int length, IEnumerable<(int, double)> enumerable)
		{
			return null;
		}

		public static DenseVector Create(int length, double value)
		{
			return null;
		}

		public static DenseVector Create(int length, Func<int, double> init)
		{
			return null;
		}

		public static DenseVector CreateRandom(int length, IContinuousDistribution distribution)
		{
			return null;
		}

		public static explicit operator double[](DenseVector vector)
		{
			return null;
		}

		public static implicit operator DenseVector(double[] array)
		{
			return null;
		}

		protected override void DoAdd(double scalar, Vector<double> result)
		{
		}

		protected override void DoAdd(Vector<double> other, Vector<double> result)
		{
		}

		public static DenseVector operator +(DenseVector leftSide, DenseVector rightSide)
		{
			return null;
		}

		protected override void DoSubtract(double scalar, Vector<double> result)
		{
		}

		protected override void DoSubtract(Vector<double> other, Vector<double> result)
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

		public static DenseVector operator *(DenseVector leftSide, double rightSide)
		{
			return null;
		}

		public static DenseVector operator *(double leftSide, DenseVector rightSide)
		{
			return null;
		}

		public static double operator *(DenseVector leftSide, DenseVector rightSide)
		{
			return 0.0;
		}

		public static DenseVector operator /(DenseVector leftSide, double rightSide)
		{
			return null;
		}

		protected override void DoModulus(double divisor, Vector<double> result)
		{
		}

		protected override void DoRemainder(double divisor, Vector<double> result)
		{
		}

		public static DenseVector operator %(DenseVector leftSide, double rightSide)
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

		protected override void DoPointwiseMultiply(Vector<double> other, Vector<double> result)
		{
		}

		protected override void DoPointwiseDivide(Vector<double> divisor, Vector<double> result)
		{
		}

		protected override void DoPointwisePower(Vector<double> exponent, Vector<double> result)
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
