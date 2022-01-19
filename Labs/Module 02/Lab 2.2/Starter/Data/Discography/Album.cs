using System;

namespace Wincubate.CS8.Data
{
    public sealed class Album
    {
        public Guid Id { get; }
        public string Artist { get; }
        public string AlbumName { get; }
        public DateTime ReleaseDate { get; }

        public Album(string artist,
                     string albumName,
                     DateTime releaseDate)
        {
            Id = Guid.NewGuid();
            Artist = artist;
            AlbumName = albumName;
            ReleaseDate = releaseDate;
        }

        public void Deconstruct(out Guid id, out string summary, out int age)
        {
            id = Id;

            summary = $"\"{AlbumName}\" by {Artist}";

            DateTime today = DateTime.Now;
            age = today.Year - ReleaseDate.Year - (ReleaseDate.DayOfYear < today.DayOfYear ? 0 : 1);
        }
    }
}
