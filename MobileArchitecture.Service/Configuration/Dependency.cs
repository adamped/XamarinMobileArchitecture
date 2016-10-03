namespace MobileArchitecture.Service.Configuration
{
    using Framework.Interface;
    using Repository;

    public class Dependency
    {

        public static void Init(IInjection injection)
        {
            injection.Register<IDatabase, Database>();
        }

    }
}
