sealed record Single(string Artist, string Name, DateTime? ReleaseDate, IEnumerable<Album>? Albums)
    : Record(Artist, Name, ReleaseDate)
{
    //public override string ToString()
    //{
    //    string albums = string.Join("-", Albums ?? new Album[0]);

    //    return $"{Artist}: \"{Name}\" [{ReleaseDate}] - From the album(s) \"{albums}\"";
    //}
}
