//===================================================
// Copyright (c) 2025 Elshod Ibadullayev
// Free To Use For Learning and Development
// Project: Liftni_Boshqarish_Tizimi.Api
//===================================================

using Liftni_Boshqarish_Tizimi.Api.Brokers.Storages;
using Liftni_Boshqarish_Tizimi.Api.Models.Foundations.ElevatorStates;
using Liftni_Boshqarish_Tizimi.Api.Models.Foundations.Exceptions;

namespace Liftni_Boshqarish_Tizimi.Api.Services.Foundations.ElevatorStates
{
    public class ElevatorStateService : IElevatorStateService
    {
        private readonly IStorageBroker storageBroker;

        public ElevatorStateService(IStorageBroker storageBroker) =>
        this.storageBroker = storageBroker;

        public async ValueTask<ElevatorState> AddElevatorStateAsync(ElevatorState elevatorState)
        {
            if (elevatorState is null)
            {
                var nullElevatorStateException = new NullElevatorStateException();

                throw new ElevatorStateValidationException(nullElevatorStateException);
            }

            return await this.storageBroker.InserElevatorStateAsync(elevatorState);
        }
    }
}
