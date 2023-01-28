using UnityEngine;

public class IronSourceMediationSettings : ScriptableObject
{
	public static readonly string IRONSOURCE_SETTINGS_ASSET_PATH;

	[Tooltip("Add your application AppKeys, as provided in Ironsource Platform")]
	[Header("Ironsource AppKey")]
	public string AndroidAppKey;

	[Tooltip("Add your application AppKeys, as provided in Ironsource Platform")]
	public string IOSAppKey;

	[Tooltip("Use this flag when you wish to initialize all ad units (recommended)")]
	[Header("Automatic Initialization")]
	public bool EnableIronsourceSDKInitAPI;

	[Tooltip("Add Ironsource SKAdNetworkIdentifier to your Info.plist for iOS 14+")]
	[Header("Ironsource SKAdNetwork ID")]
	public bool AddIronsourceSkadnetworkID;

	[Tooltip("Add Google Play Services normal permission for API level 31 (Android 12)")]
	[Header("Google Play Services Settings")]
	public bool DeclareAD_IDPermission;

	[Header("Project Features")]
	public bool EnableAdapterDebug;

	public bool EnableIntegrationHelper;
}
