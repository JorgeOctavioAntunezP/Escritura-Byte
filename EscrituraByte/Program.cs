
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrituraByte
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            byte[] buffer = new byte[81];
            int nbytes = 0, car;

            try
            {
                fs = new FileStream("text.txt", FileMode.Create, FileAccess.Write);
                Console.WriteLine("Escriba el texto que desea almacenar en el archivo:");
                while ((car = Console.Read()) != '\r' && (nbytes < buffer.Length))
                {
                    buffer[nbytes] = (byte)car;
                    nbytes++;
                }
                fs.Write(buffer, 8, nbytes);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }
    }
}