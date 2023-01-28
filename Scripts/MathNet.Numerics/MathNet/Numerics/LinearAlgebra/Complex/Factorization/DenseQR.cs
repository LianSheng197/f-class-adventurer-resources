using System.Numerics;
using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Complex.Factorization
{
	internal sealed class DenseQR : QR
	{
		private System.Numerics.Complex[] Tau
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

		private DenseQR(Matrix<System.Numerics.Complex> q, Matrix<System.Numerics.Complex> rFull, QRMethod method, System.Numerics.Complex[] tau)
			: base(null, null, default(QRMethod))
		{
		}

		public override void Solve(Matrix<System.Numerics.Complex> input, Matrix<System.Numerics.Complex> result)
		{
		}

		public override void Solve(Vector<System.Numerics.Complex> input, Vector<System.Numerics.Complex> result)
		{
		}
	}
}
