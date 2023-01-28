namespace MathNet.Numerics.Differentiation
{
	public class FiniteDifferenceCoefficients
	{
		private double[][,] _coefficients;

		private int _points;

		public int Points
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public FiniteDifferenceCoefficients(int points)
		{
		}

		public double[] GetCoefficients(int center, int order)
		{
			return null;
		}

		public double[,] GetCoefficientsForAllOrders(int center)
		{
			return null;
		}

		private void CalculateCoefficients(int points)
		{
		}
	}
}
