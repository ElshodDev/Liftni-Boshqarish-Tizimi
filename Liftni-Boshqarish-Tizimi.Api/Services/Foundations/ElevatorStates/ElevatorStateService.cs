//===================================================
// Copyright (c) 2025 Elshod Ibadullayev
// Free To Use For Learning and Development
// Project: Liftni_Boshqarish_Tizimi.Api
//===================================================

using Liftni_Boshqarish_Tizimi.Api.Brokers.Loggings;
using Liftni_Boshqarish_Tizimi.Api.Brokers.Storages;
using Liftni_Boshqarish_Tizimi.Api.Models.Foundations.ElevatorStates;

namespace Liftni_Boshqarish_Tizimi.Api.Services.Foundations.ElevatorStates
{
    public partial class ElevatorStateService : IElevatorStateService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;

        public ElevatorStateService(
            IStorageBroker storageBroker,
            ILoggingBroker loggingBroker)
        {
            this.storageBroker = storageBroker;
            this.loggingBroker=loggingBroker;
        }

        public ValueTask<ElevatorState> AddElevatorStateAsync(
            ElevatorState elevatorState) =>
            TryCatch(async () =>
            {
                ValidateElevatorStateNotNull(elevatorState);

                return await this.storageBroker.
                InserElevatorStateAsync(elevatorState);
            });
    }
}
