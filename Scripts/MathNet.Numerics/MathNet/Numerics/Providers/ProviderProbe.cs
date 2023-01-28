using System;

namespace MathNet.Numerics.Providers
{
	public class ProviderProbe<T> where T : class
	{
		private readonly bool _disabled;

		private readonly Lazy<IProviderCreator<T>> _creator;

		public ProviderProbe(string typeName, bool disabled = false)
		{
		}

		public T Create()
		{
			return null;
		}

		public T TryCreate()
		{
			return null;
		}
	}
}
