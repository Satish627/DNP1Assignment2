using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models
{
    public class Job
    {
        [JsonPropertyName("jobtitle")]
        public string JobTitle { get; set; }
        [JsonPropertyName("Salary")]
        public int Salary { get; set; }

        [JsonPropertyName("jobId"),Key]
        public int JobId { get; set; }
        
    }
}