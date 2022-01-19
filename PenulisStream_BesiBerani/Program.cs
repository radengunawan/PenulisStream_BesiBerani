using System;
using System.IO;

namespace PenulisStream_BesiBerani
{
    class Program
    {
        static void Main(string[] args)
        {
            Flobbo f = new Flobbo("biru kuning");

            StreamWriter aax = f.Snobbo();

            f.Blobbo(f.Blobbo(f.Blobbo(aax),aax), aax);

            var volder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            string the_address = f.full_path;
            string destination = Flobbo.gen_address;

            //var pembaca = new StreamReader($"{volder}{Path.DirectorySeparatorChar}{the_address}");
            //var penulis = new StreamWriter($"{volder}{Path.DirectorySeparatorChar}{destination}mailToCaptainA.txt");
            var pembaca = new StreamReader($"{the_address}");
            var 作家 = new StreamWriter($"{destination}mailToCaptainA_Chineze_Code.txt");

            作家.WriteLine("To: CaptainAmazing@objectville.net");
            作家.WriteLine("From: Commissioner@objectville.net");
            作家.WriteLine("Subject: Can you save the day... again?");
            作家.WriteLine();
            作家.WriteLine("We’ve discovered the Swindler’s terrible plan:");

            while (!pembaca.EndOfStream) {
                var lineFromThePlan = pembaca.ReadLine();
                作家.WriteLine($"The plan -> {lineFromThePlan}");
            }

            作家.WriteLine();
            作家.WriteLine("Can you help us?");

            作家.Close();
            pembaca.Close();


        } //end Main
    }//end class
} // end namespace
