//1)CLASS WORK(PRACTICE)

//a)
//int[] nums = { 1, 2, 3, 3, 4, 4, 5, 5 };

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] == 3)
//    {
//        Console.WriteLine(nums[i] + " - Tapildi");
//        break;
//    }
//}

//b)

//int[] nums = { 1, 2, 3, 2, 4, 4, 2, 5 };
//int count = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] == 2)
//    {
//        count++;
//    }
//    if (count == 3)
//    {
//        Console.WriteLine("Found min. 3 times");
//        break;
//    }
//}

//c)

//int[] nums = { 1, 2, 3, 4 };

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] == 2)
//    {
//        continue;

//    }
//    Console.WriteLine(nums[i]);
//}

//d)

//int[] nums = { 1, 2, 3, 4 };
//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] == 1)
//    {
//        continue;
//    }
//    if (nums[i] == 4)
//    {
//        break;
//    }
//    Console.WriteLine(nums[i]);
//}


//2)HOMEWORK
//a)n - ededinin faktorialini hesablayin.

//int n = 3;
//int faktorial = 1;

//for (int i = 1; i <= 3; i++)
//{
//    faktorial *= i;
//}
//Console.WriteLine(faktorial);


//b)Verilmis arrayin icerisinde cut ededlerin ceminin kvadratini hesablayin.

//int[] nums = {1,2,3,4,5,6};
//int sum = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] % 2 == 0)
//    {
//        sum+= nums[i];
//    }
//}
//int kvadrat = sum * sum;
//Console.WriteLine(kvadrat);

//c) n ededi gelir. n - ededinin 2-ni hansisa quvvete yukseltdikde alinan edede beraber olub-olmadigini tapin. Meselen : n ededi 4,8,16 ve s. gelirse yazilsin ki, 2-nin quvettidir. Eks halda quvveti deil yazilsin.

int n = 12;
int count = 0;
int sum = 0;

if (n == 1)
{
    Console.WriteLine("0-i dereceden quvvetidir");
}
else if (n % 2 != 0)
{
    Console.WriteLine("quvveti deyil");
}
else
{
    for (int i = 2; i < n; i *= 2)
    {
        if (n % i == 0)
        {
            sum = n % i;
        }
        if (sum % i == 0)
        {
            count++;
        }
    }
    if (count > 1)
    {
        Console.WriteLine("quvvetidir");
    }
    else
    {
        Console.WriteLine("quvveti deyil");
    }
}