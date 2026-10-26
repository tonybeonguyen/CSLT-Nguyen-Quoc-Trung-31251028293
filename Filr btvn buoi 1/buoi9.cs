using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;

namespace Filr_btvn_buoi_1
{
    internal class buoi9
    {
        static void bai_1()
        {
            string filePath = "blank_file.txt";

            using (FileStream fs = File.Create(filePath))
            {
            }

            Console.WriteLine($"Đã tạo file trống thành công tại: {Path.GetFullPath(filePath)}");
        
        }
        static void bai_2()
        {
            string filePath = "blank_file.txt";

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine($"Đã xóa file thành công: {Path.GetFullPath(filePath)}");
            }
            else
            {
                Console.WriteLine($"File không tồn tại: {Path.GetFullPath(filePath)}");
            
        }
        
        }
        static void bai_4()
        {
            string filePath = "my_text_file.txt";
            string content = "tôi yêu ueh.";

            File.WriteAllText(filePath, content);
            Console.WriteLine($"Đã tạo file tại: {Path.GetFullPath(filePath)}");

            string readContent = File.ReadAllText(filePath);
            Console.WriteLine("Nội dung đọc được từ file:");
            Console.WriteLine(readContent);
        }
        static void bai_3()
        {
            string filePath = "my_text_file.txt";
            string content = "tôi yêu ueh";

            File.WriteAllText(filePath, content);

            Console.WriteLine($"Đã tạo file và ghi nội dung thành công tại: {Path.GetFullPath(filePath)}");
        }
        static void bai_5()
        {
            string filePath = "string_array.txt";
            string[] lines = {
            "Dòng 1: tôi yêu ueh.",
            "Dòng 2: tôi yêu cơ sở lập trình.",
            "Dòng 3: tôi là con người."
        };

            File.WriteAllLines(filePath, lines);

            Console.WriteLine($"Đã tạo file và ghi mảng chuỗi thành công tại: {Path.GetFullPath(filePath)}");
        }
        static void bai_6()
        {
            string filePath = "my_text_file.txt";

            File.WriteAllText(filePath, "Nội dung ban đầu.\n");

            string textToAppend = "Đây là dòng chữ được nối thêm vào cuối file.\n";
            File.AppendAllText(filePath, textToAppend);

            Console.WriteLine($"Đã nối thêm nội dung vào file thành công tại: {Path.GetFullPath(filePath)}");
            Console.WriteLine("Toàn bộ nội dung file sau khi nối:");
            Console.WriteLine(File.ReadAllText(filePath));
        }
        static void bai_7()
        {
            string sourceFile = "source_file.txt";
            string destFile = "copied_file.txt";
            string content = "Đây là nội dung gốc của file.";

            File.WriteAllText(sourceFile, content);
            Console.WriteLine($"Đã tạo file gốc tại: {Path.GetFullPath(sourceFile)}");

            File.Copy(sourceFile, destFile, true);
            Console.WriteLine($"Đã sao chép sang file mới tại: {Path.GetFullPath(destFile)}");

            string copiedContent = File.ReadAllText(destFile);
            Console.WriteLine("Nội dung của file sau khi sao chép:");
            Console.WriteLine(copiedContent);
        }
        static void bai_8()
        {
            string sourceFile = "original_file.txt";
            string destinationFile = "moved_file.txt";

            if (File.Exists(destinationFile))
            {
                File.Delete(destinationFile);
            }

            File.WriteAllText(sourceFile, "Đây là nội dung của file trước khi đổi tên/di chuyển.");
            Console.WriteLine($"Đã tạo file ban đầu tại: {Path.GetFullPath(sourceFile)}");

            File.Move(sourceFile, destinationFile);
            Console.WriteLine($"Đã di chuyển (đổi tên) sang file mới tại: {Path.GetFullPath(destinationFile)}");

            Console.WriteLine("Nội dung của file sau khi di chuyển:");
            Console.WriteLine(File.ReadAllText(destinationFile));
        }
        static void bai_9()
        {
            string filePath = "my_text_file.txt";

            string[] lines = {
            "Dòng 1: tôi yêu ueh.",
            "Dòng 2:tôi yêu ueh 2.",
            "Dòng 3: tôi yêu ueh3"
        };

            File.WriteAllLines(filePath, lines);
            Console.WriteLine($"Đã tạo file mẫu tại: {Path.GetFullPath(filePath)}");

            string firstLine = File.ReadAllLines(filePath)[0];

            Console.WriteLine("Nội dung dòng đầu tiên đọc được:");
            Console.WriteLine(firstLine);
        }
        static void bai_10()
        {
            string filePath = "my_text_file.txt";

            string[] lines = {
            "Dòng 1: tôi yêu ueh.",
            "Dòng 2:tôi yêu ueh 2.",
            "Dòng 3: tôi yêu ueh3"
        };

            File.WriteAllLines(filePath, lines);
            Console.WriteLine($"Đã tạo file tại: {Path.GetFullPath(filePath)}");

            string[] allLines = File.ReadAllLines(filePath);
            string lastLine = allLines[allLines.Length - 1];

            Console.WriteLine("Nội dung dòng cuối cùng đọc được:");
            Console.WriteLine(lastLine);
        }
        static void bai_11()
        {
            string filePath = "my_text_file.txt";

            string[] lines = {
            "Dòng 1: tôi yêu ueh.",
            "Dòng 2:tôi yêu ueh 2.",
            "Dòng 3: tôi yêu ueh3"
        };

            File.WriteAllLines(filePath, lines);
            Console.WriteLine($"Đã tạo file tại: {Path.GetFullPath(filePath)}");

            Console.Write("Nhập số dòng cuối muốn đọc (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n{n} dòng cuối cùng của file là:");
            var lastNLines = File.ReadLines(filePath).TakeLast(n);

            foreach (string line in lastNLines)
            {
                Console.WriteLine(line);
            }
        }
        static void bai_12()
        {
            string filePath = "my_text_file.txt";

            string[] lines = {
            "Dòng 1: tôi yêu ueh.",
            "Dòng 2:tôi yêu ueh 2.",
            "Dòng 3: tôi yêu ueh3"
        };

            File.WriteAllLines(filePath, lines);
            Console.WriteLine($"Đã tạo file tại: {Path.GetFullPath(filePath)}");

            Console.Write("Nhập số thứ tự dòng cần đọc (bắt đầu từ 1): ");
            int lineNumber = int.Parse(Console.ReadLine());

            string[] allLines = File.ReadAllLines(filePath);

            if (lineNumber >= 1 && lineNumber <= allLines.Length)
            {
                Console.WriteLine($"Nội dung dòng thứ {lineNumber}:");
                Console.WriteLine(allLines[lineNumber - 1]);
            }
            else
            {
                Console.WriteLine($"Không tìm thấy dòng {lineNumber}. File chỉ có {allLines.Length} dòng.");
            }
        }
        static void bai_13()
        {
            string filePath = "my_text_file.txt";

            string[] lines = {
            "Dòng 1: tôi yêu ueh.",
            "Dòng 2:tôi yêu ueh 2.",
            "Dòng 3: tôi yêu ueh3"
        };

            File.WriteAllLines(filePath, lines);
            Console.WriteLine($"Đã tạo file tại: {Path.GetFullPath(filePath)}");

            int lineCount = File.ReadAllLines(filePath).Length;

            Console.WriteLine($"Số dòng có trong file là: {lineCount}");
        
        }
        static void bai_14()
        {
            string rootPath = "ThuMucMau";

            Directory.CreateDirectory(Path.Combine(rootPath, "ThuMucCon1"));
            Directory.CreateDirectory(Path.Combine(rootPath, "ThuMucCon2"));

            string[] lines = {
            "Dòng 1: tôi yêu ueh.",
            "Dòng 2:tôi yêu ueh 2.",
            "Dòng 3: tôi yêu ueh3"
        };

            File.WriteAllLines(Path.Combine(rootPath, "file_goc.txt"), lines);
            File.WriteAllLines(Path.Combine(rootPath, "ThuMucCon1", "file_con.txt"), lines);

            Console.WriteLine($"Cấu trúc thư mục tại: {Path.GetFullPath(rootPath)}\n");

            PrintDirectoryTree(new DirectoryInfo(rootPath), "");


            static void PrintDirectoryTree(DirectoryInfo dir, string indent)
            {
                Console.WriteLine($"{indent}[Thư mục] {dir.Name}");
                indent += "    ";

                foreach (FileInfo file in dir.GetFiles())
                {
                    Console.WriteLine($"{indent}└── [File] {file.Name}");
                }

                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    PrintDirectoryTree(subDir, indent);
                }
            }
        }
        static void bai_15()
        {

        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bai_1();
            bai_2();
            bai_3();
            bai_4();
            bai_5();
            bai_6();
            bai_7();
            bai_8();
            bai_9();
            bai_10();
            bai_11();
            bai_12();
            bai_13();
            bai_14();
            bai_15();
        } 

        }
}
