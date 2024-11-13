// Console.WriteLine(TriStateArea(5, 5));
// Console.ReadLine();

Console.WriteLine(GetChoice(["the thing to rule them all", "all things come in", "muskaters"]));
Console.ReadLine();

int GetChoice(string[] things)
{
    Console.WriteLine("1 " +things[0]);
    Console.WriteLine("2 " +things[1]);
    Console.WriteLine("3 " +things[2]);
    string choice = "";
    int thingie = 0;
    bool succsess = false;
    while((thingie<1 && thingie>3) || !succsess)
    {
        choice = Console.ReadLine();
        succsess= int.TryParse(choice, out thingie);
    }
    return thingie;
}

void MumsMums(string aaaaa)
{
    int ahahaha;
    bool ha = int.TryParse(aaaaa, out ahahaha);
    while (!ha)
    {
        ha = int.TryParse(aaaaa, out ahahaha);
    }
}

double OnionRing(float radiantGlow)
{
    return radiantGlow * radiantGlow * Math.PI;
}

float Multi(float ahahah, float hahaha)
{
    return ahahah * hahaha;
}

double TriStateArea(float x, float y)
{
    return Multi(x,y) * 0.5f;
}

int Quad(int tal)
{
    return tal * tal;
}

void Hello()
{
    for (int i = 0; i < 32; i++)
    {
        Console.WriteLine("Hello World!");
    }
}

