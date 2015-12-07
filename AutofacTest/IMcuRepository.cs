using System;

namespace AutofacTest
{
    public interface IMcuRepository
    {
    }

    public class McuRepository : IMcuRepository
    {
        private readonly IProxy proxy;

        public McuRepository(IProxy proxy)
        {
            this.proxy = proxy;
            
        }
    }

}

