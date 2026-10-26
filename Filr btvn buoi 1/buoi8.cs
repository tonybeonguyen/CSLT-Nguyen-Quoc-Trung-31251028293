using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Filr_btvn_buoi_1
{
    internal class buoi8
    {
        static void bai_1()
        {
            string filePath = "mytest.txt";

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine($"Đã xóa tập tin '{filePath}' thành công khỏi đĩa!");
            }
            else
            {
                Console.WriteLine($"Tập tin '{filePath}' không tồn tại trên đĩa.");
            }
        }
        static void bai_2()
        {
            string filePath = "mytest.txt";

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine($"Đã xóa tập tin '{filePath}' thành công khỏi đĩa!");
            }
            else
            {
                Console.WriteLine($"Tập tin '{filePath}' không tồn tại trên đĩa.");
            }
        }
        static void bai_3()
        {
            string filePath = "mytest.txt";
            string content = "Dòng 1: tôi yêu ueh 1.";

            File.WriteAllText(filePath, content);
            Console.WriteLine($"Đã tạo tập tin '{filePath}' và ghi nội dung thành công!");

        }
        static void bai_4()
        {
            string filePath = "mytest.txt";
            string content = "Dòng 1: tôi yêu ueh 1.\nDòng 2: tôi yêu ueh 2.\nDòng 3: tôi yêu ueh 3.";

            File.WriteAllText(filePath, content);
            Console.WriteLine($"Đã tạo tập tin '{filePath}' thành công!\n");

            Console.WriteLine("Nội dung đọc từ tập tin:");
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        static void bai_5()
        {
            string filePath = "mytest.txt";
            string[] lines = new string[]
            {
    "Dòng 1: tôi yêu ueh 1.",
    "Dòng 2: tôi yêu ueh 2.",
    "Dòng 3: tôi yêu ueh 3."
            };

            File.WriteAllLines(filePath, lines);
            Console.WriteLine($"Đã tạo tập tin '{filePath}' và ghi mảng chuỗi thành công!");
        }
        static void bai_6()
        {
            string filePath = "mytest.txt";
            string appendText = Environment.NewLine + "Đây là dòng nội dung được nối thêm vào file.";

            if (File.Exists(filePath))
            {
                File.AppendAllText(filePath, appendText);
                Console.WriteLine($"Đã nối thêm nội dung vào tập tin '{filePath}' thành công!");

                Console.WriteLine("\nNội dung tập tin sau khi cập nhật:");
                string content = File.ReadAllText(filePath);
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine($"Tập tin '{filePath}' không tồn tại trên đĩa.");
            }
        }
        static void bai_7()
        {
            string sourcePath = "source.txt";
            string targetPath = "destination.txt";
            string[] lines = new string[]
            {
    "Dòng 1: tôi yêu ueh 1.",
    "Dòng 2: tôi yêu ueh 2.",
    "Dòng 3: tôi yêu ueh 3."
            };

            File.WriteAllLines(sourcePath, lines);
            Console.WriteLine($"Đã tạo tập tin gốc '{sourcePath}' thành công!");

            File.Copy(sourcePath, targetPath, true);
            Console.WriteLine($"Đã sao chép sang tập tin mới '{targetPath}' thành công!\n");

            Console.WriteLine($"Nội dung của tập tin sau khi sao chép ({targetPath}):");
            string copiedContent = File.ReadAllText(targetPath);
            Console.WriteLine(copiedContent);
        }

        static void bai_8()
        {
            string sourcePath = "original.txt";
            string targetPath = "renamed.txt";
            string[] lines = new string[]
            {
    "Dòng 1: tôi yêu ueh 1.",
    "Dòng 2: tôi yêu ueh 2.",
    "Dòng 3: tôi yêu ueh 3."
            };

            File.WriteAllLines(sourcePath, lines);
            Console.WriteLine($"Đã tạo tập tin '{sourcePath}' thành công!");

            if (File.Exists(targetPath))
            {
                File.Delete(targetPath);
            }

            File.Move(sourcePath, targetPath);
            Console.WriteLine($"Đã di chuyển/đổi tên tập tin sang '{targetPath}' trong cùng thư mục thành công!");

            if (File.Exists(targetPath))
            {
                Console.WriteLine("\nNội dung của tập tin sau khi di chuyển:");
                Console.WriteLine(File.ReadAllText(targetPath));
            }
        }
        static void bai_9()
        {
            string filePath = "mytest.txt";
            string[] lines = new string[]
            {
    "Dòng 1: tôi yêu ueh 1.",
    "Dòng 2: tôi yêu ueh 2.",
    "Dòng 3: tôi yêu ueh 3."
            };

            File.WriteAllLines(filePath, lines);
            Console.WriteLine($"Đã tạo tập tin '{filePath}' với dữ liệu mẫu thành công!\n");

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string firstLine = sr.ReadLine();

                    if (firstLine != null)
                    {
                        Console.WriteLine($"Dòng đầu tiên của tập tin là:\n{firstLine}");
                    }
                    else
                    {
                        Console.WriteLine("Tập tin đang rỗng.");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Tập tin '{filePath}' không tồn tại trên đĩa.");
            }
        }
        static void bai_10()
        {
            string filePath = "mytest.txt";
            string[] lines = new string[]
            {
    "Dòng 1: tôi yêu ueh 1.",
    "Dòng 2: tôi yêu ueh 2.",
    "Dòng 3: tôi yêu ueh 3.",
    "Dòng 4: tôi yêu ueh 4."
            };

            File.WriteAllLines(filePath, lines);
            Console.WriteLine($"Đã tạo tập tin '{filePath}' với dữ liệu mẫu thành công!\n");

            if (File.Exists(filePath))
            {
                string lastLine = null;
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lastLine = line;
                    }
                }

                if (lastLine != null)
                {
                    Console.WriteLine($"Dòng cuối cùng của tập tin là:\n{lastLine}");
                }
                else
                {
                    Console.WriteLine("Tập tin đang rỗng.");
                }
            }
            else
            {
                Console.WriteLine($"Tập tin '{filePath}' không tồn tại trên đĩa.");
            }
        }
        static void bai_11()
        {
            string filePath = "mytest.txt";
            string[] sampleLines = new string[]
            {
    "Dòng 1: tôi yêu ueh 1.",
    "Dòng 2: tôi yêu ueh 2.",
    "Dòng 3: tôi yêu ueh 3.",
    "Dòng 4: tôi yêu ueh 4.",
    "Dòng 5: tôi yêu ueh 5."
            };

            File.WriteAllLines(filePath, sampleLines);
            Console.WriteLine($"Đã tạo tập tin '{filePath}' với {sampleLines.Length} dòng nội dung thành công!\n");

            Console.Write("Nhập số dòng cuối cùng cần đọc (n): ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                string[] allLines = File.ReadAllLines(filePath);
                int totalLines = allLines.Length;

                int startIndex = Math.Max(0, totalLines - n);

                Console.WriteLine($"\n{Math.Min(n, totalLines)} dòng cuối cùng của tập tin là:");
                for (int i = startIndex; i < totalLines; i++)
                {
                    Console.WriteLine(allLines[i]);
                }
            }
            else
            {
                Console.WriteLine("Giá trị n không hợp lệ. Vui lòng nhập số nguyên dương!");
            }
        }
        static void bai_12()
        {
            string filePath = "mytest.txt";
            string[] sampleLines = new string[]
            {
    "Dòng 1: UEH - Đại học Kinh tế TP.HCM",
    "Dòng 2: Tôi yêu trường",
    "Dòng 3: Tôi yêu cơ sở lập trình",
    "Dòng 4: hy vọng điểm cao",
    "Dòng 5: Hoàn thành bài tập số 12"
            };

            File.WriteAllLines(filePath, sampleLines);
            Console.WriteLine($"Đã tạo tập tin '{filePath}' với {sampleLines.Length} dòng nội dung thành công!\n");

            Console.Write($"Nhập số thứ tự dòng muốn đọc (từ 1 đến {sampleLines.Length}): ");
            if (int.TryParse(Console.ReadLine(), out int lineNumber) && lineNumber > 0)
            {
                string[] allLines = File.ReadAllLines(filePath);

                if (lineNumber <= allLines.Length)
                {
                    Console.WriteLine($"\nNội dung tại dòng {lineNumber} là:\n{allLines[lineNumber - 1]}");
                }
                else
                {
                    Console.WriteLine($"Tập tin chỉ có {allLines.Length} dòng. Không tìm thấy dòng {lineNumber}!");
                }
            }
            else
            {
                Console.WriteLine("Số dòng không hợp lệ. Vui lòng nhập số nguyên dương!");
            }
        }
        static void bai_13()
        {
            string filePath = "mytest.txt";
            string[] sampleLines = new string[]
            {
    "tôi yêu ueh",
    "tôi yêu ueh 2",
    "tôi yêu ueh3",
    "tôi yêu ueh4",
    "tôi yêu ueh5"
            };

            File.WriteAllLines(filePath, sampleLines);
            Console.WriteLine($"Đã tạo tập tin '{filePath}' thành công!\n");

            if (File.Exists(filePath))
            {
                int lineCount = 0;
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (sr.ReadLine() != null)
                    {
                        lineCount++;
                    }
                }

                Console.WriteLine($"Tổng số dòng trong tập tin là: {lineCount}");
            }
            else
            {
                Console.WriteLine($"Tập tin '{filePath}' không tồn tại trên đĩa.");
            }
        }
        static void bai_14()
        {
            static void PrintFolderStructure(DirectoryInfo dir, string indent = "")
            {
                Console.WriteLine($"{indent}[Thư mục] {dir.Name}");

                foreach (FileInfo file in dir.GetFiles())
                {
                    Console.WriteLine($"{indent}  |-- [Tập tin] {file.Name}");
                }

                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    PrintFolderStructure(subDir, indent + "  ");
                }
            }

            Console.Write("Nhập đường dẫn thư mục cần kiểm tra: ");
            string folderPath = Console.ReadLine() ?? "";

            if (Directory.Exists(folderPath))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(folderPath);
                Console.WriteLine($"\nCấu trúc thư mục của '{dirInfo.FullName}':\n");
                PrintFolderStructure(dirInfo);
            }
            else
            {
                Console.WriteLine("Thư mục không tồn tại trên đĩa.");
            }
        }
        static void bai_15()
        {
            string filepath = "mytest.txt";

            if (File.Exists(filepath))
            {
                int[,] stats = new int[128, 2];
                for (int i = 0; i < 128; i++)
                {
                    stats[i, 0] = i;
                    stats[i, 1] = 0;
                }

                string content = File.ReadAllText(filepath);

                foreach (char c in content)
                {
                    if (c < 128)
                    {
                        stats[(int)c, 1]++;
                    }
                }

                Console.WriteLine("Thống kê ký tự chữ số");
                for (int i = 0; i < 128; i++)
                {
                    char c = (char)stats[i, 0];
                    if (char.IsDigit(c) && stats[i, 1] > 0)
                    {
                        Console.WriteLine($"Ký tự số '{c}': {stats[i, 1]} lần");
                    }
                }

                Console.WriteLine("Thông kê ký tự chữ cái");
                for (int i = 0; i < 128; i++)
                {
                    char c = (char)stats[i, 0];
                    if (char.IsLetter(c) && stats[i, 1] > 0)
                    {
                        Console.WriteLine($"Ký tự chữ '{c}': {stats[i, 1]} lần");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Tập tin '{filepath}' không tồn tại trên đĩa.");
            }
        }
        public static void Main111111111111111111111111(string[] args)
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
