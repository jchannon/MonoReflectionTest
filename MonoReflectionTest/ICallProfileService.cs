using System;

namespace MonoReflectionTest
{
    public interface ICallProfileService
    {
    }

    public class CallProfileService : ICallProfileService
    {
        private readonly ICallProfileRepository callProfileRepository;
        private readonly IMcuRepository mcuRepository;
        private readonly IMcuCallProfileRepository mcuCallProfileRepository;
        private readonly ILogger logger;

        public CallProfileService(ICallProfileRepository callProfileRepository, IMcuRepository mcuRepository, IMcuCallProfileRepository mcuCallProfileRepository, ILogger logger)
        {
            this.callProfileRepository = callProfileRepository;
            this.mcuRepository = mcuRepository;
            this.mcuCallProfileRepository = mcuCallProfileRepository;
            this.logger = logger;
        }
    }
}

