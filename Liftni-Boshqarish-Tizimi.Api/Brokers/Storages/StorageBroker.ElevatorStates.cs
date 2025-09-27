//===================================================
// Copyright (c) 2025 Elshod Ibadullayev
// Free To Use For Learning and Development
// Project: Liftni_Boshqarish_Tizimi.Api
//===================================================

using Liftni_Boshqarish_Tizimi.Api.Models.Foundations.ElevatorStates;
using Microsoft.EntityFrameworkCore;

namespace Liftni_Boshqarish_Tizimi.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<ElevatorState> ElevatorStates { get; set; }

      public   async ValueTask<ElevatorState> InserElevatorStateAsync(ElevatorState elevatorState)
        {
            using var broker = new StorageBroker(this.configuration);

            var elevatorStatesEntityEntry = await broker.ElevatorStates.AddAsync(elevatorState);
            await broker.SaveChangesAsync();

            return elevatorStatesEntityEntry.Entity;
        }
    }
}
