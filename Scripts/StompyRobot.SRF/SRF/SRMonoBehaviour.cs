using System.Diagnostics;
using UnityEngine;

namespace SRF
{
	public abstract class SRMonoBehaviour : MonoBehaviour
	{
		private Collider _collider;

		private Transform _transform;

		private Rigidbody _rigidBody;

		private GameObject _gameObject;

		private Rigidbody2D _rigidbody2D;

		private Collider2D _collider2D;

		public Transform CachedTransform
		{
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				return null;
			}
		}

		public Collider CachedCollider
		{
			[DebuggerNonUserCode]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		public Collider2D CachedCollider2D
		{
			[DebuggerNonUserCode]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		public Rigidbody CachedRigidBody
		{
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				return null;
			}
		}

		public Rigidbody2D CachedRigidBody2D
		{
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				return null;
			}
		}

		public GameObject CachedGameObject
		{
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				return null;
			}
		}

		public new Transform transform => null;

		[DebuggerStepThrough]
		[DebuggerNonUserCode]
		protected void AssertNotNull(object value, string fieldName = null)
		{
		}

		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void Assert(bool condition, string message = null)
		{
		}

		[Conditional("UNITY_EDITOR")]
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void EditorAssertNotNull(object value, string fieldName = null)
		{
		}

		[Conditional("UNITY_EDITOR")]
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void EditorAssert(bool condition, string message = null)
		{
		}
	}
}
