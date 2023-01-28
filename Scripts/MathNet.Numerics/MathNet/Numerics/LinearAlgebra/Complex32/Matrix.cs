using System;
using MathNet.Numerics.LinearAlgebra.Factorization;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Complex32
{
	[Serializable]
	public abstract class Matrix : Matrix<MathNet.Numerics.Complex32>
	{
		protected Matrix(MatrixStorage<MathNet.Numerics.Complex32> storage)
		{
			((Matrix<>)(object)this)._002Ector((MatrixStorage<T>)null);
		}

		public override void CoerceZero(double threshold)
		{
		}

		public sealed override Matrix<MathNet.Numerics.Complex32> ConjugateTranspose()
		{
			return null;
		}

		public sealed override void ConjugateTranspose(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoConjugate(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoNegate(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoAdd(MathNet.Numerics.Complex32 scalar, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoAdd(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoSubtract(MathNet.Numerics.Complex32 scalar, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoSubtract(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoMultiply(MathNet.Numerics.Complex32 scalar, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoMultiply(Vector<MathNet.Numerics.Complex32> rightSide, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoDivide(MathNet.Numerics.Complex32 divisor, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoDivideByThis(MathNet.Numerics.Complex32 dividend, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoMultiply(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoTransposeAndMultiply(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoConjugateTransposeAndMultiply(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoConjugateTransposeThisAndMultiply(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Vector<MathNet.Numerics.Complex32> rightSide, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoConjugateTransposeThisAndMultiply(Vector<MathNet.Numerics.Complex32> rightSide, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseMultiply(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseDivide(Matrix<MathNet.Numerics.Complex32> divisor, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwisePower(MathNet.Numerics.Complex32 exponent, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwisePower(Matrix<MathNet.Numerics.Complex32> exponent, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected sealed override void DoPointwiseModulus(Matrix<MathNet.Numerics.Complex32> divisor, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected sealed override void DoPointwiseRemainder(Matrix<MathNet.Numerics.Complex32> divisor, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected sealed override void DoModulus(MathNet.Numerics.Complex32 divisor, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected sealed override void DoModulusByThis(MathNet.Numerics.Complex32 dividend, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected sealed override void DoRemainder(MathNet.Numerics.Complex32 divisor, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected sealed override void DoRemainderByThis(MathNet.Numerics.Complex32 dividend, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseExp(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseLog(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseAbs(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseAcos(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseAsin(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseAtan(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseAtan2(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseCeiling(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseCos(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseCosh(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseFloor(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseLog10(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseRound(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseSign(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseSin(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseSinh(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseSqrt(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseTan(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseTanh(Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override Matrix<MathNet.Numerics.Complex32> PseudoInverse()
		{
			return null;
		}

		public override MathNet.Numerics.Complex32 Trace()
		{
			return default(MathNet.Numerics.Complex32);
		}

		protected override void DoPointwiseMinimum(MathNet.Numerics.Complex32 scalar, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseMaximum(MathNet.Numerics.Complex32 scalar, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseAbsoluteMinimum(MathNet.Numerics.Complex32 scalar, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseAbsoluteMaximum(MathNet.Numerics.Complex32 scalar, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseMinimum(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseMaximum(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseAbsoluteMinimum(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		protected override void DoPointwiseAbsoluteMaximum(Matrix<MathNet.Numerics.Complex32> other, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override double L1Norm()
		{
			return 0.0;
		}

		public override double InfinityNorm()
		{
			return 0.0;
		}

		public override double FrobeniusNorm()
		{
			return 0.0;
		}

		public override Vector<double> RowNorms(double norm)
		{
			return null;
		}

		public override Vector<double> ColumnNorms(double norm)
		{
			return null;
		}

		public sealed override Matrix<MathNet.Numerics.Complex32> NormalizeRows(double norm)
		{
			return null;
		}

		public sealed override Matrix<MathNet.Numerics.Complex32> NormalizeColumns(double norm)
		{
			return null;
		}

		public override Vector<MathNet.Numerics.Complex32> RowSums()
		{
			return null;
		}

		public override Vector<MathNet.Numerics.Complex32> RowAbsoluteSums()
		{
			return null;
		}

		public override Vector<MathNet.Numerics.Complex32> ColumnSums()
		{
			return null;
		}

		public override Vector<MathNet.Numerics.Complex32> ColumnAbsoluteSums()
		{
			return null;
		}

		public override bool IsHermitian()
		{
			return false;
		}

		public override Cholesky<MathNet.Numerics.Complex32> Cholesky()
		{
			return null;
		}

		public override LU<MathNet.Numerics.Complex32> LU()
		{
			return null;
		}

		public override QR<MathNet.Numerics.Complex32> QR(QRMethod method = QRMethod.Thin)
		{
			return null;
		}

		public override GramSchmidt<MathNet.Numerics.Complex32> GramSchmidt()
		{
			return null;
		}

		public override Svd<MathNet.Numerics.Complex32> Svd(bool computeVectors = true)
		{
			return null;
		}

		public override Evd<MathNet.Numerics.Complex32> Evd(Symmetricity symmetricity = Symmetricity.Unknown)
		{
			return null;
		}
	}
}
