//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//           Min();
//            Console.WriteLine(Min());
//        }
//         static int Min() 
//        {
//            int[] arr = { 4, 2, 1, 3 };

//            int min = 0;
//            for (int i = 0;i < arr.Length; i++)
//            {
//                if (arr[i] < arr[min])
//                {
//                    min = i;
//                }
//            }

//            return min;
//        }
//    }
//}
namespace consoleapp2
{
    internal class program
    {
        static void main(string[] args)
        {
            //CalcArea();
            Console.WriteLine(CalcArea(1));
            Console.WriteLine(CalcArea(1,2));
            Console.WriteLine(CalcArea(1,2,3));
            Console.WriteLine(CalcArea(1,2,3,4));
        }

        public static int CalcArea(int p = 3)
        {
            
            int r = 4;
            int S = p * r * r;
            Console.WriteLine("cevrenin sahesi" + S);
            return S;
        }
        public static int CalcArea(int a,int b)
        {
             a = 3;
             b = 4;
            int Sduz = a * b;
            Console.WriteLine("duzbucaqlinin sahesi" + Sduz);
            return Sduz;
        }
        public static int CalcArea(int a, int b, int c)
        {
            a = 3;
            b = 4;
            c = 5;
            int Spar = 2 * (a * b + b * c + a * c);
            Console.WriteLine("paralelpipedin sahesi" + Spar);
            return Spar;
        }
        public static int CalcArea(int a, int b, int c, int r)
        {
             a = 3;
             b = 4;
             c = 5;
             r = 4;
            int p = (a + b + c) / 2;
            int Scirc = p * r;
            Console.WriteLine("daxile cekilmis cevrenin sahesi" + Scirc);
            return Scirc;
        }





    }

}

