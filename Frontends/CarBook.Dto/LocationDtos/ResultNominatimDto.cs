namespace CarBook.Dto.LocationDtos;

public class ResultNominatimDto
{
    public string licence { get; set; }
    public string lat { get; set; }
    public string lon { get; set; }
    
    public string name { get; set; }
    public string display_name { get; set; }
    public Address address { get; set; }
    public string[] boundingbox { get; set; }
    
    public GeoJson geojson { get; set; }
}
public class Address
{
    public string city { get; set; }
    public string town { get; set; }
    public string province { get; set; }
    public string ISO3166_2_lvl4 { get; set; }
    public string region { get; set; }
    public string postcode { get; set; }
    public string country { get; set; }
    public string country_code { get; set; }
}

public class GeoJson
{
    public string type { get; set; }
    public object coordinates { get; set; }
}
