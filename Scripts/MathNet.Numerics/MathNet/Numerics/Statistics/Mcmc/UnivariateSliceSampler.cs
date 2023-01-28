namespace MathNet.Numerics.Statistics.Mcmc
{
	public class UnivariateSliceSampler : McmcSampler<double>
	{
		private readonly DensityLn<double> _pdfLnP;

		private double _current;

		private double _currentDensityLn;

		private int _burnInterval;

		private double _scale;

		public int BurnInterval
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public double Scale
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public UnivariateSliceSampler(double x0, DensityLn<double> pdfLnP, double scale)
		{
			((McmcSampler<>)(object)this)._002Ector();
		}

		public UnivariateSliceSampler(double x0, DensityLn<double> pdfLnP, int burnInterval, double scale)
		{
			((McmcSampler<>)(object)this)._002Ector();
		}

		private void Burn(int n)
		{
		}

		public override double Sample()
		{
			return 0.0;
		}
	}
}
