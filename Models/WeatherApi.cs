using System.Text.Json;
// Szeged: 46.25 20.14

class WeatherApi
{
    const string KEY = "38822c7dd29282c20114f6af665511f5";
    static HttpClient client = new HttpClient();
    static JsonSerializerOptions deserializeOptions = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};
    public static WeatherResponse? weather;

    public static async Task<string> GetWeatherByCoords((double lat, double lon) coords)
    {
        string uri = $"https://api.openweathermap.org/data/2.5/weather?lat={coords.lat}&lon={coords.lon}&appid={KEY}&units=metric";
        return await client.GetStringAsync(uri);
    }

    public static async Task<(double, double)> GetCoordsByCity(string cityName)
    {
        string uri = $"http://api.openweathermap.org/geo/1.0/direct?q={cityName},hu&limit=1&appid={KEY}";
        string json = await client.GetStringAsync(uri);
        var response = JsonSerializer.Deserialize<List<CityResponse>>(json, deserializeOptions);

        if (response is null) throw new Exception();

        double lat = response[0].lat;
        double lon = response[0].lon;

        return (lat, lon);
    }    

    public static async Task SetResponse(string cityName)
    {
        (double, double) coords = await GetCoordsByCity(cityName);
        string json = await GetWeatherByCoords(coords);
        System.Console.WriteLine(json);

        weather = JsonSerializer.Deserialize<WeatherResponse>(json, deserializeOptions);
    }
}