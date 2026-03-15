using System;

namespace Pools
{
    public interface IObjectPool<T> : IDisposable
    {
        T Rent();
        void Return(T obj);
    }
}