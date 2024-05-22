using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace ConsoleApp2
{
    internal class Program
    {
        //input1 = "fun&!! time"  Output: time
        public static string LongestWord(string sen)
        {
            int i = 0, max; string newstr = "";
            while (i < sen.Length)
            {
                if (sen[i] == ' ' || char.IsLetter(sen[i]) || char.IsDigit(sen[i]))

                    newstr += sen[i];
                i++;
            }
            string[] words = newstr.Split(' ');
            max = words[0].Length;
            sen = words[0];
            for (i = 1; i < words.Length; i++)
            {
                if (words[i].Length > max)
                {
                    max = words[i].Length;
                    sen = words[i];
                }
            }
            return sen;
        }
       



        //input1 = "fun&!! time"  Output: time

        public static string LongestWord2(string sen)
        {
            string cleaned = Regex.Replace(sen, @"[^\w\s]", "");


            string[] words = cleaned.Split(' ');


            return words.OrderByDescending(word => word.Length).First();
        }



        // input:3 output:(1*2*3()3!)=6
        public static int FirstFactorial(int num)
        {
            if (num > 18)
                return num;
            // code goes here  
            int i = 2, sum = 1;

            while (i <= num)
            {
                sum *= i;
                i++;
            }
            num = sum;
            return num;

        }

        //חיבור שני מערכים למערך אחד
        public static int[] Tar1(int[] arr1, int[] arr2)
        {
            int[] arr = new int[Math.Max(arr1.Length, arr2.Length)];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr1.Length <= i)
                    arr[i] = arr2[i];
                else if (arr2.Length <= i)
                    arr[i] = arr1[i];
                else
                    arr[i] = arr2[i] + arr1[i];
            }
            return arr;
        }

        //[1,2,3,4] out:2,3
        public static int[] Tar2(int[] arr1)
        {
            int[] arr2 = { arr1[1], arr1[arr1.Length - 2] };
            return arr2;
        }

        //מיון מחרוזת A B C
        public static string Tar3(string str)
        {
            //char[] charArray = str.ToCharArray();

            string newstr = "";
            while (str != "")
            {
                char min = str[0];
                int ind1 = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] < min)
                    {
                        ind1 = i;
                        min = str[i];

                    }
                }
                newstr += str[ind1];
                str = str.Substring(0, ind1) + str.Substring(ind1 + 1);

            }

            return newstr;
        }
        //מיון A B C קצר ע"י המרות
        public static void TarSort(string str)
        {
            string input = str;
            char[] charArray = input.ToCharArray();
            Array.Sort(charArray);
            string sortedString = new string(charArray);
            Console.WriteLine(sortedString);
        }



        //מחרוזת מס' בין אי זוגי לשים "-"
        public static string Tar4(string str)
        {
            int i = 0;
            string newstr = "";
            while (i < str.Length - 1)
            {
                newstr += str[i];
                if ((((int)(str[i]) - 48) % 2 != 0) && (((int)(str[i + 1]) - 48) % 2 != 0))
                    newstr += '-';
                i++;
            }
            newstr += str[str.Length - 1];
            return newstr;
        }

        //input:()( () output:false
        public static string BracketMatcher(string str)
        {
            int cnt = 0, i = 0;

            while (i < str.Length)
            {
                if (str[i] == '(')
                    cnt++;
                if (str[i] == ')')
                    cnt--;
                if (cnt < 0)
                    return "0";
                i++;
            }
            return cnt == 0 ? "1" : "0";


        }

        //להכפיל ע"פ המספרים AABBCCD =2A2B2C1D
        public static string Tar6(string str)
        {
            int i = 1, pre = 0, num;
            string newstr = "" + str[0];
            while (i < str.Length)
            {

                if (str[i] >= '0' && str[i] <= '9')
                {
                    if (str[i] == '0')
                        newstr = newstr.Substring(0, newstr.Length - 1);
                    num = (int)(str[i]) - 48;
                    for (int j = 1; j < num; j++)
                    {
                        newstr += str[pre];
                    }
                }
                else
                    newstr += str[i];
                pre++;
                i++;

            }
            return newstr;
        }

        //Reverse
        public static string Tar7(string str)
        {
            int i = str.Length - 1;
            string newstr = "";
            while (i >= 0)
            {
                newstr += str[i];
                i--;
            }
            return newstr;
        }
        //Reverse
        public static void Tar77(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            str=new string(arr);
            Console.WriteLine( str);

        }
            //input=  time2= "11:22 AM"  time1= "2:01 AM";
            //output=561
            public static  int CalculateDifference(string time1, string time2)
            {
                DateTime dt1 = DateTime.Parse(time1);
                DateTime dt2 = DateTime.Parse(time2);
            if(dt1 > dt2)
            {
                dt2 = dt2.AddDays(1);
            }
       
                return Math.Abs( (int)((dt2 - dt1).TotalMinutes));            
            }

            //input =aaadfrr; output=a3d1f1r2
            public static void Tur8(string str)
            {
                int i = 1,p=0,cnt=1;
                string newstr = ""+str[0];
                while (i < str.Length)
                {
                    if (str[i] == str[p])
                        cnt++;
                    else
                    {   newstr += cnt;
                        newstr+=str[i];
                        cnt = 1;  
                    }
                    i++;
                    p++;

                }
                Console.WriteLine( newstr+cnt);
            }


            //input=36 (3*6 ,1*8) output=8
            public static void Tur9(int num)
            {
                while (num / 10 != 0)
                {
                    num=(num/10)*(num%10);
                }
                Console.WriteLine(num);
            }



        //input:{ 0, 1, 14, 16, 8, 12, 30 } output:true(0+14+16=30)
        public static bool Tur10(int[] arr)
        {
            int num,sum;
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                { 
                    if (i == j)
                        continue;
                    num = arr[i] - arr[j];
                    int s = 0, e = arr.Length - 1;
                    while (s < e)
                    {
                        if (s == i || s == j)
                        {
                            s++; continue;
                        }
                         if (e == i || e == j)
                        {
                            e--; continue;
                        }
                       sum =arr[s]+ arr[e];
                        if (sum == num)
                        {
                            Console.WriteLine(arr[i]);
                            return true; 
                        }
                        if (sum < num)
                            s++;
                        else
                            e--;
                       }
                }

            }
            return false;

        }

        //input:{ 4, 5, 7} output:8(2^N)
        public static int tar11(int[]arr)
        {
           
            return (int)Math.Pow(2,arr.Length);
        }

        //input=156 output=21/05/2024 02:36:00
        public static DateTime Tar12(int num)
        {
            string str = "";
            str += num / 60 + ":" + num % 60;
            
            return DateTime.Parse(str);
        }

        //input:"III" Output: 3
        public static int RomanToInt(string s)
        {

            Dictionary<char, int> dictionary = new Dictionary<char, int> {
                {'I',1} ,
                {'V',5} ,
                {'X',10} ,
                {'L',50} ,
                {'C',100} ,
                {'D',500} ,
                {'M',1000}
            };
            int res = 0, prev = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (dictionary[s[i]] < prev)
                {
                    res -= dictionary[s[i]];
                }
                else
                {
                    res += dictionary[s[i]];
                }
                prev = dictionary[s[i]];
            }
            return res;

        }
        //input:"AabdD" out:12
        public static int Tar13(string str)
        {
            int i = 0,sum=0;
            while (i < str.Length)
            { if (str[i] > 96)
                    sum += str[i] - 96;
                else
                    sum += str[i] - 64;
                i++;
            }
            return sum;
        }


        public static string Tar14(string str)
        {
            string[] words=str.Split(' ');
            string newstr = "";
            for (int i=0;i< words.Length; i++)
            {
                if (words[i][0]>96)
                words[i] =(char)((int)(words[i][0]) - 32) + words[i].Substring(1);
            }
            for (int i = 0; i < words.Length; i++)
            {
                newstr += words[i] + " ";
            }
            return newstr;
        }

        //input:3128 out:6(3*1*2*8=48=4*8=32=3*2=6)
        public static int Tar15(int num)
        {
            int sum = num;
            while (num / 10 != 0)
            {
                sum=num % 10;
                num/= 10;
                while (num > 0)
                {
                    sum *= num % 10;
                    num/=10;
                }
                num = sum;
            }
            return num;
        }
        //input: { "12AM-12PM", "2:1AM-3AM" } output:12:0
        public static string Tar16(string[] arrTime)
        {
            string str1=arrTime[0];
            string str2=arrTime[1];
            
         
            DateTime start1 =DateTime.Parse( str1.Substring(0, str1.IndexOf("-")));
            DateTime start2 = DateTime.Parse(str2.Substring(0, str2.IndexOf("-")));
            DateTime end1 = DateTime.Parse(str1.Substring( str1.IndexOf("-")+1));
            DateTime end2 = DateTime.Parse(str2.Substring( str2.IndexOf("-")+1));
           
            int num;
          
            if (Math.Abs((int)((start2 - end2).TotalMinutes)) > Math.Abs((int)((start1 - end1).TotalMinutes)))
                num = Math.Abs((int)((start2 - end2).TotalMinutes));

            else
                num = Math.Abs((int)((start1 - end1).TotalMinutes));

            return ""+num/60+":"+num % 60;
        }


        static void Main(string[] args)
            {
            //string[] arr = { "12AM-12PM", "2:1AM-3AM" };
            //Console.WriteLine(Tar16(arr));

            //Console.WriteLine(Tar15(3128));

            //Console.WriteLine(Tar14("sari Rom gtev Kkbec g ged"));


            //Console.WriteLine(Tar13("AabdD"));

            //char c = 'A';//a=97 A=65
            //int x = (int)(c);
            //Console.WriteLine(x-64);

            //Console.WriteLine(RomanToInt("III"));       // Output: 3
            //Console.WriteLine(RomanToInt("LVIII"));     // Output: 58
            //Console.WriteLine(RomanToInt("MCMXCIV"));   // Output: 1994
            //Console.WriteLine(Tar12(156));


            //int[] arr = { 4, 5, 7,5,8 };
            //Console.WriteLine( tar11(arr));


            //int[] arr = { 0, 1, 14, 16, 8, 12, 30 };
            //Console.WriteLine(Tur10(arr));

            //string input1 = "fun&!! time";
            //string input2 = "I love dogs";
            //string input3 = "Hello world123 567";

            //Console.WriteLine(LongestWord1(input1)); // Output: time
            //Console.WriteLine(LongestWord1(input2)); // Output: love
            //Console.WriteLine(LongestWord1(input3)); // Output: world123

            //Console.WriteLine(char.IsLetter('*'));


            //מס' דקות הפרש 
            //string time2 = "11:22 PM";
            //string time1 = "2:01 AM";
            //Console.WriteLine(CalculateDifference(time1, time2));


            //הופך מחרוזת
            //Console.WriteLine(Tar7("sarah"));


            //ממכפיל תווים- AAAAC
            //Console.WriteLine(Tar6("A4B0C1D0"));

            //סכום עד המס'
            //Console.WriteLine(Tar5(5));


            ////בדיקת התאמת סוגריים ()
            //Console.WriteLine(BracketMatcher(")("));


            // Tar44();
            //לשים "-" איזוגי
            //string str = Tar4("12358479");
            //Console.WriteLine(str);

            //קןד אסקי של מספרים=48
            //int x = (int)('4')-48;
            //Console.WriteLine(x);


            //מיון ע"י המרות
            //TarSort("bacghfdeij");


            //מיון מחרוזת לA B C...
            //string str = Tar3("bacghfdeij");
            //Console.WriteLine(str);

            //ניביונות עם Substring 
            //string str = "satfj";
            //str = str.Substring(0,0);
            //Console.WriteLine(str=="");

            //int[] arr1 = { 1, 2, 3, 4 };
            //int[] arr = Tar2(arr1);
            //Console.WriteLine(arr[0] + "  " + arr[1]);

            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 1, 2, 3,5,8 };
            //int[] arr3 = Tar1(arr1 , arr2);  
            //for (int i= 0; i < arr3.Length; i++)
            //{
            //    Console.WriteLine(arr3 [i]);    
            //}

            //Console.WriteLine(FirstFactorial(19));

            //string input = "fun&!! saaaeee time";
            //string result = LongestWord(input);
            //Console.WriteLine(result);
        }
        }
    }

