using System.Collections.Generic;

namespace Spine
{
	public class Skin
	{
		public struct AttachmentKeyTuple
		{
			public readonly int slotIndex;

			public readonly string name;

			internal readonly int nameHashCode;

			public AttachmentKeyTuple(int slotIndex, string name)
			{
			}
		}

		private class AttachmentKeyTupleComparer : IEqualityComparer<AttachmentKeyTuple>
		{
			internal static readonly AttachmentKeyTupleComparer Instance;

			private bool System_002ECollections_002EGeneric_002EIEqualityComparer_003CSpine_002ESkin_002EAttachmentKeyTuple_003E_002EEquals(AttachmentKeyTuple o1, AttachmentKeyTuple o2)
			{
				return false;
			}

			private int System_002ECollections_002EGeneric_002EIEqualityComparer_003CSpine_002ESkin_002EAttachmentKeyTuple_003E_002EGetHashCode(AttachmentKeyTuple o)
			{
				return 0;
			}
		}

		internal string name;

		private Dictionary<AttachmentKeyTuple, Attachment> attachments;

		public string Name => null;

		public Dictionary<AttachmentKeyTuple, Attachment> Attachments => null;

		public Skin(string name)
		{
		}

		public void AddAttachment(int slotIndex, string name, Attachment attachment)
		{
		}

		public Attachment GetAttachment(int slotIndex, string name)
		{
			return null;
		}

		public void FindNamesForSlot(int slotIndex, List<string> names)
		{
		}

		public void FindAttachmentsForSlot(int slotIndex, List<Attachment> attachments)
		{
		}

		public override string ToString()
		{
			return null;
		}

		internal void AttachAll(Skeleton skeleton, Skin oldSkin)
		{
		}
	}
}
