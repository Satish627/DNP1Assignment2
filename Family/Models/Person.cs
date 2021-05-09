using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models {
public class Person {
    [JsonPropertyName("ID")]
    public int Id { get; set; }
    [JsonPropertyName("FName"),Required]
    public string FirstName { get; set; }
    [JsonPropertyName("LName"),Required]
    public string LastName { get; set; }

    [JsonPropertyName("Hair")] 
    public string HairColor { get; set; }

    [JsonPropertyName("Eye")]
    public string EyeColor { get; set; }
    [JsonPropertyName("Age")]
    public int Age { get; set; }
    [JsonPropertyName("Weight")]
    public float Weight { get; set; }
    [JsonPropertyName("Height")]
    public int Height { get; set; }
    [JsonPropertyName("Sex")]
    public string Sex { get; set; }
}


}