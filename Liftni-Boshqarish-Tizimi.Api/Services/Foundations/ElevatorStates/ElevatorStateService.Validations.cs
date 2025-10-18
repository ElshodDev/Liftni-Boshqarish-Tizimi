//===================================================
// Copyright (c) 2025 Elshod Ibadullayev
// Free To Use For Learning and Development
// Project: Liftni_Boshqarish_Tizimi.Api
//===================================================

using Liftni_Boshqarish_Tizimi.Api.Models.Foundations.ElevatorStates;
using Liftni_Boshqarish_Tizimi.Api.Models.Foundations.Exceptions;

namespace Liftni_Boshqarish_Tizimi.Api.Services.Foundations.ElevatorStates
{
    public partial class ElevatorStateService
    {
        private void ValidateElevatorStateNotNull(ElevatorState elevatorState)
        {
            if (elevatorState is null)
            {
                throw new NullElevatorStateException();
            }
        }
    }
}
