using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateProviderConfiguration
{
    public class TextConfigurationSource : IConfigurationSource
    {
        public string FilePath { get; set; }
        public TextConfigurationSource(string filename)
        {
            FilePath = filename;
        }
        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            string filepath = builder.GetFileProvider().GetFileInfo(FilePath).PhysicalPath;
            return new TextConfigurationProvider(filepath);
        }  
    }
}
