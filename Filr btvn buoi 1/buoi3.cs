using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Channels;

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
            double cc;
                double kg;
            while (true)
            {


                Console.Write("Nhập chiều cao(m): ");
                string nhapcc = Console.ReadLine();
                if (double.TryParse(nhapcc, CultureInfo.InvariantCulture, out cc) && cc > 0)
                {
                    break;
                }
                Console.WriteLine("Chiều cao không hợp lệ");
            }
            while (true)
            {


                Console.Write("Nhập cân năng(kg): ");
                string nhapkg = Console.ReadLine();

                if (double.TryParse(nhapkg, CultureInfo.InvariantCulture, out kg) && kg > 0)
                {
                    break;
                }
                Console.WriteLine("Cân nặng không hợp lệ");
            }
                double bmi = kg / (cc * cc);
            double cannangtoithieu = 18.5 * cc * cc;
            double cannangtoida = 22.9 * cc * cc;
            Console.WriteLine($"Chỉ số BMI của bạn là {bmi:F2}");
            if (bmi < 18.5)
            {
                Console.WriteLine("Phân loại sức khỏe: Gầy");

            }
            else if (bmi >= 18.5 && bmi < 23)

            {
                Console.WriteLine("Phân loại sức khỏe: Bình thường");

            }
            else if (bmi >= 23 && bmi < 25)
            {
                Console.WriteLine("Phân loại sức khỏe: Thừa cân");
            }
            else if (bmi >= 25)
            {
                Console.WriteLine("Phân loại sức khỏe: Béo phì");
            }
            Console.WriteLine($"Khuyên dùng: Cân năng lý tưởng của bạn nên từ {cannangtoithieu}kg đến {cannangtoida}kg");
        }

        static void Bai_3()
        {
            decimal vnd = 0;
            while (true)
            {

           
            Console.Write("Nhập số tiền:");
                string nhapvao = Console.ReadLine();
                if (decimal.TryParse(nhapvao, out vnd) && vnd >= 0)
                {
                    break;
                }
                Console.WriteLine("Lỗi: Số tiền không hợp lệ. Vui lòng nhập lại số dương!\n");
            }

           
            Console.WriteLine("Chọn ngoại tệ 1=usd, 2= eur, 3=jpy, 4= gbp");
            decimal pdv = vnd * 0.005m;
            decimal vndd = vnd - pdv;
            decimal usd = 1m / 25400m * vndd;
            decimal eur = 1m / 27200m * vndd;
            decimal jpy = 1m / 165m * vndd;
            decimal gbp = 1m / 32100m * vndd;
            Console.WriteLine($"Phí dịch vụ:{pdv:C}VND");
            Console.WriteLine($"Số tiền vnd tính đổi:{vndd:C}VND");
            Console.Write("Chọn số");
            int chon = int.Parse(Console.ReadLine());
            if (chon == 1)
            {
                Console.WriteLine($"Số tiền usd nhận được:{usd:N2}");

            }
            else if (chon == 2)
            {
                Console.WriteLine($"Số tiền eur nhận được:{eur:N2}");

            }
            else if (chon == 3)
            {
                Console.Write($"Số tiền jpy nhận được:{jpy:N2}");

            }
            else if (chon == 4)
            {
                Console.Write($"Số tiền gbp nhận được{gbp:N2}");

            }




        }

        static void Bai_4()
        {
            while (true)
            {
                Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
                string ns = Console.ReadLine();

                if (DateTime.TryParseExact(ns, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngaysinh))
                {
                    DateTime today = DateTime.Now.Date;

                    int tuoi = today.Year - ngaysinh.Year;
                    if (ngaysinh.Date > today.AddYears(-tuoi))
                    {
                        tuoi--;
                    }

                    TimeSpan lived = today - ngaysinh;
                    int tongsongay = (int)lived.TotalDays;

                    DateTime sntt = ngaysinh.AddYears(today.Year - ngaysinh.Year);
                    if (sntt < today)
                    {
                        sntt = ngaysinh.AddYears(today.Year - ngaysinh.Year + 1);
                    }

                    int ngayconlai = (int)(sntt - today).TotalDays;

                    Console.WriteLine($"Tuổi hiện tại: {tuoi} tuổi");
                    Console.WriteLine($"Bạn đã sống tổng cộng: {tongsongay:N0} ngày");
                    Console.WriteLine($"Sinh nhật tiếp theo còn: {ngayconlai} ngày nữa");
                    break;
                }
                else
                {
                    Console.WriteLine("Lỗi: Định dạng ngày sinh không hợp lệ. Vui lòng nhập lại theo đúng định dạng dd/MM/yyyy!\n");
                }
            }
        }






        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //   Bai_1();
            //Bai_2();
            //Bai_3();
            //Bai_4();
            int tcc;
            int tct;
            int tca;
            double dc;
            double dt;
            double da;

            while (true)
            {
                Console.Write("Số tín chỉ lập trình của bạn là:");
                string nhapvaotcc = Console.ReadLine();
                if (int.TryParse(nhapvaotcc, out tcc) && tcc > 0)
                {
                    break;

                }
                Console.WriteLine("Số tín chỉ không hợp lệ");
            }
                while (true)
                {
                    Console.Write("Sô điểm môm lập trình của bạn là:");
                    String nhapvaodc = Console.ReadLine();
                if (double.TryParse(nhapvaodc, out dc) && dc >= 0 && dc <= 10)
                {
                    break;
                }
                Console.WriteLine("Số điểm không hợp lệ");
                }
                while (true)
            {
                Console.Write("Số tín chỉ toán rời rạc của bạn là:");
                string nhapvaotct = Console.ReadLine();
                if (int.TryParse(nhapvaotct, out tct) && tct > 0)
                {
                    break;

                }
                Console.WriteLine("Số tín chỉ không hợp lệ");
                
            }
                while (true)
            {
                Console.Write("Số điểm toán rời rạc của bạn là:");
                string nhapvaodt = Console.ReadLine();
                if (double.TryParse(nhapvaodt, out dt) && dt >= 0 && dt <= 10)
                {
                    break;
                }
                Console.WriteLine("Số điểm không hợp lệ");
            }
                while (true)
            {
                Console.Write("Số tín chỉ môn tiếng anh của bạn là:");
                string nhapvaosta = Console.ReadLine();
                if (int.TryParse(nhapvaosta, out tca)&& tca > 0)

                {
                    break;
                }
                Console.WriteLine("Số tín chỉ không hợp lệ");
            }
                while (true)
            {
                Console.Write("Số điểm tiếng anh của bạn là:");
                string nhapvaoda = Console.ReadLine();
                if (double.TryParse(nhapvaoda, out da) && da >= 0 && da <= 10)
                {
                    break;
                }
                Console.WriteLine("Số điểm không hợp lệ");
            }
            double dtb = (dc * tcc + da * tca + dt * tct) / (tcc + tca + tct);

        }


    }
    }

















