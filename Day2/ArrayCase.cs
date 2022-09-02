namespace Day2
{
    class ArrayClass
    {
        public static void IntroArray()
        {
            int[] arr;
            int[] arrInt = new int[5];
            arrInt[0] = 12;
            arrInt[1] = 45;
            arrInt[3] = 50;
            arrInt[4] = 1_000_000;

            //init array with string data type
            string[] listGirl = new string[] {"Yuli","Rini","Widi"};
            // AATAU BISA DIBAWAH INI
            //string[] listGirl = { "Yuli", "Rini", "Widi" };

            foreach (var item in listGirl)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < listGirl.Length; i++)
            {
                Console.WriteLine(listGirl[i]);
            }
        }
        // METHOD RETURN OR FUNCTION INPUT ARRAY INT, RETURN ARRAY INT
        // RETURN ITU HARUS PAKAI TIPE DATA
        public static int[] InitArrayInt(int[] arr)
        {
            int[] array = arr;
            return array;
        }
        // INITIAL VALUE WITH RANDOM
        public static int[] InitArrayRandom(int n)
        {
            int[] arr = new int[n];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(50);
            }

            return arr;
        }
        // SUM ALL ARRAY ELEMENT
        public static double FindSumElement(int[] arr)
        {
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static int FindLargestElement(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int FindSmallestElement(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public static int GreatestSecond(int[] arr)
        {
            int max = arr[0];
            var second = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    second = max;
                    max = arr[i];
                }
                else if (arr[i] > second && max != arr[i])
                {
                    second = arr[i];
                }
                else if (max == second && second != arr[i])
                {
                    second = arr[i];
                }
            }
            return second;

        }
        public static void DisplayArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{ item } ");
            }
        }
    }
}