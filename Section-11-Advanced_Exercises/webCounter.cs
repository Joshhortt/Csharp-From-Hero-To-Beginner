using System;
using System.Net;
public class WebCounter
{
    static public void Main () 
    {
         int count = 0;

         // This code is a bit different than form WebCounter63.cs 
         /*
         The lines I've added use concepts beyond the scope of this course,
        but in short they are telling your program to ignore website certificate
         */
         var request = (HttpWebRequest)WebRequest.Create("http://bio.acousti.ca/");
         request.ServerCertificateValidationCallback += 
                (sender, cert, chain, error) =>
         {
             return true;
         };
         
         WebClient wc = new WebClient();
         string webData = (wc.DownloadString("http://bio.acousti.ca/").ToUpper());
         string searchWord;
         Console.Write("Enter Search Word: ");
         searchWord = Console.ReadLine().ToUpper();
         string[] words = webData.Split(' ');
         foreach(string w in words)
         {
             if(w.Contains(searchWord))
                 count++;
         }
         Console.WriteLine("{0} occurs {1}", searchWord, count);
     }
}

/*
Enter Search Word: Bioacoustics
BIOACOUSTICS occurs 2

*/