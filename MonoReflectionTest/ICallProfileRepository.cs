using System;

namespace MonoReflectionTest
{
    public interface ICallProfileRepository
    {
    }


    public class CallProfileRepository  :ICallProfileRepository
    {
        private readonly IProxy proxy;

        public CallProfileRepository(IProxy proxy)
        {
            this.proxy = proxy;
            
        }
    }
}

