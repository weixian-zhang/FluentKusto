using System.Collections.Generic;
using Newtonsoft.Json;

public class Table
    {
        public string Name { get; set; }

        /// Name2 is to cater for Name property inconsistently return "Table" for certain tables
        [JsonProperty("Table")]
        public string Name2 {
            set
            {
                Name = value;
            }
        }
        public List<Column> Columns { get; set; }
    }