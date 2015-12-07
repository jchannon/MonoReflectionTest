using System;

namespace MonoReflectionTest
{
    public interface ICallRepository
    {
    }

    public class CallRepository : ICallRepository
    {
        private readonly IProxy proxy;
        private readonly IRecurringTemplateRepository recurringTemplateRepository;

        public CallRepository(IProxy proxy, IRecurringTemplateRepository recurringTemplateRepository)
        {
            this.proxy = proxy;
            this.recurringTemplateRepository = recurringTemplateRepository;
        }
    }
}

