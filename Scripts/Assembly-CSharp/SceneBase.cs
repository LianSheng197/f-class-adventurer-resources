using UnityEngine;

public class SceneBase : MonoBehaviour
{
	public GameObject _root;

	private LetterBox _letterBox;

	public AttachTopUI _attachTopUI;

	private void Awake()
	{
	}

	private void InitBase()
	{
	}

	public void UpdateALLUIPlaySoundVolume(float volume)
	{
	}

	private void InitLetterBox()
	{
	}

	public void UpdateLetterBox()
	{
	}

	public LetterBox GetLetterBox()
	{
		return null;
	}

	public void UpdateName()
	{
	}

	public void UpdateTeamLevel()
	{
	}

	public void UpdateCurrency()
	{
	}

	public void UpdateNew()
	{
	}

	public void UpdateTopUI()
	{
	}

	public void UpdateCharacterIcon()
	{
	}

	public virtual void InitScene()
	{
	}

	public virtual void EnterScene()
	{
	}

	public virtual void ExitScene()
	{
	}

	public virtual void InitSceneStart()
	{
	}

	public virtual void InitSceneEnd()
	{
	}

	public virtual void EnterSceneStart()
	{
	}

	public virtual void EnterSceneEnd()
	{
	}

	public virtual void PauseScene()
	{
	}

	public virtual void ResumeScene()
	{
	}

	public virtual void ApplicationQuit()
	{
	}

	public virtual bool AndroidBackButton()
	{
		return false;
	}
}
