// See https://aka.ms/new-console-template for more information
using INSAT.OneM2MCommunication;
using INSAT.OneM2MCommunication.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Net.Http.Headers;
using System.Net.Http.Json;

Console.WriteLine("Sending query...");

var client = new HttpClient(new LoggingHandler(new HttpClientHandler()));

client.DefaultRequestHeaders.Add("X-M2M-Origin", "Cmyself");
client.DefaultRequestHeaders.Add("X-M2M-RI", "123");
client.DefaultRequestHeaders.Add("X-M2M-RVI", "3");

Uri uri = new("http://localhost:8080/webui/index.html");





