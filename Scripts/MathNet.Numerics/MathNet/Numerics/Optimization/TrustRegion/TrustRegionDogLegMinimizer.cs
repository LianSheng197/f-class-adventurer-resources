namespace MathNet.Numerics.Optimization.TrustRegion
{
	public sealed class TrustRegionDogLegMinimizer : TrustRegionMinimizerBase
	{
		public TrustRegionDogLegMinimizer(double gradientTolerance = 1E-08, double stepTolerance = 1E-08, double functionTolerance = 1E-08, double radiusTolerance = 1E-08, int maximumIterations = -1)
			: base(null, 0.0, 0.0, 0.0, 0.0, 0)
		{
		}
	}
}
