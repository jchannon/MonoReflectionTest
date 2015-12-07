using System;

namespace AutofacTest
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

