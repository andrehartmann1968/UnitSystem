using System;

namespace AH.UnitSystem.Interface
{
    /// <summary>
    /// This class represents an exception that is thrown by the unit system when
    /// it is confronted with an instance that is not registered with it.
    /// </summary>
    public class UnregisteredInstanceException : Exception
    {
        public UnregisteredInstanceException(
            object pInstance
        )
        {
            Instance = pInstance;
        }

        public object Instance { get; }
    }
}
