
using TurningObjects;


List<ITurnable> turn = new()
{
    new Page(),
    new Leaf(),
    new Corner(),
    new Pancake(),
};

foreach(ITurnable t in turn)
{
    Turning(t);
}

static void Turning (ITurnable O)
{
    Console.WriteLine(O.Turn());
}
