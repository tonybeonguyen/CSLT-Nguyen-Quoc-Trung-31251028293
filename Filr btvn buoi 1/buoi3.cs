using System;
using System.Collections.Generic;
using System.Text;

namespace Filr_btvn_buoi_1
{
    internal class buoi3
    {
        static void Bai_1()
        {
            Console.Write("Nhập chỉ số điện cũ: ");
            decimal chisodiencu = decimal.Parse(Console.ReadLine());

            decimal chisodienmoi;
            do
            {
                Console.Write("Nhập chỉ số điện mới: ");
                chisodienmoi = decimal.Parse(Console.ReadLine());

                if (chisodienmoi >= chisodiencu)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ!");
                }
            }
            while (true);
            decimal tieuthu = chisodienmoi - chisodiencu;
            decimal tiendienchuathue = 0;
            decimal conlai = tieuthu;
            if (conlai > 0)
            {
                decimal kwhbac1 = Math.Min(conlai, 50);
                tiendienchuathue = tiendienchuathue + kwhbac1 * 1806;
                conlai = conlai - kwhbac1;
            }
            if (conlai > 0)
            {
                decimal kwhbac2 = Math.Min(conlai, 50);
                tiendienchuathue = tiendienchuathue + kwhbac2 * 1866;
                conlai = conlai - kwhbac2;

            }
            if (conlai > 0)
            {
                decimal kwhbac3 = Math.Min(conlai, 100);
                tiendienchuathue = tiendienchuathue + kwhbac3 * 2167;
                conlai = conlai - kwhbac3;
            }
            if (conlai > 0)
            {
                decimal kwbac4 = Math.Min(conlai, 100);
                tiendienchuathue = tiendienchuathue + kwbac4 * 2729;
                conlai = conlai - kwbac4;

            }
            if (conlai > 0)
            {
                tiendienchuathue = tiendienchuathue + conlai * 3050;

            }
            decimal vat = tiendienchuathue * 0.08m;
            Console.WriteLine($"Số điện tiêu thụ:{tieuthu}");
            Console.WriteLine($"Tiền điện chưa thuế:{tiendienchuathue:C} VND");
            Console.WriteLine($" Thuế VAT:{vat:C}VND");
            Console.WriteLine($" Tổng thanh toán:{tiendienchuathue + vat:C}VND");

        }

        static void Bai_2()
        {

        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_1();



            






        }
    }
}
