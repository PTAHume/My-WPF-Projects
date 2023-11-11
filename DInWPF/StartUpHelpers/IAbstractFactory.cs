namespace DInWPF.StartUpHelpers
{
    public interface IAbstractFactory<T>
    {
        T Create();
    }
}