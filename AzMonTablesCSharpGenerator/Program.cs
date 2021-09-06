using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.Monitor.Query;
using Azure.Monitor.Query.Models;
using Newtonsoft.Json;
using RazorEngine;
using RazorEngine.Configuration;
using RazorEngine.Templating;
using RazorEngine.Text;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace FluentKusto.AzMonTablesCSharpGenerator
{
    class Program
    {
        private const string CSharpKustoClassFile = "AzMonTablesCSharpGenerator\\CSharpKustoClassFile.txt";
        private const string AzMonitorRefTables = "AzMonTablesCSharpGenerator\\AzMonitorRefTables.txt";
        private const string TableJsonFileDir = "AzMonTablesCSharpGenerator\\TableJsonFiles";
        private static bool WriteSchemaToFiles = false;
        private static string CSHtmlTableClassTemplateFilePath = "AzMonTablesCSharpGenerator\\TableClassTemplate.cshtml";
        private static string CSHtmlKustoPropertyTemplate = "AzMonTablesCSharpGenerator\\KustoPropertyTemplate.cshtml";

        private const string AzMonTableRefYaml =
            "https://raw.githubusercontent.com/MicrosoftDocs/azure-reference-other/master/azure-monitor-ref/TOC.yml";

        private const string GeneratedClassFileDestDir = "src\\tables";

        static void Main(string[] args)
        {
            WriteSchemaToFiles = Convert.ToBoolean(Environment.GetEnvironmentVariable("WriteSchemaToFiles"));

            var tables = GetTables();

            //TableContentAsJsonFiles(tables);

            //GenerateTableClassFiles();

            GenerateKustoPropertiesInClassFile(tables);
        }

        private static void GenerateKustoPropertiesInClassFile(IEnumerable<string> tables)
        {
            string template = File.ReadAllText(CSHtmlKustoPropertyTemplate);

            var config = new TemplateServiceConfiguration();
            config.EncodedStringFactory = new RawStringFactory(); // Raw string encoding instead of html

            var svc = RazorEngineService.Create(config);
            Engine.Razor = svc;

            string kustoProps
                    = Engine.Razor.RunCompile(template, "multifile-main", typeof(string[]), tables);

            using(var writer  = new StreamWriter(CSharpKustoClassFile))
            {
                writer.WriteLine(kustoProps);
            }
        }

        private static void GenerateTableClassFiles()
        {
            string template = File.ReadAllText(CSHtmlTableClassTemplateFilePath);

            var config = new TemplateServiceConfiguration();
            config.EncodedStringFactory = new RawStringFactory(); // Raw string encoding instead of html

            var svc = RazorEngineService.Create(config);
            Engine.Razor = svc;

            var files = Directory.GetFiles(TableJsonFileDir);

            foreach(var f in files)
            {
                var tableJson = File.ReadAllText(f);

                var tableObj = JsonConvert.DeserializeObject<Table>(tableJson);

                string tableClass
                    = Engine.Razor.RunCompile(template, "multifile-main", typeof(Table), tableObj);

                using(var writer  = new StreamWriter(Path.Combine(GeneratedClassFileDestDir, tableObj.Name + ".cs")))
                {
                    writer.WriteLine(tableClass);
                }
            }
        }

        private static string CallAzCli(string table)
        {
            var cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine($"az rest -u https://api.loganalytics.io/v1/workspaces/4cecddb2-c069-488a-b3a1-d9bf129168bf/metadata --query \"tables[?name=='{table}'].columns[]\" -o json");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit(5000);

            string result = cmd.StandardOutput.ReadToEnd();

            return result;
        }

        private static void TableContentAsJsonFiles(IEnumerable<string> tables)
        {
            //var tableWithCols = new List<TableWithColumns>();

            foreach(string t in tables)
            {
                string result = CallAzCli(t);

                if(!string.IsNullOrEmpty(result))
                {
                    try
                    {
                        int indexStartOfJson = result.IndexOf('{');

                        if(indexStartOfJson == -1)
                            continue;

                        indexStartOfJson = indexStartOfJson - 5;

                        string jsonWithNewLine = result.Remove(0, indexStartOfJson);
                        string json = jsonWithNewLine.Replace("\r\n", "");

                        int indexOfEndOfJson = json.LastIndexOf(']');
                        indexOfEndOfJson = indexOfEndOfJson + 1;
                        json = json.Remove(indexOfEndOfJson, (json.Length - indexOfEndOfJson));

                        var tableCol = JsonConvert.DeserializeObject<List<Column>>(json);

                        var tableWithCol = new Table()
                        {
                            Name = t,
                            Columns = tableCol
                        };

                        //tableWithCols.Add(tableWithCol);

                        if(WriteSchemaToFiles)
                        {
                            string path = Path.Combine(TableJsonFileDir, t + ".json");

                            using(var w = new StreamWriter(path, false))
                            {
                                w.WriteLine(JsonConvert.SerializeObject(tableWithCol));
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine($"Table: {t}" + " " + ex.ToString());
                    }
                }
            }
        }

        private static IEnumerable<string> GetTables()
        {
           string refTables = File.ReadAllText(AzMonitorRefTables);

           string[] tables = refTables.Split(Environment.NewLine);

           return tables;

           //TODO - download ref yaml
           //https://raw.githubusercontent.com/MicrosoftDocs/azure-reference-other/master/azure-monitor-ref/TOC.yml

            // using(var webclient = new WebClient())
            // {
            //     byte[] tablesRaw = webclient.DownloadData(AzMonTableRefYaml);

            //     string yaml = System.Text.Encoding.UTF8.GetString(tablesRaw);

            //     string[] splitNewLine = yaml.Split(Environment.NewLine);
            //     var newList = splitNewLine.ToList();
            //     newList.RemoveRange(0, 12);

            //     //get names only, ignore "href"
            //     var namesOnly = newList.Where(x => x.Contains("name"));

            //     var tableNames = new List<string>();

            //     foreach(string n in namesOnly)
            //     {
            //         string name = n.Split("- name: ")[1];
            //         tableNames.Add(name);
            //     }

            //     return tableNames;
            // }
        }
    }
}
