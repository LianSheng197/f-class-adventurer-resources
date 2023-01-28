using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Complex32.Factorization
{
	internal sealed class DenseQR : QR
	{
		private MathNet.Numerics.Complex32[] Tau
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static DenseQR Create(DenseMatrix matrix, QRMethod method = QRMethod.Full)
		{
			return null;
		}

		private DenseQR(Matrix<MathNet.Numerics.Complex32> q, Matrix<MathNet.Numerics.Complex32> rFull, QRMethod method, MathNet.Numerics.Complex32[] tau)
			: base(null, null, default(QRMethod))
		{
		}

		public override void Solve(Matrix<MathNet.Numerics.Complex32> input, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override void Solve(Vector<MathNet.Numerics.Complex32> input, Vector<MathNet.Numerics.Complex32> result)
		{
		}
	}
}
