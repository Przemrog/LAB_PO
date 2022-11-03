namespace WebApplication3.Services.LAB4
{
    public class Polish : Language, ILanguage
    {

        public Polish(string name)
        {
            Name = name;
        }


        public string Name { get; set; }

        public override string getLang()
        {
            return "POLSKA GUROM";
        }

        public string GetLanguageName()
        {
            return Name;
        }
    }
} 
