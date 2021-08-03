namespace WillTheAirKillMe.Data
{
    public class Category
    {
        public int Number{get;set;}
        public string Name{get;set;}
        public string Color{get;set;}
        public string Message{
        get{
            switch(Number){
                case 1:
                    return "1";
                case 2:
                    return "2";
                case 3:
                    return "3";
                case 4:
                    return "4";
                case 5:
                    return "5";
                case 6:
                    return "6";
                default:
                    return "Meow";
            }
        }
        set{}
        }
    }
}