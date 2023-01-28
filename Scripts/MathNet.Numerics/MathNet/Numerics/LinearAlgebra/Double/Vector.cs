using System;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Double
{
	[Serializable]
	public abstract class Vector : Vector<double>
	{
		protected Vector(VectorStorage<double> storage)
		{
			((Vector<>)(object)this)._002Ector((VectorStorage<T>)null);
		}

		public override void CoerceZero(double threshold)
		{
		}

		protected sealed override void DoConjugate(Vector<double> result)
		{
		}

		protected override void DoNegate(Vector<double> result)
		{
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

		protected override void DoMultiply(double scalar, Vector<double> result)
		{
		}

		protected override void DoDivide(double divisor, Vector<double> result)
		{
		}

		protected override void DoDivideByThis(double dividend, Vector<double> result)
		{
		}

		protected override void DoPointwiseMultiply(Vector<double> other, Vector<double> result)
		{
		}

		protected override void DoPointwiseDivide(Vector<double> divisor, Vector<double> result)
		{
		}

		protected override void DoPointwisePower(double exponent, Vector<double> result)
		{
		}

		protected override void DoPointwisePower(Vector<double> exponent, Vector<double> result)
		{
		}

		protected override void DoPointwiseModulus(Vector<double> divisor, Vector<double> result)
		{
		}

		protected override void DoPointwiseRemainder(Vector<double> divisor, Vector<double> result)
		{
		}

		protected override void DoPointwiseExp(Vector<double> result)
		{
		}

		protected override void DoPointwiseLog(Vector<double> result)
		{
		}

		protected override void DoPointwiseAbs(Vector<double> result)
		{
		}

		protected override void DoPointwiseAcos(Vector<double> result)
		{
		}

		protected override void DoPointwiseAsin(Vector<double> result)
		{
		}

		protected override void DoPointwiseAtan(Vector<double> result)
		{
		}

		protected override void DoPointwiseAtan2(Vector<double> other, Vector<double> result)
		{
		}

		protected override void DoPointwiseAtan2(double scalar, Vector<double> result)
		{
		}

		protected override void DoPointwiseCeiling(Vector<double> result)
		{
		}

		protected override void DoPointwiseCos(Vector<double> result)
		{
		}

		protected override void DoPointwiseCosh(Vector<double> result)
		{
		}

		protected override void DoPointwiseFloor(Vector<double> result)
		{
		}

		protected override void DoPointwiseLog10(Vector<double> result)
		{
		}

		protected override void DoPointwiseRound(Vector<double> result)
		{
		}

		protected override void DoPointwiseSign(Vector<double> result)
		{
		}

		protected override void DoPointwiseSin(Vector<double> result)
		{
		}

		protected override void DoPointwiseSinh(Vector<double> result)
		{
		}

		protected override void DoPointwiseSqrt(Vector<double> result)
		{
		}

		protected override void DoPointwiseTan(Vector<double> result)
		{
		}

		protected override void DoPointwiseTanh(Vector<double> result)
		{
		}

		protected override double DoDotProduct(Vector<double> other)
		{
			return 0.0;
		}

		protected sealed override double DoConjugateDotProduct(Vector<double> other)
		{
			return 0.0;
		}

		protected override void DoModulus(double divisor, Vector<double> result)
		{
		}

		protected override void DoModulusByThis(double dividend, Vector<double> result)
		{
		}

		protected override void DoRemainder(double divisor, Vector<double> result)
		{
		}

		protected override void DoRemainderByThis(double dividend, Vector<double> result)
		{
		}

		protected override void DoPointwiseMinimum(double scalar, Vector<double> result)
		{
		}

		protected override void DoPointwiseMaximum(double scalar, Vector<double> result)
		{
		}

		protected override void DoPointwiseAbsoluteMinimum(double scalar, Vector<double> result)
		{
		}

		protected override void DoPointwiseAbsoluteMaximum(double scalar, Vector<double> result)
		{
		}

		protected override void DoPointwiseMinimum(Vector<double> other, Vector<double> result)
		{
		}

		protected override void DoPointwiseMaximum(Vector<double> other, Vector<double> result)
		{
		}

		protected override void DoPointwiseAbsoluteMinimum(Vector<double> other, Vector<double> result)
		{
		}

		protected override void DoPointwiseAbsoluteMaximum(Vector<double> other, Vector<double> result)
		{
		}

		public override double AbsoluteMinimum()
		{
			return 0.0;
		}

		public override int AbsoluteMinimumIndex()
		{
			return 0;
		}

		public override double AbsoluteMaximum()
		{
			return 0.0;
		}

		public override int AbsoluteMaximumIndex()
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

		public override int MaximumIndex()
		{
			return 0;
		}

		public override int MinimumIndex()
		{
			return 0;
		}

		public override Vector<double> Normalize(double p)
		{
			return null;
		}
	}
}
