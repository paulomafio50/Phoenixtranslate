using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Gecko.WebIDL;

namespace phoenixtranslate.Class
{
    class ReadWrite_rpy
    {
        public void Read_rpy()
        {
            string line;
            string path = "rpyFiles\\1_diya.rpy";
            try
            {
                StreamReader sr = new StreamReader(path);
                line = sr.ReadLine();

                while (line !=null)
                {
                    System.Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            finally
            {
                System.Console.WriteLine("finsih");
            }

        }
        

    }
}