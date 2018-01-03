
namespace StarBuzz
{

    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string Description {get;}
    }
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            //description = "모카";
        }

        public override string Description => beverage.Description + ", 모카";

        public override double Cost()
        {
            return .20 + beverage.Cost();
        }
    } 

    public class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
            //description = "두유";
        }

        public override string Description => beverage.Description + ", 두유";


        public override double Cost()
        {
            return .15 + beverage.Cost();
        }
    }

    public class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            //description = "휘핑 크림";
        }

        public override string Description => beverage.Description + ", 휘핑 크림";


        public override double Cost()
        {
            return .10 + beverage.Cost();
        }
    }

    public class SteamMilk : CondimentDecorator
    {
        Beverage beverage;

        public SteamMilk(Beverage beverage)
        {
            this.beverage = beverage;
            //description = "두유";
        }

        public override string Description => beverage.Description + ", 스팀 크림";


        public override double Cost()
        {
            return .10 + beverage.Cost();
        }
    }
}