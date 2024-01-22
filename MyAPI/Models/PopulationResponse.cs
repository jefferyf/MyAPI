using Newtonsoft.Json;

namespace MyAPI.Models
{
    public class PopulationResponse
    {
        public List<USPopulationByYear> Data { get; set; }
    }

    public class USPopulationByYear
    {
        [JsonProperty("ID Nation")]
        public string IdNation { get; set; }
        [JsonProperty("Nation")]
        public string Nation { get; set; }
        [JsonProperty("ID Year")]
        public int IdYear { get; set; }
        [JsonProperty("Year")]
        public string Year { get; set; }
        [JsonProperty("Population")]
        public int Population { get; set; }
        [JsonProperty("Slug Nation")]
        public string SlugNation { get; set; }
    }
}
