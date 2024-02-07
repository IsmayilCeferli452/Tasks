//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//A)PRACTICE CLASSWORK:
//1)
//int age = 35;

//Console.WriteLine(age);

//2)
//int n = 15;
//int m = 30;
//int sum = n+m;

//Console.WriteLine(sum);


//3)
//bool isMarried = true;

//if (isMarried == true)
//{
//    Console.WriteLine("Evli");
//}
//else
//{
//    Console.WriteLine("Subay");
//}


//4)
//int[] arr = { 5, 10, 15, 20, 25, 30, 25 };

//for (int i = 0; i < arr.Length; i++) 
//{
//    Console.WriteLine(i);
//}

//for (int i = 0;i < arr.Length; i++) 
//{ 
//    Console.WriteLine(arr[i]); 
//}  

//5)
//int n = 10;
//int m = 18;

//for (int i = n; i <= m; i++)
//{
//    Console.WriteLine(i);
//}

//6)
//int n = 18;

//if (n % 2 == 0)
//{
//    Console.WriteLine(n + " - Cutdur");
//}

//7)
//int n = 3;
//int m = 12;
//int sum = 0;

//for (int i = n;i<=m;i++)
//{
//    sum += i;
//    Console.WriteLine(sum);
//}

//8)
//int n = 3;
//int m = 12;
//int sum = 0;

//for (int i = n; i <= m; i++)
//{
//    sum += i;
//}
//Console.WriteLine(sum);

//9)
//string[] names = { "salam", "sagol", "hello", "bye", "salam" };
//int count = 0;

//for (int i = 0; i < names.Length; i++) 
//{
//    if (names[i]=="salam")
//    {
//        count++; 
//    }
//}
//Console.WriteLine(count);

//B)HOME TASK:
//1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

//int n = 21;

//if (n %3==0 && n % 7 == 0)
//{
//    Console.WriteLine("Bolunur");
//}
//else
//{
//    Console.WriteLine("Bolunmur");
//}

//2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

//int n = 6;
//int m = 18;
//int sum = n + m;

//if (n % 2 == 0 && m % 2 == 0)
//{
//    Console.WriteLine(sum);
//}

//3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.

//int n = 3;
//int m = 9;
//int sum = 0;

//for (int i = n; i <=m; i++)
//{
//    if (i % 2 == 1)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine(sum);

//4) Verilmish arrayin icindeki tek ededlerin cemini tapin.

//int[] nums = { 1, 2, 3, 4, 6, 4, 2, 6, 8, 7, 11 };
//int sum = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] % 2 == 1)
//    {
//        sum += nums[i];
//    }
//}
//Console.WriteLine(sum);

//5) Verilmish arrayin icindeki cut ededlerin sayini tapin.

//int[] nums = { 1, 2, 3, 4, 6, 4, 2, 6, 8, 7, 11 };
//int count = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] % 2 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

//6) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

//int n = 6;
//int m = 12;
//int count = 0;

//for (int i = n; i <= m; i++)
//{
//    if (i % 2 == 1)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

//7) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.

//int n = 10;
//int m = 20;
//int sum= 0;

//for (int i = n; i <= m; i++)
//{
//    if (i % 2 == 0)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine(sum);

//8) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.

//int n = 34;
//int m = 40;
//int count  = 0; 

//for (int i = n; i <= m; i++)
//{
//    if (i % 2 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

//9) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

//int n = 121;
//int count = 0;
//if (n < 2)
//{
//    Console.WriteLine("ne sade,ne murekkebdir");
//}
//else if (n == 2)
//{
//    Console.WriteLine("sadedir");
//}
//else
//{
//    for (int i = 1; i <= n; i++)
//    {
//        if (n % i == 0)
//        {
//            count++;
//        }
//        if (count > 2)
//        {
//            Console.WriteLine("murekkebdir");
//        }
//    }

//}