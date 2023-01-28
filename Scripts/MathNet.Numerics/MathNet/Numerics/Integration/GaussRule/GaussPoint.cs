using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Integration.GaussRule
{
	internal class GaussPoint
	{
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

		internal int Order
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		internal GaussPoint(double intervalBegin, double intervalEnd, int order, double[] abscissas, double[] weights)
		{
		}

		internal GaussPoint(int order, double[] abscissas, double[] weights)
		{
		}
	}
}
