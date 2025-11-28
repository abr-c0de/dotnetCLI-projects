

using proj7;

IRecoverable p1 = new Patient();
IRecoverable p2 = new FootballPlayer();
IRecoverable p3 = new Upholsterer();

//Recovery(p1);
//Recovery(p2);
Recovery(p3);
void Recovery(IRecoverable r)//Any class instance can be passed in the function which implement IRecover interface;
{
    Console.WriteLine(r.Recover());
}
