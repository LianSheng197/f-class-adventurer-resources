using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearRegression;

namespace MathNet.Numerics
{
	[Serializable]
	[DataContract(Namespace = "urn:MathNet/Numerics")]
	public class Polynomial : IFormattable, IEquatable<Polynomial>, ICloneable
	{
		[DataMember(Order = 2)]
		public string VariableName;

		[DataMember(Order = 1)]
		public double[] Coefficients
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int Degree => 0;

		public static Polynomial Zero => null;

		public Polynomial(int n)
		{
		}

		public Polynomial()
		{
		}

		public Polynomial(double coefficient)
		{
		}

		public Polynomial(params double[] coefficients)
		{
		}

		public Polynomial(IEnumerable<double> coefficients)
		{
		}

		public static Polynomial Fit(double[] x, double[] y, int order, DirectRegressionMethod method = DirectRegressionMethod.QR)
		{
			return null;
		}

		private static int EvaluateDegree(double[] coefficients)
		{
			return 0;
		}

		public static double Evaluate(double z, params double[] coefficients)
		{
			return 0.0;
		}

		public static Complex Evaluate(Complex z, params double[] coefficients)
		{
			return default(Complex);
		}

		public static Complex Evaluate(Complex z, params Complex[] coefficients)
		{
			return default(Complex);
		}

		public double Evaluate(double z)
		{
			return 0.0;
		}

		public Complex Evaluate(Complex z)
		{
			return default(Complex);
		}

		public IEnumerable<double> Evaluate(IEnumerable<double> z)
		{
			return null;
		}

		public IEnumerable<Complex> Evaluate(IEnumerable<Complex> z)
		{
			return null;
		}

		public Polynomial Differentiate()
		{
			return null;
		}

		public Polynomial Integrate()
		{
			return null;
		}

		public Complex[] Roots()
		{
			return null;
		}

		public DenseMatrix EigenvalueMatrix()
		{
			return null;
		}

		public static Polynomial Add(Polynomial a, Polynomial b)
		{
			return null;
		}

		public static Polynomial Add(Polynomial a, double b)
		{
			return null;
		}

		public static Polynomial Subtract(Polynomial a, Polynomial b)
		{
			return null;
		}

		public static Polynomial Subtract(Polynomial a, double b)
		{
			return null;
		}

		public static Polynomial Subtract(double b, Polynomial a)
		{
			return null;
		}

		public static Polynomial Negate(Polynomial a)
		{
			return null;
		}

		public static Polynomial Multiply(Polynomial a, Polynomial b)
		{
			return null;
		}

		public static Polynomial Multiply(Polynomial a, double k)
		{
			return null;
		}

		public static Polynomial Divide(Polynomial a, double k)
		{
			return null;
		}

		public static (Polynomial, Polynomial) DivideRemainder(Polynomial a, Polynomial b)
		{
			return default((Polynomial, Polynomial));
		}

		public static Polynomial PointwiseDivide(Polynomial a, Polynomial b)
		{
			return null;
		}

		public static Polynomial PointwiseMultiply(Polynomial a, Polynomial b)
		{
			return null;
		}

		public (Polynomial, Polynomial) DivideRemainder(Polynomial b)
		{
			return default((Polynomial, Polynomial));
		}

		public static Polynomial operator +(Polynomial a, Polynomial b)
		{
			return null;
		}

		public static Polynomial operator +(Polynomial a, double k)
		{
			return null;
		}

		public static Polynomial operator +(double k, Polynomial a)
		{
			return null;
		}

		public static Polynomial operator -(Polynomial a, Polynomial b)
		{
			return null;
		}

		public static Polynomial operator -(Polynomial a, double k)
		{
			return null;
		}

		public static Polynomial operator -(double k, Polynomial a)
		{
			return null;
		}

		public static Polynomial operator -(Polynomial a)
		{
			return null;
		}

		public static Polynomial operator *(Polynomial a, Polynomial b)
		{
			return null;
		}

		public static Polynomial operator *(Polynomial a, double k)
		{
			return null;
		}

		public static Polynomial operator *(double k, Polynomial a)
		{
			return null;
		}

		public static Polynomial operator /(Polynomial a, double k)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToStringDescending()
		{
			return null;
		}

		public string ToString(string format)
		{
			return null;
		}

		public string ToStringDescending(string format)
		{
			return null;
		}

		public string ToString(IFormatProvider formatProvider)
		{
			return null;
		}

		public string ToStringDescending(IFormatProvider formatProvider)
		{
			return null;
		}

		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		public string ToStringDescending(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		public bool Equals(Polynomial other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public Polynomial Clone()
		{
			return null;
		}

		private object System_002EICloneable_002EClone()
		{
			return null;
		}
	}
}
