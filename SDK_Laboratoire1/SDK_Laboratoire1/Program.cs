using LibrairieConversionNote;

static class Program
{
    static int Main()
    {
        var converter = new ConversionAlphabetiqueToNote();
       // converter.Transformer('P');
       // Console.WriteLine(converter.Transformer('P'));

        //On roule l'application non-stop, tant que CTRL+C
        while (true)
        {
            Console.Write("Type de conversion à faire : ");
            var input = Console.ReadLine();

            //Si l'utilisateur tape note
            if (input?.ToUpperInvariant() == "NOTE")
            {
                //On demande en boucle la coBnversion  
                while (true)
                {
                    Console.Write("Conversion à faire : ");
                    var note = Console.ReadLine();
                    var result = converter.Transformer(note);
                    string noteRetour = result == "" ? "Je ne suis pas implémentée" : result; 
                    Console.Write(noteRetour);
                    Console.WriteLine();
                }
            }
        }
         
        return 0;
    }
}
// demarches