using System.Text.RegularExpressions;
////1
//int a = 4;
//int b = 5;
//int sum = 0;
//if (a == b)
//{
//    sum = (a+b) * 3;
//}
//else
//{
//    sum = a + b;
//}
//Console.WriteLine(sum);
////2
//int n = 50;
//if (n <= 51)
//{
//    Console.WriteLine("Eded yanlisdir");
//}
//else
//{
//    Console.WriteLine(n - 51);
//}
////3
//int c = 30;
//int d = 40;
//if (c == 30 || d == 30)
//{
//    Console.WriteLine("True");
//}
//else
//{
//    Console.WriteLine("False");
//}

//int a = 5;
//int b = 6;
//int res = 0;

//if (a == b)
//{
//    res = (a + b) * 3;

//}
//else
//{
//    res = a + b;
//}
//Console.WriteLine(res);


//int a = 3;
//if (a <= 20)
//{
//    while (a <= 20)
//    {
//        Console.WriteLine(a);
//        a += 5;
//    }
//}
//else
//{
//    while (a >= 0)
//    {
//        Console.WriteLine(a);
//        a -= 5;
//    }
//}
//Console.Write("Adinizi daxil edin: ");
//string Ad = Console.ReadLine();
//Console.Write("Soyadinizi daxil edin: ");
//string Soyad = Console.ReadLine();
//Console.WriteLine("Adiniz "+Ad+" "+Soyad);

//Console.WriteLine($"Adiniz: {Ad} {Soyad}");

//double a6 = 1, b6 = 58, c6 = 3, d6 = 4, e6 = 2;
//double sum = (a6 + b6 + c6 + d6 + e6) / 5;
//Console.WriteLine(sum);

//int a = 10;
//int b = 20;

//int c = a * b; // saheni tapmaq ucun
//int d = 2 * (a + b); //perimetr

//Console.WriteLine(c);
//Console.WriteLine(d);

////1
//int a8 = 0;
//if (a8 % 2 == 0) Console.WriteLine("cut");
//else Console.WriteLine("tek");

////2
//int eded = 24;
//string res = "tek";
//if (eded % 2 == 0)
//{
//    res = "cut";
//}

//Console.WriteLine(res);
////3
//int a = Convert.ToInt32(Console.ReadLine());
//if (a % 2 == 0)
//{
//    Console.WriteLine("Cut");
//}
//else
//{
//    Console.WriteLine("Tek");
//}
////4
//int v = 5;
//if (v % 2 == 0)
//{
//    Console.WriteLine("cut");
//}
//else
//{
//    Console.WriteLine("tek");

//}

//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine("Hello World");
//}

//int a = 0;
//while (a <= 10) 
//{
//    Console.WriteLine("Hello World");
//    a++;
//};
//Console.WriteLine(a);


//int point = 96;

//if (point >= 0 && point <= 100)
//{
//    if (point >= 91 && point <= 100)
//    {
//        Console.WriteLine("A almisiz");
//    }
//    else if (point >= 81 && point <= 90)
//    {
//        Console.WriteLine("B almisiz");
//    }
//    else if (point >= 71 && point <= 80)
//    {
//        Console.WriteLine("C almisiz");
//    }
//    else if (point >= 61 && point <= 70)
//    {
//        Console.WriteLine("D almisiz");
//    }
//    else if (point >= 51 && point <= 60)
//    {
//        Console.WriteLine("E almisiz");
//    }
//    else
//    {
//        Console.WriteLine("Kesildiz");
//    }
//}
//else
//{
//    Console.WriteLine("Duzgun qiymet daxil edin: 0-100 araliginda");
//}


//22.06.2023

//1

//Regex emailRegex = new Regex(@"^[a-zA-Z][a-zA-Z.0-9_]+@[a-zA-Z]{2,10}\.[a-zA-Z]{2,10}(\.[a-zA-Z]{2,10})?$");
//Regex passwordRegex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{6,10}$");

//Console.Write("Email daxil edin: ");
//string email = Console.ReadLine();

//while (!emailRegex.IsMatch(email))
//{
//    Console.Write("Duzgun formatda mail daxil edin: ");
//    email = Console.ReadLine();
//}
//Console.Write("Sifre daxil edin: ");
//string password = Console.ReadLine();
//while (!passwordRegex.IsMatch(password))
//{
//    Console.Write("Duzgun formatda sifre daxil edin: ");
//    password = Console.ReadLine();
//}
//Console.Write("Sifreni testiq edin: ");
//string confirmPassword = Console.ReadLine();
//while (password != confirmPassword)
//{
//    Console.Write("Yazdigiz sifreler ust-uste dusmur: ");
//    confirmPassword = Console.ReadLine();
//}
//Console.WriteLine("Ugurla qeydiyyatdan kecildi");


//2
//int guesses = 0; 
//bool isWon = false; 
//Console.Write("0-10 arasinda 1 reqem texmin edin: "); 

//while (guesses < 3) 
//{
//    int num = Convert.ToInt32(Console.ReadLine());
//    if (num == 7)
//    {
//        isWon = true;
//        break;
//    }
//    else if (num < 7)
//    {
//        Console.WriteLine("Boyuk reqem olmalidir:");
//    }
//    else
//    {
//        Console.WriteLine("Kicik reqem olmalidir:");
//    }

//    guesses++;
//}

//if (isWon) 
//{
//    Console.WriteLine("Qalibsiz!");
//}
//else
//{
//    Console.WriteLine("Meglub oldunuz reqem 7 idi");
//}

//7
//Console.Write("Eded daxil edin: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int module = 0;

//while (num > 0)
//{
//    module = num % 10;
//    num = (num - module) / 10;
//    //1
//    //258 % 10 --> 8 -module
//    //(258-8) /10 = 25 - num
//    //2
//    //25 % 10  --> 5 -module
//    //(25-5) /10 = 2 - num
//    //2 % 10 --> 2 -module
//    //(2-2) / 10 = 0 -num
//    Console.Write(module +" ,");
//}

