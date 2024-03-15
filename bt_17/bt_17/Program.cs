using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_17
{
    internal class Program
    {
        public static string MaHoaKyTu(string input)
        {
            string result = "";
            char[] inputSplit = input.ToCharArray();

            foreach (char item in inputSplit)
            {
                byte asciiCode = Convert.ToByte(item);
                if (asciiCode == 32)
                {
                    result += " ";
                }
                else
                {
                    result += asciiCode;
                }
            }
            
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Mời bạn nhập vào ký tự cần mã hóa:");
            string input = Console.ReadLine();
            string rs = MaHoaKyTu(input);
            Console.WriteLine($"Kết quả sau khi mã hóa: {rs}");

            Console.ReadKey();
        }
    }
}
