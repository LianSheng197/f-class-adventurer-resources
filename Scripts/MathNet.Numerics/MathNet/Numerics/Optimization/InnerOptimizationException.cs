using System;

namespace MathNet.Numerics.Optimization
{
	public class InnerOptimizationException : OptimizationException
	{
		public InnerOptimizationException(string message)
			: base(null)
		{
		}

		public InnerOptimizationException(string message, Exception innerException)
			: base(null)
		{
		}
	}
}
