using System;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace Spectrometer_CS2000.Entity
{
    class Job
    {
        public string Version { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }

        public Job()
        {
            this.Version = "1";
            this.Id = Guid.NewGuid().ToString();
        }

        public Job(string id)
        {
            this.Version = "1";
            this.Id = id;
        }

        public string GetAsString()
        {
            TextEncoderSettings encoderSettings = new TextEncoderSettings();
            encoderSettings.AllowRange(UnicodeRanges.All);

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(encoderSettings),
                WriteIndented = false
            };

            return JsonSerializer.Serialize<Job>(this, options);
        }

        public static Job SetFromString(string jobAsJSON)
        {
            Job job = JsonSerializer.Deserialize<Job>(jobAsJSON);

            return job;
        }

        [JsonConstructor]
        public Job(string version, string id, string name)
        {
            this.Version = version;
            this.Id = id;
            this.Name = name;
        }
    }
}
