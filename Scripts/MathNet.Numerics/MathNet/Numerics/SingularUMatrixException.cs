using System;
using System.Runtime.Serialization;

namespace MathNet.Numerics
{
	[Serializable]
	public class SingularUMatrixException : NativeInterfaceException
	{
		public SingularUMatrixException()
		{
		}

		public SingularUMatrixException(int element)
		{
		}

		public SingularUMatrixException(int element, Exception innerException)
		{
		}

		protected SingularUMatrixException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
