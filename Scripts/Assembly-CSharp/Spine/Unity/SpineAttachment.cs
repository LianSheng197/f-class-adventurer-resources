namespace Spine.Unity
{
	public class SpineAttachment : SpineAttributeBase
	{
		public struct Hierarchy
		{
			public string skin;

			public string slot;

			public string name;

			public Hierarchy(string fullPath)
			{
			}
		}

		public bool returnAttachmentPath;

		public bool currentSkinOnly;

		public bool placeholdersOnly;

		public string skinField;

		public string slotField;

		public SpineAttachment(bool currentSkinOnly = true, bool returnAttachmentPath = false, bool placeholdersOnly = false, string slotField = "", string dataField = "", string skinField = "", bool includeNone = true, bool fallbackToTextField = false)
		{
		}

		public static Hierarchy GetHierarchy(string fullPath)
		{
			return default(Hierarchy);
		}

		public static Attachment GetAttachment(string attachmentPath, SkeletonData skeletonData)
		{
			return null;
		}

		public static Attachment GetAttachment(string attachmentPath, SkeletonDataAsset skeletonDataAsset)
		{
			return null;
		}
	}
}
