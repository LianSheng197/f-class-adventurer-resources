using System.Threading.Tasks;
using Firebase.Auth;
using UnityEngine;

public class FirebaseManager : MonoBehaviour
{
	private static FirebaseManager instance;

	private bool isInit;

	private bool isProcessing;

	private FirebaseAuth mAuth;

	public static string mIdToken;

	public static string mUserId;

	public static string mEmail;

	public static FirebaseManager Instance => null;

	public void Init()
	{
	}

	public bool IsInit()
	{
		return false;
	}

	public void SignInWithGoogle(bool linkWithCurrentAnonUser)
	{
	}

	private void HandleGoogleSignResult(Task<FirebaseUser> task)
	{
	}

	public void SendIntegrationGoogleSign()
	{
	}
}
