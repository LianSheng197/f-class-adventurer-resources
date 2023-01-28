using System.Threading.Tasks;

namespace Firebase.Auth
{
	public static class GameCenterAuthProvider
	{
		public static string ProviderId => null;

		static GameCenterAuthProvider()
		{
		}

		public static Task<Credential> GetCredentialAsync()
		{
			return null;
		}

		public static bool IsPlayerAuthenticated()
		{
			return false;
		}
	}
}
