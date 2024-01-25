//bingus :3
using RestSharp;
using System.Text.Json;
using System.IO;
using System.Net.WebSockets;
using System.Xml.Serialization;

RestClient client = new RestClient("https://royaleapi.com");

RestRequest request = new RestRequest("player/PY02UVG");

RestResponse response = client.GetAsync(request).Result;

Console.WriteLine($"{response.Content}");


XmlSerializer RoyaleSerializer = new XmlSerializer(typeof(RoyaleApi));

RoyaleApi damn = new RoyaleApi();

StringWriter textWriter = new StringWriter();

RoyaleSerializer.Serialize(textWriter, damn);

textWriter.Close();

StringReader textReader = new StringReader(xmlText);

damn = (RoyaleApi) RoyaleSerializer.Deserialize(textReader);

textReader.Close();







