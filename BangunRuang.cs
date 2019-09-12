using system;

namespace BangunRuang
{
    class Ruang
    {
         public void VolumeBalok()
        {
            
            int Panjang, Lebar, Tinggi, Volume;

            Console.Write("Panjang = ");
            Panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tinggi = ");
            Tinggi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lebar = ");
            Lebar = Convert.ToInt32(Console.ReadLine());

            Volume = Panjang* Lebar* Tinggi;

            Console.WriteLine("Volume Balok adalah "+Volume+ "/n");

        }

        public void VolumeKubus()
        {

            int Sisi, Volume;

            Console.Write("Sisi = ");
            Sisi = Convert.ToInt32(Console.ReadLine());

            Volume = Sisi* Sisi* Sisi;

            COnsole.WriteLine("Volume Kubus Adalah = " +Volume+"/n");
        }
    }
}
