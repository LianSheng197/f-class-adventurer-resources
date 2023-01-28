using System.Numerics;
using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.Providers.LinearAlgebra
{
	public sealed class ManagedLinearAlgebraProvider : ILinearAlgebraProvider, ILinearAlgebraProvider<double>, ILinearAlgebraProvider<float>, ILinearAlgebraProvider<Complex>, ILinearAlgebraProvider<Complex32>
	{
		public static ManagedLinearAlgebraProvider Instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public void AddVectorToScaledVector(Complex[] y, Complex alpha, Complex[] x, Complex[] result)
		{
		}

		public void ScaleArray(Complex alpha, Complex[] x, Complex[] result)
		{
		}

		public void ConjugateArray(Complex[] x, Complex[] result)
		{
		}

		public Complex DotProduct(Complex[] x, Complex[] y)
		{
			return default(Complex);
		}

		public void AddArrays(Complex[] x, Complex[] y, Complex[] result)
		{
		}

		public void SubtractArrays(Complex[] x, Complex[] y, Complex[] result)
		{
		}

		public void PointWiseMultiplyArrays(Complex[] x, Complex[] y, Complex[] result)
		{
		}

		public void PointWiseDivideArrays(Complex[] x, Complex[] y, Complex[] result)
		{
		}

		public void PointWisePowerArrays(Complex[] x, Complex[] y, Complex[] result)
		{
		}

		public double MatrixNorm(Norm norm, int rows, int columns, Complex[] matrix)
		{
			return 0.0;
		}

		public void MatrixMultiply(Complex[] x, int rowsX, int columnsX, Complex[] y, int rowsY, int columnsY, Complex[] result)
		{
		}

		public void MatrixMultiplyWithUpdate(Transpose transposeA, Transpose transposeB, Complex alpha, Complex[] a, int rowsA, int columnsA, Complex[] b, int rowsB, int columnsB, Complex beta, Complex[] c)
		{
		}

		public void LUFactor(Complex[] data, int order, int[] ipiv)
		{
		}

		public void LUInverse(Complex[] a, int order)
		{
		}

		public void LUInverseFactored(Complex[] a, int order, int[] ipiv)
		{
		}

		public void LUSolve(int columnsOfB, Complex[] a, int order, Complex[] b)
		{
		}

		public void LUSolveFactored(int columnsOfB, Complex[] a, int order, int[] ipiv, Complex[] b)
		{
		}

		public void CholeskyFactor(Complex[] a, int order)
		{
		}

		private static void DoCholeskyStep(Complex[] data, int rowDim, int firstCol, int colLimit, Complex[] multipliers, int availableCores)
		{
		}

		public void CholeskySolve(Complex[] a, int orderA, Complex[] b, int columnsB)
		{
		}

		public void CholeskySolveFactored(Complex[] a, int orderA, Complex[] b, int columnsB)
		{
		}

		private static void DoCholeskySolve(Complex[] a, int orderA, Complex[] b, int index)
		{
		}

		public void QRFactor(Complex[] r, int rowsR, int columnsR, Complex[] q, Complex[] tau)
		{
		}

		public void ThinQRFactor(Complex[] a, int rowsA, int columnsA, Complex[] r, Complex[] tau)
		{
		}

		private static void ComputeQR(Complex[] work, int workIndex, Complex[] a, int rowStart, int rowCount, int columnStart, int columnCount, int availableCores)
		{
		}

		private static void GenerateColumn(Complex[] work, Complex[] a, int rowCount, int row, int column)
		{
		}

		public void QRSolve(Complex[] a, int rows, int columns, Complex[] b, int columnsB, Complex[] x, QRMethod method = QRMethod.Full)
		{
		}

		public void QRSolveFactored(Complex[] q, Complex[] r, int rowsA, int columnsA, Complex[] tau, Complex[] b, int columnsB, Complex[] x, QRMethod method = QRMethod.Full)
		{
		}

		public void SingularValueDecomposition(bool computeVectors, Complex[] a, int rowsA, int columnsA, Complex[] s, Complex[] u, Complex[] vt)
		{
		}

		public void SvdSolve(Complex[] a, int rowsA, int columnsA, Complex[] b, int columnsB, Complex[] x)
		{
		}

		public void SvdSolveFactored(int rowsA, int columnsA, Complex[] s, Complex[] u, Complex[] vt, Complex[] b, int columnsB, Complex[] x)
		{
		}

		public void EigenDecomp(bool isSymmetric, int order, Complex[] matrix, Complex[] matrixEv, Complex[] vectorEv, Complex[] matrixD)
		{
		}

		internal static void SymmetricTridiagonalize(Complex[] matrixA, double[] d, double[] e, Complex[] tau, int order)
		{
		}

		internal static void SymmetricDiagonalize(Complex[] dataEv, double[] d, double[] e, int order)
		{
		}

		internal static void SymmetricUntridiagonalize(Complex[] dataEv, Complex[] matrixA, Complex[] tau, int order)
		{
		}

		internal static void NonsymmetricReduceToHessenberg(Complex[] dataEv, Complex[] matrixH, int order)
		{
		}

		internal static void NonsymmetricReduceHessenberToRealSchur(Complex[] vectorV, Complex[] dataEv, Complex[] matrixH, int order)
		{
		}

		private static void GetRow(Transpose transpose, int rowindx, int numRows, int numCols, Complex[] matrix, Complex[] row)
		{
		}

		private static void GetColumn(Transpose transpose, int colindx, int numRows, int numCols, Complex[] matrix, Complex[] column)
		{
		}

		public void AddVectorToScaledVector(Complex32[] y, Complex32 alpha, Complex32[] x, Complex32[] result)
		{
		}

		public void ScaleArray(Complex32 alpha, Complex32[] x, Complex32[] result)
		{
		}

		public void ConjugateArray(Complex32[] x, Complex32[] result)
		{
		}

		public Complex32 DotProduct(Complex32[] x, Complex32[] y)
		{
			return default(Complex32);
		}

		public void AddArrays(Complex32[] x, Complex32[] y, Complex32[] result)
		{
		}

		public void SubtractArrays(Complex32[] x, Complex32[] y, Complex32[] result)
		{
		}

		public void PointWiseMultiplyArrays(Complex32[] x, Complex32[] y, Complex32[] result)
		{
		}

		public void PointWiseDivideArrays(Complex32[] x, Complex32[] y, Complex32[] result)
		{
		}

		public void PointWisePowerArrays(Complex32[] x, Complex32[] y, Complex32[] result)
		{
		}

		public double MatrixNorm(Norm norm, int rows, int columns, Complex32[] matrix)
		{
			return 0.0;
		}

		public void MatrixMultiply(Complex32[] x, int rowsX, int columnsX, Complex32[] y, int rowsY, int columnsY, Complex32[] result)
		{
		}

		public void MatrixMultiplyWithUpdate(Transpose transposeA, Transpose transposeB, Complex32 alpha, Complex32[] a, int rowsA, int columnsA, Complex32[] b, int rowsB, int columnsB, Complex32 beta, Complex32[] c)
		{
		}

		public void LUFactor(Complex32[] data, int order, int[] ipiv)
		{
		}

		public void LUInverse(Complex32[] a, int order)
		{
		}

		public void LUInverseFactored(Complex32[] a, int order, int[] ipiv)
		{
		}

		public void LUSolve(int columnsOfB, Complex32[] a, int order, Complex32[] b)
		{
		}

		public void LUSolveFactored(int columnsOfB, Complex32[] a, int order, int[] ipiv, Complex32[] b)
		{
		}

		public void CholeskyFactor(Complex32[] a, int order)
		{
		}

		private static void DoCholeskyStep(Complex32[] data, int rowDim, int firstCol, int colLimit, Complex32[] multipliers, int availableCores)
		{
		}

		public void CholeskySolve(Complex32[] a, int orderA, Complex32[] b, int columnsB)
		{
		}

		public void CholeskySolveFactored(Complex32[] a, int orderA, Complex32[] b, int columnsB)
		{
		}

		private static void DoCholeskySolve(Complex32[] a, int orderA, Complex32[] b, int index)
		{
		}

		public void QRFactor(Complex32[] r, int rowsR, int columnsR, Complex32[] q, Complex32[] tau)
		{
		}

		public void ThinQRFactor(Complex32[] a, int rowsA, int columnsA, Complex32[] r, Complex32[] tau)
		{
		}

		private static void ComputeQR(Complex32[] work, int workIndex, Complex32[] a, int rowStart, int rowCount, int columnStart, int columnCount, int availableCores)
		{
		}

		private static void GenerateColumn(Complex32[] work, Complex32[] a, int rowCount, int row, int column)
		{
		}

		public void QRSolve(Complex32[] a, int rows, int columns, Complex32[] b, int columnsB, Complex32[] x, QRMethod method = QRMethod.Full)
		{
		}

		public void QRSolveFactored(Complex32[] q, Complex32[] r, int rowsA, int columnsA, Complex32[] tau, Complex32[] b, int columnsB, Complex32[] x, QRMethod method = QRMethod.Full)
		{
		}

		public void SingularValueDecomposition(bool computeVectors, Complex32[] a, int rowsA, int columnsA, Complex32[] s, Complex32[] u, Complex32[] vt)
		{
		}

		public void SvdSolve(Complex32[] a, int rowsA, int columnsA, Complex32[] b, int columnsB, Complex32[] x)
		{
		}

		public void SvdSolveFactored(int rowsA, int columnsA, Complex32[] s, Complex32[] u, Complex32[] vt, Complex32[] b, int columnsB, Complex32[] x)
		{
		}

		public void EigenDecomp(bool isSymmetric, int order, Complex32[] matrix, Complex32[] matrixEv, Complex[] vectorEv, Complex32[] matrixD)
		{
		}

		internal static void SymmetricTridiagonalize(Complex32[] matrixA, float[] d, float[] e, Complex32[] tau, int order)
		{
		}

		internal static void SymmetricDiagonalize(Complex32[] dataEv, float[] d, float[] e, int order)
		{
		}

		internal static void SymmetricUntridiagonalize(Complex32[] dataEv, Complex32[] matrixA, Complex32[] tau, int order)
		{
		}

		internal static void NonsymmetricReduceToHessenberg(Complex32[] dataEv, Complex32[] matrixH, int order)
		{
		}

		internal static void NonsymmetricReduceHessenberToRealSchur(Complex32[] vectorV, Complex32[] dataEv, Complex32[] matrixH, int order)
		{
		}

		private static void GetRow(Transpose transpose, int rowindx, int numRows, int numCols, Complex32[] matrix, Complex32[] row)
		{
		}

		private static void GetColumn(Transpose transpose, int colindx, int numRows, int numCols, Complex32[] matrix, Complex32[] column)
		{
		}

		public bool IsAvailable()
		{
			return false;
		}

		public void InitializeVerify()
		{
		}

		public void FreeResources()
		{
		}

		public override string ToString()
		{
			return null;
		}

		private static void GetRow<T>(Transpose transpose, int rowindx, int numRows, int numCols, T[] matrix, T[] row)
		{
		}

		private static void GetColumn<T>(Transpose transpose, int colindx, int numRows, int numCols, T[] matrix, T[] column)
		{
		}

		public void AddVectorToScaledVector(double[] y, double alpha, double[] x, double[] result)
		{
		}

		public void ScaleArray(double alpha, double[] x, double[] result)
		{
		}

		public void ConjugateArray(double[] x, double[] result)
		{
		}

		public double DotProduct(double[] x, double[] y)
		{
			return 0.0;
		}

		public void AddArrays(double[] x, double[] y, double[] result)
		{
		}

		public void SubtractArrays(double[] x, double[] y, double[] result)
		{
		}

		public void PointWiseMultiplyArrays(double[] x, double[] y, double[] result)
		{
		}

		public void PointWiseDivideArrays(double[] x, double[] y, double[] result)
		{
		}

		public void PointWisePowerArrays(double[] x, double[] y, double[] result)
		{
		}

		public double MatrixNorm(Norm norm, int rows, int columns, double[] matrix)
		{
			return 0.0;
		}

		public void MatrixMultiply(double[] x, int rowsX, int columnsX, double[] y, int rowsY, int columnsY, double[] result)
		{
		}

		public void MatrixMultiplyWithUpdate(Transpose transposeA, Transpose transposeB, double alpha, double[] a, int rowsA, int columnsA, double[] b, int rowsB, int columnsB, double beta, double[] c)
		{
		}

		public void LUFactor(double[] data, int order, int[] ipiv)
		{
		}

		public void LUInverse(double[] a, int order)
		{
		}

		public void LUInverseFactored(double[] a, int order, int[] ipiv)
		{
		}

		public void LUSolve(int columnsOfB, double[] a, int order, double[] b)
		{
		}

		public void LUSolveFactored(int columnsOfB, double[] a, int order, int[] ipiv, double[] b)
		{
		}

		public void CholeskyFactor(double[] a, int order)
		{
		}

		private static void DoCholeskyStep(double[] data, int rowDim, int firstCol, int colLimit, double[] multipliers, int availableCores)
		{
		}

		public void CholeskySolve(double[] a, int orderA, double[] b, int columnsB)
		{
		}

		public void CholeskySolveFactored(double[] a, int orderA, double[] b, int columnsB)
		{
		}

		private static void DoCholeskySolve(double[] a, int orderA, double[] b, int index)
		{
		}

		public void QRFactor(double[] r, int rowsR, int columnsR, double[] q, double[] tau)
		{
		}

		public void ThinQRFactor(double[] a, int rowsA, int columnsA, double[] r, double[] tau)
		{
		}

		private static void ComputeQR(double[] work, int workIndex, double[] a, int rowStart, int rowCount, int columnStart, int columnCount, int availableCores)
		{
		}

		private static void GenerateColumn(double[] work, double[] a, int rowCount, int row, int column)
		{
		}

		public void QRSolve(double[] a, int rows, int columns, double[] b, int columnsB, double[] x, QRMethod method = QRMethod.Full)
		{
		}

		public void QRSolveFactored(double[] q, double[] r, int rowsA, int columnsA, double[] tau, double[] b, int columnsB, double[] x, QRMethod method = QRMethod.Full)
		{
		}

		public void SingularValueDecomposition(bool computeVectors, double[] a, int rowsA, int columnsA, double[] s, double[] u, double[] vt)
		{
		}

		private static void Drotg(ref double da, ref double db, out double c, out double s)
		{
			c = default(double);
			s = default(double);
		}

		public void SvdSolve(double[] a, int rowsA, int columnsA, double[] b, int columnsB, double[] x)
		{
		}

		public void SvdSolveFactored(int rowsA, int columnsA, double[] s, double[] u, double[] vt, double[] b, int columnsB, double[] x)
		{
		}

		public void EigenDecomp(bool isSymmetric, int order, double[] matrix, double[] matrixEv, Complex[] vectorEv, double[] matrixD)
		{
		}

		internal static void SymmetricTridiagonalize(double[] a, double[] d, double[] e, int order)
		{
		}

		internal static void SymmetricDiagonalize(double[] a, double[] d, double[] e, int order)
		{
		}

		internal static void NonsymmetricReduceToHessenberg(double[] a, double[] matrixH, int order)
		{
		}

		internal static void NonsymmetricReduceHessenberToRealSchur(double[] a, double[] matrixH, double[] d, double[] e, int order)
		{
		}

		private static Complex Cdiv(double xreal, double ximag, double yreal, double yimag)
		{
			return default(Complex);
		}

		public void AddVectorToScaledVector(float[] y, float alpha, float[] x, float[] result)
		{
		}

		public void ScaleArray(float alpha, float[] x, float[] result)
		{
		}

		public void ConjugateArray(float[] x, float[] result)
		{
		}

		public float DotProduct(float[] x, float[] y)
		{
			return 0f;
		}

		public void AddArrays(float[] x, float[] y, float[] result)
		{
		}

		public void SubtractArrays(float[] x, float[] y, float[] result)
		{
		}

		public void PointWiseMultiplyArrays(float[] x, float[] y, float[] result)
		{
		}

		public void PointWiseDivideArrays(float[] x, float[] y, float[] result)
		{
		}

		public void PointWisePowerArrays(float[] x, float[] y, float[] result)
		{
		}

		public double MatrixNorm(Norm norm, int rows, int columns, float[] matrix)
		{
			return 0.0;
		}

		public void MatrixMultiply(float[] x, int rowsX, int columnsX, float[] y, int rowsY, int columnsY, float[] result)
		{
		}

		public void MatrixMultiplyWithUpdate(Transpose transposeA, Transpose transposeB, float alpha, float[] a, int rowsA, int columnsA, float[] b, int rowsB, int columnsB, float beta, float[] c)
		{
		}

		public void LUFactor(float[] data, int order, int[] ipiv)
		{
		}

		public void LUInverse(float[] a, int order)
		{
		}

		public void LUInverseFactored(float[] a, int order, int[] ipiv)
		{
		}

		public void LUSolve(int columnsOfB, float[] a, int order, float[] b)
		{
		}

		public void LUSolveFactored(int columnsOfB, float[] a, int order, int[] ipiv, float[] b)
		{
		}

		public void CholeskyFactor(float[] a, int order)
		{
		}

		private static void DoCholeskyStep(float[] data, int rowDim, int firstCol, int colLimit, float[] multipliers, int availableCores)
		{
		}

		public void CholeskySolve(float[] a, int orderA, float[] b, int columnsB)
		{
		}

		public void CholeskySolveFactored(float[] a, int orderA, float[] b, int columnsB)
		{
		}

		private static void DoCholeskySolve(float[] a, int orderA, float[] b, int index)
		{
		}

		public void QRFactor(float[] r, int rowsR, int columnsR, float[] q, float[] tau)
		{
		}

		public void ThinQRFactor(float[] a, int rowsA, int columnsA, float[] r, float[] tau)
		{
		}

		private static void ComputeQR(float[] work, int workIndex, float[] a, int rowStart, int rowCount, int columnStart, int columnCount, int availableCores)
		{
		}

		private static void GenerateColumn(float[] work, float[] a, int rowCount, int row, int column)
		{
		}

		public void QRSolve(float[] a, int rows, int columns, float[] b, int columnsB, float[] x, QRMethod method = QRMethod.Full)
		{
		}

		public void QRSolveFactored(float[] q, float[] r, int rowsA, int columnsA, float[] tau, float[] b, int columnsB, float[] x, QRMethod method = QRMethod.Full)
		{
		}

		public void SingularValueDecomposition(bool computeVectors, float[] a, int rowsA, int columnsA, float[] s, float[] u, float[] vt)
		{
		}

		private static void Drotg(ref float da, ref float db, out float c, out float s)
		{
			c = default(float);
			s = default(float);
		}

		public void SvdSolve(float[] a, int rowsA, int columnsA, float[] b, int columnsB, float[] x)
		{
		}

		public void SvdSolveFactored(int rowsA, int columnsA, float[] s, float[] u, float[] vt, float[] b, int columnsB, float[] x)
		{
		}

		public void EigenDecomp(bool isSymmetric, int order, float[] matrix, float[] matrixEv, Complex[] vectorEv, float[] matrixD)
		{
		}

		internal static void SymmetricTridiagonalize(float[] a, float[] d, float[] e, int order)
		{
		}

		internal static void SymmetricDiagonalize(float[] a, float[] d, float[] e, int order)
		{
		}

		internal static void NonsymmetricReduceToHessenberg(float[] a, float[] matrixH, int order)
		{
		}

		internal static void NonsymmetricReduceHessenberToRealSchur(float[] a, float[] matrixH, float[] d, float[] e, int order)
		{
		}

		private static Complex32 Cdiv(float xreal, float ximag, float yreal, float yimag)
		{
			return default(Complex32);
		}
	}
}
