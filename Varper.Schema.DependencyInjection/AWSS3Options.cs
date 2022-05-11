using Amazon.S3;
using Amazon.S3.Util;
using System.Collections;
using System.Linq.Expressions;

namespace Varper.Schema.DependencyInjection
{
    public class AWSS3Options
    {
        public string AwsClientId { get; set; }
        public string AwsSecretKey { get; set; }
        public string AwsRegion { get; set; }

        public void SelectFiles(Func<IQueryable<AmazonS3Uri>, bool> getFilesWhere)
        {
            var uri = new AmazonS3Uri("");
            getFilesWhere(uri);

            var storage = new AWSS3Storage();
            storage.Where(u => u.Bucket == "");

            Expression<AmazonS3Uri> ex;
            ex.Lambda<int>().Compile();
        }
    }

    public class AWSS3Storage : IEnumerable<AmazonS3Uri>
    {
        public IEnumerator<AmazonS3Uri> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}