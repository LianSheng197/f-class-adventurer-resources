using System;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Factorization;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Complex
{
	[Serializable]
	public abstract class Matrix : Matrix<System.Numerics.Complex>
	{
		protected Matrix(MatrixStorage<System.Numerics.Complex> storage)
		{
			((Matrix<>)(object)this)._002Ector((MatrixStorage<T>)null);
		}

		public override void CoerceZero(double threshold)
		{
		}

		public sealed override Matrix<System.Numerics.Complex> ConjugateTranspose()
		{
			return null;
		}

		public sealed override void ConjugateTranspose(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoConjugate(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoNegate(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoAdd(System.Numerics.Complex scalar, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoAdd(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoSubtract(System.Numerics.Complex scalar, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoSubtract(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoMultiply(System.Numerics.Complex scalar, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoMultiply(Vector<System.Numerics.Complex> rightSide, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoMultiply(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoDivide(System.Numerics.Complex divisor, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoDivideByThis(System.Numerics.Complex dividend, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoTransposeAndMultiply(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoConjugateTransposeAndMultiply(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoConjugateTransposeThisAndMultiply(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoTransposeThisAndMultiply(Vector<System.Numerics.Complex> rightSide, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoConjugateTransposeThisAndMultiply(Vector<System.Numerics.Complex> rightSide, Vector<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseMultiply(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseDivide(Matrix<System.Numerics.Complex> divisor, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwisePower(System.Numerics.Complex exponent, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwisePower(Matrix<System.Numerics.Complex> exponent, Matrix<System.Numerics.Complex> result)
		{
		}

		protected sealed override void DoPointwiseModulus(Matrix<System.Numerics.Complex> divisor, Matrix<System.Numerics.Complex> result)
		{
		}

		protected sealed override void DoPointwiseRemainder(Matrix<System.Numerics.Complex> divisor, Matrix<System.Numerics.Complex> result)
		{
		}

		protected sealed override void DoModulus(System.Numerics.Complex divisor, Matrix<System.Numerics.Complex> result)
		{
		}

		protected sealed override void DoModulusByThis(System.Numerics.Complex dividend, Matrix<System.Numerics.Complex> result)
		{
		}

		protected sealed override void DoRemainder(System.Numerics.Complex divisor, Matrix<System.Numerics.Complex> result)
		{
		}

		protected sealed override void DoRemainderByThis(System.Numerics.Complex dividend, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseExp(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseLog(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseAbs(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseAcos(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseAsin(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseAtan(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseAtan2(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseCeiling(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseCos(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseCosh(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseFloor(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseLog10(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseRound(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseSign(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseSin(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseSinh(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseSqrt(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseTan(Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseTanh(Matrix<System.Numerics.Complex> result)
		{
		}

		public override Matrix<System.Numerics.Complex> PseudoInverse()
		{
			return null;
		}

		public override System.Numerics.Complex Trace()
		{
			return default(System.Numerics.Complex);
		}

		protected override void DoPointwiseMinimum(System.Numerics.Complex scalar, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseMaximum(System.Numerics.Complex scalar, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseAbsoluteMinimum(System.Numerics.Complex scalar, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseAbsoluteMaximum(System.Numerics.Complex scalar, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseMinimum(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseMaximum(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseAbsoluteMinimum(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
		{
		}

		protected override void DoPointwiseAbsoluteMaximum(Matrix<System.Numerics.Complex> other, Matrix<System.Numerics.Complex> result)
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

		public sealed override Matrix<System.Numerics.Complex> NormalizeRows(double norm)
		{
			return null;
		}

		public sealed override Matrix<System.Numerics.Complex> NormalizeColumns(double norm)
		{
			return null;
		}

		public override Vector<System.Numerics.Complex> RowSums()
		{
			return null;
		}

		public override Vector<System.Numerics.Complex> RowAbsoluteSums()
		{
			return null;
		}

		public override Vector<System.Numerics.Complex> ColumnSums()
		{
			return null;
		}

		public override Vector<System.Numerics.Complex> ColumnAbsoluteSums()
		{
			return null;
		}

		public override bool IsHermitian()
		{
			return false;
		}

		public override Cholesky<System.Numerics.Complex> Cholesky()
		{
			return null;
		}

		public override LU<System.Numerics.Complex> LU()
		{
			return null;
		}

		public override QR<System.Numerics.Complex> QR(QRMethod method = QRMethod.Thin)
		{
			return null;
		}

		public override GramSchmidt<System.Numerics.Complex> GramSchmidt()
		{
			return null;
		}

		public override Svd<System.Numerics.Complex> Svd(bool computeVectors = true)
		{
			return null;
		}

		public override Evd<System.Numerics.Complex> Evd(Symmetricity symmetricity = Symmetricity.Unknown)
		{
			return null;
		}
	}
}
