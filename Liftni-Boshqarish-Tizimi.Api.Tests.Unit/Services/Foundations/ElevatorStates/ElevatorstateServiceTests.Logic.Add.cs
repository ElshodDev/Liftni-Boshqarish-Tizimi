//===================================================
// Copyright (c) 2025 Elshod Ibadullayev
// Free To Use For Learning and Development
// Project: Liftni_Boshqarish_Tizimi.Api
//===================================================


using FluentAssertions;
using Force.DeepCloner;
using Liftni_Boshqarish_Tizimi.Api.Models.Foundations.ElevatorStates;
using Moq;

namespace Liftni_Boshqarish_Tizimi.Api.Tests.Unit.Services.Foundations.ElevatorStates
{
    public partial class ElevatorstateServiceTests
    {
        [Fact]
        public async Task ShouldAddElevatorStateAsync()
        {
            //given
            ElevatorState randomElevatorState = CreateRandomElevatorState();
            ElevatorState inputElevatorState = randomElevatorState;
            ElevatorState storageElevatorState = inputElevatorState;
            ElevatorState expectedElevatorState = storageElevatorState.DeepClone();

            this.storageBrokerMock.Setup(broker=>
            broker.InserElevatorStateAsync(inputElevatorState))
                .ReturnsAsync(storageElevatorState);

            //when
            ElevatorState actualElevatorState =
                await this.elevatorStateService.AddElevatorStateAsync(inputElevatorState);

            //then
            actualElevatorState.Should().BeEquivalentTo(expectedElevatorState);

            this.storageBrokerMock.Verify(broker =>
            broker.InserElevatorStateAsync(inputElevatorState),
            Times.Once);

            this.storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
