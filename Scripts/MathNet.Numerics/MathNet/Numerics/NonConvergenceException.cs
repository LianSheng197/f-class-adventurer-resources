using System;
using System.Runtime.Serialization;

namespace MathNet.Numerics
{
	[Serializable]
	public class NonConvergenceException : Exception
	{
		public NonConvergenceException()
		{
		}

		public NonConvergenceException(string message)
		{
		}

		public NonConvergenceException(string message, Exception innerException)
		{
		}

		protected NonConvergenceException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
