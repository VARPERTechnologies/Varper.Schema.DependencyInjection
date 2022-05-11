namespace Varper.Schema.DependencyInjection
{
    public class StorageProviderOptions
    {
        public void UseAWSS3(Action<AWSS3Options> getAWSS3Options)
        {
            getAWSS3Options(new AWSS3Options());
        }

        public void UsePhysicalStorage(Action<Varper.Schema.DependencyInjection.PhysicalStorageOptions> getFile)
        {
            throw new NotImplementedException();
        }
    }
}