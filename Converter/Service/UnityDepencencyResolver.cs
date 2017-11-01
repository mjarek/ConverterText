using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;

namespace Converter.Service
{
    public class UnityDepencencyResolver : IDependencyResolver
    {
        private IUnityContainer _container;
        public UnityDepencencyResolver(IUnityContainer unityContainer)
        {
            _container = unityContainer;
        }
        public object GetService(Type serviceType)
        {
            try
            {
                return _container.Resolve(serviceType);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _container.ResolveAll(serviceType);
            }
            catch (Exception)
            {

                return new List<object>();
            }
        }
    }
}