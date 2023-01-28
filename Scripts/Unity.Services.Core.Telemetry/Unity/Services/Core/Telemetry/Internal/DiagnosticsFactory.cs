using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal class DiagnosticsFactory : IDiagnosticsFactory, IServiceComponent
	{
		private readonly IProjectConfiguration m_ProjectConfig;

		public IReadOnlyDictionary<string, string> CommonTags
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal DiagnosticsHandler Handler
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public DiagnosticsFactory(DiagnosticsHandler handler, IProjectConfiguration projectConfig)
		{
		}

		public IDiagnostics Create(string packageName)
		{
			return null;
		}
	}
}
