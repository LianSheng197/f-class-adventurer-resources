using System.Runtime.CompilerServices;
using UnityEngine;

namespace UniRx.Triggers
{
	[DisallowMultipleComponent]
	public class ObservableStateMachineTrigger : StateMachineBehaviour
	{
		public class OnStateInfo
		{
			public Animator Animator
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

			public AnimatorStateInfo StateInfo
			{
				[CompilerGenerated]
				get
				{
					return default(AnimatorStateInfo);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int LayerIndex
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public OnStateInfo(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
			{
			}
		}

		public class OnStateMachineInfo
		{
			public Animator Animator
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

			public int StateMachinePathHash
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public OnStateMachineInfo(Animator animator, int stateMachinePathHash)
			{
			}
		}

		private Subject<OnStateInfo> onStateExit;

		private Subject<OnStateInfo> onStateEnter;

		private Subject<OnStateInfo> onStateIK;

		private Subject<OnStateInfo> onStateUpdate;

		private Subject<OnStateMachineInfo> onStateMachineEnter;

		private Subject<OnStateMachineInfo> onStateMachineExit;

		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		public IObservable<OnStateInfo> OnStateExitAsObservable()
		{
			return null;
		}

		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		public IObservable<OnStateInfo> OnStateEnterAsObservable()
		{
			return null;
		}

		public override void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		public IObservable<OnStateInfo> OnStateIKAsObservable()
		{
			return null;
		}

		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		public IObservable<OnStateInfo> OnStateUpdateAsObservable()
		{
			return null;
		}

		public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
		{
		}

		public IObservable<OnStateMachineInfo> OnStateMachineEnterAsObservable()
		{
			return null;
		}

		public override void OnStateMachineExit(Animator animator, int stateMachinePathHash)
		{
		}

		public IObservable<OnStateMachineInfo> OnStateMachineExitAsObservable()
		{
			return null;
		}
	}
}
