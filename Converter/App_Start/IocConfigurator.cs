﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;
using Converter.Service;
using Converter.Service.Interface;
using System.Web.Mvc;

namespace Converter.App_Start
{
    public class IocConfigurator
    {

        public static void ConfigureIoc()
        {

            IUnityContainer container = new UnityContainer();
            RegisterServices(container);
            DependencyResolver.SetResolver(new UnityDepencencyResolver(container));
        }

        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterType<IManagerParsing, ManagerParsing>();
        }
    }
}