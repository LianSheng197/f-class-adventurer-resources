namespace CodeStage.AntiCheat.Storage
{
	public enum ObscuredFileErrorCode : byte
	{
		NoError = 0,
		FileNotFound = 5,
		FileDamaged = 10,
		DataIsNotLocked = 15,
		NotInitialized = 20,
		OtherException = 250
	}
}
