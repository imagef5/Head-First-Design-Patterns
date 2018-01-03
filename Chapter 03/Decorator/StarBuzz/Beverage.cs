
namespace StarBuzz
{
    public abstract class Beverage
    {
        protected string description = "제목 없음";

        public virtual string Description => description;

        public abstract double Cost();
    }

    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "에스프레소";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "하우스 블렌드 커피";
        }

        public override double Cost()
        {
            return .89;
        }
    }

    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "다크 로스트";
        }

        public override double Cost()
        {
            return .99;
        }
    } 

    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "디카페인";
        }

        public override double Cost()
        {
            return 1.05;
        }
    } 
}