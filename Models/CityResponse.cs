// Root myDeserializedClass = JsonConvert.DeserializeObject<List<

    public class CityResponse
    {
        public required string name { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public required string country { get; set; }
    }