using System;
using MathNet.Numerics.LinearAlgebra.Factorization;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Double
{
	[Serializable]
	public abstract class Matrix : Matrix<double>
	{
		protected Matrix(MatrixStorage<double> storage)
		{
			((Matrix<>)(object)this)._002Ector((MatrixStorage<T>)null);
		}

		public override void CoerceZero(double threshold)
		{
		}

		public sealed override Matrix<double> ConjugateTranspose()
		{
			return null;
		}

		public sealed override void ConjugateTranspose(Matrix<double> result)
		{
		}

		protected sealed override void DoConjugate(Matrix<double> result)
		{
		}

		protected override void DoNegate(Matrix<double> result)
		{
		}

		protected override void DoAdd(double scalar, Matrix<double> result)
		{
		}

		protected override void DoAdd(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoSubtract(double scalar, Matrix<double> result)
		{
		}

		protected override void DoSubtract(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoMultiply(double scalar, Matrix<double> result)
		{
		}

		protected override void DoMultiply(Vector<double> rightSide, Vector<double> result)
		{
		}

		protected override void DoDivide(double divisor, Matrix<double> result)
		{
		}

		protected override void DoDivideByThis(double dividend, Matrix<double> result)
		{
		}

		protected override void DoMultiply(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoTransposeAndMultiply(Matrix<double> other, Matrix<double> result)
		{
		}

		protected sealed override void DoConjugateTransposeAndMultiply(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Matrix<double> other, Matrix<double> result)
		{
		}

		protected sealed override void DoConjugateTransposeThisAndMultiply(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Vector<double> rightSide, Vector<double> result)
		{
		}

		protected sealed override void DoConjugateTransposeThisAndMultiply(Vector<double> rightSide, Vector<double> result)
		{
		}

		protected override void DoModulus(double divisor, Matrix<double> result)
		{
		}

		protected override void DoModulusByThis(double dividend, Matrix<double> result)
		{
		}

		protected override void DoRemainder(double divisor, Matrix<double> result)
		{
		}

		protected override void DoRemainderByThis(double dividend, Matrix<double> result)
		{
		}

		protected override void DoPointwiseMultiply(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoPointwiseDivide(Matrix<double> divisor, Matrix<double> result)
		{
		}

		protected override void DoPointwisePower(double exponent, Matrix<double> result)
		{
		}

		protected override void DoPointwisePower(Matrix<double> exponent, Matrix<double> result)
		{
		}

		protected override void DoPointwiseModulus(Matrix<double> divisor, Matrix<double> result)
		{
		}

		protected override void DoPointwiseRemainder(Matrix<double> divisor, Matrix<double> result)
		{
		}

		protected override void DoPointwiseExp(Matrix<double> result)
		{
		}

		protected override void DoPointwiseLog(Matrix<double> result)
		{
		}

		protected override void DoPointwiseAbs(Matrix<double> result)
		{
		}

		protected override void DoPointwiseAcos(Matrix<double> result)
		{
		}

		protected override void DoPointwiseAsin(Matrix<double> result)
		{
		}

		protected override void DoPointwiseAtan(Matrix<double> result)
		{
		}

		protected override void DoPointwiseAtan2(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoPointwiseCeiling(Matrix<double> result)
		{
		}

		protected override void DoPointwiseCos(Matrix<double> result)
		{
		}

		protected override void DoPointwiseCosh(Matrix<double> result)
		{
		}

		protected override void DoPointwiseFloor(Matrix<double> result)
		{
		}

		protected override void DoPointwiseLog10(Matrix<double> result)
		{
		}

		protected override void DoPointwiseRound(Matrix<double> result)
		{
		}

		protected override void DoPointwiseSign(Matrix<double> result)
		{
		}

		protected override void DoPointwiseSin(Matrix<double> result)
		{
		}

		protected override void DoPointwiseSinh(Matrix<double> result)
		{
		}

		protected override void DoPointwiseSqrt(Matrix<double> result)
		{
		}

		protected override void DoPointwiseTan(Matrix<double> result)
		{
		}

		protected override void DoPointwiseTanh(Matrix<double> result)
		{
		}

		public override Matrix<double> PseudoInverse()
		{
			return null;
		}

		public override double Trace()
		{
			return 0.0;
		}

		protected override void DoPointwiseMinimum(double scalar, Matrix<double> result)
		{
		}

		protected override void DoPointwiseMaximum(double scalar, Matrix<double> result)
		{
		}

		protected override void DoPointwiseAbsoluteMinimum(double scalar, Matrix<double> result)
		{
		}

		protected override void DoPointwiseAbsoluteMaximum(double scalar, Matrix<double> result)
		{
		}

		protected override void DoPointwiseMinimum(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoPointwiseMaximum(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoPointwiseAbsoluteMinimum(Matrix<double> other, Matrix<double> result)
		{
		}

		protected override void DoPointwiseAbsoluteMaximum(Matrix<double> other, Matrix<double> result)
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

		public sealed override Matrix<double> NormalizeRows(double norm)
		{
			return null;
		}

		public sealed override Matrix<double> NormalizeColumns(double norm)
		{
			return null;
		}

		public override Vector<double> RowSums()
		{
			return null;
		}

		public override Vector<double> RowAbsoluteSums()
		{
			return null;
		}

		public override Vector<double> ColumnSums()
		{
			return null;
		}

		public override Vector<double> ColumnAbsoluteSums()
		{
			return null;
		}

		public sealed override bool IsHermitian()
		{
			return false;
		}

		public override Cholesky<double> Cholesky()
		{
			return null;
		}

		public override LU<double> LU()
		{
			return null;
		}

		public override QR<double> QR(QRMethod method = QRMethod.Thin)
		{
			return null;
		}

		public override GramSchmidt<double> GramSchmidt()
		{
			return null;
		}

		public override Svd<double> Svd(bool computeVectors = true)
		{
			return null;
		}

		public override Evd<double> Evd(Symmetricity symmetricity = Symmetricity.Unknown)
		{
			return null;
		}
	}
}
