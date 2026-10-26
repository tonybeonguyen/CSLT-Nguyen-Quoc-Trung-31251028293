using System;
using System.Collections.Generic;
using System.Text;

namespace Filr_btvn_buoi_1
{
    internal class buoi7
    {
        static void bai_1()
        {
            Console.Write("nhap: ");
            string input = Console.ReadLine();
            Console.WriteLine($"da nhap: {input}");
        }
        static void bai_2()
        {
            Console.Write("nhap: ");
            string input = Console.ReadLine();

            int length = 0;
            foreach (char c in input)
            {
                length++;
            }

            Console.WriteLine($"do dai: {length}");
        }
        static void bai_3()
        {
            Console.Write("nhap: ");
            string input = Console.ReadLine() ?? "";

            Console.Write("chon char: ");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{input[i]} ");
            }

            Console.WriteLine();
        }
        static void bai_4()
        {
            Console.Write("nhap: ");
            string input = Console.ReadLine() ?? "";

            Console.Write("nguoc la: ");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write($"{input[i]} ");
            }

            Console.WriteLine();
        }
        static void bai_5()
        {
            Console.Write("nhap: ");
            string input = Console.ReadLine() ?? "";

            int wordCount = 0;
            bool inWord = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsWhiteSpace(input[i]))
                {
                    inWord = false;
                }
                else if (!inWord)
                {
                    inWord = true;
                    wordCount++;
                }
            }

            Console.WriteLine($"tong : {wordCount}");
        }
        static void bai_6()
        {
            Console.Write("nhap 1: ");
            string str1 = Console.ReadLine() ?? "";

            Console.Write("nhap 2: ");
            string str2 = Console.ReadLine() ?? "";

            int len1 = 0;
            foreach (char c in str1) len1++;

            int len2 = 0;
            foreach (char c in str2) len2++;

            bool areEqual = true;

            if (len1 != len2)
            {
                areEqual = false;
            }
            else
            {
                for (int i = 0; i < len1; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        areEqual = false;
                        break;
                    }
                }
            }

            if (areEqual)
            {
                Console.WriteLine("giong het.");
            }
            else if (len1 != len2)
            {
                Console.WriteLine("khac.");
            }
            else
            {
                Console.WriteLine("dai bang nhau nhung khac nhau.");
            }
        }
        static void bai_7()
        {
            Console.Write("nhap: ");
            string input = Console.ReadLine() ?? "";

            int alphabets = 0;
            int digits = 0;
            int specialChars = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    alphabets++;
                }
                else if (c >= '0' && c <= '9')
                {
                    digits++;
                }
                else
                {
                    specialChars++;
                }
            }

            Console.WriteLine($"so Alphabets: {alphabets}");
            Console.WriteLine($"so Digits: {digits}");
            Console.WriteLine($"so Special Characters: {specialChars}");
        }
        static void bai_8()
        {
            Console.Write("nhap: ");
            string input = Console.ReadLine() ?? "";

            int vowels = 0;
            int consonants = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    char lower = (c >= 'A' && c <= 'Z') ? (char)(c + 32) : c;

                    if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }

            Console.WriteLine($"so Vowels: {vowels}");
            Console.WriteLine($"soConsonants: {consonants}");
        }
        static void bai_9()
        {
            Console.Write("nhap: ");
            string str = Console.ReadLine() ?? "";

            Console.Write("nhap substring: ");
            string sub = Console.ReadLine() ?? "";

            bool found = false;

            if (sub.Length <= str.Length)
            {
                for (int i = 0; i <= str.Length - sub.Length; i++)
                {
                    int j = 0;
                    while (j < sub.Length && str[i + j] == sub[j])
                    {
                        j++;
                    }

                    if (j == sub.Length)
                    {
                        found = true;
                        break;
                    }
                }
            }

            if (found)
            {
                Console.WriteLine("co substring.");
            }
            else
            {
                Console.WriteLine("ko co substring.");
            }
        }
        static void bai_10()
        {
            Console.Write("nhap: ");
            string str = Console.ReadLine() ?? "";

            Console.Write("nhao substring: ");
            string sub = Console.ReadLine() ?? "";

            int index = -1;

            if (sub.Length <= str.Length && sub.Length > 0)
            {
                for (int i = 0; i <= str.Length - sub.Length; i++)
                {
                    int j = 0;
                    while (j < sub.Length && str[i + j] == sub[j])
                    {
                        j++;
                    }

                    if (j == sub.Length)
                    {
                        index = i;
                        break;
                    }
                }
            }

            if (index != -1)
            {
                Console.WriteLine($" substring '{sub}' nam o: {index}");
            }
            else
            {
                Console.WriteLine("ko co substring.");
            }
        }
        static void bai_11()
        {
            Console.Write("Enter a character: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine($"'{ch}' la alphabet va UPPERCASE.");
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine($"'{ch}' la alphabet va LOWERCASE.");
            }
            else
            {
                Console.WriteLine($"'{ch}' ko phai alphabet.");
            }
        }
        static void bai_12()
        {
            Console.Write("nhap: ");
            string str = Console.ReadLine() ?? "";

            Console.Write("nhap substring: ");
            string sub = Console.ReadLine() ?? "";

            int count = 0;

            if (sub.Length > 0 && sub.Length <= str.Length)
            {
                for (int i = 0; i <= str.Length - sub.Length; i++)
                {
                    bool match = true;
                    for (int j = 0; j < sub.Length; j++)
                    {
                        if (str[i + j] != sub[j])
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($" substring '{sub}' xuat hien {count} lan.");
        
        }
        static void bai_13()
        {
            Console.Write("nhap: ");
            string original = Console.ReadLine() ?? "";

            Console.Write("nhap cai de tim: ");
            string target = Console.ReadLine() ?? "";

            Console.Write("nhap string de inserted: ");
            string insertStr = Console.ReadLine() ?? "";

            int index = -1;

            if (target.Length > 0 && target.Length <= original.Length)
            {
                for (int i = 0; i <= original.Length - target.Length; i++)
                {
                    bool match = true;
                    for (int j = 0; j < target.Length; j++)
                    {
                        if (original[i + j] != target[j])
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                    {
                        index = i;
                        break;
                    }
                }
            }

            if (index != -1)
            {
                string result = "";

                for (int i = 0; i < index; i++)
                {
                    result += original[i];
                }

                result += insertStr;

                for (int i = index; i < original.Length; i++)
                {
                    result += original[i];
                }

                Console.WriteLine($"chuoi da sua la: \"{result}\"");
            }
            else
            {
                Console.WriteLine("ko thay chuoi can tim.");
            }
        }
        public static void Main111111111111111111111(string[] args)
        {
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


        }
    }
}
