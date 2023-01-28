using System;
using System.Collections.Generic;
using System.Threading;
using Moments.Encoder;
using UnityEngine;

public class SPUM_Exporter : MonoBehaviour
{
	public enum UnitType
	{
		SwordMan = 0,
		BowMan = 1,
		Magician = 2
	}

	public GameObject _unitPrefab;

	public string _imageName;

	public UnitType _unitType;

	public bool _separated;

	public string _sepaName;

	public Vector2 _imageSize;

	public Vector2 _fullSize;

	public float _scaleFactor;

	public int _frameRate;

	public int _frameNumber;

	public bool _advanced;

	private int ImageNumber;

	public Camera _camera;

	public Animator _anim;

	public Transform _objectPivot;

	public GameObject _objectNow;

	public RectTransform _imgBG;

	public GameObject _bgSet;

	public int frameNowNumber;

	public int _animNum;

	public float timer;

	public float timerForSave;

	public bool useTimer;

	public bool _netAnimClip;

	public int animNum;

	public AnimationClip[] animationClips;

	public List<string> _animNameList;

	public List<string> _animNameNow;

	public List<Texture2D> _textSaveList;

	private Queue<RenderTexture> m_Frames;

	public ThreadPriority WorkerPriority;

	public Action<int, string> OnFileSaved;

	public Action<int, float> OnFileSaveProgress;

	public bool _gifExportUse;

	public Color _gifBGColor;

	public bool _gifUseTransparancy;

	public Color _gifAlphaBGColor;

	public float _gifDelay;

	public int _gifQuality;

	public int _gifRepeatNum;

	private Texture2D imageSave;

	private bool takeHiResShot;

	public void StartExport()
	{
	}

	public void CheckObjNow()
	{
	}

	public void MakeObjNow()
	{
	}

	public void TakeHiResShot()
	{
	}

	public void SetScreenShot()
	{
	}

	public void MakeScreenShotFile()
	{
	}

	public void MakeGifAnimation()
	{
	}

	private void PreProcess()
	{
	}

	private GifFrame ToGifFrame(Texture2D source, Texture2D target)
	{
		return null;
	}

	public void PrintEndMessage()
	{
	}

	public static Texture2D FillColorAlpha(Texture2D tex2D, Color32? fillColor = null)
	{
		return null;
	}
}
