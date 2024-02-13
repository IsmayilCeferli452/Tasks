//HOMEWORK(PRACTICE)
//a)

//void ShowText()
//{
//    Console.WriteLine("Hello World");
//}

//ShowText();

//b)

//void Sum()
//{
//    int a = 5;
//    int b = 6;
//    int sum = a + b;
//    Console.WriteLine(sum);
//}

//Sum();

//c)

//int SumOfNumbers()
//{
//    int a = 5;
//    int b = 6;
//    int sum = a+b;
//    return sum;
//}

//int result = SumOfNumbers();

//Console.WriteLine(result);

//d)Arrayin icindeki tek ededlerin cemini tapin(for ile):

//void SumOfOddNumbers()
//{
//    int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
//    int sum = 0;

//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (nums[i] % 2 != 0)
//        {
//            sum += nums[i];
//        }
//    }
//    Console.WriteLine(sum);
//}

//SumOfOddNumbers();

//e)Arrayin icindeki tek ededlerin cemini tapin(foreach ile):

//void SumOfOddNumbers()
//{
//    int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
//    int sum = 0;

//    foreach (int num in nums)
//    {
//        if (num % 2 != 0)
//        {
//            sum += num;
//        }
//    }
//    Console.WriteLine(sum);
//}
//SumOfOddNumbers();

//f)Parametrsiz metod:

//void ShowText()
//{
//    Console.WriteLine("Hello World");
//}

//ShowText();

//g)Parametr ile metod:

//void ShowTextImproved(string text)
//{
//    Console.WriteLine(text);
//}

//ShowTextImproved("Example");

//ShowTextImproved("Example 2");

//h)If ile:

//void ShowText(string text)
//{
//    Console.WriteLine(text);
//}

//bool isMarried=false;

//if (isMarried)
//{
//    ShowText("Subay");
//}
//else
//{
//    ShowText("Evli");
//}

//i)sum=num1+num2

//void Sum(int num1, int num2)
//{
//    int sum = num1 + num2;
//    Console.WriteLine(sum);
//}
//Sum(5, 6);

//Sum(10, 15);

//q)name=text1+text2;

//void ShowText(string text1, string text2)
//{
//    string name= text1 + text2;
//    Console.WriteLine(name);
//}

//ShowText("Hello", "World");

//l)Array(Parametr):

//void SumOfOddNumbers(int[] arr)
//{
//    int sum = 0;

//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i]%2 != 0)
//        {
//            sum += arr[i]; 
//        }
//    }
//    Console.WriteLine(sum);
//}

//int[] nums = { 1, 2, 3, 4, 5, 6 };

//SumOfOddNumbers(nums);

//m)Arrary(Parametr) + Number:

//void SumOfOddNumbers(int[] arr, int number)
//{
//    int sum = 0;

//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] % 2 != 0)
//        {
//            sum += arr[i];
//        }
//    }
//    int result = sum + number;
//    Console.WriteLine(result);
//}

//int[] nums = { 1, 2, 3, 4, 5, 6 };

//SumOfOddNumbers(nums, 50);

//n)Array(Parametr) + Number(return ile):

//int SumOfOddNumbers(int[] arr, int number)
//{
//    int sum = 0;

//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] % 2 != 0)
//        {
//            sum += arr[i];
//        }
//    }
//    int result = sum + number;
//    return result;
//}

//int[] nums = { 1, 2, 3, 4, 5, 6 };

//int result= SumOfOddNumbers(nums, 50);

//Console.WriteLine(result);

//p)Add your name and surname:

//void AddNameAndSurname()
//{
//    Console.WriteLine("Add your name:");

//    string name=Console.ReadLine();

//    Console.WriteLine("Add your surname:");

//    string surname=Console.ReadLine();

//    Console.WriteLine(name + " " + surname);
//}
//AddNameAndSurname();


//r)String to Int Parse etmek:

//void SumOfNumbers()
//{
//    Console.WriteLine("Add first number:");
//    int num1 = int.Parse(Console.ReadLine());

//    Console.WriteLine("Add second number:");
//    int num2 = int.Parse(Console.ReadLine());

//    int result = num1 + num2;

//    Console.WriteLine("Result - " + result);
//}
//SumOfNumbers();

//s)Params:

//using System.Globalization;

//int[] GetDatas(int num1, int num2, params int[] nums)
//{
//    return nums;
//}

//var result = GetDatas(1, 2, 3, 4, 5, 6, 7);

//foreach (int num in result)
//{
//    Console.WriteLine(num);
//}

//t)Params:

//int SumOfNumbers(int num1, int num2,params int[] nums)
//{
//    int sum = num1 + num2;

//    int sumOfArray = 0;

//    foreach(var item in nums)
//    {
//        sumOfArray += item;
//    }
//    int result = sumOfArray + sum;

//    return result;
//}
//int result = SumOfNumbers(1, 2, 3, 4, 5, 6, 7);

//Console.WriteLine(result);

//u)Default parameter value:

//string ShowText(string text = "xxx")
//{
//    return text;
//}

//Console.WriteLine(ShowText());

//Console.WriteLine(ShowText("Example"));


//ü)goto:

//string GetName(string text = "xxx")
//{
//    return text;
//}

//Name: string text= Console.ReadLine();

//if (text == "")
//{
//    Console.WriteLine(GetName());
//    goto Name;
//}
//else
//{
//    Console.WriteLine(GetName(text));
//}


//w)Class Task:

//using System.Threading.Channels;

//string Login(string username, string password)
//{
//    if (username == "Cavid123" && password == "cavid12345")
//    {
//        return "Login successful";
//    }
//    else
//    {
//        return "Username or password is wrong";
//    }
//}

//Console.WriteLine("Username:");
//string username = Console.ReadLine();

//Console.WriteLine("Password:");
//string password = Console.ReadLine();

//string result = Login(username, password);

//Console.WriteLine(result);


