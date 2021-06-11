using System;

namespace Ngcs.Practices.IoC
{
    public static class ServiceLocator
    {
        private static IServiceLocator _current;

        public static IServiceLocator Current
        {
            get => ServiceLocator._current != null ? ServiceLocator._current : throw new NullReferenceException("Service Locator must be set");
            set => ServiceLocator._current = value;
        }
    }
}