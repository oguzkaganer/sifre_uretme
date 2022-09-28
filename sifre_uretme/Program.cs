// See https://aka.ms/new-console-template for more information

char[] karakter = new char[26];
int i = 0;

for (char k = 'a'; k <= 'z' ; k++)
{
    karakter[i] = k;
    i++;
}

i = 0;
while (i<=karakter.Length-1)
{
    Console.Write(karakter[i]+" ");
    i++;
}

Console.WriteLine();

string sifre = "";
int dizisayaci = 0;

Random uret = new Random();

for (i = 0; i <= 9; i++)
{
    dizisayaci = uret.Next(0, 25);
    sifre = sifre + karakter[dizisayaci];
}

Console.WriteLine("Üretilen şifre : " +sifre);

Console.ReadKey();
