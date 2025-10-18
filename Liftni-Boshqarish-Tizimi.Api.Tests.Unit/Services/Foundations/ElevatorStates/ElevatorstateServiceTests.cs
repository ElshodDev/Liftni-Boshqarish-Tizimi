//===================================================
// Copyright (c) 2025 Elshod Ibadullayev
// Free To Use For Learning and Development
// Project: Liftni_Boshqarish_Tizimi.Api
//===================================================

using Liftni_Boshqarish_Tizimi.Api.Brokers.Loggings;
using Liftni_Boshqarish_Tizimi.Api.Brokers.Storages;
using Liftni_Boshqarish_Tizimi.Api.Models.Foundations.ElevatorStates;
using Liftni_Boshqarish_Tizimi.Api.Services.Foundations.ElevatorStates;
using Moq;
using Tynamix.ObjectFiller;

namespace Liftni_Boshqarish_Tizimi.Api.Tests.Unit.Services.Foundations.ElevatorStates
{
    public partial class ElevatorstateServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly Mock<ILoggingBroker> loggingBrokerMock;
        private readonly IElevatorStateService elevatorStateService;

        public ElevatorstateServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();
            this.loggingBrokerMock = new Mock<ILoggingBroker>();

            this.elevatorStateService =
                new ElevatorStateService(
              storageBroker:this.storageBrokerMock.Object,
              loggingBroker:this.loggingBrokerMock.Object);
        }

        private static ElevatorState CreateRandomElevatorState() =>
        CreateElevatorStateFiller(date: GetRandomDateTime()).Create();

        private static DateTime GetRandomDateTime() =>
           new DateTimeRange(earliestDate: new DateTime(2020, 1, 1)).GetValue();
        private static Filler<ElevatorState> CreateElevatorStateFiller(DateTime date)
        {
            var filler = new Filler<ElevatorState>();

            filler.Setup()
                .OnType<Guid>().Use(Guid.NewGuid)
                .OnProperty(t => t.LastUpdated).Use(DateTime.UtcNow).
                OnProperty(t => t.IsBusy).Use(GetRandomBool)
                .OnProperty(t => t.Direction).Use(GetRandomDirection)
                .OnProperty(t => t.CurrentFloor).Use(GetRandomFloor);

            return filler;
        }

        private static int GetRandomFloor() =>
            new Random().Next(1, 11);

        private static ElevatorDirection GetRandomDirection()
        {
            Array directions = Enum.GetValues(typeof(ElevatorDirection));
            return (ElevatorDirection)directions.GetValue(new Random().Next(directions.Length))!;
        }

        private static bool GetRandomBool()
        {
            return new Random().Next(0, 2) == 1;
        }
    }
}
