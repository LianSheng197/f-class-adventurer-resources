using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class DownLoadTexture : MonoBehaviour
{
	public class DownLoadData
	{
		public string _url;

		public UITexture _texture;

		public bool _fileSave;
	}

	[CompilerGenerated]
	private sealed class _003CStartDownloadTexture_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DownLoadTexture _003C_003E4__this;

		private UnityWebRequest _003Crequest_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CStartDownloadTexture_003Ed__21(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private static DownLoadTexture _instance;

	private Texture2D _defaultImage;

	private bool _isDownLoad;

	private const float _coolDownTime = 0.2f;

	private float _coolDown;

	private List<DownLoadData> _downLoadList;

	private DownLoadData _curDownLoad;

	private const string _downloadDir = "downloadTexture";

	private long _removeTerm;

	public static DownLoadTexture Instance => null;

	public void InitDownLoadTexture()
	{
	}

	public void Add(string url, UITexture tex, bool fileSave = false)
	{
	}

	private void Update()
	{
	}

	public void Download(DownLoadData data)
	{
	}

	private void EndDownLoad(Texture2D tex, bool isTween = true)
	{
	}

	public bool GetFullFileUrl(string root, string fullUrl, out string resultUrl)
	{
		resultUrl = null;
		return false;
	}

	public Texture2D LoadTexture(string filePath)
	{
		return null;
	}

	public bool RemoveImageWhereTerm(string filePath, long removeTermSec)
	{
		return false;
	}

	public void RemoveDirectoryWhereTerm(string dirPath, long removeTermSec)
	{
	}

	[IteratorStateMachine(typeof(_003CStartDownloadTexture_003Ed__21))]
	private IEnumerator StartDownloadTexture()
	{
		return null;
	}

	public void Remove()
	{
	}
}
