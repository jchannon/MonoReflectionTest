using System;

namespace AutofacTest
{
    public interface IMcuCallProfileRepository
    {
    }

    public class McuCallProfileRepository : IMcuCallProfileRepository
    {
        private readonly IProxy proxy;

        public McuCallProfileRepository(IProxy proxy)
        {
            this.proxy = proxy;
            
        }
    }
}

