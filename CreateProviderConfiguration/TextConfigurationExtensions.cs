using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateProviderConfiguration
{
    public static class TextConfigurationExtensions
    {
        public static IConfigurationBuilder AddTextFile(this IConfigurationBuilder builder, string path)
        {
            if(builder == null)
            {
               new ArgumentNullException(nameof(builder));
            }
            if (string.IsNullOrEmpty(path))
            {
                new Exception("Путь к файлу не задан, либо файла не существует");
            }

            var source = new TextConfigurationSource(path);
            builder.Add(source);
            return builder;

        }
    }
}
