using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using System.Linq;

namespace Varper.Schema.DependencyInjection.Test
{
    public class Tests
    {
        private static readonly IServiceCollection services = new ServiceCollection();
        private IServiceProvider? sp;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void UsingAWSS3()
        {
            services.AddXmlSchemaValidation(config =>
                config.UseAWSS3(s3 =>
                {
                    s3.AwsClientId = "";
                    s3.AwsSecretKey = "";
                    s3.SelectFiles(uri => uri.Where(u => u.Key == "").Select(u => u.Key == ""));
                })
            );
            Assert.Pass();
        }

        [Test]
        public void UsingLocalStorage()
        {
            services.AddXmlSchemaValidation(config =>

            config.UsePhysicalStorage(f =>
            {
                f.SelectFiles("", file => file.Name == "");
            })
            //config.UseStream();
            //config.UseMemory();

            );
            Assert.Pass();
        }
    }
}