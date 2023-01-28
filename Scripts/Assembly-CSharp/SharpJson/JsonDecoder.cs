using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SharpJson
{
	public class JsonDecoder
	{
		private Lexer lexer;

		public string errorMessage
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool parseNumbersAsFloat
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public object Decode(string text)
		{
			return null;
		}

		public static object DecodeText(string text)
		{
			return null;
		}

		private IDictionary<string, object> ParseObject()
		{
			return null;
		}

		private IList<object> ParseArray()
		{
			return null;
		}

		private object ParseValue()
		{
			return null;
		}

		private void TriggerError(string message)
		{
		}

		private T EvalLexer<T>(T value)
		{
			return default(T);
		}
	}
}
