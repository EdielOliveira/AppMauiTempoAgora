using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using AppMauiTempoAgora.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;
using System.Net.Http;

namespace AppMauiTempoAgora.Services
{
    public class DataService
    {
        public static async Task<Tempo?> GetPrevisao(string cidade)
        {
            Tempo? t = null;

            string chave = "02307b4d1a558723bcdaca3c2aec4c3f";
            string url = $"https://api.openweathermap.org/data/2.5/weather?" +
                        $"q={cidade}&units=metric&appid={chave}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage resp = await client.GetAsync(url);

                    if (resp.IsSuccessStatusCode)
                    {
                        string json = await resp.Content.ReadAsStringAsync();

                        var rascunnho = JObject.Parse(json);

                        DateTime time = new();
                        DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds((long)rascunnho["sys"]["sunrise"]);
                        DateTime sunrise = dateTimeOffset.LocalDateTime;


                        dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds((long)rascunnho["sys"]["sunset"]);
                        DateTime sunset = dateTimeOffset.LocalDateTime;


                        t = new()
                        {
                            lat = (double)rascunnho["coord"]["lat"],
                            lon = (double)rascunnho["coord"]["lon"],
                            description = (string)rascunnho["weather"][0]["description"],
                            main = (string)rascunnho["weather"][0]["main"],
                            temp_min = (double)rascunnho["main"]["temp_min"],
                            temp_max = (double)rascunnho["main"]["temp_max"],
                            speed = (double)rascunnho["wind"]["speed"],
                            visibility = (int)rascunnho["visibility"],
                            sunrise = sunrise.ToString(),
                            sunset = sunset.ToString(),
                        };
                    }
                    else if (resp.StatusCode == HttpStatusCode.NotFound)
                    {
                        throw new Exception("Cidade não encontrada. Verifique o nome e tente novamente.");
                    }
                    else
                    {
                        throw new Exception("Erro ao buscar a previsão do tempo. Tente novamente mais tarde.");
                    }
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception("Sem conexão com a internet. Verifique sua rede e tente novamente.");
                }
            }

            return t;
        }
    }
}
