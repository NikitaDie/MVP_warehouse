using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LightInject;

namespace PresenterLayout.Common
{
    public class LightInjectAdapter : IContainer
    {
        private readonly ServiceContainer _container = new ServiceContainer();

        public void Register<TService, TImplementation>() where TImplementation : TService
        {
            _container.Register<TService, TImplementation>();
        }

        public void Register<TService, TImplementation>(ILifetime lifetime) where TImplementation : TService
        {
            _container.Register<TService, TImplementation>(lifetime);
        }

        public void Register<TService>()
        {
            _container.Register<TService>();
        }

        public void Register<TService>(ILifetime lifetime)
        {
            _container.Register<TService>(lifetime);
        }

        public void RegisterInstance<T>(T instance)
        {
            _container.RegisterInstance(instance);
        }

        public void Register<TService, TArgument>(Expression<Func<TArgument, TService>> factory)
        {
            _container.Register(serviceFactory => factory);
        }

        public void Dispose()
        {
            _container.Dispose();
        }

        public T GetInstance<T>()
        {
            return _container.GetInstance<T>();
        }

        public TService Resolve<TService>()
        {
            return _container.GetInstance<TService>();
        }

        public bool IsRegistered<TService>()
        {
            return _container.CanGetInstance(typeof(TService), string.Empty);
        }
    }
}
