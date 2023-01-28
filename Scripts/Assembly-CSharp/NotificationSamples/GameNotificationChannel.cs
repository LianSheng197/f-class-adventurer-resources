namespace NotificationSamples
{
	public struct GameNotificationChannel
	{
		public enum NotificationStyle
		{
			None = 0,
			NoSound = 2,
			Default = 3,
			Popup = 4
		}

		public enum PrivacyMode
		{
			Secret = -1,
			Private = 0,
			Public = 1
		}

		public readonly string Id;

		public readonly string Name;

		public readonly string Description;

		public readonly bool ShowsBadge;

		public readonly bool ShowLights;

		public readonly bool Vibrates;

		public readonly bool HighPriority;

		public readonly NotificationStyle Style;

		public readonly PrivacyMode Privacy;

		public readonly int[] VibrationPattern;

		public GameNotificationChannel(string id, string name, string description)
		{
		}

		public GameNotificationChannel(string id, string name, string description, NotificationStyle style, bool showsBadge = true, bool showLights = false, bool vibrates = true, bool highPriority = false, PrivacyMode privacy = PrivacyMode.Public, long[] vibrationPattern = null)
		{
		}
	}
}
