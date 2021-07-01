namespace Ngcs.Practices.Composition
{
    public interface IBootstrapperInitializationFacade
    {
        IAssembliesReadOnlyResolver AssembliesResolver { get; }

        void Initialize(string rootPath);
    }
}