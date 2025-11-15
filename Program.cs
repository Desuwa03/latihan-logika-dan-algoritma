using System;

namespace Program
{
    class Exercise
    {
        static void Main()
        {
            Console.WriteLine("Masukkan 'true' atau 'false'");
            string inputPedang = Console.ReadLine();
            string inputArmor = Console.ReadLine();
            string inputKunci = Console.ReadLine();

            string gerbangTerbuka = "Gerbang Terbuka";
            string gerbangMenyerang = "Gerbang Menyerang Player!";
            string gerbangMenghilang = "Tidak ditemukan adanya Gerbang!";

            bool isInputPedang = Convert.ToBoolean(inputPedang);
            bool isInputArmor = Convert.ToBoolean(inputArmor);
            bool isInputKunci = Convert.ToBoolean(inputKunci);

            if ((isInputPedang && isInputArmor) || isInputKunci)
            {
                Console.WriteLine(gerbangTerbuka);
            }
            else if (isInputPedang || isInputArmor)
            {
                Console.WriteLine(gerbangMenyerang);
            }
            else {
                Console.WriteLine(gerbangMenghilang);
            }
        }
    }
}