
namespace StaticInitializer
{
    /*
    정적 초기화는 대부분의 상황에 적합합니다.
    응용 프로그램이 인스턴스화를 연기해야하거나 인스턴스 생성 전에 기본이 아닌 생성자를 사용하거나 
    다른 작업을 수행하고 다중 스레드 환경에서 작업해야하는 경우 다른 솔루션이 필요합니다.
    그러나 정적 초기화 예제에서와 같이 공용 언어 런타임에 의존하여 스레드 안전을 보장 할 수없는 경우가 있습니다. 
    https://msdn.microsoft.com/en-us/library/ff650316.aspx?f=255&MSPPError=-2147217396
    */
    public class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        private Singleton() { }

        public static Singleton Instance => instance;

        public int SomeValue { get; set; }

    }
}
