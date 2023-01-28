using UnityEngine;

public class Tutorial : MonoBehaviour
{
	public enum Type
	{
		None = 0,
		Max = 1
	}

	public delegate void TutorialEnd();

	private static Tutorial _instance;

	private TutorialEnd _tutorialEnd;

	private GameObject _tutorialPrefabRoot;

	private GameObject _tutorialObj;

	public static Tutorial Instance => null;

	public bool IsClear(Type type)
	{
		return false;
	}

	public bool IsTutorial()
	{
		return false;
	}

	public void Clear(Type type)
	{
	}

	public bool CloseTutorial()
	{
		return false;
	}

	private void MakePrefabRoot()
	{
	}

	public void AddTutorialPrefab(Type type, TutorialEnd tutorialEnd = null)
	{
	}

	private void Message(UIButton btn)
	{
	}
}
