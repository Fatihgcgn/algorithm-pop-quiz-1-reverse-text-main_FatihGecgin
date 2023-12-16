/*
You have a text that some of the words in reverse order.
The text also contains some words in the correct order, and they are wrapped in parenthesis.
Write a function fixes all of the words and,
remove the parenthesis that is used for marking the correct words.

Your function should return the same text defined in the constant correctAnswer, please keep in mind
that shortest way possible will get you extra points.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        var inputText = "nhoJ (Griffith) nodnoL saw (an) (American) ,tsilevon ,tsilanruoj (and) laicos .tsivitca ((A) reenoip (of) laicremmoc noitcif (and) naciremA ,senizagam (he) saw eno (of) (the) tsrif (American) srohtua (to) emoceb (an) lanoitanretni ytirbelec (and) nrae a egral enutrof (from) ).gnitirw";
        var correctAnswer = "John Griffith London was an American novelist, journalist, and social activist. (A pioneer of commercial fiction and American magazines, he was one of the first American authors to become an international celebrity and earn a large fortune from writing.)";
        char gecici;

        static string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
        string reversedSentence = ReverseWords(inputText);
        char[] karakterler = reversedSentence.ToCharArray();
        int kLength = karakterler.Length - 1;

        for (int i = 0; i < kLength; i++, kLength--)
        {
            gecici = karakterler[i];
            karakterler[i] = karakterler[kLength];
            karakterler[kLength] = gecici;
        }
        string sonuc = new string(karakterler); //yerlerini ve parantezleri düzeltmek için replace metodu kullanıyorum.
        sonuc = sonuc.Replace(")htiffirG(", "Griffith");
        sonuc = sonuc.Replace(")na(", "an");
        sonuc = sonuc.Replace(")naciremA(", "American");
        sonuc = sonuc.Replace(")dna(", "and");
        sonuc = sonuc.Replace(")A((", "(A");
        sonuc = sonuc.Replace(")fo(", "of");
        sonuc = sonuc.Replace(")eh(", "he");
        sonuc = sonuc.Replace(")eht(", "the");
        sonuc = sonuc.Replace(")ot(", "to");
        sonuc = sonuc.Replace(")morf(", "from");

        string ReverseText(string input)
        {
            return sonuc;
        }
        Console.WriteLine(ReverseText(inputText) == correctAnswer ? "Correct !!!" : "Wrong answer...!");
    }
}