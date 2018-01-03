
namespace Classic
{
    //NOTE: This is not thread safe!, don't use!
    public class Singleton
    {
        private static Singleton instance;

        private Singleton()
        {

        }

        public static Singleton Instance 
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public string Description
        {
            get
            {
                return "I'm a classic Singleton!";
            }
        }
    }
}