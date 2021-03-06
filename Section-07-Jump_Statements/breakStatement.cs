/*
using System;
using System.Net;
 
public class BreakStatement
{
    static public void Main () 
    {
        string word;
        string url;
        Console.WriteLine("Search Word:");
        word = Console.ReadLine();
        Console.WriteLine("URL");
        url = Console.ReadLine();

        WebClient wc = new WebClient();
        
        string webText = wc.DownloadString(url);

        Console.WriteLine(webText);
    }
}
*/
/*
Search Word:
Peanut
URL
http://textfiles.com/fun/blood
                REALISTIC BLOOD
                           ---------------

  Ingrediants  - Corn syrop or Karo syrop (clear)
               - Zinc Oxide
               - Red food color
               - Yellow food color
               - Water ( H O )
                          2

       Optional  - Green food color
                 - Peanut butter ( smooth )
                 - Kodak Photo-Flo


Quantitiy Table

+--------------------------------------------------------------------+
I Karo    Zinc Oxide    Red color   Yellow color    Photo-flo   H2O  I
+--------------------------------------------------------------------+
I                                                                    I
I  1P     1/2 L Tsps.     1 Oz.     2 1/2 Tsps.       1 Oz.     1 Oz I
I  1Q     1   L Tsps.     2 Oz.     5     Tsps.       2 Oz.     2 Oz I
I  2Q     2   L Tsps.     4 Oz.     1oz + 4 Tsps      4 Oz.     4 Oz I
I  3Q     3   L Tsps.     6 Oz.     2 1/2 Oz.         6 Oz.     6 Oz I
I  1G     4   L Tsps.     8 Oz.     3oz + 2 Tsps      8 Oz.     8 Oz.I
I                                                                    I
I                                     note 1          note 2         I
+--------------------------------------------------------------------+
I  P = Pint           L = Level           Tsps. = Tea Spoon          I
I  Q = Quart          G = Gallon          Oz. = Fluid Ounce          I
+--------------------------------------------------------------------+

  Note 1 = Test yellow food color first by droping a drop of color onto white
           paper .  If the color stained is lemon yellow then use above ratio .
           If color is more orange than yellow then devide amount in half ( 1/2
           norm ) .

  Note 2 = If you add Kodak Photo-flo to the blood you cannot eat it .  The
           Photo-flo alows the blood to soak into cloth .



  Procedure - Get a bowl slightly large than volume of Karo syrop.  Add equal
amounts of zinc oxide and mix together.  Add color.  Mix well.  When color is
mixed in well add a bit of the syrop , mix well.  Continue until all the syrop
is mixed in.  Put in conatianer .

  Notes - If you want the blood to soak into fabrics then add the Photo-flo
when you add the colors.

  Keep blood cold.  It molds if left in warm area

  Mix before using.  The zinc oxide deposites at the bottom of the bottle if
not mixed .

  Zinc Oxide can be found at drug stores and chemical supply houses.  In small
doses it is harmless.


     To Darken   Add drops of green .
    To Thicken   Add small amounts of peanut butter.
       To Thin   Use above with Photo-flo , but match amounts of syrop with
                 water ie.  if recipe calls for 1 Q syrop then also add 1 Q
                 water .

Formula created by Mark Benett  Mtl.
It does work, it looks great and you can wash it out of fabrics.


Future files, Grey Matter, Intestines and Eyes.
Call The Works BBS - 1600+ Textfiles! - [914]/238-8195 - 300/1200 - Always Open
*/


// But we can´t do a serach if we don t split it up into individual words
// In thsi case without the break statement, iT will print out every single
// word we are seraching.

/*
using System;
using System.Net;
 
public class BreakStatement
{
    static public void Main () 
    {
        string word;
        string url;
        Console.WriteLine("Search Word:");
        word = Console.ReadLine();
        Console.WriteLine("URL");
        url = Console.ReadLine();

        WebClient wc = new WebClient();
        
        string webText = wc.DownloadString(url);

        string[] words = webText.Split(' ');
        foreach(string w in words)
        {
            if(w.ToUpper() == word.ToUpper())
            {
                Console.WriteLine("{0} found.", word); 
            }
        }
    }
}

Search Word:
oz
URL
http://textfiles.com/fun/blood
oz found.
oz found.
oz found.
oz found.

*/

// Now here with the break statement included. It will return the word we are searchin, it doesn' matter
// How many are in the textfile and it will break out immediatly 
// after it encounters the serached word. It doesn´t keeping looping through the other same words.

using System;
using System.Net;
 
public class BreakStatement
{
    static public void Main () 
    {
        string word;
        string url;
        Console.WriteLine("Search Word:");
        word = Console.ReadLine();
        Console.WriteLine("URL");
        url = Console.ReadLine();

        WebClient wc = new WebClient();
        
        string webText = wc.DownloadString(url);

        string[] words = webText.Split(' ');
        foreach(string w in words)
        {
            if(w.ToUpper() == word.ToUpper())
            {
                Console.WriteLine("{0} found.", word); 
                break;
            }
        }
    }
}

/*
Search Word:
oz
URL
http://textfiles.com/fun/blood
oz found.
*/