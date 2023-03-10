namespace Unity.Services.Core.Telemetry.Internal
{
	internal interface ICachePersister<TPayload> where TPayload : ITelemetryPayload
	{
		bool CanPersist { get; }

		void Persist(CachedPayload<TPayload> cache);

		bool TryFetch(out CachedPayload<TPayload> persistedCache);

		void Delete();
	}
}
