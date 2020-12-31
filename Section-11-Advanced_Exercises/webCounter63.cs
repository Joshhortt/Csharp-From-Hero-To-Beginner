// 63. Webpage Word Search Counter
// Small program that read a string from a website and it than count the number of words.

using System;
using System.Net;

public class WebCounter63
{
    static public void Main () 
    {
    	int count = 0;  // a counter

		WebClient wc = new WebClient(); //webClient gives us the possibility to give us some text from a webpage.
		// webData is a string that contaisn all the data within the webpage.
        string webData = (wc.DownloadString("http://antkey.org/en/").ToUpper()); // We give to webClient a string, 
                                                             //that is a webaddress and downloads the webpage into our computers memory

		string searchWord;  // searchWord by a string that will be entered by the user
		Console.Write("Enter Search Word: ");
		searchWord = Console.ReadLine().ToUpper();  // search word in uppercase 

		string[] words = webData.Split(' '); // split method that separates word by spaces and put them all into an array of words.
		foreach(string w in words)  // loops through all those words
		{
			if(w.Contains(searchWord))  // if statement of word searched by the user
				count++;               // if true it increases by 1
		}

		Console.WriteLine("{0} occurs {1}", searchWord, count);  // print out the searched word occurs so many times.
	}
}

/*Enter Search Word: ant
ANT occurs 116

it includes all the word wit 'ant' ants etc.. including the HTML behind it, because we include the 'Contains in line 25.
*/