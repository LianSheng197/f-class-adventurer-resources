using System;
using System.Collections.Generic;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.LinearRegression
{
	public static class MultipleRegression
	{
		public static Vector<T> DirectMethod<T>(Matrix<T> x, Vector<T> y, DirectRegressionMethod method = DirectRegressionMethod.NormalEquations) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> DirectMethod<T>(Matrix<T> x, Matrix<T> y, DirectRegressionMethod method = DirectRegressionMethod.NormalEquations) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static T[] DirectMethod<T>(T[][] x, T[] y, bool intercept = false, DirectRegressionMethod method = DirectRegressionMethod.NormalEquations) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static T[] DirectMethod<T>(IEnumerable<Tuple<T[], T>> samples, bool intercept = false, DirectRegressionMethod method = DirectRegressionMethod.NormalEquations) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> NormalEquations<T>(Matrix<T> x, Vector<T> y) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> NormalEquations<T>(Matrix<T> x, Matrix<T> y) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static T[] NormalEquations<T>(T[][] x, T[] y, bool intercept = false) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static T[] NormalEquations<T>(IEnumerable<Tuple<T[], T>> samples, bool intercept = false) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static T[] NormalEquations<T>(IEnumerable<(T[], T)> samples, bool intercept = false) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> QR<T>(Matrix<T> x, Vector<T> y) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> QR<T>(Matrix<T> x, Matrix<T> y) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static T[] QR<T>(T[][] x, T[] y, bool intercept = false) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static T[] QR<T>(IEnumerable<Tuple<T[], T>> samples, bool intercept = false) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static T[] QR<T>(IEnumerable<(T[], T)> samples, bool intercept = false) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Vector<T> Svd<T>(Matrix<T> x, Vector<T> y) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> Svd<T>(Matrix<T> x, Matrix<T> y) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static T[] Svd<T>(T[][] x, T[] y, bool intercept = false) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static T[] Svd<T>(IEnumerable<Tuple<T[], T>> samples, bool intercept = false) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static T[] Svd<T>(IEnumerable<(T[], T)> samples, bool intercept = false) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}
	}
}
