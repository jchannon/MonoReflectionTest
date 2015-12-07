using System;

namespace MonoReflectionTest
{
    public interface ICustomerRepository
    {
    }

    public class CustomerRepository : ICustomerRepository
    {
        private readonly IProxy proxy;

        public CustomerRepository(IProxy proxy)
        {
            this.proxy = proxy;
            
        }
    }
}

