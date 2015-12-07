using System;

namespace AutofacTest
{
    public interface IEndpointRepository
    {
    }

    public class EndpointRepository : IEndpointRepository
    {
        private readonly IProxy proxy;

        public EndpointRepository(IProxy proxy)
        {
            this.proxy = proxy;
            
        }
    }
}

