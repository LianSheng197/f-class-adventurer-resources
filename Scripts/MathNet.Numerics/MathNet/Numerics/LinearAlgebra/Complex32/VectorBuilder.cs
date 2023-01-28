using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Complex32
{
	internal class VectorBuilder : VectorBuilder<MathNet.Numerics.Complex32>
	{
		public override MathNet.Numerics.Complex32 Zero => default(MathNet.Numerics.Complex32);

		public override MathNet.Numerics.Complex32 One => default(MathNet.Numerics.Complex32);

		public override Vector<MathNet.Numerics.Complex32> Dense(DenseVectorStorage<MathNet.Numerics.Complex32> storage)
		{
			return null;
		}

		public override Vector<MathNet.Numerics.Complex32> Sparse(SparseVectorStorage<MathNet.Numerics.Complex32> storage)
		{
			return null;
		}

		public override Vector<MathNet.Numerics.Complex32> Random(int length, IContinuousDistribution distribution)
		{
			return null;
		}

		public VectorBuilder()
		{
			((VectorBuilder<>)(object)this)._002Ector();
		}
	}
}
