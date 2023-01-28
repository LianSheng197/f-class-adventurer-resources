using System;
using System.Runtime.Serialization;

namespace MathNet.Numerics
{
	[Serializable]
	public abstract class NativeInterfaceException : Exception
	{
		protected NativeInterfaceException()
		{
		}

		protected NativeInterfaceException(string message)
		{
		}

		protected NativeInterfaceException(string message, Exception innerException)
		{
		}

		protected NativeInterfaceException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
