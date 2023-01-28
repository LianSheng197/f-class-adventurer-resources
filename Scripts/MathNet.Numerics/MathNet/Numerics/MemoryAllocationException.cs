using System;
using System.Runtime.Serialization;

namespace MathNet.Numerics
{
	[Serializable]
	public class MemoryAllocationException : NativeInterfaceException
	{
		public MemoryAllocationException()
		{
		}

		public MemoryAllocationException(Exception innerException)
		{
		}

		protected MemoryAllocationException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
