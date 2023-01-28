using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Unity.Cloud.UserReporting.Plugin.SimpleJson.Reflection;

namespace Unity.Cloud.UserReporting.Plugin.SimpleJson
{
	[GeneratedCode("simple-json", "1.0.0")]
	public class PocoJsonSerializerStrategy : IJsonSerializerStrategy
	{
		internal IDictionary<Type, ReflectionUtils.ConstructorDelegate> ConstructorCache;

		internal IDictionary<Type, IDictionary<string, ReflectionUtils.GetDelegate>> GetCache;

		internal IDictionary<Type, IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>> SetCache;

		internal static readonly Type[] EmptyTypes;

		internal static readonly Type[] ArrayConstructorParameterTypes;

		private static readonly string[] Iso8601Format;

		protected virtual string MapClrMemberNameToJsonFieldName(string clrPropertyName)
		{
			return null;
		}

		internal virtual ReflectionUtils.ConstructorDelegate ContructorDelegateFactory(Type key)
		{
			return null;
		}

		internal virtual IDictionary<string, ReflectionUtils.GetDelegate> GetterValueFactory(Type type)
		{
			return null;
		}

		internal virtual IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>> SetterValueFactory(Type type)
		{
			return null;
		}

		public virtual bool TrySerializeNonPrimitiveObject(object input, out object output)
		{
			output = null;
			return false;
		}

		public virtual object DeserializeObject(object value, Type type)
		{
			return null;
		}

		protected virtual object SerializeEnum(Enum p)
		{
			return null;
		}

		protected virtual bool TrySerializeKnownTypes(object input, out object output)
		{
			output = null;
			return false;
		}

		protected virtual bool TrySerializeUnknownTypes(object input, out object output)
		{
			output = null;
			return false;
		}
	}
}
