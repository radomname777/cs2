using System;
class Program
{
    static string[] realanswer = new string[] { "Baki", "3", "Peru", "Meksico", "Istanbul" };
    static int score = 0;
    static void Start(string[][]arr,string[][]arr2)
    {
        for (int i = 0; i < arr.Length; i++)
        {
           while (true)
           {
               Console.Clear();
               Console.ForegroundColor = ConsoleColor.White;
               bool isokay= false;
               Console.WriteLine(arr[i][0]);
               Console.WriteLine($"A){arr2[i][0]} B){arr2[i][1]} C){arr2[i][2]}");
               var symbol = Console.ReadLine().ToUpper();
               if (symbol == "A") { isokay = Score(arr2[i][0], i);}
               else if (symbol == "B") { isokay = Score(arr2[i][1], i);}
               else if (symbol == "C") { isokay = Score(arr2[i][2], i);}
               else continue;
               if (isokay) Console.ForegroundColor = ConsoleColor.Green;
               else Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine(symbol);
               Thread.Sleep(1659);
               break;
           }
        }
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Score: {score}\n");
    }
    static void Shuffle(string[][] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Random random = new Random();
            arr[i] = arr[i].OrderBy(x => random.Next()).ToArray();
        }
    }
    static bool Score(string realansw,int count)
    {
        if(realansw == realanswer[count]) { score += 10; return true; }
        else if(score == 0) { score = 0; }
        else { score -= 10; }
        return false;
    }
    static void Main(string[] args)
    {
       string[][] qusetion = new string[5][] {
           new string[]{ "Azerbaycanin paytaxdi haradir ?"},
           new string[]{ "Simali Amerikada nece olke var ?"},
           new string[]{ "macu picu seheri hansi olkededir? "},
           new string[]{ "Meksikanin paytaxdi haradir ?"},
           new string[]{ "Avropanin en boyuk seheri haradir ?"},
       };
       string[][] answers = new string[5][] {
           new string[3]{ "Baki", "Gence", "Samaxi"},
           new string[3]{ "11", "3", "27"},
           new string[3]{ "Peru", "Meksika", "Argentina"},
           new string[3]{ "Quadalaxara", "Meksico city", "Meksico"},
           new string[3]{ "Istanbul", "Paris", "Madrid" }
       };
       Shuffle(answers);
       Start(qusetion, answers);
    }
}
