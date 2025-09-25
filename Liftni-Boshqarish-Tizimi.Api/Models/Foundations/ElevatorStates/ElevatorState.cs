//===================================================
// Copyright (c) 2025 Elshod Ibadullayev
// Free To Use For Learning and Development
// Project: Liftni_Boshqarish_Tizimi.Api
//===================================================

namespace Liftni_Boshqarish_Tizimi.Api.Models.Foundations.ElevatorStates
{
    public class ElevatorState
    {
        public Guid Id { get; set; }
        public int CurrentFloor { get; set; }
        public ElevatorDirection Direction { get; set; }
        public bool IsBusy { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
