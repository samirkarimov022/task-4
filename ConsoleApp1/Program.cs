
//1)

//int num = 8;

//bool result = false;
//int step = 0;
//for (int i = 0; i < num; i++)
//{
//        step++;
//        if (num % 2 == 0)
//        {
//         result = true;

//        break;  
//        }


//}
//if (result)
//{
//    Console.WriteLine("eded 2nin quvvetidir");
//}
//else
//{
//    Console.WriteLine("quvvet deyil");
//}

//2)

//int num = 824;
//int a = num % 10;
//int b = num / 10;
//bool result = false;
//for (int i = 0;i < num; i++)
//{


//    if ( b != 0)
//    { 
//        a = b % 10;
//        result = true;
//    }
//    b = b / 10;

//} 
//if ( result)
//{
//    if ( a > b)
//{
//    Console.WriteLine(a);
//    }
//    else {  Console.WriteLine(b); }
//}


//3)



//int[] num = { 1, 2, 3, 5, 4};

//int maxNum = num[num.Length - 1];
//int minNum = num[0];
//int sum = 0;
//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] > maxNum)
//    {
//        maxNum = num[i];

//    }
//    if (num[i] < minNum)
//    {
//        minNum = num[i];
//    }

//    sum = minNum + maxNum;
//}

//Console.WriteLine(sum);



//4)

//int[] arr = { 2, 3, 5, 6, 9 };
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 1 && arr[i] % 3 == 0)
//    {
//        Console.WriteLine(arr[i]);
//    }
//}

// 5)

int[] num = { 0,1,5, 9, 12, 11 ,15};
int count = 0;
for (int i = 0; i < num.Length; i++)
{
    for (int j = 2; j < num[i]; j++)
    {
        if (num[i] % j == 0)
        {
            count++;
            break;
        }
    }
}
    Console.WriteLine(count);