abstract record Record(string Artist, string Name, DateTime? ReleaseDate = default)
{
    sealed public override string ToString() =>
        $"{Artist}: \"{Name}\" [{ReleaseDate?.ToShortDateString()}]";

    public int? Age
    {
        get
        {
            if (ReleaseDate.HasValue)
            {
                DateTime today = DateTime.Now;
                return today.Year - ReleaseDate.Value.Year - (ReleaseDate.Value.DayOfYear < today.DayOfYear ? 0 : 1);
            }

            return null;
        }
    }
}