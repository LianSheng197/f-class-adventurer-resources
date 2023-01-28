using System;

namespace MathNet.Numerics.LinearAlgebra.Factorization
{
	public abstract class GramSchmidt<T> : QR<T> where T : struct, IEquatable<T>, IFormattable
	{
		protected GramSchmidt(Matrix<T> q, Matrix<T> rFull)
		{
			((QR<>)(object)this)._002Ector((Matrix<T>)null, (Matrix<T>)null, default(QRMethod));
		}
	}
}
