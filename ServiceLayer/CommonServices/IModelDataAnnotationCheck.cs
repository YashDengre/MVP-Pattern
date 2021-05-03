namespace ServiceLayer.CommonServices
{
    public interface IModelDataAnnotationCheck
    {
        void ValidateModelDataAnnotaions<TDomainModel>(TDomainModel domainModel);
    }
}