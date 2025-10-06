int n  = 0;
int z = 0;
int zbroj = 0;

Console.WriteLine("Unesite broj n ;");
n = int.Parse(Console.ReadLine());
do
{
    z++;
        if (z % 2 == 0)
    {
        zbroj += z;
    }
} while (z < n);
Console.WriteLine("Ukupni FIbonacijev zbroj je {0}: ", zbroj);

