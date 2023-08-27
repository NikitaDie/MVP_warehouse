using System.Linq.Expressions;

namespace PresenterLayout.Common
{
    public interface IContainer
    {
        void Register<TService, TImplementation>() where TImplementation : TService;
        void Register<TService, TImplementation>(LightInject.ILifetime lifetime) where TImplementation : TService;
        void Register<TService>();
        void Register<TService>(LightInject.ILifetime lifetime);
        void RegisterInstance<T>(T instance);
        void Dispose();
        T GetInstance<T>();
        TService Resolve<TService>();
        bool IsRegistered<TService>();
        void Register<TService, TArgument>(Expression<Func<TArgument, TService>> factory);
    }
}
