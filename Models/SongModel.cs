using System.Xml;

namespace mom4.Models{

    public class SongModel {

        public int SongId { get; set; }

        public string? Artist { get; set; }
        public string? Title { get; set; }

        public int? Length { get; set; }

        public string? Category { get; set; }

        List<CommentModel>? Comments {get; set;}


    }
}