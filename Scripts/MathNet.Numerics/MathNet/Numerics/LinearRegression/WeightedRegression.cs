using System;
using System.Collections.Generic;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.LinearRegression
{
	public static class WeightedRegression
	{
		public static Vector<T> Weighted<T>(Matrix<T> x, Vector<T> y, Matrix<T> w) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static Matrix<T> Weighted<T>(Matrix<T> x, Matrix<T> y, Matrix<T> w) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static T[] Weighted<T>(T[][] x, T[] y, T[] w, bool intercept = false) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static T[] Weighted<T>(IEnumerable<Tuple<T[], T>> samples, T[] weights, bool intercept = false) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		public static T[] Weighted<T>(IEnumerable<(T[], T)> samples, T[] weights, bool intercept = false) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		[Obsolete("Warning: This function is here to stay but its signature will likely change. Opting out from semantic versioning.")]
		public static Vector<T> Local<T>(Matrix<T> x, Vector<T> y, Vector<T> t, double radius, Func<double, T> kernel) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		[Obsolete("Warning: This function is here to stay but its signature will likely change. Opting out from semantic versioning.")]
		public static Matrix<T> Local<T>(Matrix<T> x, Matrix<T> y, Vector<T> t, double radius, Func<double, T> kernel) where T : struct, IEquatable<T>, IFormattable
		{
			return null;
		}

		[Obsolete("Warning: This function is here to stay but will likely be refactored and/or moved to another place. Opting out from semantic versioning.")]
		public static double GaussianKernel(double normalizedDistance)
		{
			return 0.0;
		}
	}
}
