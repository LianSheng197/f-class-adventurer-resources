using System;
using UnityEngine;

[Serializable]
public class SerializableDecimal : ISerializationCallbackReceiver
{
	[SerializeField]
	private string inspectorField;

	[HideInInspector]
	public decimal value;

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}
}
