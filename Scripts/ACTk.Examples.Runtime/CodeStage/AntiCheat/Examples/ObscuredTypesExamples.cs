using System.Text;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

namespace CodeStage.AntiCheat.Examples
{
	internal class ObscuredTypesExamples : MonoBehaviour
	{
		[Header("Regular variables")]
		public string regularString;

		public int regularInt;

		public float regularFloat;

		public Vector3 regularVector3;

		[Header("Obscured (secure) variables")]
		public ObscuredString obscuredString;

		public ObscuredInt obscuredInt;

		public ObscuredFloat obscuredFloat;

		public ObscuredVector3 obscuredVector3;

		public ObscuredBool obscuredBool;

		public ObscuredLong obscuredLong;

		public ObscuredDouble obscuredDouble;

		public ObscuredVector2 obscuredVector2;

		public ObscuredDecimal obscuredDecimal;

		public ObscuredVector2Int obscuredVector2Int;

		public ObscuredVector3Int obscuredVector3Int;

		private readonly StringBuilder logBuilder;

		private string allSimpleObscuredTypes;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void RandomizeObscuredVars()
		{
		}

		private void ObscuredStringExample()
		{
		}

		private void ObscuredIntExample()
		{
		}

		public void DrawUI(ExamplesGUI examplesGUIInstance)
		{
		}

		private string Get()
		{
			return null;
		}
	}
}
