using IPA;
using IPALogger = IPA.Logging.Logger;

namespace PlatformFactory
{
    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin
    {
        internal static IPALogger? Log { get; private set; }

        [Init]
        public Plugin(IPALogger logger)
        {
            Log = logger;
        }

        [OnEnable, OnDisable]
        public void OnState()
        {

        }
    }
}