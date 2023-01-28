using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PlayerManager : MonoBehaviour
{
	public enum ScreenShotSize
	{
		HD = 0,
		FHD = 1,
		UHD = 2
	}

	public PlayerObj _prefabObj;

	public List<GameObject> _savedUnitList;

	public Vector2 _startPos;

	public Vector2 _addPos;

	public int _columnNum;

	public Transform _playerPool;

	public List<PlayerObj> _playerList;

	public PlayerObj _nowObj;

	public Transform _playerObjCircle;

	public Transform _goalObjCircle;

	public Camera _camera;

	private Texture2D imageSave;

	public bool _generate;

	public GameObject _bg;

	public bool _screenShot;

	public ScreenShotSize _screenShotSize;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void GetPlayerList()
	{
	}

	public void SetScreenShot()
	{
	}
}
