using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Unity.Cloud.UserReporting.Plugin.SimpleJson.Reflection
{
	[GeneratedCode("reflection-utils", "1.0.0")]
	internal class ReflectionUtils
	{
		public delegate object GetDelegate(object source);

		public delegate void SetDelegate(object source, object value);

		public delegate object ConstructorDelegate(params object[] args);

		public delegate TValue ThreadSafeDictionaryValueFactory<TKey, TValue>(TKey key);

		[DefaultMember("Item")]
		public sealed class ThreadSafeDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
		{
			private Dictionary<TKey, TValue> _dictionary;

			private readonly object _lock;

			private readonly ThreadSafeDictionaryValueFactory<TKey, TValue> _valueFactory;

			public int Count => 0;

			public bool IsReadOnly => false;

			public TValue Item
			{
				get
				{
					return default(TValue);
				}
				set
				{
				}
			}

			public ICollection<TKey> Keys => null;

			public ICollection<TValue> Values => null;

			public ThreadSafeDictionary(ThreadSafeDictionaryValueFactory<TKey, TValue> valueFactory)
			{
			}

			public void Add(TKey key, TValue value)
			{
			}

			public void Add(KeyValuePair<TKey, TValue> item)
			{
			}

			private TValue AddValue(TKey key)
			{
				return default(TValue);
			}

			public void Clear()
			{
			}

			public bool Contains(KeyValuePair<TKey, TValue> item)
			{
				return false;
			}

			public bool ContainsKey(TKey key)
			{
				return false;
			}

			public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
			{
			}

			private TValue Get(TKey key)
			{
				return default(TValue);
			}

			public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
			{
				return null;
			}

			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			public bool Remove(TKey key)
			{
				return false;
			}

			public bool Remove(KeyValuePair<TKey, TValue> item)
			{
				return false;
			}

			public bool TryGetValue(TKey key, out TValue value)
			{
				value = default(TValue);
				return false;
			}
		}

		private static readonly object[] EmptyObjects;

		public static Type GetTypeInfo(Type type)
		{
			return null;
		}

		public static Attribute GetAttribute(MemberInfo info, Type type)
		{
			return null;
		}

		public static Type GetGenericListElementType(Type type)
		{
			return null;
		}

		public static Attribute GetAttribute(Type objectType, Type attributeType)
		{
			return null;
		}

		public static Type[] GetGenericTypeArguments(Type type)
		{
			return null;
		}

		public static bool IsTypeGeneric(Type type)
		{
			return false;
		}

		public static bool IsTypeGenericeCollectionInterface(Type type)
		{
			return false;
		}

		public static bool IsAssignableFrom(Type type1, Type type2)
		{
			return false;
		}

		public static bool IsTypeDictionary(Type type)
		{
			return false;
		}

		public static bool IsNullableType(Type type)
		{
			return false;
		}

		public static object ToNullableType(object obj, Type nullableType)
		{
			return null;
		}

		public static bool IsValueType(Type type)
		{
			return false;
		}

		public static IEnumerable<ConstructorInfo> GetConstructors(Type type)
		{
			return null;
		}

		public static ConstructorInfo GetConstructorInfo(Type type, params Type[] argsType)
		{
			return null;
		}

		public static IEnumerable<PropertyInfo> GetProperties(Type type)
		{
			return null;
		}

		public static IEnumerable<FieldInfo> GetFields(Type type)
		{
			return null;
		}

		public static MethodInfo GetGetterMethodInfo(PropertyInfo propertyInfo)
		{
			return null;
		}

		public static MethodInfo GetSetterMethodInfo(PropertyInfo propertyInfo)
		{
			return null;
		}

		public static ConstructorDelegate GetContructor(ConstructorInfo constructorInfo)
		{
			return null;
		}

		public static ConstructorDelegate GetContructor(Type type, params Type[] argsType)
		{
			return null;
		}

		public static ConstructorDelegate GetConstructorByReflection(ConstructorInfo constructorInfo)
		{
			return null;
		}

		public static ConstructorDelegate GetConstructorByReflection(Type type, params Type[] argsType)
		{
			return null;
		}

		public static GetDelegate GetGetMethod(PropertyInfo propertyInfo)
		{
			return null;
		}

		public static GetDelegate GetGetMethod(FieldInfo fieldInfo)
		{
			return null;
		}

		public static GetDelegate GetGetMethodByReflection(PropertyInfo propertyInfo)
		{
			return null;
		}

		public static GetDelegate GetGetMethodByReflection(FieldInfo fieldInfo)
		{
			return null;
		}

		public static SetDelegate GetSetMethod(PropertyInfo propertyInfo)
		{
			return null;
		}

		public static SetDelegate GetSetMethod(FieldInfo fieldInfo)
		{
			return null;
		}

		public static SetDelegate GetSetMethodByReflection(PropertyInfo propertyInfo)
		{
			return null;
		}

		public static SetDelegate GetSetMethodByReflection(FieldInfo fieldInfo)
		{
			return null;
		}
	}
}
