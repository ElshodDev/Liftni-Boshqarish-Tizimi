//===================================================
// Copyright (c) 2025 Elshod Ibadullayev
// Free To Use For Learning and Development
// Project: Liftni_Boshqarish_Tizimi.Api
//===================================================

using Liftni_Boshqarish_Tizimi.Api.Brokers.Loggings;
using Liftni_Boshqarish_Tizimi.Api.Brokers.Storages;
using Liftni_Boshqarish_Tizimi.Api.Models.Foundations.ElevatorStates;
using Liftni_Boshqarish_Tizimi.Api.Models.Foundations.Exceptions;

namespace Liftni_Boshqarish_Tizimi.Api.Services.Foundations.ElevatorStates
{
    public class ElevatorStateService : IElevatorStateService
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

        public async ValueTask<ElevatorState> AddElevatorStateAsync(
            ElevatorState elevatorState)
        {
            try
            {
                if (elevatorState is null)
                {

                    throw new NullElevatorStateException();
                }
                return await this.storageBroker.InserElevatorStateAsync(elevatorState);
            }
            catch (NullElevatorStateException nullElevatorStateException)
            {
                var elevatorStateValidationException =
                   new ElevatorStateValidationException(nullElevatorStateException);

                this.loggingBroker.LogError(elevatorStateValidationException);

                throw elevatorStateValidationException;
            }
        }
    }
}
