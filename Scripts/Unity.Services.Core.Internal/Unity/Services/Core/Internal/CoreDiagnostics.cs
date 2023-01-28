using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Unity.Services.Core.Telemetry.Internal;

namespace Unity.Services.Core.Internal
{
	internal class CoreDiagnostics
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CSendCoreDiagnosticsAsync_003Ed__24 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public CoreDiagnostics _003C_003E4__this;

			public string diagnosticName;

			public Exception exception;

			private TaskAwaiter<IDiagnostics> _003C_003Eu__1;

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
		private struct _003CGetOrCreateDiagnosticsAsync_003Ed__26 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IDiagnostics> _003C_003Et__builder;

			public CoreDiagnostics _003C_003E4__this;

			private TaskAwaiter<IDiagnosticsFactory> _003C_003Eu__1;

			private TaskAwaiter<string> _003C_003Eu__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		internal const string CorePackageName = "com.unity.services.core";

		internal const string CircularDependencyDiagnosticName = "circular_dependency";

		internal const string CorePackageInitDiagnosticName = "core_package_init";

		internal const string OperateServicesInitDiagnosticName = "operate_services_init";

		internal const string ProjectConfigTagName = "project_config";

		public static CoreDiagnostics Instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public IDictionary<string, string> CoreTags
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal IDiagnosticsComponentProvider DiagnosticsComponentProvider
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

		internal IDiagnostics Diagnostics
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

		public void SetProjectConfiguration(string serializedProjectConfig)
		{
		}

		public void SendCircularDependencyDiagnostics(Exception exception)
		{
		}

		public void SendCorePackageInitDiagnostics(Exception exception)
		{
		}

		public void SendOperateServicesInitDiagnostics(Exception exception)
		{
		}

		[AsyncStateMachine(typeof(_003CSendCoreDiagnosticsAsync_003Ed__24))]
		internal Task SendCoreDiagnosticsAsync(string diagnosticName, Exception exception)
		{
			return null;
		}

		private static void OnSendFailed(Task failedSendTask)
		{
		}

		[AsyncStateMachine(typeof(_003CGetOrCreateDiagnosticsAsync_003Ed__26))]
		internal Task<IDiagnostics> GetOrCreateDiagnosticsAsync()
		{
			return null;
		}
	}
}
