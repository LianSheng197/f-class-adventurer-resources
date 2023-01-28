using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaa;
using UnityEngine;

public class OneStoreBillingV7 : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStartConnectService_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OneStoreBillingV7 _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CStartConnectService_003Ed__6(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private string _devPayload;

	private string _base64EncodedPublicKey;

	private static OneStoreBillingV7 _instance;

	private void InitCallback()
	{
	}

	private void OnDestroy()
	{
	}

	public static OneStoreBillingV7 GetInstance()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CStartConnectService_003Ed__6))]
	private IEnumerator StartConnectService()
	{
		return null;
	}

	public void StartConnection()
	{
	}

	public void InAppInit(bool callback = false)
	{
	}

	public void RequestRestore()
	{
	}

	public void buyProduct(string productId)
	{
	}

	public void Consume(string productJsonData)
	{
	}

	public static void buyProduct(string _productId, string _productType, string _payload)
	{
	}

	public void SendLog(string tag, string message)
	{
	}

	private void OnLoadingVisibility(bool visibility)
	{
	}

	private void PurchaseClientStateResponse(IapResult iapResult)
	{
	}

	private void OnPurchaseUpdatedResponse(List<PurchaseData> purchases, List<string> signatures)
	{
	}

	private void OnQueryPurchasesResponse(List<PurchaseData> purchases, List<string> signatures)
	{
	}

	private void ParsePurchaseData(string func, List<PurchaseData> purchases, List<string> signatures)
	{
	}

	private void OnProductDetailsResponse(List<ProductDetail> products)
	{
	}

	private void OnConsumeSuccessResponse(PurchaseData purchaseData)
	{
	}

	private void OnAcknowledgeSuccessResponse(PurchaseData purchaseData)
	{
	}

	private void OnManageRecurringResponse(PurchaseData purchaseData, string action)
	{
	}
}
