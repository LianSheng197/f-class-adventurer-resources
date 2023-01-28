using System.Runtime.CompilerServices;
using UnityEngine;

namespace UniRx
{
	public abstract class PresenterBase : PresenterBase<Unit>
	{
		protected sealed override void BeforeInitialize(Unit argument)
		{
		}

		protected abstract void BeforeInitialize();

		protected override void Initialize(Unit argument)
		{
		}

		public void ForceInitialize()
		{
		}

		protected abstract void Initialize();

		protected PresenterBase()
		{
			((PresenterBase<>)(object)this)._002Ector();
		}
	}
	public abstract class PresenterBase<T> : MonoBehaviour, IPresenter
	{
		protected static readonly IPresenter[] EmptyChildren;

		private int childrenCount;

		private int currentCalledCount;

		private bool isAwaken;

		private bool isInitialized;

		private bool isStartedCapturePhase;

		private Subject<Unit> initializeSubject;

		private IPresenter[] children;

		private IPresenter parent;

		private T argument;

		public IPresenter Parent => null;

		protected abstract IPresenter[] Children { get; }

		public IObservable<Unit> InitializeAsObservable()
		{
			return null;
		}

		public void PropagateArgument(T argument)
		{
		}

		protected abstract void BeforeInitialize(T argument);

		protected abstract void Initialize(T argument);

		public virtual void ForceInitialize(T argument)
		{
		}

		private void UniRx_002EIPresenter_002EForceInitialize(object argument)
		{
		}

		private void UniRx_002EIPresenter_002EAwake()
		{
		}

		protected void Awake()
		{
		}

		protected virtual void OnAwake()
		{
		}

		protected void Start()
		{
		}

		private void UniRx_002EIPresenter_002EStartCapturePhase()
		{
		}

		private void UniRx_002EIPresenter_002ERegisterParent(IPresenter parent)
		{
		}

		private void UniRx_002EIPresenter_002EInitializeCore()
		{
		}

		[SpecialName]
		private GameObject UniRx_002EIPresenter_002Eget_gameObject()
		{
			return null;
		}
	}
}
