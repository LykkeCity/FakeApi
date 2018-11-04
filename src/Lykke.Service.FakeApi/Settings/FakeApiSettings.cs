using JetBrains.Annotations;
using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.FakeApi.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class FakeApiSettings
    {
        public DbSettings Db { get; set; }
    }
}
