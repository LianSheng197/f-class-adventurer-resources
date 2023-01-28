using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Integration.GaussRule
{
	internal class GaussPointPair
	{
		internal int Order
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		internal double[] Abscissas
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal double[] Weights
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal int SecondOrder
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		internal double[] SecondAbscissas
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal double[] SecondWeights
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal double IntervalBegin
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
		}

		internal double IntervalEnd
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
		}

		internal GaussPointPair(double intervalBegin, double intervalEnd, int order, double[] abscissas, double[] weights, int secondOrder, double[] secondAbscissas, double[] secondWeights)
		{
		}

		internal GaussPointPair(int order, double[] abscissas, double[] weights, int secondOrder, double[] secondWeights)
		{
		}
	}
}
