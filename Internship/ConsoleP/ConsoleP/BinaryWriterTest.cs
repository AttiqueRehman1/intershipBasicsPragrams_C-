using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleP
{
    internal class BinaryWriterTest
    {
        public void BinaryWriterTEst()
        {
            string filePath = @"C:\\At\\Attiq\\example.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    Console.WriteLine("Write your name ");
                    String nn = Console.ReadLine();
                    Console.WriteLine("Write you password");
                    String pass = Console.ReadLine();
                    String asdf=String.Concat(nn, pass);
                    byte[] byteArray = Encoding.ASCII.GetBytes(asdf);
                    string binaryString = string.Join(" ", byteArray);

                    // Write the binary value to the file
                    writer.WriteLine(binaryString); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Read the binary string from the file
                    string binaryString = reader.ReadLine();

                    // Convert the binary string back to a string
                    string decodedString = DecodeBinaryString(binaryString);

                    // Print the decoded string
                    Console.WriteLine(decodedString);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static string DecodeBinaryString(string binaryString)
        {
            string[] byteStrings = binaryString.Split(' ');
            byte[] byteArray = new byte[byteStrings.Length];

            for (int i = 0; i < byteStrings.Length; i++)
            {
                byteArray[i] = byte.Parse(byteStrings[i]);
            }

            return Encoding.UTF8.GetString(byteArray);
        }
    }
}
