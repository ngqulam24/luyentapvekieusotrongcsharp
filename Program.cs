using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("BÀI TẬP VỀ KIỂU SỐ TRONG C#");
        Console.WriteLine("------------------------");
        int choice;
        do
        {
            Console.Write("\nNhập bài a, b, c, d, e, g, h, k, l, m:\nNhập 'x' để thoát.\n");
            Console.Write("Nhập lựa chọn của bạn: ");
            choice =char.Parse(Console.ReadLine());
            switch (choice)
            {
                case 'a':
                    Console.WriteLine("\na. Viết một chương trình nhận vào hai số nguyên không dấu từ người dùng và tính tổng của chúng.");
                    Exa();
                    break;
                case 'b':
                    Console.WriteLine("\nb. Viết một chương trình nhận vào chiều dài và chiều rộng của một hình chữ nhật từ người dùng là số nguyên 2 byte không dấu. Tính diện tích và chu vi của hình chữ nhật đó.");
                    Exb();
                    break;
                case 'c':
                    Console.WriteLine("\nc. Viết một chương trình nhận vào một số nguyên không dấu  4byte từ người dùng và kiểm tra xem số đó là chẵn hay lẻ.");
                    Exc();
                    break;
                case 'd':
                    Console.WriteLine("\nd. Viết một chương trình nhận vào hai số nguyên có dấu 1byte từ người dùng và tính tổng của chúng.");
                    Exd();
                    break;
                case 'e':
                    Console.WriteLine("\ne. Viết một chương trình nhận vào một số nguyên n không dấu 4byte từ người dùng và tính tổng của các số từ 1 đến n.");
                    Exe();
                    break;
                case 'g':
                    Console.WriteLine("\ng. Viết một chương trình nhận vào chiều dài và chiều rộng kiểu số thực 8 byte của một hình chữ nhật từ người dùng. Tính diện tích và chu vi của hình chữ nhật đó.");
                    Exg();
                    break;
                case 'h':
                    Console.WriteLine("\nh. Viết một chương trình nhận vào ba số nguyên từ người dùng và tìm số lớn nhất trong ba số đó.");
                    Exh();
                    break;
                case 'k':
                    Console.WriteLine("\nk. Viết một chương trình nhận vào một số nguyên không âm n từ người dùng và tính giai thừa của số đó.");
                    Exk();
                    break;
                case 'l':
                    Console.WriteLine("\nl. Viết một chương trình nhận vào một số nguyên không âm n từ người dùng và kiểm tra xem số đó có phải là số nguyên tố hay không.");
                    Exl();
                    break;
                case 'm':
                    Console.WriteLine("\nm. Viết một chương trình nhận vào một số nguyên từ người dùng và kiểm tra xem số đó có phải là số hoàn hảo hay không. Số hoàn hảo là số mà tổng các ước số của nó (không tính chính nó) bằng chính nó.");
                    Exm();
                    break;
                case 'x':
                    Console.WriteLine("Exited......");
                    break;
                default:
                    Console.WriteLine("Nhập sai lựa chọn!");
                    break ;
            }
        }while (choice!='x');
    }
    static void Exa()
    {
        Console.Write("Nhập số thứ nhất: ");
        uint number1 = uint.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        uint number2 = uint.Parse(Console.ReadLine());

        uint sum = number1 + number2;

        Console.WriteLine("Tổng của hai số là: " + sum);
    }
    static void Exb() 
    {
        Console.Write("Nhập chiều dài: ");
        ushort length = ushort.Parse(Console.ReadLine());

        Console.Write("Nhập chiều rộng: ");
        ushort width = ushort.Parse(Console.ReadLine());

        Console.WriteLine("Chu vi của hình chữ nhật là " + (((uint)width+(uint)length)*2));
        Console.WriteLine("Diện tích hình chữ nhật là " + ((uint)width * (uint)length));  
    }
    static void Exc() 
    {
        Console.Write("Nhập số nguyên không dấu (4 byte): ");
        uint number = uint.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Số " + number + " là số chẵn.");
        }
        else
        {
            Console.WriteLine("Số " + number + " là số lẻ.");
        }
    }
    static void Exd() 
    {
        Console.Write("Nhập số nguyên có dấu 1 byte đầu tiên: ");
        sbyte number1 = sbyte.Parse(Console.ReadLine());

        Console.Write("Nhập số nguyên có dấu 1 byte thứ hai: ");
        sbyte number2 = sbyte.Parse(Console.ReadLine());

        sbyte sum = (sbyte)(number1 + number2);

        Console.WriteLine("Tổng của " + number1 + " và " + number2 + " là: " + sum);
    }
    static void Exe() 
    {
        Console.Write("Nhập số nguyên không dấu (4 byte): ");
        uint n = uint.Parse(Console.ReadLine());

        uint sum = 0;
        for (uint i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine("Tổng của các số từ 1 đến " + n + " là: " + sum);
    }
    static void Exg() 
    {
        Console.Write("Nhập chiều dài của hình chữ nhật (số thực 8 byte): ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Nhập chiều rộng của hình chữ nhật (số thực 8 byte): ");
        double width = double.Parse(Console.ReadLine());

        double area = length * width;

        double perimeter = 2 * (length + width);

        Console.WriteLine("Diện tích của hình chữ nhật là: " + area);
        Console.WriteLine("Chu vi của hình chữ nhật là: " + perimeter);
    }
    static void Exh() 
    {
        Console.Write("Nhập số thứ nhất: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ ba: ");
        int num3 = int.Parse(Console.ReadLine());

        int max = num1;
        if (num2 > max)
        {
            max = num2;
        }
        if (num3 > max)
        {
            max = num3;
        }

        Console.WriteLine("Số lớn nhất trong ba số là: " + max);
    }
    static void Exk() 
    {
        Console.Write("Nhập số nguyên không âm: ");
        int n = int.Parse(Console.ReadLine());

        long factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("Giai thừa của " + n + " là: " + factorial);
    }
    static void Exl() 
    {
        Console.Write("Nhập số nguyên không âm: ");
        int n = int.Parse(Console.ReadLine());

        bool isPrime = true;
        if (n <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine(n + " là số nguyên tố.");
        }
        else
        {
            Console.WriteLine(n + " không phải là số nguyên tố.");
        }
    }
    static void Exm() 
    {
        Console.Write("Nhập số nguyên: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }

        if (sum == n)
        {
            Console.WriteLine(n + " là số hoàn hảo.");
        }
        else
        {
            Console.WriteLine(n + " không phải là số hoàn hảo.");
        }
    }
}