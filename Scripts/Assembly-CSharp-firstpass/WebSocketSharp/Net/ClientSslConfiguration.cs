using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace WebSocketSharp.Net
{
	public class ClientSslConfiguration : SslConfiguration
	{
		private X509CertificateCollection _certs;

		private string _host;

		public X509CertificateCollection ClientCertificates
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocalCertificateSelectionCallback ClientCertificateSelectionCallback
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RemoteCertificateValidationCallback ServerCertificateValidationCallback
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TargetHost
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ClientSslConfiguration(string targetHost)
			: base(default(SslProtocols), checkCertificateRevocation: false)
		{
		}

		public ClientSslConfiguration(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
			: base(default(SslProtocols), checkCertificateRevocation: false)
		{
		}
	}
}
