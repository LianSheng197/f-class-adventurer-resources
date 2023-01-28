namespace MathNet.Numerics.Statistics.Mcmc
{
	public class MetropolisSampler<T> : McmcSampler<T>
	{
		private readonly DensityLn<T> _pdfLnP;

		private readonly LocalProposalSampler<T> _proposal;

		private T _current;

		private double _currentDensityLn;

		private int _burnInterval;

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

		public MetropolisSampler(T x0, DensityLn<T> pdfLnP, LocalProposalSampler<T> proposal, int burnInterval = 0)
		{
			((McmcSampler<>)(object)this)._002Ector();
		}

		private void Burn(int n)
		{
		}

		public override T Sample()
		{
			return default(T);
		}
	}
}
