using JetBrains.Annotations;

namespace Lykke.Service.FakeApi.Client
{
    /// <summary>
    /// FakeApi client interface.
    /// </summary>
    [PublicAPI]
    public interface IFakeApiClient
    {
        // Make your app's controller interfaces visible by adding corresponding properties here.
        // NO actual methods should be placed here (these go to controller interfaces, for example - IFakeApiApi).
        // ONLY properties for accessing controller interfaces are allowed.

        /// <summary>Application Api interface</summary>
        IFakeApiApi Api { get; }
    }
}
