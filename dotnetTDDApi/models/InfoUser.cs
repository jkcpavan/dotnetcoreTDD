namespace dotnetTDDApi.models
{
    public class InfoName{

        public InfoName(string FirstName,string LastName)
        {
            this.FirstName=FirstName;
            this.LastName=LastName;
        }
        public readonly string FirstName;
        public readonly string LastName;

    }
}