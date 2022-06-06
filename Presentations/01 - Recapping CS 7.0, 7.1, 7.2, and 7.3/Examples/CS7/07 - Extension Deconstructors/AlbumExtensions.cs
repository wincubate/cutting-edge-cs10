using DiscographyLib;
using System;

namespace Wincubate.CS7.Slide07
{
    static class AlbumExtensions
    {
        public static void Deconstruct(this Album album, out string summary, out int age)
        {
            summary = $"\"{album.AlbumName}\" by {album.Artist}";

            DateTime today = DateTime.Now;
            age = today.Year - album.ReleaseDate.Year - (album.ReleaseDate.DayOfYear < today.DayOfYear ? 0 : 1);
        }
    }
}
