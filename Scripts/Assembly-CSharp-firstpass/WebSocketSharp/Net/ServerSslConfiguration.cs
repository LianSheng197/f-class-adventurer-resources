using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace WebSocketSharp.Net
{
	public class ServerSslConfiguration : SslConfiguration
	{
		private X509Certificate2 _cert;

		private bool _clientCertRequired;

		public bool ClientCertificateRequired
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public RemoteCertificateValidationCallback ClientCertificateValidationCallback
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public X509Certificate2 ServerCertificate
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ServerSslConfiguration(X509Certificate2 serverCertificate)
			: base(default(SslProtocols), checkCertificateRevocation: false)
		{
		}

		public ServerSslConfiguration(X509Certificate2 serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
			: base(default(SslProtocols), checkCertificateRevocation: false)
		{
		}
	}
}
