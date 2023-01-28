using System;
using System.Collections.Generic;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics
{
	public static class Distance
	{
		public static double SAD<T>(Vector<T> a, Vector<T> b) where T : struct, IEquatable<T>, IFormattable
		{
			return 0.0;
		}

		public static double SAD(double[] a, double[] b)
		{
			return 0.0;
		}

		public static float SAD(float[] a, float[] b)
		{
			return 0f;
		}

		public static double MAE<T>(Vector<T> a, Vector<T> b) where T : struct, IEquatable<T>, IFormattable
		{
			return 0.0;
		}

		public static double MAE(double[] a, double[] b)
		{
			return 0.0;
		}

		public static float MAE(float[] a, float[] b)
		{
			return 0f;
		}

		public static double SSD<T>(Vector<T> a, Vector<T> b) where T : struct, IEquatable<T>, IFormattable
		{
			return 0.0;
		}

		public static double SSD(double[] a, double[] b)
		{
			return 0.0;
		}

		public static float SSD(float[] a, float[] b)
		{
			return 0f;
		}

		public static double MSE<T>(Vector<T> a, Vector<T> b) where T : struct, IEquatable<T>, IFormattable
		{
			return 0.0;
		}

		public static double MSE(double[] a, double[] b)
		{
			return 0.0;
		}

		public static float MSE(float[] a, float[] b)
		{
			return 0f;
		}

		public static double Euclidean<T>(Vector<T> a, Vector<T> b) where T : struct, IEquatable<T>, IFormattable
		{
			return 0.0;
		}

		public static double Euclidean(double[] a, double[] b)
		{
			return 0.0;
		}

		public static float Euclidean(float[] a, float[] b)
		{
			return 0f;
		}

		public static double Manhattan<T>(Vector<T> a, Vector<T> b) where T : struct, IEquatable<T>, IFormattable
		{
			return 0.0;
		}

		public static double Manhattan(double[] a, double[] b)
		{
			return 0.0;
		}

		public static float Manhattan(float[] a, float[] b)
		{
			return 0f;
		}

		public static double Chebyshev<T>(Vector<T> a, Vector<T> b) where T : struct, IEquatable<T>, IFormattable
		{
			return 0.0;
		}

		public static double Chebyshev(double[] a, double[] b)
		{
			return 0.0;
		}

		public static float Chebyshev(float[] a, float[] b)
		{
			return 0f;
		}

		public static double Minkowski<T>(double p, Vector<T> a, Vector<T> b) where T : struct, IEquatable<T>, IFormattable
		{
			return 0.0;
		}

		public static double Minkowski(double p, double[] a, double[] b)
		{
			return 0.0;
		}

		public static float Minkowski(double p, float[] a, float[] b)
		{
			return 0f;
		}

		public static double Canberra(double[] a, double[] b)
		{
			return 0.0;
		}

		public static float Canberra(float[] a, float[] b)
		{
			return 0f;
		}

		public static double Cosine(double[] a, double[] b)
		{
			return 0.0;
		}

		public static float Cosine(float[] a, float[] b)
		{
			return 0f;
		}

		public static double Hamming(double[] a, double[] b)
		{
			return 0.0;
		}

		public static float Hamming(float[] a, float[] b)
		{
			return 0f;
		}

		public static double Pearson(IEnumerable<double> a, IEnumerable<double> b)
		{
			return 0.0;
		}

		public static double Jaccard(double[] a, double[] b)
		{
			return 0.0;
		}

		public static double Jaccard(float[] a, float[] b)
		{
			return 0.0;
		}
	}
}
