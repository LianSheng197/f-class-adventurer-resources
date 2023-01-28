using System;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Complex32
{
	[Serializable]
	public abstract class Vector : Vector<MathNet.Numerics.Complex32>
	{
		protected Vector(VectorStorage<MathNet.Numerics.Complex32> storage)
		{
			((Vector<>)(object)this)._002Ector((VectorStorage<T>)null);
		}

		public override void CoerceZero(double threshold)
		{
		}

		protected override void DoConjugate(Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoNegate(Vector<MathNet.Numerics.Complex32> result)
		{
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

		protected override void DoMultiply(MathNet.Numerics.Complex32 scalar, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoDivide(MathNet.Numerics.Complex32 divisor, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoDivideByThis(MathNet.Numerics.Complex32 dividend, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseMultiply(Vector<MathNet.Numerics.Complex32> other, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseDivide(Vector<MathNet.Numerics.Complex32> divisor, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwisePower(MathNet.Numerics.Complex32 exponent, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwisePower(Vector<MathNet.Numerics.Complex32> exponent, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected sealed override void DoPointwiseModulus(Vector<MathNet.Numerics.Complex32> divisor, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected sealed override void DoPointwiseRemainder(Vector<MathNet.Numerics.Complex32> divisor, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseExp(Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseLog(Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseAbs(Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseAcos(Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseAsin(Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseAtan(Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseAtan2(Vector<MathNet.Numerics.Complex32> other, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseAtan2(MathNet.Numerics.Complex32 scalar, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseCeiling(Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseCos(Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseCosh(Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseFloor(Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseLog10(Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseRound(Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseSign(Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseSin(Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseSinh(Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseSqrt(Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseTan(Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseTanh(Vector<MathNet.Numerics.Complex32> result)
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

		protected sealed override void DoModulus(MathNet.Numerics.Complex32 divisor, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected sealed override void DoModulusByThis(MathNet.Numerics.Complex32 dividend, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected sealed override void DoRemainder(MathNet.Numerics.Complex32 divisor, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected sealed override void DoRemainderByThis(MathNet.Numerics.Complex32 dividend, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseMinimum(MathNet.Numerics.Complex32 scalar, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseMaximum(MathNet.Numerics.Complex32 scalar, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseAbsoluteMinimum(MathNet.Numerics.Complex32 scalar, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseAbsoluteMaximum(MathNet.Numerics.Complex32 scalar, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseMinimum(Vector<MathNet.Numerics.Complex32> other, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseMaximum(Vector<MathNet.Numerics.Complex32> other, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseAbsoluteMinimum(Vector<MathNet.Numerics.Complex32> other, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseAbsoluteMaximum(Vector<MathNet.Numerics.Complex32> other, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		public sealed override MathNet.Numerics.Complex32 AbsoluteMinimum()
		{
			return default(MathNet.Numerics.Complex32);
		}

		public override int AbsoluteMinimumIndex()
		{
			return 0;
		}

		public override MathNet.Numerics.Complex32 AbsoluteMaximum()
		{
			return default(MathNet.Numerics.Complex32);
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

		public override int MaximumIndex()
		{
			return 0;
		}

		public override int MinimumIndex()
		{
			return 0;
		}

		public override Vector<MathNet.Numerics.Complex32> Normalize(double p)
		{
			return null;
		}
	}
}
