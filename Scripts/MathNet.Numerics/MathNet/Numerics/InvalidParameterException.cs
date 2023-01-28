using System;
using System.Runtime.Serialization;

namespace MathNet.Numerics
{
	[Serializable]
	public class InvalidParameterException : NativeInterfaceException
	{
		public InvalidParameterException()
		{
		}

		public InvalidParameterException(int parameter)
		{
		}

		public InvalidParameterException(int parameter, Exception innerException)
		{
		}

		protected InvalidParameterException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
