namespace LibrairieConversionNote
{
    public class ConversionAlphabetiqueToNote
    {
        public string Transformer(string alphabet)
        {


            switch (alphabet)
            {
                case "A": case "a": return "LA"; break;
                case "B": case "b": return "SI"; break;
                case "C": case "c": return "DO"; break;
                case "D": case "d": return "RE"; break;
                case "E": case "e": return "MI"; break;
                case "F": case "f": return "FA"; break;
                case "G": case "g": return "SOL"; break;
                default: return string.Empty;
            }

        }


    }
}