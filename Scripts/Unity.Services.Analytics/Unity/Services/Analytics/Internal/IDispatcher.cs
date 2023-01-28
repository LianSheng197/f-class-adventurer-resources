using System.Threading.Tasks;

namespace Unity.Services.Analytics.Internal
{
	internal interface IDispatcher
	{
		string CollectUrl { get; set; }

		Task Flush();
	}
}
