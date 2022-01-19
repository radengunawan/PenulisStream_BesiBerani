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
            var penulis = new StreamWriter($"{destination}mailToCaptainA.txt");

            penulis.WriteLine("To: CaptainAmazing@objectville.net");
            penulis.WriteLine("From: Commissioner@objectville.net");
            penulis.WriteLine("Subject: Can you save the day... again?");
            penulis.WriteLine();
            penulis.WriteLine("We’ve discovered the Swindler’s terrible plan:");

            while (!pembaca.EndOfStream) {
                var lineFromThePlan = pembaca.ReadLine();
                penulis.WriteLine($"The plan -> {lineFromThePlan}");
            }

            penulis.WriteLine();
            penulis.WriteLine("Can you help us?");

            penulis.Close();
            pembaca.Close();


        } //end Main
    }//end class
} // end namespace
