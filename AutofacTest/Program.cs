using System;
using Autofac;
using System.Diagnostics;
using Autofac.Core.Lifetime;

namespace AutofacTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                //App-wide registrations
                var appContainer = new ContainerBuilder().Build();

                var builder = new ContainerBuilder();
                builder.RegisterType<Logger>().As<ILogger>().SingleInstance();
                builder.Update(appContainer.ComponentRegistry);


                var sw = new Stopwatch();
                sw.Start();


                //Request-wide registrations
                var childContainer = appContainer.BeginLifetimeScope(MatchingScopeLifetimeTags.RequestLifetimeScopeTag);
                var childBuilder = new ContainerBuilder();
                childBuilder.RegisterType<CallProfileRepository>().As<ICallProfileRepository>().SingleInstance();
                childBuilder.RegisterType<McuRepository>().As<IMcuRepository>().SingleInstance();
                childBuilder.RegisterType<CallRepository>().As<ICallRepository>().SingleInstance();
                childBuilder.RegisterType<CustomerRepository>().As<ICustomerRepository>().SingleInstance();
                childBuilder.RegisterType<EndpointRepository>().As<IEndpointRepository>().SingleInstance();
                childBuilder.RegisterType<GatewayDialPlanRepository>().As<IGatewayDialPlanRepository>().SingleInstance();
                childBuilder.RegisterType<McuCallProfileRepository>().As<IMcuCallProfileRepository>().SingleInstance();
                childBuilder.RegisterType<McuUriReservationRepository>().As<IMcuUriReservationRepository>().SingleInstance();
                childBuilder.RegisterType<RecurringTemplateRepository>().As<IRecurringTemplateRepository>().SingleInstance();
                childBuilder.RegisterType<RmxResolutionSettingRepository>().As<IRmxResolutionSettingRepository>().SingleInstance();
                childBuilder.RegisterType<CallProfileService>().As<ICallProfileService>().SingleInstance();
                childBuilder.RegisterType<McuService>().As<IMcuService>().SingleInstance();
                childBuilder.RegisterType<Proxy>().As<IProxy>().SingleInstance();

                childBuilder.Update(childContainer.ComponentRegistry);

                var mcuService = childContainer.Resolve<IMcuService>();

                sw.Stop();
                Console.WriteLine("Register and Resolve took " + sw.ElapsedMilliseconds);


            }

            Console.ReadKey();
        }
    }
}
