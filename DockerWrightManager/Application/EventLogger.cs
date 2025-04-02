using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DockerWrightManager
{
    public enum EventSeverity
    {
        Debug = 0,
        Info = 1,
        Warning = 2,
        Error = 3
    }

    public class Event
    {
        public EventSeverity severity { get; set; }
        public string application { get; set; }
        public string message { get; set; }
    }

    public static class EventLogger
    {
        public static string logUrl { get; set; }
        public static string logSecret { get; set; }
        public static string logName { get; set; }
        public static EventSeverity level { get; set; }

        public static async Task LogEvent(EventSeverity severity, string message)
        {
            Console.WriteLine(message);
            if (severity >= level && !string.IsNullOrEmpty(logSecret))
            {
                HttpClient webClient = new HttpClient() { BaseAddress = new Uri(logUrl) };
                webClient.DefaultRequestHeaders.Add("Authorization", logSecret);
                var res = await webClient.PostAsync("event", new StringContent(JsonSerializer.Serialize(new Event { severity = severity, application = logName, message = message }), Encoding.UTF8, "application/json"));
            }
        }       
    }
}