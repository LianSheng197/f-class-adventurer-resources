using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal class DisabledMetricsFactory : IMetricsFactory, IServiceComponent
	{
		private IReadOnlyDictionary<string, string> Unity_002EServices_002ECore_002ETelemetry_002EInternal_002EIMetricsFactory_002ECommonTags
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		private IMetrics Unity_002EServices_002ECore_002ETelemetry_002EInternal_002EIMetricsFactory_002ECreate(string packageName)
		{
			return null;
		}
	}
}
