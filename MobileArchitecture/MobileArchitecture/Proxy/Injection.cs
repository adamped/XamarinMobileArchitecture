namespace MobileArchitecture.Proxy
{
    using Framework.Interface;

    public class Injection : IInjection
    {
        public void Register<I, T>() where T : class, I
                              where I : class
        {
            
        }
    }
}
