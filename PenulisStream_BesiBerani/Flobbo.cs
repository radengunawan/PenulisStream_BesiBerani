using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PenulisStream_BesiBerani
{
    class Flobbo
    {
        //field(S)
        private string zap;

        // Constructor
        public Flobbo(string zap)
        {
            this.zap = zap;
        }

        //Method #1
        public StreamWriter Snobbo()
        {
            return new StreamWriter("C:\\Users\\sendr\\Documents\\Experiment_Result\\macaw.txt");
        } // end Method #1

        //Method #2
        public bool Blobbo(StreamWriter jcz)
        {
            jcz.WriteLine(this.zap);
            this.zap = "green purple";
            return false;
        }// end Method # 2

        // Method #3
        public bool Blobbo (bool Already, StreamWriter sw)
        {
            if (Already)
            {
                sw.WriteLine(this.zap);
                sw.Close();
                return false;
            } else
            {
                sw.WriteLine(this.zap);
                this.zap = "red orange";
                return true;
            }

                
        }
        // end Method #3








    } //end class
} //end namespace
