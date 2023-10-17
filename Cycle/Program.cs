Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xA = 40;
int yA = 1;
int xB = 1;
int yB = 10;
int xC = 20;
int yC = 30;

Console.SetCursorPosition(xA, yA);
Console.WriteLine("+");

Console.SetCursorPosition(xB, yB);
Console.WriteLine("+");

Console.SetCursorPosition(xC, yC);
Console.WriteLine("+");

int x = xA, y = xB;

int count = 10;

while (count < 10)
{
    int what = new Random().Next(0, 3); // 0, 1, 2;
    if (what == 0)
    {
        x = (x + xA) / 2;
        y = (y + yA) / 2;
    }
    if (what == 1)
    {
        x = (x + xB) / 2;
        y = (y + yB) / 2;
    }
    if (what == 2)
    {
        x = (x + xC) / 2;
        y = (y + yC) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1;
}