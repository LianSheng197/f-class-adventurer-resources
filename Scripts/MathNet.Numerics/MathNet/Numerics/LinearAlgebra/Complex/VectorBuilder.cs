using System.Numerics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra.Complex
{
	internal class VectorBuilder : VectorBuilder<System.Numerics.Complex>
	{
		public override System.Numerics.Complex Zero => default(System.Numerics.Complex);

		public override System.Numerics.Complex One => default(System.Numerics.Complex);

		public override Vector<System.Numerics.Complex> Dense(DenseVectorStorage<System.Numerics.Complex> storage)
		{
			return null;
		}

		public override Vector<System.Numerics.Complex> Sparse(SparseVectorStorage<System.Numerics.Complex> storage)
		{
			return null;
		}

		public override Vector<System.Numerics.Complex> Random(int length, IContinuousDistribution distribution)
		{
			return null;
		}

		public VectorBuilder()
		{
			((VectorBuilder<>)(object)this)._002Ector();
		}
	}
}
