    public class Clouds
    {
        public int all { get; set; }
    }

    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public int sea_level { get; set; }
        public int grnd_level { get; set; }
    }

    public class WeatherResponse
    {
        public required Coord coord { get; set; }
        public required List<Weather> weather { get; set; }
        public required string @base { get; set; }
        public required Main main { get; set; }
        public int visibility { get; set; }
        public required Wind wind { get; set; }
        public required Clouds clouds { get; set; }
        public int dt { get; set; }
        public required Sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public required string name { get; set; }
        public int cod { get; set; }
    }

    public class Sys
    {
        public required string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public required string main { get; set; }
        public required string description { get; set; }
        public required string icon { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
        public int deg { get; set; }
        public double gust { get; set; }
    }

