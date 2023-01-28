using System;

namespace CodeStage.AntiCheat.Storage
{
	internal class UnsupportedDataTypeException : Exception
	{
		public UnsupportedDataTypeException(Type type)
		{
		}
	}
}
