using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Double
{
	internal class VectorBuilder : VectorBuilder<double>
	{
		public override double Zero => 0.0;

		public override double One => 0.0;

		public override Vector<double> Dense(DenseVectorStorage<double> storage)
		{
			return null;
		}

		public override Vector<double> Sparse(SparseVectorStorage<double> storage)
		{
			return null;
		}

		public override Vector<double> Random(int length, IContinuousDistribution distribution)
		{
			return null;
		}

		public VectorBuilder()
		{
			((VectorBuilder<>)(object)this)._002Ector();
		}
	}
}
