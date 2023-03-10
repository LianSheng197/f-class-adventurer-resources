using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Unity.Services.Core.Telemetry.Internal
{
	[Serializable]
	internal struct DiagnosticsPayload : ITelemetryPayload
	{
		[JsonProperty("diagnostics")]
		public List<Diagnostic> Diagnostics;

		[JsonProperty("commonTags")]
		public Dictionary<string, string> CommonTags;

		[JsonProperty("diagnosticsCommonTags")]
		public Dictionary<string, string> DiagnosticsCommonTags;

		private Dictionary<string, string> Unity_002EServices_002ECore_002ETelemetry_002EInternal_002EITelemetryPayload_002ECommonTags => null;

		private int Unity_002EServices_002ECore_002ETelemetry_002EInternal_002EITelemetryPayload_002ECount => 0;

		private void Unity_002EServices_002ECore_002ETelemetry_002EInternal_002EITelemetryPayload_002EAdd(ITelemetryEvent telemetryEvent)
		{
		}
	}
}
