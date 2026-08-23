using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
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


        static void Bai_5()
        {
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
                if (int.TryParse(nhapvaosta, out tca) && tca > 0)

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
            char diemChu;
            double gpa4;
            string xepLoai;
            if (dtb >= 8.5)
            {
                diemChu = 'A';
                gpa4 = 4.0;
                xepLoai = "Xuất sắc / Giỏi";
            }
            else if (dtb >= 7.0)
            {
                diemChu = 'B';
                gpa4 = 3.0;
                xepLoai = "Khá";
            }
            else if (dtb >= 5.5)
            {
                diemChu = 'C';
                gpa4 = 2.0;
                xepLoai = "Trung bình";
            }
            else if (dtb >= 4.0)
            {
                diemChu = 'D';
                gpa4 = 1.0;
                xepLoai = "Yếu";
            }
            else
            {
                diemChu = 'F';
                gpa4 = 0.0;
                xepLoai = "Kém (Trượt)";
            }


            Console.WriteLine($"Điểm TB Thang 10: {dtb:N2}");
            Console.WriteLine($"Điểm Chữ Quy Đổi: {diemChu}");
            Console.WriteLine($"Điểm GPA Thang 4: {gpa4:N1}");
            Console.WriteLine($"Xếp Loại Học Lực: {xepLoai}");
        }

        static void Bai_6()
        {
            static string bodau(string text)
            {
                string source = "áàảãạăắằẳẵặâấầẩẫậéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵđ";
                string destination = "aaaaaaaaaaaaaaaaaeeeeeeeeeeeiiiiiooooooooooooooooouuuuuuuuuuuyyyyyd";

                char[] chars = text.ToLower().ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    int index = source.IndexOf(chars[i]);
                    if (index >= 0)
                    {
                        chars[i] = destination[index];
                    }
                }
                return new string(chars);
            }
            Console.Write("Nhập họ tên thô:");
            string tentho = Console.ReadLine();


            string[] ten = tentho.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


            string ten1 = string.Join(" ", ten);


            string tendung = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ten1.ToLower());
            string[] tendungtach = tendung.Split(' ');



            string ho = tendungtach.Length > 0 ? tendungtach[0] : "";
            string tenng = tendungtach.Length > 0 ? tendungtach[tendungtach.Length - 1] : "";

            string tenDem = "";
            if (tendungtach.Length > 2)
            {

                string[] middleWords = new string[tendungtach.Length - 2];
                Array.Copy(tendungtach, 1, middleWords, 0, tendungtach.Length - 2);
                tenDem = string.Join(" ", middleWords);

            }

            Console.WriteLine($"Họ tên chuẩn hóa:{tendung}");
            Console.WriteLine($"Họ: {ho} | Tên đệm: {tenDem} | Tên: {tenng}");
            string ho1 = bodau(ho).ToLower();
            string tendem1 = bodau(tenDem).ToLower().Replace(" ", "");
            string tenng1 = bodau(tenng).ToLower();
            Console.WriteLine($"Usernam tạo tự động: {tenng1}.{ho1}{tendem1}");
            Console.WriteLine($"Email cấp phát:{tenng1}.{ho1}{tendem1}@company.edu.vn");
        }

        static void Bai_7()
        {
            double qd = 0;
            double xang = 0;
            decimal giaxang = 0;
            int snd = 0;
            while (true)
            {


                Console.Write("Quãng đường (km):");
                string nhapvaoqd = Console.ReadLine();
                if (double.TryParse(nhapvaoqd, out qd) && qd >= 0)
                {
                    break;
                }
                Console.WriteLine("Quãng đường không hợp lệ");
            }
            while (true)
            {


                Console.Write("Mức tiêu hao (l/100km):");
                string nhapvaoxang = Console.ReadLine();
                if (double.TryParse(nhapvaoxang, out xang) && xang >= 0)
                {
                    break;
                }
                Console.WriteLine("Mức tiêu hao không hợp lệ");
            }
            while (true)
            {


                Console.Write("Giá xăng hiện tại (VND/l):");
                string nhapvaogx = Console.ReadLine();
                if (decimal.TryParse(nhapvaogx, out giaxang) && giaxang >= 0)
                {
                    break;
                }
                Console.WriteLine("Giá xăng không hợp lệ");
            }
            while (true)
            {


                Console.Write("Số người đi");
                string nhapvaosnd = Console.ReadLine();
                if (int.TryParse(nhapvaosnd, out snd) && snd >= 0)
                {
                    break;
                }
                Console.WriteLine("Số người đi không hợp lệ");
            }
            double txd = (qd / 100) * xang;
            decimal cp = (decimal)txd * giaxang;
            decimal cpmng = Math.Ceiling(cp / snd);
            Console.WriteLine($"Tổng nhiên liệu tiêu thụ:{txd}lít");
            Console.WriteLine($"Tổng chi phí xăng dầu:{cp:C}VND");
            Console.WriteLine($"Chi phí mỗi người:{cpmng:C}VND");
        }

        static void Bai_8()
        {
            string otpdung = "839201";
            DateTime tgt = DateTime.Now;
            Console.WriteLine($"[Hệ thống] Đã gửi mã OTP (Mã đúng: {otpdung}) vào lúc: {tgt:HH:mm:ss}");


            Console.Write("Nhập mã OTP:");
            string otpnhap = Console.ReadLine();
            int giaytroiqua;
            while (true)
            {
                Console.Write("Nhập số giây trôi qua kể từ lúc phát hành ( giây): ");
                string giaytroiquanhap = Console.ReadLine();
                if (int.TryParse(giaytroiquanhap, out giaytroiqua))
                {
                    break;
                }
                Console.WriteLine("Số giây trôi qua không hợp lệ");
            }




            DateTime tgxm = tgt.AddSeconds(giaytroiqua);
            bool ketqua = true;
            if (string.IsNullOrEmpty(otpnhap) || otpnhap.Length != 6)
            {
                ketqua = false;
            }
            else
            {
                foreach (char c in otpnhap)
                {
                    if (!char.IsDigit(c))
                    {
                        ketqua = false;
                        break;

                    }
                }
            }
            if (!ketqua)
            {
                Console.WriteLine("Trạng thái xác thực: LỖI CỤ THỂ - Định dạng không hợp lệ (OTP phải gồm đúng 6 chữ số).");
                return;
            }
            TimeSpan tgc = tgxm - tgt;
            if (tgc.TotalSeconds > 300)
            {
                Console.WriteLine($"Trạng thái xác thực: LỖI CỤ THỂ - Hết hạn OTP (Thời gian trôi qua: {tgc.TotalSeconds} giây).");
                return;
            }
            if (otpnhap != otpdung)
            {
                Console.WriteLine("Trạng thái xác thực: LỖI CỤ THỂ - Mã sai.");
                return;
            }
            Console.WriteLine($"Thời gian trôi qua: {tgc.Minutes} phút {tgc.Seconds} giây");
            Console.WriteLine("Trạng thái xác thực: THÀNH CÔNG - Giao dịch đã được phê duyệt.");
        }
        
        static void Bai_9()
        {
            decimal gross = 0;
            int snpt = 0;
            while (true)
            {
                Console.Write("Lương gross:");
                string grossnhap = Console.ReadLine();
                if (decimal.TryParse(grossnhap, out gross) && gross >= 0)
                {
                    break;
                }
                Console.WriteLine("Lương gross không hợp lệ");
            }
            while (true)
            {
                Console.Write("Số người phụ thuộc:");
                string snptnhap = Console.ReadLine();
                if (int.TryParse(snptnhap, out snpt) && snpt >= 0)
                {
                    break;
                }
                Console.WriteLine("Số người phụ thuộc không hợp lệ");

            }

            decimal gtbh = gross * 0.105m;
            decimal tnct = gross - gtbh - 11000000 - 4400000 * snpt;
            if (tnct < 0)
            {
                tnct = 0;
            }
            decimal ttncn = 0;

            if (tnct <= 5000000)
            {
                ttncn = tnct * 0.05m;
            }
            else if (tnct > 500000 && tnct <= 10000000)
            {
                ttncn = 5000000m * 0.05m + (tnct - 5000000) * 0.1m;
            }
            else if (tnct > 10000000 && tnct <= 18000000)
            {
                ttncn = 5000000 * 0.05m + 5000000 * 0.1m + (tnct - 10000000) * 0.15m;
            }
            else if (tnct > 18000000)
            {
                ttncn = 5000000 * 0.05m + 5000000 * 0.1m + 8000000 * 0.15m + (tnct - 18000000) * 0.2m;
                Console.WriteLine($"Giảm trừ bảo hiểm (10.5%): {gtbh:C}");
            }
            Console.WriteLine($"Thu nhập chịu thuế: {tnct:C}");
            Console.WriteLine($"Thuế TNCN phải nộp: {ttncn:C}");
            Console.WriteLine($"Lượng net thực nhận: {gross - gtbh - ttncn:C}");
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            //   Bai_1();
            //Bai_2();
            //Bai_3();
            //Bai_4();
            //  Bai_5();
            //Bai_6();
            //Bai_7();
            //Bai_8();
            //Bai_9();
            


        }


    }
}
















