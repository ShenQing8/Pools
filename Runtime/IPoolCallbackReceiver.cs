namespace Pools
{
    public interface IPoolCallbackReceiver
    {
        void OnRent();
        void OnReturn();
    }
}