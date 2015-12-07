using System;

namespace AutofacTest
{
    public interface IMcuUriReservationRepository
    {
    }

    public class McuUriReservationRepository : IMcuUriReservationRepository
    {
        private readonly IProxy proxy;

        public McuUriReservationRepository(IProxy proxy)
        {
            this.proxy = proxy;
            
        }
    }
}

