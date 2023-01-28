using System;

namespace Firebase.Auth
{
	public interface IUserInfo
	{
		string DisplayName { get; }

		string Email { get; }

		Uri PhotoUrl { get; }

		string ProviderId { get; }

		string UserId { get; }
	}
}
