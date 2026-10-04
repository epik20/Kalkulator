Console.WriteLine("Program liczący średnią arytmetyczną z podanych liczb.");
Console.Write("Proszę podaj swoje imię: ");
string name = Console.ReadLine();

//ocena nr 1
double one = 0;

//checking
while(true)
{
    Console.Write($"Podaj pierwszą ocenę: ");
    one = double.Parse(Console.ReadLine());
    if(one >= 1 && one <= 6)
    { 
        break;
    }
    else
    {
        Console.WriteLine($"Liczba {one} nie jest w przedziale od 1 do 6.");
    }
}

//ocena nr 2
double two = 0;

//checking
while(true)
{
    Console.Write($"Podaj drugą ocenę: ");
    two = double.Parse(Console.ReadLine());
    if(two >= 1 && two <= 6)
    { 
        break;
    }
    else
    {
        Console.WriteLine($"Liczba {two} nie jest w przedziale od 1 do 6.");
    }
}

//ocena nr 3
double three = 0;
    
//checking
while(true)
{
    Console.Write($"Podaj trzecią ocenę: ");
    three = double.Parse(Console.ReadLine());
    if(three >= 1 && three <= 6)
    { 
        break;
    }
    else
    {
        Console.WriteLine($"Liczba {three} nie jest w przedziale od 1 do 6.");
    }
}

// Obliczanie średniej arytmetycznej i zaokrąglanie do 1 miejsca po przecinku
double avg = Math.Round((one + two + three)/3, 1);
Console.WriteLine($"{name}, Twoja średnia to: {avg}");

// Ocena końcowa - zaliczone/niezaliczone
if(avg >= 3.0)
{
    Console.WriteLine($"Ocena końcowa to: Zaliczone!");
}
else
{
    Console.WriteLine($"Ocena końcowa to: Niezaliczone!");
}