List<IShape> shapes = new()
{
    new Circle(3),
    new Rectangle(4, 5)
};

IEnumerable<string> infos = shapes
    .Select(shape => shape.Serialize())
    ;

foreach (var info in infos)
{
    WriteLine(info);
}