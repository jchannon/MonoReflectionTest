using System;

namespace MonoReflectionTest
{
    public interface IRecurringTemplateRepository
    {
    }

    public class RecurringTemplateRepository : IRecurringTemplateRepository
    {
        private readonly IProxy proxy;

        public RecurringTemplateRepository(IProxy proxy)
        {
            this.proxy = proxy;
            
        }
    }
    
}

