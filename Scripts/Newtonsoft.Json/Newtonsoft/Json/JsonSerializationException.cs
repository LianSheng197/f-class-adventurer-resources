using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	[Serializable]
	public class JsonSerializationException : JsonException
	{
		public int LineNumber
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		public int LinePosition
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		public string? Path
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public JsonSerializationException()
		{
		}

		public JsonSerializationException(string message)
		{
		}

		public JsonSerializationException(string message, Exception innerException)
		{
		}

		public JsonSerializationException(SerializationInfo info, StreamingContext context)
		{
		}

		public JsonSerializationException(string message, string path, int lineNumber, int linePosition, Exception? innerException)
		{
		}

		internal static JsonSerializationException Create(JsonReader reader, string message)
		{
			return null;
		}

		internal static JsonSerializationException Create(JsonReader reader, string message, Exception? ex)
		{
			return null;
		}

		internal static JsonSerializationException Create(IJsonLineInfo? lineInfo, string path, string message, Exception? ex)
		{
			return null;
		}
	}
}
