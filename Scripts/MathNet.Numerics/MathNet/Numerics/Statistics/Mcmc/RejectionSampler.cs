namespace MathNet.Numerics.Statistics.Mcmc
{
	public class RejectionSampler<T> : McmcSampler<T>
	{
		private readonly Density<T> _pdfP;

		private readonly Density<T> _pdfQ;

		private readonly GlobalProposalSampler<T> _proposal;

		public RejectionSampler(Density<T> pdfP, Density<T> pdfQ, GlobalProposalSampler<T> proposal)
		{
			((McmcSampler<>)(object)this)._002Ector();
		}

		public override T Sample()
		{
			return default(T);
		}
	}
}
