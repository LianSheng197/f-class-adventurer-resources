using UnityEngine;

namespace Spine.Unity
{
	[CreateAssetMenu(menuName = "Spine/Animation Reference Asset")]
	public class AnimationReferenceAsset : ScriptableObject, IHasSkeletonDataAsset
	{
		private const bool QuietSkeletonData = true;

		[SerializeField]
		protected SkeletonDataAsset skeletonDataAsset;

		[SpineAnimation(null, null, true, false)]
		[SerializeField]
		protected string animationName;

		private Animation animation;

		public SkeletonDataAsset SkeletonDataAsset => null;

		public Animation Animation => null;

		public void Initialize()
		{
		}

		public static implicit operator Animation(AnimationReferenceAsset asset)
		{
			return null;
		}
	}
}
