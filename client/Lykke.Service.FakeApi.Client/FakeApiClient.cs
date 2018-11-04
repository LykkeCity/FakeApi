using Lykke.HttpClientGenerator;

namespace Lykke.Service.FakeApi.Client
{
    /// <summary>
    /// FakeApi API aggregating interface.
    /// </summary>
    public class FakeApiClient : IFakeApiClient
    {
        // Note: Add similar Api properties for each new service controller

        /// <summary>Inerface to FakeApi Api.</summary>
        public IFakeApiApi Api { get; private set; }

        /// <summary>C-tor</summary>
        public FakeApiClient(IHttpClientGenerator httpClientGenerator)
        {
            Api = httpClientGenerator.Generate<IFakeApiApi>();
        }
    }
}
