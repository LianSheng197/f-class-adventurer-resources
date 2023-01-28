using UnityEngine;

namespace Spine.Unity
{
	[RequireComponent(typeof(SkeletonUtilityBone))]
	[ExecuteInEditMode]
	public abstract class SkeletonUtilityConstraint : MonoBehaviour
	{
		protected SkeletonUtilityBone utilBone;

		protected SkeletonUtility skeletonUtility;

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public abstract void DoUpdate();
	}
}
