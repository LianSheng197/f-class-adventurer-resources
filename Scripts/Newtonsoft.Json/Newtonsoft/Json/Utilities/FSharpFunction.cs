namespace Newtonsoft.Json.Utilities
{
	internal class FSharpFunction
	{
		private readonly object? _instance;

		private readonly MethodCall<object?, object> _invoker;

		public FSharpFunction(object? instance, MethodCall<object?, object> invoker)
		{
		}

		public object Invoke(params object[] args)
		{
			return null;
		}
	}
}
