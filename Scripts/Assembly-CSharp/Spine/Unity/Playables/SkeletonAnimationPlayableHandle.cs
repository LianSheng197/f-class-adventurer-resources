using UnityEngine;

namespace Spine.Unity.Playables
{
	[AddComponentMenu("Spine/Playables/SkeletonAnimation Playable Handle (Playables)")]
	public class SkeletonAnimationPlayableHandle : SpinePlayableHandleBase
	{
		public SkeletonAnimation skeletonAnimation;

		public override Skeleton Skeleton => null;

		public override SkeletonData SkeletonData => null;
	}
}
