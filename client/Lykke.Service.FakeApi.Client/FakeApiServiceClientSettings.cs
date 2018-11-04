using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.FakeApi.Client 
{
    /// <summary>
    /// FakeApi client settings.
    /// </summary>
    public class FakeApiServiceClientSettings 
    {
        /// <summary>Service url.</summary>
        [HttpCheck("api/isalive")]
        public string ServiceUrl {get; set;}
    }
}
