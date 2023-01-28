namespace WebSocketSharp.Net
{
	public class NetworkCredential
	{
		private string _domain;

		private string _password;

		private string[] _roles;

		private string _userName;

		public string Domain
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string Password
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string[] Roles
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string UserName
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public NetworkCredential(string userName, string password)
		{
		}

		public NetworkCredential(string userName, string password, string domain, params string[] roles)
		{
		}
	}
}
