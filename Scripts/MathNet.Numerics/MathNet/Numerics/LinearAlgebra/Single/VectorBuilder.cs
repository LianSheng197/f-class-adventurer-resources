using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Single
{
	internal class VectorBuilder : VectorBuilder<float>
	{
		public override float Zero => 0f;

		public override float One => 0f;

		public override Vector<float> Dense(DenseVectorStorage<float> storage)
		{
			return null;
		}

		public override Vector<float> Sparse(SparseVectorStorage<float> storage)
		{
			return null;
		}

		public override Vector<float> Random(int length, IContinuousDistribution distribution)
		{
			return null;
		}

		public VectorBuilder()
		{
			((VectorBuilder<>)(object)this)._002Ector();
		}
	}
}
