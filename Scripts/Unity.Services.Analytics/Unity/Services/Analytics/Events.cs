using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Unity.Services.Analytics
{
	[Obsolete("The interface provided by this static class has moved to AnalyticsService.Instance, and should be accessed from there instead. This API will be removed in an upcoming release.")]
	public static class Events
	{
		[Obsolete("This enum has been moved outside the Events class. Please use that instead. This enum will be removed in an upcoming release.")]
		public enum AdCompletionStatus
		{
			Completed = 0,
			Partial = 1,
			Incomplete = 2
		}

		[Obsolete("This enum has been moved outside the Events class. Please use that instead. This enum will be removed in an upcoming release.")]
		public enum AdProvider
		{
			AdColony = 0,
			AdMob = 1,
			Amazon = 2,
			AppLovin = 3,
			ChartBoost = 4,
			Facebook = 5,
			Fyber = 6,
			Hyprmx = 7,
			Inmobi = 8,
			Maio = 9,
			Pangle = 10,
			Tapjoy = 11,
			UnityAds = 12,
			Vungle = 13,
			IrnSource = 14,
			Other = 15
		}

		[Obsolete("This class has been aligned with other interfaces. Please use AdImpressionParameters with the AnalyticsService.Instance API instead. This class will be removed in an upcoming release")]
		public class AdImpressionArgs
		{
			public AdCompletionStatus AdCompletionStatus
			{
				[CompilerGenerated]
				get
				{
					return default(AdCompletionStatus);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public AdProvider AdProvider
			{
				[CompilerGenerated]
				get
				{
					return default(AdProvider);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string PlacementID
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string PlacementName
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string PlacementType
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public double? AdEcpmUsd
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string SdkVersion
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string AdImpressionID
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string AdStoreDstID
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string AdMediaType
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public long? AdTimeWatchedMs
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public long? AdTimeCloseButtonShownMs
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public long? AdLengthMs
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public bool? AdHasClicked
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string AdSource
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string AdStatusCallback
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public AdImpressionArgs(AdCompletionStatus adCompletionStatus, AdProvider adProvider, string placementID, string placementName)
			{
			}
		}

		[Obsolete("This enum has been moved outside the Events class, the standalone enum should be used instead. This enum will be removed in an upcoming release.")]
		public enum TransactionServer
		{
			APPLE = 0,
			AMAZON = 1,
			GOOGLE = 2
		}

		[Obsolete("This enum has been moved outside the Events class, the standalone enum should be used instead. This enum will be removed in an upcoming release.")]
		public enum TransactionType
		{
			INVALID = 0,
			SALE = 1,
			PURCHASE = 2,
			TRADE = 3
		}

		[Obsolete("This struct has been moved outside the Events class, and it's parameters now conform to C# guidelines. Please use the standalone struct instead. This struct will be removed in an upcoming release.")]
		public struct Item
		{
			public string itemName;

			public string itemType;

			public long itemAmount;
		}

		[Obsolete("This struct has been moved outside the Events class, and it's parameters now conform to C# guidelines. Please use the standalone struct instead. This struct will be removed in an upcoming release.")]
		public struct VirtualCurrency
		{
			public string virtualCurrencyName;

			public string virtualCurrencyType;

			public long virtualCurrencyAmount;
		}

		[Obsolete("This struct has been moved outside the Events class, and it's parameters now conform to C# guidelines. Please use the standalone struct instead. This struct will be removed in an upcoming release.")]
		public struct RealCurrency
		{
			public string realCurrencyType;

			public long realCurrencyAmount;
		}

		[Obsolete("This struct has been moved outside the Events class, and it's parameters now conform to C# guidelines. Please use the standalone struct instead. This struct will be removed in an upcoming release.")]
		public struct Product
		{
			public RealCurrency? realCurrency;

			public List<VirtualCurrency> virtualCurrencies;

			public List<Item> items;
		}

		[Obsolete("This struct has been moved outside the Events class, and it's parameters now conform to C# guidelines. Please use the standalone struct instead. This struct will be removed in an upcoming release.")]
		public struct TransactionParameters
		{
			[Obsolete]
			public bool? isInitiator;

			public string paymentCountry;

			public string productID;

			public long? revenueValidated;

			public string transactionID;

			public string transactionReceipt;

			public string transactionReceiptSignature;

			public TransactionServer? transactionServer;

			public string transactorID;

			public string storeItemSkuID;

			public string storeItemID;

			public string storeID;

			public string storeSourceID;

			public string transactionName;

			public TransactionType transactionType;

			public Product productsReceived;

			public Product productsSpent;
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CCheckForRequiredConsents_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<List<string>> _003C_003Et__builder;

			private TaskAwaiter<List<string>> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Obsolete("The interface provided by this field has moved to AnalyticsService.Instance.PrivacyUrl, and should be accessed from there instead. This API will be removed in an upcoming release.")]
		public static readonly string PrivacyUrl;

		[Obsolete("The interface provided by this method has moved to AnalyticsService.Instance.AdImpression, and should be accessed from there instead. This API will be removed in an upcoming release.")]
		public static void AdImpression(AdImpressionArgs args)
		{
		}

		[Obsolete("The interface provided by this method has moved to AnalyticsService.Instance.CheckForRequiredConsents, and should be accessed from there instead. This API will be removed in an upcoming release.")]
		[AsyncStateMachine(typeof(_003CCheckForRequiredConsents_003Ed__4))]
		public static Task<List<string>> CheckForRequiredConsents()
		{
			return null;
		}

		[Obsolete("The interface provided by this method has moved to AnalyticsService.Instance.ProvideOptInConsent, and should be accessed from there instead. This API will be removed in an upcoming release.")]
		public static void ProvideOptInConsent(string identifier, bool consent)
		{
		}

		[Obsolete("The interface provided by this method has moved to AnalyticsService.Instance.CustomData, and should be accessed from there instead. This API will be removed in an upcoming release.")]
		public static void CustomData(string eventName, IDictionary<string, object> eventParams)
		{
		}

		[Obsolete("The interface provided by this method has moved to AnalyticsService.Instance.OptOut, and should be accessed from there instead. This API will be removed in an upcoming release.")]
		public static void OptOut()
		{
		}

		[Obsolete("The interface provided by this method has moved to AnalyticsService.Instance.Flush, and should be accessed from there instead. This API will be removed in an upcoming release.")]
		public static void Flush()
		{
		}

		[Obsolete("The interface provided by this method has moved to AnalyticsService.Instance.Transaction, and should be accessed from there instead. This API will be removed in an upcoming release.")]
		public static void Transaction(TransactionParameters transactionParameters)
		{
		}

		private static Unity.Services.Analytics.Product ConvertProduct(Product from)
		{
			return default(Unity.Services.Analytics.Product);
		}

		private static List<Unity.Services.Analytics.Item> ConvertItems(List<Item> from)
		{
			return null;
		}
	}
}
