using System;
using System.Runtime.CompilerServices;
using Gaa;
using UnityEngine;

public class GaaIapCallbackManager : MonoBehaviour
{
	public static event Action<bool> ServiceAvailableEvent
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

	public static event Action<IapResult> PurchaseClientStateEvent
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

	public static event Action<PurchaseData, string, int, int> PurchaseUpdatedSuccessEvent
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

	public static event Action<IapResult> PurchaseUpdatedErrorEvent
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

	public static event Action<PurchaseData, string, int, int> QueryPurchasesSuccessEvent
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

	public static event Action<IapResult> QueryPurchasesErrorEvent
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

	public static event Action<ProductDetail, int, int> ProductDetailsSuccessEvent
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

	public static event Action<IapResult> ProductDetailsErrorEvent
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

	public static event Action<PurchaseData> ConsumeSuccessEvent
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

	public static event Action<IapResult> ConsumeErrorEvent
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

	public static event Action<PurchaseData> AcknowledgeSuccessEvent
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

	public static event Action<IapResult> AcknowledgeErrorEvent
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

	public static event Action<PurchaseData, string> RecurringSuccessEvent
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

	public static event Action<IapResult> RecurringErrorEvent
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

	public static event Action<string> StoreInfoEvent
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

	public static event Action<IapResult> LoginFlowEvent
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

	public static event Action<IapResult> UpdateOrInstallFlowEvent
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

	public void PurchaseClientStateListener(string result)
	{
	}

	public void PurchaseUpdatedListener(string result)
	{
	}

	public void QueryPurchaseListener(string result)
	{
	}

	public void ProductDetailsListener(string result)
	{
	}

	public void ConsumeListener(string result)
	{
	}

	public void AcknowledgeListener(string result)
	{
	}

	public void RecurringProductListener(string result)
	{
	}

	public void StoreInfoListener(string result)
	{
	}

	public void LoginFlowListener(string result)
	{
	}

	public void UpdateOrInstallListener(string result)
	{
	}
}
