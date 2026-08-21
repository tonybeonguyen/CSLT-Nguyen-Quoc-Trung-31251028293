using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    public static void Main111111(string[] args)
    {
        int a = 5, b = 6;
        //        1.to Add / Sum Two Numbers.
        int sum = a + b;
        Console.WriteLine($"{a}+{b}={sum}");

        //2.to Swap Values of Two Variables.
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($" after swap a = {a}, b = {b} ");

        //3.to Multiply two Floating Point Numbers
        float f1 = 6.9f;
        float f2 = 9.6f;
        float f3 = f1 * f2;
        Console.WriteLine($"{f1}*{f2}={f3}");

        //4.to convert feet to meter
        float meet = 9f;
        float feet = 0.3048f * meet;
        Console.WriteLine($"{meet}meet={feet}feet");

        //5.to convert Celsius to Fahrenheit and vice versa
        float cel = 14f;
        float fah = cel * 1.8f + 32;
        Console.WriteLine($"{cel}cel={fah}fah");

        //6.to find the Size of data types
        Console.WriteLine($"Size of double data type is {sizeof(double)}");
        Console.WriteLine($"Size of int data type is {sizeof(int)}");

        //7.to Print ASCII Value(tip: read character, print number of this char)
        Console.Write("nhap 1 ki tu bat ki");
        char kytu = Console.ReadKey().KeyChar;
        int maAscii = (int)kytu;
        Console.WriteLine($" mã ASCII của ký tự '{kytu}' la {maAscii}");

        //8.to Calculate Area of Circle
        double bankinh = 14;
        double dientich = Math.PI * bankinh * bankinh;
        Console.WriteLine($"dien tich hinh tron la {dientich}");

        //9.to Calculate Area of Square
        double canh = 5;
        double dientichhv = canh * canh;
        Console.WriteLine($"dien tich hv la {dientichhv}");

        //10.to convert days to years, weeks and days
        Console.Write("nhap tong so ngay");
        int tongsongay = int.Parse(Console.ReadLine());
        int nam = tongsongay / 365;
        int ngayconlai = tongsongay % 365;
        int tuan = ngayconlai / 7;
        int ngay = ngayconlai % 7;
        Console.WriteLine($"tong so ngay bang {nam}nam{tuan}tuan{ngay}ngay");
    }
}