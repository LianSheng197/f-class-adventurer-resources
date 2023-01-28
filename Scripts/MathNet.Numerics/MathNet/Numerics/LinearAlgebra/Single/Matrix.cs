using System;
using MathNet.Numerics.LinearAlgebra.Factorization;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Single
{
	[Serializable]
	public abstract class Matrix : Matrix<float>
	{
		protected Matrix(MatrixStorage<float> storage)
		{
			((Matrix<>)(object)this)._002Ector((MatrixStorage<T>)null);
		}

		public override void CoerceZero(double threshold)
		{
		}

		public sealed override Matrix<float> ConjugateTranspose()
		{
			return null;
		}

		public sealed override void ConjugateTranspose(Matrix<float> result)
		{
		}

		protected sealed override void DoConjugate(Matrix<float> result)
		{
		}

		protected override void DoNegate(Matrix<float> result)
		{
		}

		protected override void DoAdd(float scalar, Matrix<float> result)
		{
		}

		protected override void DoAdd(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoSubtract(float scalar, Matrix<float> result)
		{
		}

		protected override void DoSubtract(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoMultiply(float scalar, Matrix<float> result)
		{
		}

		protected override void DoMultiply(Vector<float> rightSide, Vector<float> result)
		{
		}

		protected override void DoMultiply(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoDivide(float divisor, Matrix<float> result)
		{
		}

		protected override void DoDivideByThis(float dividend, Matrix<float> result)
		{
		}

		protected override void DoTransposeAndMultiply(Matrix<float> other, Matrix<float> result)
		{
		}

		protected sealed override void DoConjugateTransposeAndMultiply(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Matrix<float> other, Matrix<float> result)
		{
		}

		protected sealed override void DoConjugateTransposeThisAndMultiply(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Vector<float> rightSide, Vector<float> result)
		{
		}

		protected sealed override void DoConjugateTransposeThisAndMultiply(Vector<float> rightSide, Vector<float> result)
		{
		}

		protected override void DoModulus(float divisor, Matrix<float> result)
		{
		}

		protected override void DoModulusByThis(float dividend, Matrix<float> result)
		{
		}

		protected override void DoRemainder(float divisor, Matrix<float> result)
		{
		}

		protected override void DoRemainderByThis(float dividend, Matrix<float> result)
		{
		}

		protected override void DoPointwiseMultiply(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoPointwiseDivide(Matrix<float> divisor, Matrix<float> result)
		{
		}

		protected override void DoPointwisePower(float exponent, Matrix<float> result)
		{
		}

		protected override void DoPointwisePower(Matrix<float> exponent, Matrix<float> result)
		{
		}

		protected override void DoPointwiseModulus(Matrix<float> divisor, Matrix<float> result)
		{
		}

		protected override void DoPointwiseRemainder(Matrix<float> divisor, Matrix<float> result)
		{
		}

		protected override void DoPointwiseExp(Matrix<float> result)
		{
		}

		protected override void DoPointwiseLog(Matrix<float> result)
		{
		}

		protected override void DoPointwiseAbs(Matrix<float> result)
		{
		}

		protected override void DoPointwiseAcos(Matrix<float> result)
		{
		}

		protected override void DoPointwiseAsin(Matrix<float> result)
		{
		}

		protected override void DoPointwiseAtan(Matrix<float> result)
		{
		}

		protected override void DoPointwiseAtan2(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoPointwiseCeiling(Matrix<float> result)
		{
		}

		protected override void DoPointwiseCos(Matrix<float> result)
		{
		}

		protected override void DoPointwiseCosh(Matrix<float> result)
		{
		}

		protected override void DoPointwiseFloor(Matrix<float> result)
		{
		}

		protected override void DoPointwiseLog10(Matrix<float> result)
		{
		}

		protected override void DoPointwiseRound(Matrix<float> result)
		{
		}

		protected override void DoPointwiseSign(Matrix<float> result)
		{
		}

		protected override void DoPointwiseSin(Matrix<float> result)
		{
		}

		protected override void DoPointwiseSinh(Matrix<float> result)
		{
		}

		protected override void DoPointwiseSqrt(Matrix<float> result)
		{
		}

		protected override void DoPointwiseTan(Matrix<float> result)
		{
		}

		protected override void DoPointwiseTanh(Matrix<float> result)
		{
		}

		public override Matrix<float> PseudoInverse()
		{
			return null;
		}

		public override float Trace()
		{
			return 0f;
		}

		protected override void DoPointwiseMinimum(float scalar, Matrix<float> result)
		{
		}

		protected override void DoPointwiseMaximum(float scalar, Matrix<float> result)
		{
		}

		protected override void DoPointwiseAbsoluteMinimum(float scalar, Matrix<float> result)
		{
		}

		protected override void DoPointwiseAbsoluteMaximum(float scalar, Matrix<float> result)
		{
		}

		protected override void DoPointwiseMinimum(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoPointwiseMaximum(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoPointwiseAbsoluteMinimum(Matrix<float> other, Matrix<float> result)
		{
		}

		protected override void DoPointwiseAbsoluteMaximum(Matrix<float> other, Matrix<float> result)
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

		public sealed override Matrix<float> NormalizeRows(double norm)
		{
			return null;
		}

		public sealed override Matrix<float> NormalizeColumns(double norm)
		{
			return null;
		}

		public override Vector<float> RowSums()
		{
			return null;
		}

		public override Vector<float> RowAbsoluteSums()
		{
			return null;
		}

		public override Vector<float> ColumnSums()
		{
			return null;
		}

		public override Vector<float> ColumnAbsoluteSums()
		{
			return null;
		}

		public sealed override bool IsHermitian()
		{
			return false;
		}

		public override Cholesky<float> Cholesky()
		{
			return null;
		}

		public override LU<float> LU()
		{
			return null;
		}

		public override QR<float> QR(QRMethod method = QRMethod.Thin)
		{
			return null;
		}

		public override GramSchmidt<float> GramSchmidt()
		{
			return null;
		}

		public override Svd<float> Svd(bool computeVectors = true)
		{
			return null;
		}

		public override Evd<float> Evd(Symmetricity symmetricity = Symmetricity.Unknown)
		{
			return null;
		}
	}
}
