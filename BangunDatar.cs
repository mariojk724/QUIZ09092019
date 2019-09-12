using system;

namespace Bangun_Datar
{
    class Program
    {
         public String hidup()
        {
            Return "READY ?";
        }
    
        public Void LuasPersegi()
    {
        Console.WriteLine("Menghitung Luas Persegi");
        Console.WriteLine("-----------------------");
    

        Int Sisi, Luas;

        Console.Write("Sisi = ");
        Sisi = Convert.ToInt32(Console.ReadLine());

        Luas = Sisi* Sisi;

        Console.WriteLine("Luas Persegi Adalah = " +Luas);
        }
    public void LuasSegitiga()
    {
        Int Alas, Tinggi;
        double luas;

        Console.Write("Alas = ");
        Alas = Convert.ToInt32(Console.ReadLine());

        Console.Write("Tinggi = ");
        Tinggi = Convert.ToInt32(Console.ReadLine());

        Luas = Tinggi* Alas /2;

        Console.WriteLine("Luas Segitiga Adalah = "+Luas);
    }
    
    public void LuasLingkaran()
    {
        int R, phi;
        double Luas;
        double phi;
        phi = 22/7;

        Console.Write("R = ");
        R = Convert.ToInt32(Console.ReadLine());

        Luas = R* R* phi;

        Console.WriteLine("Luas Lingkaran Adalah = " +Luas);
    }
    }   
 }