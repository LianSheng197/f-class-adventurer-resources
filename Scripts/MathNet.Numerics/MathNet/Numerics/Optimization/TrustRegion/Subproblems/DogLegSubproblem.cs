using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization.TrustRegion.Subproblems
{
	internal class DogLegSubproblem : ITrustRegionSubproblem
	{
		public Vector<double> Pstep
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

		public bool HitBoundary
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Solve(IObjectiveModel objective, double delta)
		{
		}
	}
}
