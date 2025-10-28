using System.Text.Json.Serialization;

namespace JsonExerciseLists
{
    public class Library
    {
        [JsonPropertyName("books")]
        public List<Book> Books { get; set; }
    }
}
