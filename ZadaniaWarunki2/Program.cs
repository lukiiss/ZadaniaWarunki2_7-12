using System;

//Zadanie 7

int First = 25;
int Second = 63;
int Third = 79;

int max = First;

if (Second > max)
{
    max = Second;
}
if (Third > max)
{
max = Third;
}

Console.WriteLine(max);

//Zadanie 8

int Matematyka = 80;
int Fizyka = 71;
int Chemia = 0;
int All = Matematyka + Fizyka + Chemia;

if (Matematyka > 70 && Fizyka > 55 && Chemia > 45 && All > 180 || Matematyka + Fizyka > 150 || Matematyka + Chemia > 150)
{
    Console.WriteLine("Kandydat dopuszczony do rekrutacji");
}

else
{
    Console.WriteLine("Kandydat nie został dopuszczony do rekrutacji");
}

//Zadanie 9 

int Temp = 41;

if (Temp < 0)
{
    Console.WriteLine("cholernie piździ");
}

else if (Temp >= 0 && Temp <= 10)
{
    Console.WriteLine("zimno");
}

else if (Temp >= 10 && Temp <= 20)
{
    Console.WriteLine("chłodno");
}

else if (Temp >= 20 && Temp <= 30)
{
    Console.WriteLine("w sam raz");
}

else if (Temp >= 30 && Temp <= 40)
{
    Console.WriteLine("zaczyna być słabo, bo gorąco");
}

else
{
    Console.WriteLine("a weź wyprowadzam się na Alaskę");
}

//Zadanie 10

int a = 40;
int b = 55;
int c = 65;

int maximum = a;

if (b > maximum)
{
    maximum = b;
}
if (c > maximum)
{
    maximum = c;
}

if (maximum == a && maximum < b + c)
{
    Console.WriteLine("Mozna zbudować trójkąt");
}
 else if (maximum == b && maximum < a + c)
{
    Console.WriteLine("Mozna zbudować trójkąt");
}
else if (maximum == c && maximum < a + b)
{
    Console.WriteLine("Mozna zbudować trójkąt");
}

else
{
    Console.WriteLine("Nie można zbudować trójkąta");
}

//Zadanie 11

int Ocena = 3;
string OcenaSlowna;

switch (Ocena)
{
    case 6:
        OcenaSlowna = "Celujący";
        Console.WriteLine(OcenaSlowna);
        break;
    case 5:
        OcenaSlowna = "BardzoDobry";
        Console.WriteLine(OcenaSlowna);
        break;
    case 4:
        OcenaSlowna = "Dobry";
        Console.WriteLine(OcenaSlowna);
        break;
    case 3:
        OcenaSlowna = "Dostateczny";
        Console.WriteLine(OcenaSlowna);
        break;
    case 2:
        OcenaSlowna = "Dopuszczający";
        Console.WriteLine(OcenaSlowna);
        break;
    case 1:
        OcenaSlowna = "Niedostateczny";
        Console.WriteLine(OcenaSlowna);
        break;
    default: 
        Console.WriteLine("Błędna ocena");
        break;
}

//Zadanie 12

int Dzien = 4;
string DzienTygodnia;

switch (Dzien)
{
    case 7:
        DzienTygodnia = "Niedziela";
        Console.WriteLine(DzienTygodnia);
        break;
    case 6:
        DzienTygodnia = "Sobota";
        Console.WriteLine(DzienTygodnia);
        break;
    case 5:
        DzienTygodnia = "Piątek";
        Console.WriteLine(DzienTygodnia);
        break;
    case 4:
        DzienTygodnia = "Czwartek";
        Console.WriteLine(DzienTygodnia);
        break;
    case 3:
        DzienTygodnia = "Środa";
        Console.WriteLine(DzienTygodnia);
        break;
    case 2:
        DzienTygodnia = "Wtorek";
        Console.WriteLine(DzienTygodnia);
        break;
    case 1:
        DzienTygodnia = "Poniedziałek";
        Console.WriteLine(DzienTygodnia);
        break;
    default:
        Console.WriteLine("Błędny dzień tygodnia");
        break;
}
