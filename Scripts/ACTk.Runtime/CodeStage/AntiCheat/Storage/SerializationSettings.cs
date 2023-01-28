using System.Runtime.CompilerServices;

namespace CodeStage.AntiCheat.Storage
{
	internal class SerializationSettings
	{
		public ACTkSerializationKind SerializationKind
		{
			[CompilerGenerated]
			get
			{
				return default(ACTkSerializationKind);
			}
		}

		public SerializationSettings(ACTkSerializationKind serializationKind = ACTkSerializationKind.Binary)
		{
		}
	}
}
