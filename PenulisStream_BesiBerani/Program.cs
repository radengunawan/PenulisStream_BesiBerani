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

        }
    }
}
