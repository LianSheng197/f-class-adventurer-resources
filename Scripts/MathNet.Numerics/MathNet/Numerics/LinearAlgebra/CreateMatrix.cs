using System;
using System.Collections.Generic;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra
{
	public static class CreateMatrix
	{
		public static Matrix<T> WithStorage<T>(MatrixStorage<T> storage) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SameAs<T, TU>(Matrix<TU> example, int rows, int columns, bool fullyMutable = false) where T : struct, IEquatable<T>, IFormattable where TU : struct, IEquatable<TU>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SameAs<T, TU>(Matrix<TU> example) where T : struct, IEquatable<T>, IFormattable where TU : struct, IEquatable<TU>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SameAs<T>(Vector<T> example, int rows, int columns) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SameAs<T>(Matrix<T> example, Matrix<T> otherExample, int rows, int columns, bool fullyMutable = false) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SameAs<T>(Matrix<T> example, Matrix<T> otherExample) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> Random<T>(int rows, int columns, IContinuousDistribution distribution) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> Random<T>(int rows, int columns) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> Random<T>(int rows, int columns, int seed) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> RandomPositiveDefinite<T>(int order, IContinuousDistribution distribution) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> RandomPositiveDefinite<T>(int order) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> RandomPositiveDefinite<T>(int order, int seed) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> Dense<T>(DenseColumnMajorMatrixStorage<T> storage) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> Dense<T>(int rows, int columns) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> Dense<T>(int rows, int columns, T[] storage) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> Dense<T>(int rows, int columns, T value) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> Dense<T>(int rows, int columns, Func<int, int, T> init) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseDiagonal<T>(int rows, int columns, T value) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseDiagonal<T>(int order, T value) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseDiagonal<T>(int rows, int columns, Func<int, T> init) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseIdentity<T>(int rows, int columns) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseIdentity<T>(int order) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfMatrix<T>(Matrix<T> matrix) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfArray<T>(T[,] array) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfIndexed<T>(int rows, int columns, IEnumerable<Tuple<int, int, T>> enumerable) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfIndexed<T>(int rows, int columns, IEnumerable<(int, int, T)> enumerable) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfColumnMajor<T>(int rows, int columns, IEnumerable<T> columnMajor) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfColumns<T>(IEnumerable<IEnumerable<T>> data) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfColumns<T>(int rows, int columns, IEnumerable<IEnumerable<T>> data) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfColumnArrays<T>(params T[][] columns) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfColumnArrays<T>(IEnumerable<T[]> columns) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfColumnVectors<T>(params Vector<T>[] columns) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfColumnVectors<T>(IEnumerable<Vector<T>> columns) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfRows<T>(IEnumerable<IEnumerable<T>> data) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfRows<T>(int rows, int columns, IEnumerable<IEnumerable<T>> data) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfRowArrays<T>(params T[][] rows) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfRowArrays<T>(IEnumerable<T[]> rows) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfRowVectors<T>(params Vector<T>[] rows) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfRowVectors<T>(IEnumerable<Vector<T>> rows) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfDiagonalVector<T>(Vector<T> diagonal) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfDiagonalVector<T>(int rows, int columns, Vector<T> diagonal) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfDiagonalArray<T>(T[] diagonal) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfDiagonalArray<T>(int rows, int columns, T[] diagonal) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DenseOfMatrixArray<T>(Matrix<T>[,] matrices) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> Sparse<T>(SparseCompressedRowMatrixStorage<T> storage) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> Sparse<T>(int rows, int columns) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> Sparse<T>(int rows, int columns, T value) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> Sparse<T>(int rows, int columns, Func<int, int, T> init) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseDiagonal<T>(int rows, int columns, T value) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseDiagonal<T>(int order, T value) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseDiagonal<T>(int rows, int columns, Func<int, T> init) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseIdentity<T>(int rows, int columns) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseIdentity<T>(int order) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfMatrix<T>(Matrix<T> matrix) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfArray<T>(T[,] array) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfIndexed<T>(int rows, int columns, IEnumerable<Tuple<int, int, T>> enumerable) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfIndexed<T>(int rows, int columns, IEnumerable<(int, int, T)> enumerable) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfRowMajor<T>(int rows, int columns, IEnumerable<T> rowMajor) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfColumnMajor<T>(int rows, int columns, IList<T> columnMajor) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfColumns<T>(IEnumerable<IEnumerable<T>> data) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfColumns<T>(int rows, int columns, IEnumerable<IEnumerable<T>> data) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfColumnArrays<T>(params T[][] columns) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfColumnArrays<T>(IEnumerable<T[]> columns) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfColumnVectors<T>(params Vector<T>[] columns) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfColumnVectors<T>(IEnumerable<Vector<T>> columns) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfRows<T>(IEnumerable<IEnumerable<T>> data) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfRows<T>(int rows, int columns, IEnumerable<IEnumerable<T>> data) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfRowArrays<T>(params T[][] rows) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfRowArrays<T>(IEnumerable<T[]> rows) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfRowVectors<T>(params Vector<T>[] rows) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfRowVectors<T>(IEnumerable<Vector<T>> rows) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfDiagonalVector<T>(Vector<T> diagonal) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfDiagonalVector<T>(int rows, int columns, Vector<T> diagonal) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfDiagonalArray<T>(T[] diagonal) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfDiagonalArray<T>(int rows, int columns, T[] diagonal) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseOfMatrixArray<T>(Matrix<T>[,] matrices) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseFromCoordinateFormat<T>(int rows, int columns, int valueCount, int[] rowIndices, int[] columnIndices, T[] values) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseFromCompressedSparseRowFormat<T>(int rows, int columns, int valueCount, int[] rowPointers, int[] columnIndices, T[] values) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> SparseFromCompressedSparseColumnFormat<T>(int rows, int columns, int valueCount, int[] rowIndices, int[] columnPointers, T[] values) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> Diagonal<T>(DiagonalMatrixStorage<T> storage) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> Diagonal<T>(int rows, int columns) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> Diagonal<T>(int rows, int columns, T[] storage) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> Diagonal<T>(T[] storage) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> Diagonal<T>(int rows, int columns, T value) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> Diagonal<T>(int rows, int columns, Func<int, T> init) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DiagonalIdentity<T>(int rows, int columns) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DiagonalIdentity<T>(int order) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DiagonalOfDiagonalVector<T>(Vector<T> diagonal) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DiagonalOfDiagonalVector<T>(int rows, int columns, Vector<T> diagonal) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DiagonalOfDiagonalArray<T>(T[] diagonal) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DiagonalOfDiagonalArray<T>(int rows, int columns, T[] diagonal) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}
	}
}
