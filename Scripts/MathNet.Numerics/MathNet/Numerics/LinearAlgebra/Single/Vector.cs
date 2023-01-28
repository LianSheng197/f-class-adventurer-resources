using System;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Single
{
	[Serializable]
	public abstract class Vector : Vector<float>
	{
		protected Vector(VectorStorage<float> storage)
		{
			((Vector<>)(object)this)._002Ector((VectorStorage<T>)null);
		}

		public override void CoerceZero(double threshold)
		{
		}

		protected sealed override void DoConjugate(Vector<float> result)
		{
		}

		protected override void DoNegate(Vector<float> result)
		{
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

		protected override void DoMultiply(float scalar, Vector<float> result)
		{
		}

		protected override void DoDivide(float divisor, Vector<float> result)
		{
		}

		protected override void DoDivideByThis(float dividend, Vector<float> result)
		{
		}

		protected override void DoPointwiseMultiply(Vector<float> other, Vector<float> result)
		{
		}

		protected override void DoPointwiseDivide(Vector<float> divisor, Vector<float> result)
		{
		}

		protected override void DoPointwisePower(float exponent, Vector<float> result)
		{
		}

		protected override void DoPointwisePower(Vector<float> exponent, Vector<float> result)
		{
		}

		protected override void DoPointwiseModulus(Vector<float> divisor, Vector<float> result)
		{
		}

		protected override void DoPointwiseRemainder(Vector<float> divisor, Vector<float> result)
		{
		}

		protected override void DoPointwiseExp(Vector<float> result)
		{
		}

		protected override void DoPointwiseLog(Vector<float> result)
		{
		}

		protected override void DoPointwiseAbs(Vector<float> result)
		{
		}

		protected override void DoPointwiseAcos(Vector<float> result)
		{
		}

		protected override void DoPointwiseAsin(Vector<float> result)
		{
		}

		protected override void DoPointwiseAtan(Vector<float> result)
		{
		}

		protected override void DoPointwiseAtan2(Vector<float> other, Vector<float> result)
		{
		}

		protected override void DoPointwiseAtan2(float scalar, Vector<float> result)
		{
		}

		protected override void DoPointwiseCeiling(Vector<float> result)
		{
		}

		protected override void DoPointwiseCos(Vector<float> result)
		{
		}

		protected override void DoPointwiseCosh(Vector<float> result)
		{
		}

		protected override void DoPointwiseFloor(Vector<float> result)
		{
		}

		protected override void DoPointwiseLog10(Vector<float> result)
		{
		}

		protected override void DoPointwiseRound(Vector<float> result)
		{
		}

		protected override void DoPointwiseSign(Vector<float> result)
		{
		}

		protected override void DoPointwiseSin(Vector<float> result)
		{
		}

		protected override void DoPointwiseSinh(Vector<float> result)
		{
		}

		protected override void DoPointwiseSqrt(Vector<float> result)
		{
		}

		protected override void DoPointwiseTan(Vector<float> result)
		{
		}

		protected override void DoPointwiseTanh(Vector<float> result)
		{
		}

		protected override float DoDotProduct(Vector<float> other)
		{
			return 0f;
		}

		protected sealed override float DoConjugateDotProduct(Vector<float> other)
		{
			return 0f;
		}

		protected override void DoModulus(float divisor, Vector<float> result)
		{
		}

		protected override void DoModulusByThis(float dividend, Vector<float> result)
		{
		}

		protected override void DoRemainder(float divisor, Vector<float> result)
		{
		}

		protected override void DoRemainderByThis(float dividend, Vector<float> result)
		{
		}

		protected override void DoPointwiseMinimum(float scalar, Vector<float> result)
		{
		}

		protected override void DoPointwiseMaximum(float scalar, Vector<float> result)
		{
		}

		protected override void DoPointwiseAbsoluteMinimum(float scalar, Vector<float> result)
		{
		}

		protected override void DoPointwiseAbsoluteMaximum(float scalar, Vector<float> result)
		{
		}

		protected override void DoPointwiseMinimum(Vector<float> other, Vector<float> result)
		{
		}

		protected override void DoPointwiseMaximum(Vector<float> other, Vector<float> result)
		{
		}

		protected override void DoPointwiseAbsoluteMinimum(Vector<float> other, Vector<float> result)
		{
		}

		protected override void DoPointwiseAbsoluteMaximum(Vector<float> other, Vector<float> result)
		{
		}

		public override float AbsoluteMinimum()
		{
			return 0f;
		}

		public override int AbsoluteMinimumIndex()
		{
			return 0;
		}

		public override float AbsoluteMaximum()
		{
			return 0f;
		}

		public override int AbsoluteMaximumIndex()
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

		public override int MaximumIndex()
		{
			return 0;
		}

		public override int MinimumIndex()
		{
			return 0;
		}

		public override Vector<float> Normalize(double p)
		{
			return null;
		}
	}
}
