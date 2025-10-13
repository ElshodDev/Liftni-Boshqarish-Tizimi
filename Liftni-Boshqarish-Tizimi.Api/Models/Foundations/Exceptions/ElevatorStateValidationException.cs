//===================================================
// Copyright (c) 2025 Elshod Ibadullayev
// Free To Use For Learning and Development
// Project: Liftni_Boshqarish_Tizimi.Api
//===================================================

using Xeptions;

namespace Liftni_Boshqarish_Tizimi.Api.Models.Foundations.Exceptions
{
    public class ElevatorStateValidationException : Xeption
    {
        public ElevatorStateValidationException(Xeption innerException)
            : base(message: "ElevatorState validation error occured,fix the errors and try again",
                  innerException)
        { }
    }
}
