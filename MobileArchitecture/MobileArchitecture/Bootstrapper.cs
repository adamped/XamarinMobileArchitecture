namespace MobileArchitecture
{
    using Framework.Interface;
    using Proxy;

    public class Bootstrapper
    {
        private IInjection _injection;
        private IPlatformBootstrapper _platformBootstrapper;
        private static Bootstrapper _bootstrapper;
        public static Bootstrapper GetInstance(IPlatformBootstrapper platformBootstrapper)
        {
            if (_bootstrapper == null)
                _bootstrapper = new Bootstrapper(platformBootstrapper);

            return _bootstrapper;
        }

        private Bootstrapper(IPlatformBootstrapper platformBootstrapper)
        {
            _platformBootstrapper = platformBootstrapper;

            // Initialize Injection Proxy
            _injection = new Injection();          
        }

        public void Init()
        {
            // Register platform dependencies
            _platformBootstrapper.Register(_injection);
            
            // Register Service dependencies
            Service.Configuration.Dependency.Init(_injection);
        }

    }
}
