using System;
using System.Collections.Generic;
using UnityEngine;

namespace UniRx
{
	public static class UnityEqualityComparer
	{
		private static class RuntimeTypeHandlerCache<T>
		{
			public static readonly RuntimeTypeHandle TypeHandle;
		}

		private class Vector2EqualityComparer : IEqualityComparer<Vector2>
		{
			public bool Equals(Vector2 self, Vector2 vector)
			{
				return false;
			}

			public int GetHashCode(Vector2 obj)
			{
				return 0;
			}
		}

		private class Vector3EqualityComparer : IEqualityComparer<Vector3>
		{
			public bool Equals(Vector3 self, Vector3 vector)
			{
				return false;
			}

			public int GetHashCode(Vector3 obj)
			{
				return 0;
			}
		}

		private class Vector4EqualityComparer : IEqualityComparer<Vector4>
		{
			public bool Equals(Vector4 self, Vector4 vector)
			{
				return false;
			}

			public int GetHashCode(Vector4 obj)
			{
				return 0;
			}
		}

		private class ColorEqualityComparer : IEqualityComparer<Color>
		{
			public bool Equals(Color self, Color other)
			{
				return false;
			}

			public int GetHashCode(Color obj)
			{
				return 0;
			}
		}

		private class RectEqualityComparer : IEqualityComparer<Rect>
		{
			public bool Equals(Rect self, Rect other)
			{
				return false;
			}

			public int GetHashCode(Rect obj)
			{
				return 0;
			}
		}

		private class BoundsEqualityComparer : IEqualityComparer<Bounds>
		{
			public bool Equals(Bounds self, Bounds vector)
			{
				return false;
			}

			public int GetHashCode(Bounds obj)
			{
				return 0;
			}
		}

		private class QuaternionEqualityComparer : IEqualityComparer<Quaternion>
		{
			public bool Equals(Quaternion self, Quaternion vector)
			{
				return false;
			}

			public int GetHashCode(Quaternion obj)
			{
				return 0;
			}
		}

		public static readonly IEqualityComparer<Vector2> Vector2;

		public static readonly IEqualityComparer<Vector3> Vector3;

		public static readonly IEqualityComparer<Vector4> Vector4;

		public static readonly IEqualityComparer<Color> Color;

		public static readonly IEqualityComparer<Rect> Rect;

		public static readonly IEqualityComparer<Bounds> Bounds;

		public static readonly IEqualityComparer<Quaternion> Quaternion;

		private static readonly RuntimeTypeHandle vector2Type;

		private static readonly RuntimeTypeHandle vector3Type;

		private static readonly RuntimeTypeHandle vector4Type;

		private static readonly RuntimeTypeHandle colorType;

		private static readonly RuntimeTypeHandle rectType;

		private static readonly RuntimeTypeHandle boundsType;

		private static readonly RuntimeTypeHandle quaternionType;

		public static IEqualityComparer<T> GetDefault<T>()
		{
			return null;
		}
	}
}
