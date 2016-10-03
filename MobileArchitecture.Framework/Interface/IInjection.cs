namespace MobileArchitecture.Framework.Interface
{
    public interface IInjection
    {
        void Register<I, T>() where T : class, I
                              where I : class;
    }
}
