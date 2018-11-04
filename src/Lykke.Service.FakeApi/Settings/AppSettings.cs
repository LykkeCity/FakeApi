using JetBrains.Annotations;
using Lykke.Sdk.Settings;

namespace Lykke.Service.FakeApi.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class AppSettings : BaseAppSettings
    {
        public FakeApiSettings FakeApiService { get; set; }
    }
}
