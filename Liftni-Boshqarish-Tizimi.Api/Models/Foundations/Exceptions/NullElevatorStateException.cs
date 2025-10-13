//===================================================
// Copyright (c) 2025 Elshod Ibadullayev
// Free To Use For Learning and Development
// Project: Liftni_Boshqarish_Tizimi.Api
//===================================================

using Xeptions;

namespace Liftni_Boshqarish_Tizimi.Api.Models.Foundations.Exceptions
{
    public class NullElevatorStateException : Xeption
    {
        public NullElevatorStateException()
            : base(message: "ElevatorStateException is null")
        { }
    }
}
