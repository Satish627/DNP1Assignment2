using System.Text.Json.Serialization;

namespace Models
{
    public class Adult : Person
    {

        public Job Work { get; set; }
    }
}
