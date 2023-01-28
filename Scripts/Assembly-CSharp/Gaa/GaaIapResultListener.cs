using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gaa
{
	public class GaaIapResultListener : MonoBehaviour
	{
		private static string TAG;

		private List<PurchaseData> purchases;

		private List<string> signatures;

		private List<ProductDetail> products;

		public static event Action<bool> OnLoadingVisibility
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<IapResult> PurchaseClientStateResponse
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<List<ProductDetail>> OnProductDetailsResponse
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<List<PurchaseData>, List<string>> OnPurchaseUpdatedResponse
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<List<PurchaseData>, List<string>> OnQueryPurchasesResponse
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<PurchaseData> OnConsumeSuccessResponse
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<PurchaseData> OnAcknowledgeSuccessResponse
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<PurchaseData, string> OnManageRecurringResponse
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<string, string> SendLog
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void PurchaseClientStateEvent(IapResult iapResult)
		{
		}

		private void PurchaseUpdatedSuccessEvent(PurchaseData purchaseData, string signature, int count, int totalCount)
		{
		}

		private void PurchaseUpdatedErrorEvent(IapResult iapResult)
		{
		}

		private void QueryPurchasesSuccessEvent(PurchaseData purchaseData, string signature, int count, int totalCount)
		{
		}

		private void QueryPurchasesErrorEvent(IapResult iapResult)
		{
		}

		private void ProductDetailsSuccessEvent(ProductDetail productDetail, int count, int totalCount)
		{
		}

		private void ProductDetailsErrorEvent(IapResult iapResult)
		{
		}

		private void ConsumeSuccessEvent(PurchaseData purchaseData)
		{
		}

		private void ConsumeErrorEvent(IapResult iapResult)
		{
		}

		private void AcknowledgeSuccessEvent(PurchaseData purchaseData)
		{
		}

		private void AcknowledgeErrorEvent(IapResult iapResult)
		{
		}

		private void RecurringSuccessEvent(PurchaseData purchaseData, string action)
		{
		}

		private void RecurringErrorEvent(IapResult iapResult)
		{
		}

		private void StoreInfoEvent(string result)
		{
		}

		private void LoginFlowEvent(IapResult iapResult)
		{
		}

		private void UpdateOrInstallFlowEvent(IapResult iapResult)
		{
		}

		public static void HandleError(string tag, IapResult iapResult)
		{
		}

		private void BuyItemResult(PurchaseData result, bool isRestore)
		{
		}
	}
}
