using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace Filr_btvn_buoi_1
{
    internal class buoi3
    {
        enum StockStatus
        {
            OutOfStock,
            LowStock,
            InStock,
            Discontinued
        }

        enum VehicleType
        {
            Motorbike,
            Car,
            Truck,

        }

        enum CurrencyType
        {
         USD,   
         EUR,
         JPY,
         GBP,

        }

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
            decimal tyGia = 0;
            string tenNgoaiTe = "";
            while (true)
            {


                Console.Write("Nhập số tiền:");
                string nhapvao = Console.ReadLine();
                if (decimal.TryParse(nhapvao, out vnd) && vnd >= 0)
                {
                    break;
                }
                Console.WriteLine("Lỗi: Số tiền không hợp lệ. Vui lòng nhập lại ");
            }

            while (true)
            {


                Console.WriteLine("Chọn loại ngoại tệ muốn đổi:");
                Console.WriteLine("1 - USD");
                Console.WriteLine("2 - EUR");
                Console.WriteLine("3 - JPY");
                Console.WriteLine("4 - GBP");
                Console.Write("Lựa chọn của bạn (1-4): ");
                string luaChon = Console.ReadLine();

                
                CurrencyType currency;

                switch (luaChon)
                {
                    case "1":
                        currency = CurrencyType.USD;
                        tyGia = 25400m;
                        tenNgoaiTe = "USD";
                        break;
                    case "2":
                        currency = CurrencyType.EUR;
                        tyGia = 27200m;
                        tenNgoaiTe = "EUR";
                        break;
                    case "3":
                        currency = CurrencyType.JPY;
                        tyGia = 165m;
                        tenNgoaiTe = "JPY";
                        break;
                    case "4":
                        currency = CurrencyType.GBP;
                        tyGia = 32100m;
                        tenNgoaiTe = "GBP";
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        continue;
                }
                break;
            }
            decimal phiDichVu = vnd * 0.005m;
            decimal soTienThucDoi = vnd - phiDichVu;
            decimal soTienNgoaiTe = soTienThucDoi / tyGia;

            

            Console.WriteLine($"Phí dịch vụ (0.5%): {phiDichVu:N0} VNĐ");
            Console.WriteLine($"Số tiền VNĐ tính đổi: {soTienThucDoi:N0} VNĐ");
            Console.WriteLine($"Số tiền {tenNgoaiTe} nhận được: {soTienNgoaiTe:N2} {tenNgoaiTe}");




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

        static void Bai_10()
        {
            string idsp = "KB - 09";
            string tensp = "Bàn phím cơ Akko";
            int? quantity = null;
            int minThreshold = 10;
            DateTime? restockDate = null;
            int quantity1 = quantity ?? 0;
            StockStatus status;
            if (quantity == null || quantity == 0)
            {
                status = StockStatus.OutOfStock;
            }
            else if (quantity < minThreshold)
            {
                status = StockStatus.LowStock;
            }
            else
            {
                status = StockStatus.InStock;
            }
            string ngaynhap = restockDate?.ToString("dd/MM/yyyy") ?? "Chưa có lịch nhập hàng";
            Console.WriteLine("--- INPUT / DATA ---");
            Console.WriteLine($"Sản phẩm: {tensp} (Mã: {idsp})");
            Console.WriteLine($"Số lượng tồn kho: {(quantity.HasValue ? quantity.ToString() : "null (Chưa kiểm kê)")}");
            Console.WriteLine($"Restock Date: {(restockDate.HasValue ? restockDate.Value.ToString("dd/MM/yyyy") : "null")}");

            Console.WriteLine("\n--- OUTPUT ---");
            Console.WriteLine($"Số lượng hiển thị: {quantity1} {(quantity == null ? "(Cảnh báo: Dữ liệu trống)" : "")}");
            Console.WriteLine($"Trạng thái kho: {status} (Hết hàng)");
            Console.WriteLine($"Dự kiến nhập hàng: {ngaynhap}");

        }

        static void Bai_11()
        {
            decimal stgbd = 0;
            double lsm = 0;
            int khg = 0;
            while (true)
            {
                Console.Write("Số tiền gửi:");
                string stgnhap = Console.ReadLine();
                if (decimal.TryParse(stgnhap, out stgbd) && stgbd > 0)
                {
                    break;
                }
                Console.WriteLine("Số tiền gửi không hợp lệ");


            }
            while (true)
            {
                Console.Write("lãi suất năm r (%):");
                string lsnhap = Console.ReadLine();
                if (double.TryParse(lsnhap, out lsm) && lsm > 0)
                {
                    break;
                }
                Console.WriteLine("Lãi suất không hợp lệ");
            }
            while (true)
            {
                Console.Write("Kỳ hạn gửi (tháng):");
                string khgnhap = Console.ReadLine();
                if (int.TryParse(khgnhap, out khg) && khg > 0)
                {
                    break;
                }
                Console.WriteLine("Kỳ hạn gửi không hợp lệ");
            }
            decimal ld = stgbd * (decimal)(lsm / 100) * (decimal)(khg / 12.0);
            double lkd = (double)stgbd * Math.Pow((1 + (lsm / 100) / 12), khg) - (double)(stgbd);
            decimal lk = (decimal)lkd;
            Console.WriteLine($"Tổng tiền lãi(lãi đơn):{ld:C}VND");
            Console.WriteLine($"Tổng tiền lãi(lãi kép):{lk:C}VND");
            Console.WriteLine($"Lợi nhuận chênh lệch:{lk - ld:C}VND");


        }

        static void Bai_12()
        {

        }

        static void Bai_13()
        {
            Console.Write("Loại xe");
            string lxnhap = Console.ReadLine();
            Console.Write("Giờ vào (yyyy-MM-đd HH:mm):");
            string lvnhap= Console.ReadLine();
           
            Console.Write("Giờ ra (yyyy-MM-đd HH:mm):");
            string lrnhap = Console.ReadLine();
            DateTime lv = DateTime.Parse(lvnhap);
            DateTime lr = DateTime.Parse(lrnhap);
            TimeSpan ttg = lr - lv;
            double ttg1 = Math.Ceiling(ttg.TotalHours);
            decimal haigd = 0;
            decimal giosau = 0;
            decimal giagiosau = 0;
            decimal phuphiquadem = 0;


            VehicleType vehicle;
            if (lxnhap.Equals("Motorbike", StringComparison.OrdinalIgnoreCase))
            {
                vehicle = VehicleType.Motorbike;
                haigd = 5000;
                giosau = 2000;
            }
            else if (lxnhap.Equals("Car", StringComparison.OrdinalIgnoreCase))
            {
                vehicle = VehicleType.Car;
                haigd = 20000;
                giosau = 10000;

            }
            else 
            {
                vehicle = VehicleType.Truck;
                haigd = 50000;
                giosau = 25000;
            }
            if (ttg1 > 2)
            {
                giagiosau = giosau * (decimal)(ttg1 - 2);
            }
            bool quadem = (lr.Date > lv.Date);
            if (quadem)
            {
                phuphiquadem = 60000;
            }
            Console.WriteLine($"Tổng thời gian đỗ:{ttg1}");
            Console.WriteLine($"Phi 2 giờ đầu: {haigd}");
            Console.WriteLine($"Tổng phí:{phuphiquadem + haigd + giagiosau}");

        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            //   Bai_1();
            //Bai_2();
            //Bai_3(); 
            //Bai_4();
            //Bai_5();
            //Bai_6();
            //Bai_7();
            //Bai_8();
            //Bai_9();
            // Bai_10();
            // Bai_11();
            Bai_12();
            //Bai_13();
        
        }


    }
}















