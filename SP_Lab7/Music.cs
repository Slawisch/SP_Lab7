namespace SP_Lab7
{
    public class Music
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Album { get; set; }

        public Music(){}

        public Music(string name, string author, string genre, string album)
        {
            Name = name;
            Author = author;
            Genre = genre;
            Album = album;
        }
    }
}