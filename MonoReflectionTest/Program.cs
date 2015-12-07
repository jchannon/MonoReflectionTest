using System;
using System.Diagnostics;
using TinyIoC;
using System.Linq;

namespace MonoReflectionTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                //App-wide registrations
                var container = new TinyIoCContainer();
                container.Register<ILogger, Logger>();

                var sw = new Stopwatch();
                sw.Start();

           
                //Request-wide registrations
                var childContainer = container.GetChildContainer();

                childContainer.Register<ICallProfileRepository, CallProfileRepository>();
                childContainer.Register<IMcuRepository, McuRepository>();
                childContainer.Register<ICallRepository, CallRepository>();
                childContainer.Register<ICustomerRepository, CustomerRepository>();
                childContainer.Register<IEndpointRepository, EndpointRepository>();
                childContainer.Register<IGatewayDialPlanRepository, GatewayDialPlanRepository>();
                childContainer.Register<IMcuCallProfileRepository, McuCallProfileRepository>();
                childContainer.Register<IMcuUriReservationRepository, McuUriReservationRepository>();
                childContainer.Register<IRecurringTemplateRepository, RecurringTemplateRepository>();
                childContainer.Register<IRmxResolutionSettingRepository, RmxResolutionSettingRepository>();

                childContainer.Register<ICallProfileService, CallProfileService>();
                childContainer.Register<IMcuService, McuService>();

                childContainer.Register<IProxy,Proxy>();

                var mcuService = childContainer.Resolve<IMcuService>();

                sw.Stop();
                Console.WriteLine("Register and Resolve took " + sw.ElapsedMilliseconds);
                childContainer.Dispose();
                container.Dispose();

            }
           
            Console.ReadKey();
        }
    }
}
