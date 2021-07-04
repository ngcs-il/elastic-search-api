using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Newtonsoft.Json;
using YamlDotNet.Serialization;

namespace YamlToNSwag
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    internal class Program
    {
        private class FromDocument
        {
            [JsonProperty(PropertyName = "json")]
            public string Json { get; set; }
        }

        private class DocumentGenerator
        {
            [JsonProperty(PropertyName = "fromDocument")]
            public FromDocument FromDocument { get; set; }
        }

        private class NSwagObject
        {
            [JsonProperty(PropertyName = "documentGenerator")]
            public DocumentGenerator DocumentGenerator { get; set; }
        }

        private static int Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: YamlToNSwag <yaml file> <nswag file>");
                return -1;
            }

            using var yamlStr = File.OpenText(args[0]);
            var deserializer = new Deserializer();
            var yamlObject = deserializer.Deserialize(yamlStr);

            var serializer = new JsonSerializer();
            using var strWriterYaml = new StringWriter();
            serializer.Serialize(strWriterYaml, yamlObject);
            var jsonStr = strWriterYaml.ToString();

            var nswagStr = File.ReadAllText(args[1]);
            var nswagObj = JsonConvert.DeserializeObject<NSwagObject>(nswagStr);

            // ReSharper disable once PossibleNullReferenceException
            nswagObj.DocumentGenerator.FromDocument.Json = jsonStr;

            using var nswagFile = File.CreateText(args[1]);
            serializer.Serialize(nswagFile, yamlObject);

            return 0;
        }
    }
}
