record Album(string Artist, string Name, DateTime? ReleaseDate, int NumberOfDiscs = 1)
    : Record(Artist, Name, ReleaseDate);