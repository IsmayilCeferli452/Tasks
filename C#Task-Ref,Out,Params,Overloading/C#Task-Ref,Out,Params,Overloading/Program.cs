

//HOMETASK(Ashagidaki tapshiriqlari method istifade ederek yazin. Butun alqoritmler ayri method seklilinde yazilmalidir. Methodlar hamisi parametr qebul etmelidir. )

//1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın:


//A)return ile:
//string IsDivided(int n)
//{
//    if (n % 3 == 0 && n % 7 == 0)
//    {
//        return "Bolunur";
//    }
//    else
//    {
//        return "Bolunmur";
//    }
//}

//string result = IsDivided(42);

//Console.WriteLine(result);


//B)void ile:
//void IsDivided(int n)
//{
//    if (n % 3 == 0 && n % 7 == 0)
//    {
//        Console.WriteLine("Bolunur");
//    }
//    else
//    {
//        Console.WriteLine("Bolunmur");
//    }
//}

//IsDivided(20);


//2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın:

//A)return ile:

//int SumOfNumbers(int n, int m)
//{
//    int sum = 0;
//    if (n % 2 == 0 && m % 2 == 0)
//    {
//        sum = n + m;
//    }
//    return sum;
//}

//int result = SumOfNumbers(4, 3);

//if (result % 2 == 0 && result != 0)
//{
//    Console.WriteLine(result);
//}
//else
//{
//    Console.WriteLine("Ededlerden biri cut deyil");
//}


//B)void ile:

//void SumOfNumbers(int n,int m)
//{
//    int sum = 0;
//    if (n % 2 != 1 && m % 2 != 1)
//    {
//        sum = n + m;
//        Console.WriteLine(sum);
//    }
//    else
//    {
//        Console.WriteLine("Ededlerden biri ve ya her ikisi cut deyil");
//    }
//}

//SumOfNumbers(4, 5);



//3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin:
//A)return ile:

//int CountOfOddNumbers(int n, int m)
//{
//    int count = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 != 0)
//        {
//            count++;
//        }
//    }
//    return count;
//}

//int result = CountOfOddNumbers(2, 10);

//Console.WriteLine(result);

//B)void ile:

//void CountOfOddNumbers(int n,int m)
//{
//    int count = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 != 0)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}

//CountOfOddNumbers(2, 10);


//4) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin:

//A)return ile:

//int SumOfOddNumbers(int n,int m)
//{
//    int sum = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 != 0)
//        {
//            sum += i;
//        }
//    }
//    return sum;
//}

//int result = SumOfOddNumbers(2, 10);

//Console.WriteLine(result);


//B)void ile:

//void SumOfOddNumbers(int n,int m)
//{
//    int sum = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 != 0)
//        {
//            sum += i;
//        }
//    }
//    Console.WriteLine(sum);
//}

//SumOfOddNumbers(2, 10);


//5)Verilmish arrayin icindeki tek ededlerin cemini tapin:

//A)return ile:

//int SumOfOddNumbers(params int[] numbers)
//{
//    int sum = 0;
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i] % 2 != 0)
//        {
//            sum += numbers[i];
//        }
//    }
//    return sum;
//}

//Console.WriteLine(SumOfOddNumbers(1,2,3,4,5));


//B)void ile:

//void SumOfOddNumbers(params int[] numbers)
//{
//    int sum = 0;

//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i] %2 != 0)
//        {
//            sum += numbers[i];
//        }
//    }
//    Console.WriteLine(sum);
//}

//SumOfOddNumbers(1,2,3,4,5);

//6)Verilmish arrayin icindeki cut ededlerin sayini tapin:

//A)return ile:

//int CountOfEvenNumbers(params int[] numbers)
//{
//    int count = 0;

//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i]%2!= 1)
//        {
//            count++;
//        }
//    }
//    return count;
//}

//Console.WriteLine(CountOfEvenNumbers(1,2,3,4,5));


//B)void ile:

//void CountOfEvenNumbers(params int[] numbers)
//{
//    int count = 0;

//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i]%2 == 0)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}

//CountOfEvenNumbers(1, 2, 3, 4, 5);

//7) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin:

//A)return ile:

//string SimpleOrComplex(int n)
//{
//int count = 0;

//if (n < 2)
//{
//    return "Ne sade ne murekkeb";
//}
//else
//{
//    for (int i = 1; i <= n; i++)
//    {
//        if (n % i == 0)
//        {
//            count++;
//        }
//    }
//}

//if (count > 2)
//{
//    return "Murekkeb";
//}
//else
//{
//    return "Sade";
//}
//}

//string result = SimpleOrComplex(121);

//Console.WriteLine(result);


//B)void ile:

//void SimpleOrComplex(int n)
//{
//    int count = 0;

//    if (n < 2)
//    {
//        Console.WriteLine("Ne sade ne murekkeb");
//    }
//    else
//    {
//        for (int i = 1; i <= n; i++)
//        {
//            count++;
//        }
//    }
//    if (count > 2)
//    {
//        Console.WriteLine("Murekkeb");
//    }
//    else
//    {
//        Console.WriteLine("Sade");
//    }
//}

