namespace mom4.Models {

    public class CommentModel {

        public int Id { get; set; }

        public string? Comment { get; set; }

        public int? SongId { get; set; } 

        public SongModel? Song { get; set; }
    }
}