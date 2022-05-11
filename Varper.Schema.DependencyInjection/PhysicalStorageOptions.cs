namespace Varper.Schema.DependencyInjection
{
    public class PhysicalStorageOptions
    {
        public void SelectFiles(DirectoryInfo directory, Func<FileInfo, bool> getFiles)
        {
            throw new NotImplementedException();
        }
        
        public void SelectFiles(string directory, Func<FileInfo, bool> getFiles)
        {
            throw new NotImplementedException();
        }
        public void SelectFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}