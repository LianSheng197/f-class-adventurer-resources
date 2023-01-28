using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Unity.Services.Core.Internal
{
	internal class AsyncOperation : IAsyncOperation, IEnumerator
	{
		protected Action<IAsyncOperation> m_CompletedCallback;

		public bool IsDone
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public AsyncOperationStatus Status
		{
			[CompilerGenerated]
			get
			{
				return default(AsyncOperationStatus);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public Exception Exception
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent => null;

		public event Action<IAsyncOperation> Completed
		{
			add
			{
			}
			remove
			{
			}
		}

		public void SetInProgress()
		{
		}

		public void Succeed()
		{
		}

		public void Fail(Exception reason)
		{
		}

		public void Cancel()
		{
		}

		private bool System_002ECollections_002EIEnumerator_002EMoveNext()
		{
			return false;
		}

		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}
	internal class AsyncOperation<T> : IAsyncOperation<T>, IEnumerator
	{
		protected Action<IAsyncOperation<T>> m_CompletedCallback;

		public bool IsDone
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public AsyncOperationStatus Status
		{
			[CompilerGenerated]
			get
			{
				return default(AsyncOperationStatus);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public Exception Exception
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public T Result
		{
			[CompilerGenerated]
			get
			{
				return default(T);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent => null;

		public event Action<IAsyncOperation<T>> Completed
		{
			add
			{
			}
			remove
			{
			}
		}

		public void SetInProgress()
		{
		}

		public void Succeed(T result)
		{
		}

		public void Fail(Exception reason)
		{
		}

		public void Cancel()
		{
		}

		private bool System_002ECollections_002EIEnumerator_002EMoveNext()
		{
			return false;
		}

		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}
}
