using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life";

        ScriptureReference r = new ScriptureReference("John", "3", "16");

        Scripture scripture = new Scripture(text);
        scripture.Reference = r;

        
        do {
            if(scripture.getNonRedactedWordCount() == 0){
                quit = true;
            }
            string outString = scripture.Reference.GetReference() + " ";
            outString = outString + " " + scripture.GetScripture();
            Console.WriteLine(outString);

            Console.WriteLine("Hit enter to redact words, or type ''quit'' to end.");
            string proceed = Console.ReadLine();
            Console.Clear();

            if (proceed == "quit" ) {
                quit = true;
            }
            else {
                scripture.RedactWords();
            }

        } while (quit != true);
        

    }
}