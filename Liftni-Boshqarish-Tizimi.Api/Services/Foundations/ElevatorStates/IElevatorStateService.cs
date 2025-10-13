//===================================================
// Copyright (c) 2025 Elshod Ibadullayev
// Free To Use For Learning and Development
// Project: Liftni_Boshqarish_Tizimi.Api
//===================================================

using Liftni_Boshqarish_Tizimi.Api.Models.Foundations.ElevatorStates;

namespace Liftni_Boshqarish_Tizimi.Api.Services.Foundations.ElevatorStates
{
    public interface IElevatorStateService
    {
        ValueTask<ElevatorState> AddElevatorStateAsync(ElevatorState elevatorState);
    }
}
