using System;

namespace MonoReflectionTest
{
    public interface IGatewayDialPlanRepository
    {
    }

    public class GatewayDialPlanRepository : IGatewayDialPlanRepository
    {
        private readonly IProxy proxy;

        public GatewayDialPlanRepository(IProxy proxy)
        {
            this.proxy = proxy;
        }
    }

}

