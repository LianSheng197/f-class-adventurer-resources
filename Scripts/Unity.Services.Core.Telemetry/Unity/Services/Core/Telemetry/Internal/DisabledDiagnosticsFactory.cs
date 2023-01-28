using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal class DisabledDiagnosticsFactory : IDiagnosticsFactory, IServiceComponent
	{
		private IReadOnlyDictionary<string, string> Unity_002EServices_002ECore_002ETelemetry_002EInternal_002EIDiagnosticsFactory_002ECommonTags
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		private IDiagnostics Unity_002EServices_002ECore_002ETelemetry_002EInternal_002EIDiagnosticsFactory_002ECreate(string packageName)
		{
			return null;
		}
	}
}
