using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Unity.Services.Core.Configuration;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Device;
using Unity.Services.Core.Environments.Internal;
using Unity.Services.Core.Internal;
using Unity.Services.Core.Scheduler.Internal;
using Unity.Services.Core.Telemetry.Internal;
using Unity.Services.Core.Threading.Internal;
using UnityEngine;

namespace Unity.Services.Core.Registration
{
	internal class CorePackageInitializer : IInitializablePackage, IDiagnosticsComponentProvider
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003C_003Ec__DisplayClass40_0
		{
			public CoreRegistry registry;

			public CorePackageInitializer _003C_003E4__this;
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CInitialize_003Ed__40 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public CoreRegistry registry;

			public CorePackageInitializer _003C_003E4__this;

			private _003C_003Ec__DisplayClass40_0 _003C_003E8__1;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CInitializeProjectConfigAsync_003Ed__45 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public CorePackageInitializer _003C_003E4__this;

			public InitializationOptions options;

			private TaskAwaiter<ProjectConfiguration> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CGenerateProjectConfigurationAsync_003Ed__46 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ProjectConfiguration> _003C_003Et__builder;

			public InitializationOptions options;

			private TaskAwaiter<SerializableProjectConfiguration> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CGetSerializedConfigOrEmptyAsync_003Ed__47 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<SerializableProjectConfiguration> _003C_003Et__builder;

			private TaskAwaiter<SerializableProjectConfiguration> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CCreateDiagnosticsComponents_003Ed__54 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IDiagnosticsFactory> _003C_003Et__builder;

			public CorePackageInitializer _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CGetSerializedProjectConfigurationAsync_003Ed__56 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public CorePackageInitializer _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private InitializationOptions m_CurrentInitializationOptions;

		internal ActionScheduler ActionScheduler
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal InstallationId InstallationId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal ProjectConfiguration ProjectConfig
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal Unity.Services.Core.Environments.Internal.Environments Environments
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal ExternalUserId ExternalUserId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal ICloudProjectId CloudProjectId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal IDiagnosticsFactory DiagnosticsFactory
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal IMetricsFactory MetricsFactory
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal UnityThreadUtilsInternal UnityThreadUtils
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void Register()
		{
		}

		[AsyncStateMachine(typeof(_003CInitialize_003Ed__40))]
		public Task Initialize(CoreRegistry registry)
		{
			return null;
		}

		private bool HaveInitOptionsChanged()
		{
			return false;
		}

		private void FreeOptionsDependantComponents()
		{
		}

		internal void InitializeInstallationId()
		{
		}

		internal void InitializeActionScheduler()
		{
		}

		[AsyncStateMachine(typeof(_003CInitializeProjectConfigAsync_003Ed__45))]
		internal Task InitializeProjectConfigAsync([NotNull] InitializationOptions options)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGenerateProjectConfigurationAsync_003Ed__46))]
		internal static Task<ProjectConfiguration> GenerateProjectConfigurationAsync([NotNull] InitializationOptions options)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetSerializedConfigOrEmptyAsync_003Ed__47))]
		internal static Task<SerializableProjectConfiguration> GetSerializedConfigOrEmptyAsync()
		{
			return null;
		}

		internal void InitializeExternalUserId(IProjectConfiguration projectConfiguration)
		{
		}

		internal void InitializeEnvironments(IProjectConfiguration projectConfiguration)
		{
		}

		internal void InitializeCloudProjectId(ICloudProjectId cloudProjectId = null)
		{
		}

		internal void InitializeDiagnostics(IActionScheduler scheduler, IProjectConfiguration projectConfiguration, ICloudProjectId cloudProjectId, IEnvironments environments)
		{
		}

		internal void InitializeMetrics(IActionScheduler scheduler, IProjectConfiguration projectConfiguration, ICloudProjectId cloudProjectId, IEnvironments environments)
		{
		}

		internal void InitializeUnityThreadUtils()
		{
		}

		[AsyncStateMachine(typeof(_003CCreateDiagnosticsComponents_003Ed__54))]
		public Task<IDiagnosticsFactory> CreateDiagnosticsComponents()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetSerializedProjectConfigurationAsync_003Ed__56))]
		public Task<string> GetSerializedProjectConfigurationAsync()
		{
			return null;
		}
	}
}
