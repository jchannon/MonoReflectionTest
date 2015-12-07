using System;

namespace MonoReflectionTest
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

