//===================================================
// Copyright (c) 2025 Elshod Ibadullayev
// Free To Use For Learning and Development
// Project: Liftni_Boshqarish_Tizimi.Api
//===================================================

using Liftni_Boshqarish_Tizimi.Api.Models.Foundations.ElevatorStates;
using Liftni_Boshqarish_Tizimi.Api.Models.Foundations.Exceptions;
using Xunit.Abstractions;

namespace Liftni_Boshqarish_Tizimi.Api.Tests.Unit.Services.Foundations.ElevatorStates
{
    public partial class ElevatorstateServiceTests
    {
        [Fact]
        public async Task ShouldThrowValidationExceptionOnAddIfElevatorStateIsNullAndLogItAsync()
        {
            //given 
            ElevatorState NullElevatorState = null;
            var nullElevatorStateException = new NullElevatorStateException();

            var expectedElevatorStateValidationException=
                new ElevatorStateValidationException(nullElevatorStateException);

            //when

            ValueTask<ElevatorState> addElevatorState =
               this.elevatorStateService.AddElevatorStateAsync(NullElevatorState);

            //then
            await Assert.ThrowsAsync<ElevatorStateValidationException>(() =>
          addElevatorState.AsTask());
        }
    }
}
