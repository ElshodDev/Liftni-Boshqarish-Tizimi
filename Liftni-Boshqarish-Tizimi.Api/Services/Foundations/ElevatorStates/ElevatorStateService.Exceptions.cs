//===================================================
// Copyright (c) 2025 Elshod Ibadullayev
// Free To Use For Learning and Development
// Project: Liftni_Boshqarish_Tizimi.Api
//===================================================

using Liftni_Boshqarish_Tizimi.Api.Models.Foundations.ElevatorStates;
using Liftni_Boshqarish_Tizimi.Api.Models.Foundations.Exceptions;
using Xeptions;

namespace Liftni_Boshqarish_Tizimi.Api.Services.Foundations.ElevatorStates
{
    public partial class ElevatorStateService
    {
        private delegate ValueTask<ElevatorState> ReturningElevatorStateFunction();

        private async ValueTask<ElevatorState> TryCatch(
            ReturningElevatorStateFunction returningElevatorStateFunction)
        {
            try
            {
                return await returningElevatorStateFunction();
            }
            catch (NullElevatorStateException nullElevatorStateException)
            {
               

                throw CreateAndLogValidationException(nullElevatorStateException);
            }
        }
         private   ElevatorStateValidationException CreateAndLogValidationException(
         Xeption exception)
         {
            var elevatorStateValidationException =
                  new ElevatorStateValidationException(exception);

            this.loggingBroker.LogError(elevatorStateValidationException);

            return elevatorStateValidationException;
        }
    }
}
