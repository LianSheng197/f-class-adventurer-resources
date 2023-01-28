using UnityEngine;
using UnityEngine.UI;

namespace SRF.UI
{
	[RequireComponent(typeof(CanvasScaler))]
	[AddComponentMenu("SRF/UI/Retina Scaler")]
	public class SRRetinaScaler : SRMonoBehaviour
	{
		[SerializeField]
		private bool _disablePixelPerfect;

		[SerializeField]
		private int _designDpi;

		private float _lastDpi;

		private void Start()
		{
		}

		private void ApplyScaling()
		{
		}

		private void Update()
		{
		}
	}
}
