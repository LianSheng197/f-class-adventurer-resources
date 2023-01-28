using System.Net.Security;
using System.Security.Authentication;

namespace WebSocketSharp.Net
{
	public abstract class SslConfiguration
	{
		private LocalCertificateSelectionCallback _certSelectionCallback;

		private RemoteCertificateValidationCallback _certValidationCallback;

		private bool _checkCertRevocation;

		private SslProtocols _enabledProtocols;

		protected LocalCertificateSelectionCallback CertificateSelectionCallback
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected RemoteCertificateValidationCallback CertificateValidationCallback
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool CheckCertificateRevocation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public SslProtocols EnabledSslProtocols
		{
			get
			{
				return default(SslProtocols);
			}
			set
			{
			}
		}

		protected SslConfiguration(SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
		}
	}
}
