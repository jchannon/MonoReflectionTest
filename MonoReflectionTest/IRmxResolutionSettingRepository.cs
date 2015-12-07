using System;

namespace MonoReflectionTest
{
    public interface IRmxResolutionSettingRepository
    {
    }

    public class RmxResolutionSettingRepository:IRmxResolutionSettingRepository
    {
        private readonly IProxy proxy;

        public RmxResolutionSettingRepository(IProxy proxy)
        {
            this.proxy = proxy;
        }
    }
}

