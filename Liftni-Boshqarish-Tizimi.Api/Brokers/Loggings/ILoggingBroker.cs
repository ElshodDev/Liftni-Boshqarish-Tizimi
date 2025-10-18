//===================================================
// Copyright (c) 2025 Elshod Ibadullayev
// Free To Use For Learning and Development
// Project: Liftni_Boshqarish_Tizimi.Api
//===================================================

namespace Liftni_Boshqarish_Tizimi.Api.Brokers.Loggings
{
    public interface ILoggingBroker
    {
        void LogError(Exception exception); 
        void LogCritical(Exception exception);
    }
}
