using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.FakeApi.Settings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }
    }
}
