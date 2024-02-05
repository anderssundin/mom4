using System.Text.Json.Serialization;

namespace mom4.Models {

    public class CommentModel {

        public int Id { get; set; }

        public string? Comment { get; set; }
        [JsonIgnore]
        public int? SongId { get; set; } 
        [JsonIgnore]
        public SongModel? Song { get; set; }
    }
}