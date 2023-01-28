using System;

namespace MathNet.Numerics.LinearAlgebra
{
	internal static class BuilderInstance<T> where T : struct, IEquatable<T>, IFormattable
	{
		private static Lazy<Tuple<MatrixBuilder<T>, VectorBuilder<T>>> _singleton;

		public static MatrixBuilder<T> Matrix => null;

		public static VectorBuilder<T> Vector => null;

		private static Tuple<MatrixBuilder<T>, VectorBuilder<T>> Create()
		{
			return null;
		}

		public static void Register(MatrixBuilder<T> matrixBuilder, VectorBuilder<T> vectorBuilder)
		{
		}
	}
}
