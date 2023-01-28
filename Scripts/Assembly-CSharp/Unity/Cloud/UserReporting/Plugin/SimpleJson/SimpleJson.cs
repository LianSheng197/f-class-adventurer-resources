using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Unity.Cloud.UserReporting.Plugin.SimpleJson
{
	[GeneratedCode("simple-json", "1.0.0")]
	public static class SimpleJson
	{
		private const int TOKEN_NONE = 0;

		private const int TOKEN_CURLY_OPEN = 1;

		private const int TOKEN_CURLY_CLOSE = 2;

		private const int TOKEN_SQUARED_OPEN = 3;

		private const int TOKEN_SQUARED_CLOSE = 4;

		private const int TOKEN_COLON = 5;

		private const int TOKEN_COMMA = 6;

		private const int TOKEN_STRING = 7;

		private const int TOKEN_NUMBER = 8;

		private const int TOKEN_TRUE = 9;

		private const int TOKEN_FALSE = 10;

		private const int TOKEN_NULL = 11;

		private const int BUILDER_CAPACITY = 2000;

		private static readonly char[] EscapeTable;

		private static readonly char[] EscapeCharacters;

		private static IJsonSerializerStrategy _currentJsonSerializerStrategy;

		private static PocoJsonSerializerStrategy _pocoJsonSerializerStrategy;

		public static IJsonSerializerStrategy CurrentJsonSerializerStrategy
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static PocoJsonSerializerStrategy PocoJsonSerializerStrategy => null;

		static SimpleJson()
		{
		}

		public static object DeserializeObject(string json)
		{
			return null;
		}

		public static bool TryDeserializeObject(string json, out object obj)
		{
			obj = null;
			return false;
		}

		public static object DeserializeObject(string json, Type type, IJsonSerializerStrategy jsonSerializerStrategy)
		{
			return null;
		}

		public static object DeserializeObject(string json, Type type)
		{
			return null;
		}

		public static T DeserializeObject<T>(string json, IJsonSerializerStrategy jsonSerializerStrategy)
		{
			return default(T);
		}

		public static T DeserializeObject<T>(string json)
		{
			return default(T);
		}

		public static string SerializeObject(object json, IJsonSerializerStrategy jsonSerializerStrategy)
		{
			return null;
		}

		public static string SerializeObject(object json)
		{
			return null;
		}

		public static string EscapeToJavascriptString(string jsonString)
		{
			return null;
		}

		private static IDictionary<string, object> ParseObject(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		private static JsonArray ParseArray(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		private static object ParseValue(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		private static string ParseString(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		private static string ConvertFromUtf32(int utf32)
		{
			return null;
		}

		private static object ParseNumber(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		private static int GetLastIndexOfNumber(char[] json, int index)
		{
			return 0;
		}

		private static void EatWhitespace(char[] json, ref int index)
		{
		}

		private static int LookAhead(char[] json, int index)
		{
			return 0;
		}

		private static int NextToken(char[] json, ref int index)
		{
			return 0;
		}

		private static bool SerializeValue(IJsonSerializerStrategy jsonSerializerStrategy, object value, StringBuilder builder)
		{
			return false;
		}

		private static bool SerializeObject(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable keys, IEnumerable values, StringBuilder builder)
		{
			return false;
		}

		private static bool SerializeArray(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable anArray, StringBuilder builder)
		{
			return false;
		}

		private static bool SerializeString(string aString, StringBuilder builder)
		{
			return false;
		}

		private static bool SerializeNumber(object number, StringBuilder builder)
		{
			return false;
		}

		private static bool IsNumeric(object value)
		{
			return false;
		}
	}
}
