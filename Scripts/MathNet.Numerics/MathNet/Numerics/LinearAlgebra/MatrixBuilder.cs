using System;
using System.Collections.Generic;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Solvers;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra
{
	public abstract class MatrixBuilder<T> where T : struct, IEquatable<T>, IFormattable
	{
		public abstract T Zero { get; }

		public abstract T One { get; }

		internal abstract T Add(T x, T y);

		public Matrix<T> OfStorage(MatrixStorage<T> storage)
		{
			return null;
		}

		public Matrix<T> SameAs<TU>(Matrix<TU> example, int rows, int columns, bool fullyMutable = false) where TU : struct, IEquatable<TU>, IFormattable
		{
			return null;
		}

		public Matrix<T> SameAs<TU>(Matrix<TU> example) where TU : struct, IEquatable<TU>, IFormattable
		{
			return null;
		}

		public Matrix<T> SameAs(Vector<T> example, int rows, int columns)
		{
			return null;
		}

		public Matrix<T> SameAs(Matrix<T> example, Matrix<T> otherExample, int rows, int columns, bool fullyMutable = false)
		{
			return null;
		}

		public Matrix<T> SameAs(Matrix<T> example, Matrix<T> otherExample)
		{
			return null;
		}

		public abstract Matrix<T> Random(int rows, int columns, IContinuousDistribution distribution);

		public Matrix<T> Random(int rows, int columns)
		{
			return null;
		}

		public Matrix<T> Random(int rows, int columns, int seed)
		{
			return null;
		}

		public Matrix<T> RandomPositiveDefinite(int order, IContinuousDistribution distribution)
		{
			return null;
		}

		public Matrix<T> RandomPositiveDefinite(int order)
		{
			return null;
		}

		public Matrix<T> RandomPositiveDefinite(int order, int seed)
		{
			return null;
		}

		public abstract Matrix<T> Dense(DenseColumnMajorMatrixStorage<T> storage);

		public Matrix<T> Dense(int rows, int columns)
		{
			return null;
		}

		public Matrix<T> Dense(int rows, int columns, T[] storage)
		{
			return null;
		}

		public Matrix<T> Dense(int rows, int columns, T value)
		{
			return null;
		}

		public Matrix<T> Dense(int rows, int columns, Func<int, int, T> init)
		{
			return null;
		}

		public Matrix<T> DenseDiagonal(int rows, int columns, T value)
		{
			return null;
		}

		public Matrix<T> DenseDiagonal(int order, T value)
		{
			return null;
		}

		public Matrix<T> DenseDiagonal(int rows, int columns, Func<int, T> init)
		{
			return null;
		}

		public Matrix<T> DenseIdentity(int rows, int columns)
		{
			return null;
		}

		public Matrix<T> DenseIdentity(int order)
		{
			return null;
		}

		public Matrix<T> DenseOfMatrix(Matrix<T> matrix)
		{
			return null;
		}

		public Matrix<T> DenseOfArray(T[,] array)
		{
			return null;
		}

		public Matrix<T> DenseOfIndexed(int rows, int columns, IEnumerable<Tuple<int, int, T>> enumerable)
		{
			return null;
		}

		public Matrix<T> DenseOfIndexed(int rows, int columns, IEnumerable<(int, int, T)> enumerable)
		{
			return null;
		}

		public Matrix<T> DenseOfColumnMajor(int rows, int columns, IEnumerable<T> columnMajor)
		{
			return null;
		}

		public Matrix<T> DenseOfColumns(IEnumerable<IEnumerable<T>> data)
		{
			return null;
		}

		public Matrix<T> DenseOfColumns(int rows, int columns, IEnumerable<IEnumerable<T>> data)
		{
			return null;
		}

		public Matrix<T> DenseOfColumnArrays(params T[][] columns)
		{
			return null;
		}

		public Matrix<T> DenseOfColumnArrays(IEnumerable<T[]> columns)
		{
			return null;
		}

		public Matrix<T> DenseOfColumnVectors(params Vector<T>[] columns)
		{
			return null;
		}

		public Matrix<T> DenseOfColumnVectors(IEnumerable<Vector<T>> columns)
		{
			return null;
		}

		public Matrix<T> DenseOfRowMajor(int rows, int columns, IEnumerable<T> columnMajor)
		{
			return null;
		}

		public Matrix<T> DenseOfRows(IEnumerable<IEnumerable<T>> data)
		{
			return null;
		}

		public Matrix<T> DenseOfRows(int rows, int columns, IEnumerable<IEnumerable<T>> data)
		{
			return null;
		}

		public Matrix<T> DenseOfRowArrays(params T[][] rows)
		{
			return null;
		}

		public Matrix<T> DenseOfRowArrays(IEnumerable<T[]> rows)
		{
			return null;
		}

		public Matrix<T> DenseOfRowVectors(params Vector<T>[] rows)
		{
			return null;
		}

		public Matrix<T> DenseOfRowVectors(IEnumerable<Vector<T>> rows)
		{
			return null;
		}

		public Matrix<T> DenseOfDiagonalVector(Vector<T> diagonal)
		{
			return null;
		}

		public Matrix<T> DenseOfDiagonalVector(int rows, int columns, Vector<T> diagonal)
		{
			return null;
		}

		public Matrix<T> DenseOfDiagonalArray(T[] diagonal)
		{
			return null;
		}

		public Matrix<T> DenseOfDiagonalArray(int rows, int columns, T[] diagonal)
		{
			return null;
		}

		public Matrix<T> DenseOfMatrixArray(Matrix<T>[,] matrices)
		{
			return null;
		}

		public abstract Matrix<T> Sparse(SparseCompressedRowMatrixStorage<T> storage);

		public Matrix<T> Sparse(int rows, int columns)
		{
			return null;
		}

		public Matrix<T> Sparse(int rows, int columns, T value)
		{
			return null;
		}

		public Matrix<T> Sparse(int rows, int columns, Func<int, int, T> init)
		{
			return null;
		}

		public Matrix<T> SparseDiagonal(int rows, int columns, T value)
		{
			return null;
		}

		public Matrix<T> SparseDiagonal(int order, T value)
		{
			return null;
		}

		public Matrix<T> SparseDiagonal(int rows, int columns, Func<int, T> init)
		{
			return null;
		}

		public Matrix<T> SparseIdentity(int rows, int columns)
		{
			return null;
		}

		public Matrix<T> SparseIdentity(int order)
		{
			return null;
		}

		public Matrix<T> SparseOfMatrix(Matrix<T> matrix)
		{
			return null;
		}

		public Matrix<T> SparseOfArray(T[,] array)
		{
			return null;
		}

		public Matrix<T> SparseOfIndexed(int rows, int columns, IEnumerable<Tuple<int, int, T>> enumerable)
		{
			return null;
		}

		public Matrix<T> SparseOfIndexed(int rows, int columns, IEnumerable<(int, int, T)> enumerable)
		{
			return null;
		}

		public Matrix<T> SparseOfRowMajor(int rows, int columns, IEnumerable<T> rowMajor)
		{
			return null;
		}

		public Matrix<T> SparseOfColumnMajor(int rows, int columns, IList<T> columnMajor)
		{
			return null;
		}

		public Matrix<T> SparseOfColumns(IEnumerable<IEnumerable<T>> data)
		{
			return null;
		}

		public Matrix<T> SparseOfColumns(int rows, int columns, IEnumerable<IEnumerable<T>> data)
		{
			return null;
		}

		public Matrix<T> SparseOfColumnArrays(params T[][] columns)
		{
			return null;
		}

		public Matrix<T> SparseOfColumnArrays(IEnumerable<T[]> columns)
		{
			return null;
		}

		public Matrix<T> SparseOfColumnVectors(params Vector<T>[] columns)
		{
			return null;
		}

		public Matrix<T> SparseOfColumnVectors(IEnumerable<Vector<T>> columns)
		{
			return null;
		}

		public Matrix<T> SparseOfRows(IEnumerable<IEnumerable<T>> data)
		{
			return null;
		}

		public Matrix<T> SparseOfRows(int rows, int columns, IEnumerable<IEnumerable<T>> data)
		{
			return null;
		}

		public Matrix<T> SparseOfRowArrays(params T[][] rows)
		{
			return null;
		}

		public Matrix<T> SparseOfRowArrays(IEnumerable<T[]> rows)
		{
			return null;
		}

		public Matrix<T> SparseOfRowVectors(params Vector<T>[] rows)
		{
			return null;
		}

		public Matrix<T> SparseOfRowVectors(IEnumerable<Vector<T>> rows)
		{
			return null;
		}

		public Matrix<T> SparseOfDiagonalVector(Vector<T> diagonal)
		{
			return null;
		}

		public Matrix<T> SparseOfDiagonalVector(int rows, int columns, Vector<T> diagonal)
		{
			return null;
		}

		public Matrix<T> SparseOfDiagonalArray(T[] diagonal)
		{
			return null;
		}

		public Matrix<T> SparseOfDiagonalArray(int rows, int columns, T[] diagonal)
		{
			return null;
		}

		public Matrix<T> SparseOfMatrixArray(Matrix<T>[,] matrices)
		{
			return null;
		}

		public Matrix<T> SparseFromCoordinateFormat(int rows, int columns, int valueCount, int[] rowIndices, int[] columnIndices, T[] values)
		{
			return null;
		}

		public Matrix<T> SparseFromCompressedSparseRowFormat(int rows, int columns, int valueCount, int[] rowPointers, int[] columnIndices, T[] values)
		{
			return null;
		}

		public Matrix<T> SparseFromCompressedSparseColumnFormat(int rows, int columns, int valueCount, int[] rowIndices, int[] columnPointers, T[] values)
		{
			return null;
		}

		public abstract Matrix<T> Diagonal(DiagonalMatrixStorage<T> storage);

		public Matrix<T> Diagonal(int rows, int columns)
		{
			return null;
		}

		public Matrix<T> Diagonal(int rows, int columns, T[] storage)
		{
			return null;
		}

		public Matrix<T> Diagonal(T[] storage)
		{
			return null;
		}

		public Matrix<T> Diagonal(int rows, int columns, T value)
		{
			return null;
		}

		public Matrix<T> Diagonal(int rows, int columns, Func<int, T> init)
		{
			return null;
		}

		public Matrix<T> DiagonalIdentity(int rows, int columns)
		{
			return null;
		}

		public Matrix<T> DiagonalIdentity(int order)
		{
			return null;
		}

		public Matrix<T> DiagonalOfDiagonalVector(Vector<T> diagonal)
		{
			return null;
		}

		public Matrix<T> DiagonalOfDiagonalVector(int rows, int columns, Vector<T> diagonal)
		{
			return null;
		}

		public Matrix<T> DiagonalOfDiagonalArray(T[] diagonal)
		{
			return null;
		}

		public Matrix<T> DiagonalOfDiagonalArray(int rows, int columns, T[] diagonal)
		{
			return null;
		}

		public abstract IIterationStopCriterion<T>[] IterativeSolverStopCriteria(int maxIterations = 1000);
	}
}
