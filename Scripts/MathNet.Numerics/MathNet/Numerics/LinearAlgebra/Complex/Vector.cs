using System;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Complex
{
	[Serializable]
	public abstract class Vector : Vector<System.Numerics.Complex>
	{
		protected Vector(VectorStorage<System.Numerics.Complex> storage)
		{
			((Vector<>)(object)this)._002Ector((VectorStorage<T>)null);
		}

		public override void CoerceZero(double threshold)
		{
		}

		protected override void DoConjugate(Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoNegate(Vector<System.Numerics.Complex> result)
		{
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

		protected override void DoMultiply(System.Numerics.Complex scalar, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoDivide(System.Numerics.Complex divisor, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoDivideByThis(System.Numerics.Complex dividend, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseMultiply(Vector<System.Numerics.Complex> other, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseDivide(Vector<System.Numerics.Complex> divisor, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwisePower(System.Numerics.Complex exponent, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwisePower(Vector<System.Numerics.Complex> exponent, Vector<System.Numerics.Complex> result)
		{
		}

		protected sealed override void DoPointwiseModulus(Vector<System.Numerics.Complex> divisor, Vector<System.Numerics.Complex> result)
		{
		}

		protected sealed override void DoPointwiseRemainder(Vector<System.Numerics.Complex> divisor, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseExp(Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseLog(Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseAbs(Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseAcos(Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseAsin(Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseAtan(Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseAtan2(Vector<System.Numerics.Complex> other, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseAtan2(System.Numerics.Complex scalar, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseCeiling(Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseCos(Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseCosh(Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseFloor(Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseLog10(Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseRound(Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseSign(Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseSin(Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseSinh(Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseSqrt(Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseTan(Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseTanh(Vector<System.Numerics.Complex> result)
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

		protected sealed override void DoModulus(System.Numerics.Complex divisor, Vector<System.Numerics.Complex> result)
		{
		}

		protected sealed override void DoModulusByThis(System.Numerics.Complex dividend, Vector<System.Numerics.Complex> result)
		{
		}

		protected sealed override void DoRemainder(System.Numerics.Complex divisor, Vector<System.Numerics.Complex> result)
		{
		}

		protected sealed override void DoRemainderByThis(System.Numerics.Complex dividend, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseMinimum(System.Numerics.Complex scalar, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseMaximum(System.Numerics.Complex scalar, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseAbsoluteMinimum(System.Numerics.Complex scalar, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseAbsoluteMaximum(System.Numerics.Complex scalar, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseMinimum(Vector<System.Numerics.Complex> other, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseMaximum(Vector<System.Numerics.Complex> other, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseAbsoluteMinimum(Vector<System.Numerics.Complex> other, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseAbsoluteMaximum(Vector<System.Numerics.Complex> other, Vector<System.Numerics.Complex> result)
		{
		}

		public sealed override System.Numerics.Complex AbsoluteMinimum()
		{
			return default(System.Numerics.Complex);
		}

		public override int AbsoluteMinimumIndex()
		{
			return 0;
		}

		public override System.Numerics.Complex AbsoluteMaximum()
		{
			return default(System.Numerics.Complex);
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

		public override int MaximumIndex()
		{
			return 0;
		}

		public override int MinimumIndex()
		{
			return 0;
		}

		public override Vector<System.Numerics.Complex> Normalize(double p)
		{
			return null;
		}
	}
}
