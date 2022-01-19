Album album = new("Depeche Mode", "Violator", new DateTime(1990, 03, 19));
Console.WriteLine(album);

Single single = new(
    "Depeche Mode",
    "Enjoy the Silence",
    new DateTime(1990, 1, 1),
    new Album[] { album });
Console.WriteLine(single);
