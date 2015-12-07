using System;

namespace AutofacTest
{
    public class McuService : IMcuService
    {
        public McuService(IMcuRepository mcuRepository, IMcuCallProfileRepository mcuCallProfileRepository,
                          ICallProfileService callProfileService, ICustomerRepository customerRepository,
                          ICallRepository callRepository, ILogger logger, IMcuUriReservationRepository mcuUriReservationRepository,
                          IEndpointRepository endpointRepository, IGatewayDialPlanRepository gatewayDialPlanRepository,
                          IRmxResolutionSettingRepository rmxResolutionSettingRepository)
        {
        }
    }
}

