using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
	private static SoundManager _instance;

	private bool _initialize;

	private Dictionary<Sound, AudioClip> _soundList;

	private Dictionary<string, AudioClip> _soundNameList;

	private AudioSource _BGMPlayer;

	private AudioSource _SEPlayer;

	private float _BGMVolume;

	private float _SEVolume;

	private float _SEPlayTime;

	private Sound _curLoopSound;

	private Dictionary<string, BattleSEData> _battleSEList;

	public static AudioClip _buttonClickSound;

	public static SoundManager Instance => null;

	private void Update()
	{
	}

	private void UpdateBattleSE()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	public void InitSoundManager()
	{
	}

	public void LoadSound()
	{
	}

	public void UpdateButtonSound(GameObject obj)
	{
	}

	public AudioClip GetSound(Sound sound)
	{
		return null;
	}

	public float GetBGMVolume()
	{
		return 0f;
	}

	public void SetBGMVolume(float volume)
	{
	}

	public float GetSEVolume()
	{
		return 0f;
	}

	public void SetSEVolume(float volume)
	{
	}

	public void SaveVolum()
	{
	}

	public void PlaySE(Sound sound)
	{
	}

	public void PlayBattleSE(string folder, string name)
	{
	}

	public void PlayBattleSEOverlap(string folder, string name)
	{
	}

	public void PlaySE(string name)
	{
	}

	public void PlayCheckSE()
	{
	}

	public void StopAllSE()
	{
	}

	public Sound GetSound()
	{
		return default(Sound);
	}

	public void StopSound()
	{
	}

	public void PauseSound()
	{
	}

	public void ResumeSound()
	{
	}

	public void PlayBGM(Sound sound)
	{
	}
}
