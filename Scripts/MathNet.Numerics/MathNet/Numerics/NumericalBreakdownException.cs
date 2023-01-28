using System;
using System.Runtime.Serialization;

namespace MathNet.Numerics
{
	[Serializable]
	public class NumericalBreakdownException : NonConvergenceException
	{
		public NumericalBreakdownException()
		{
		}

		public NumericalBreakdownException(string message)
		{
		}

		public NumericalBreakdownException(string message, Exception innerException)
		{
		}

		protected NumericalBreakdownException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
