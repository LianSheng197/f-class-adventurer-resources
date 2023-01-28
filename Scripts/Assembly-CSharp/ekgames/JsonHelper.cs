using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ekgames
{
	public static class JsonHelper
	{
		public static readonly JsonSerializerSettings SERIALIZER_SETTINGS;

		public static JObject LoadFromString(string value, FloatParseHandling floatParseHandling = FloatParseHandling.Decimal)
		{
			return null;
		}

		public static string SerializeObject(object value)
		{
			return null;
		}

		public static T DeserializeObject<T>(string value)
		{
			return default(T);
		}
	}
}
