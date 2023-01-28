using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Spine.Unity
{
	[RequireComponent(typeof(Animator))]
	public class SkeletonAnimator : SkeletonRenderer, ISkeletonAnimation
	{
		[Serializable]
		public class MecanimTranslator
		{
			public enum MixMode
			{
				AlwaysMix = 0,
				MixNext = 1,
				SpineStyle = 2
			}

			private class AnimationClipEqualityComparer : IEqualityComparer<AnimationClip>
			{
				internal static readonly IEqualityComparer<AnimationClip> Instance;

				public bool Equals(AnimationClip x, AnimationClip y)
				{
					return false;
				}

				public int GetHashCode(AnimationClip o)
				{
					return 0;
				}
			}

			private class IntEqualityComparer : IEqualityComparer<int>
			{
				internal static readonly IEqualityComparer<int> Instance;

				public bool Equals(int x, int y)
				{
					return false;
				}

				public int GetHashCode(int o)
				{
					return 0;
				}
			}

			public bool autoReset;

			public MixMode[] layerMixModes;

			private readonly Dictionary<int, Animation> animationTable;

			private readonly Dictionary<AnimationClip, int> clipNameHashCodeTable;

			private readonly List<Animation> previousAnimations;

			private readonly List<AnimatorClipInfo> clipInfoCache;

			private readonly List<AnimatorClipInfo> nextClipInfoCache;

			private Animator animator;

			public Animator Animator => null;

			public void Initialize(Animator animator, SkeletonDataAsset skeletonDataAsset)
			{
			}

			public void Apply(Skeleton skeleton)
			{
			}

			private static float AnimationTime(float normalizedTime, float clipLength, bool loop, bool reversed)
			{
				return 0f;
			}

			private static float AnimationTime(float normalizedTime, float clipLength, bool reversed)
			{
				return 0f;
			}

			private void GetAnimatorClipInfos(int layer, out int clipInfoCount, out int nextClipInfoCount, out IList<AnimatorClipInfo> clipInfo, out IList<AnimatorClipInfo> nextClipInfo)
			{
				clipInfoCount = default(int);
				nextClipInfoCount = default(int);
				clipInfo = null;
				nextClipInfo = null;
			}

			private Animation GetAnimation(AnimationClip clip)
			{
				return null;
			}
		}

		[SerializeField]
		protected MecanimTranslator translator;

		public MecanimTranslator Translator => null;

		protected event UpdateBonesDelegate _UpdateLocal
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected event UpdateBonesDelegate _UpdateWorld
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected event UpdateBonesDelegate _UpdateComplete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event UpdateBonesDelegate UpdateLocal
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UpdateBonesDelegate UpdateWorld
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UpdateBonesDelegate UpdateComplete
		{
			add
			{
			}
			remove
			{
			}
		}

		public override void Initialize(bool overwrite)
		{
		}

		public void Update()
		{
		}
	}
}
