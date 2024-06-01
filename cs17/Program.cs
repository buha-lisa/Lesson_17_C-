
namespace cs17
{
    internal class Program
    {
        //public delegate void MyDelegate();
        //public delegate string Delegate_1(string str);

        public delegate bool PairCheck(int number);
        public delegate int SquareAndCube(int number);
        public delegate bool ProgrammersDay(DateTime date);
        public delegate int MaxNumber(int[] array);
        public delegate int MinNumber(int[] array);
        public delegate int[] UnpairNumbers(int[] array);
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Choose number of task(1-7): ");
                int.TryParse(Console.ReadLine(), out int task);
                if (task == 0) break;

                switch (task)
                {
                    case 1:
                        PairCheck numberCheck = delegate (int num)
                        {
                            return num % 2 == 0;
                        };
                        Console.WriteLine($"Number {5} is pair:  {numberCheck(5)}");
                        break;
                    case 2:
                        SquareAndCube square = delegate (int num)
                        {
                            return num * num;
                        };
                        Console.WriteLine($"{5}^2 = {square(5)}");
                        break;
                    case 3:
                        SquareAndCube cube = (num) =>
                        {
                            return num * num * num;
                        };
                        Console.WriteLine($"{5}^3 = {cube(5)}");
                        break;
                    case 4:
                        ProgrammersDay dayCheck = (date) =>
                        {
                            var programmersDay = new DateTime(date.Year, 1, 1).AddDays(255);
                            return date.Date == programmersDay;
                        };
                        Console.WriteLine($"12.09.2024 is Programmer's Day:  {dayCheck(new DateTime(2024, 9, 12))}");
                        break;
                    case 5:
                        MaxNumber max = (int[] array) =>
                        {
                            int max = array[0];
                            foreach (var value in array)
                            {
                                if (value > max)
                                {
                                    max = value;
                                }
                            }
                            return max;
                        };
                        int[] array = { 1, 20, 15, 6, -9 };
                        Console.WriteLine($"Max value: {max(array)}");
                        break;
                    case 6:
                        MinNumber min = (int[] array) =>
                        {
                            int min = array[0];
                            foreach (var value in array)
                            {
                                if (value < min)
                                {
                                    min = value;
                                }
                            }
                            return min;
                        };
                        int[] array2 = { 1, 20, 15, 6, -9 };
                        Console.WriteLine($"Max value: {min(array2)}");
                        break;
                    case 7:
                        UnpairNumbers num = (int[] array) =>
                        {
                            int[] nums = new int[array.Length];
                            foreach (int value in array)
                            {
                                if (value % 2 != 0)
                                {
                                    nums.Append(value);
                                }
                            }
                            return nums;
                        };
                        int[] array3 = { 1, 20, 15, 6, -9 };
                        Console.WriteLine($"Unpair numbers:");
                        foreach(var value in num(array3))
                        {
                            Console.Write(value + " ");
                        }

                        break;
                }
            }




            //var a = new A();
            //MyDelegate del = a.Show;
            //del();
            //Delegate_1 del_1 = delegate (string str)
            //{
            //    Console.WriteLine(str);
            //    return str;
            //};
            //del_1("Hello");
            //Delegate_1 del_2 = (str) =>
            //{
            //    Console.WriteLine(str);
            //    return "Hello";
            //};
            //del_2("World!");
            //MyDelegate del_3 = () =>
            //{
            //    Console.WriteLine("Nazariy");
            //};
            //del_3();
        }
    }
    //public class A
    //{
    //    public void Show() =>
    //        Console.WriteLine("TEXT");
    //}
}
