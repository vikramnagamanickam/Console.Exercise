using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileReadandWrite
{

   public class ReadAndWrite
   {
    public void File()
    { 
        string data;
        StreamReader Reader = null;
        StreamWriter writer = null;
        try
        {
            Reader = new StreamReader("C:\\Users\\Admin\\Desktop\\read.txt");
            
            data = Reader.ReadLine();
            while (data != null)
            {
                Console.WriteLine(data);
                data = Reader.ReadLine();
            }
                Reader.Close();
                writer = new StreamWriter("C:\\Users\\Admin\\Desktop\\write.txt");
                writer.WriteLine("hi i am vikram");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            
            writer.Close();
        }
    }
   }
 }
    

