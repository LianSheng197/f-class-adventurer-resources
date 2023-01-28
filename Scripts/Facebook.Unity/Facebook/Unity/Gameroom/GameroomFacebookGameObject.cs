using System.Collections;

namespace Facebook.Unity.Gameroom
{
	internal class GameroomFacebookGameObject : FacebookGameObject, IFacebookCallbackHandler
	{
		protected IGameroomFacebookImplementation GameroomFacebookImpl => null;

		public void WaitForResponse(GameroomFacebook.OnComplete onCompleteDelegate, string callbackId)
		{
		}

		protected override void OnAwake()
		{
		}

		private IEnumerator WaitForPipeResponse(GameroomFacebook.OnComplete onCompleteDelegate, string callbackId)
		{
			return null;
		}
	}
}