//SimpleOrComplex(121);



//8) n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın.Meselen: Cavablar ola biler:2,4,8,16,32 ve s. Yeni n bele ededler olmalidir.

//A)return ile:

//string IsPower(int n)
//{
//    int i = 2;

//    if (n <= 0)
//    {
//        return "Musbet eded olmalidir";
//    }
//    else if (n == 1)
//    {
//        return "1-ci dereceden Quvvetidir";
//    }
//    else
//    {
//        while (i < n)
//        {
//            i *= 2;
//        }
//        if (i == n)
//        {
//            return "Quvvetidir";
//        }
//        else
//        {
//            return "Quvveti deyil";
//        }
//    }
//}

//string result = IsPower(16);

//Console.WriteLine(result);


//B)void ile:

//void IsPower(int n)
//{
//    int i = 2;

//    if (n <= 0)
//    {
//        Console.WriteLine("Musbet eded daxil olunmalidir");
//    }
//    else if (n == 1)
//    {
//        Console.WriteLine("1-ci dereceden quvvetidir");
//    }
//    else
//    {
//        while (i < n)
//        {
//            i *= 2;
//        }
//        if (i == n)
//        {
//            Console.WriteLine("Quvvetidir");
//        }
//        else
//        {
//            Console.WriteLine("Quvveti deyil");
//        }
//    }
//}

//IsPower(16);


//9)Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.Mes ([1,3,55,6,33], cavab : 18):

//A)return ile:

//int ResultOfNumbers(params int[] numbers)
//{
//    int result = 0;

//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i] > 1 && numbers[i] < 20)
//        {
//            result += numbers[i];
//        }
//    }
//    return result;
//}

//Console.WriteLine(Result(2, 6, 70, 56, 42));

//B)void ile:

//void ResultOfNumbers(params int[] numbers)
//{
//    int result = 0;

//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i] >1&& numbers[i] < 20)
//        {
//            result += numbers[i];
//        }
//    }
//    Console.WriteLine(result);
//}

//ResultOfNumbers(3, 5, 70, 80, 90);

//10)Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq:

//A)return ile:

//int SquareOfNumbers(params int[] numbers)
//{
//    int sum = 0;
//    int result = 0;

//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i] % 2 != 1)
//        {
//            sum += numbers[i];
//        }
//    }
//    result = sum * sum;
//    return result;
//}

//Console.WriteLine(SquareOfNumbers(1, 2, 3, 4, 5, 6));


//B)void ile:

//void SquareOfNumbers(params int[] numbers)
//{
//    int sum = 0;

//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i] % 2 != 1)
//        {
//            sum += numbers[i];
//        }
//    }
//    int result = sum * sum;
//    Console.WriteLine(result);
//}

//SquareOfNumbers(1,2,3,4);

//CLASSWORK
//11)temp qebul eden method yazirsiz. Return type olan method olmalidir. Method temp 20den boyukdurse isti, kicikdirse soyuq, beraberdirse mulayim mesajlarini qaytarsin.

//string Temprature(int temp)
//{
//    if (temp > 20)
//    {
//        return "Isti";
//    }
//    else if (temp < 20)
//    {
//        return "Soyuq";
//    }
//    else
//    {
//        return "Normal";
//    }
//}

//string temprature = Temprature(20);

//Console.WriteLine(temprature);



//12)Methoda a ve b ededleri gelecek, method a ve b arasindaki ededlerin sayini qaytarsin:

//int CountOfNumbers(int a, int b)
//{
//    int count = 0;

//    for (int i = a + 1; i < b; i++)
//    {
//        count++;
//    }
//    return count;
//}

//int result = CountOfNumbers(4, 8);

//Console.WriteLine(result);


//13)Method reqemlerden ibaret 2 array qebul edecek, her iki arrayin elementlerinin cemini geri qaytarsin:

//int SumOfArrays(int[] array1, int[] array2)
//{
//    int sum = 0;

//    for (int i = 0; i < array1.Length; i++)
//    {
//        sum += array1[i];
//    }
//    for (int i = 0; i < array2.Length; i++)
//    {
//        sum += array2[i];
//    }
//    return sum;
//}

//int[] numbers1 = { 1, 2, 3 };
//int[] numbers2 = { 5, 6, 7 };

//int result = SumOfArrays(numbers1,numbers2);

//Console.WriteLine(result);


//14)Methoda eded gelir, hemin method ededin kvadratini geriye qaytarsin:

//int SquareOfNumber(int number)
//{
//    int square = number * number;
//    return square;
//}

//int result=SquareOfNumber(5);

//Console.WriteLine(result);


//15)Methoda eded gelir, hemin method 1-den gelen edede qeder olan cut ededlerin cemini geri qaytarsin:

//int SumOfNumbers(int number)
//{
//    int sum = 0;

//    for (int i = 1; i < number; i++)
//    {
//        sum+= i;   
//    }
//    return sum;
//}

//int result=SumOfNumbers(5);

//Console.WriteLine(result);