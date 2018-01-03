namespace DCL
{
    public class Singleton
    {
        private volatile static Singleton instance;
        private static readonly object syncLock = new object();

        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                if(instance != null)
                    return instance;

                lock (syncLock)
                {   
                    if(instance == null)
                    {
                        instance = new Singleton();
                    }
                }
                return instance;
            }
        }

        public int SomeValue { get; set; }
    }
}