using System;
using System.Text;

namespace Gumball
{
    public class GumballMachine
    {
        GumballState state = GumballState.SOLDOUT;
        int count = 0;

        public GumballMachine(int count)
        {
            this.count = count;
            if(count > 0)
            {
                state = GumballState.NOQUARTER;
            }
        }

        #region Public Method Area
        public void InsertQuarter()
        {
            if(state == GumballState.HASQUARTER)
            {
                Console.WriteLine("동전은 한 개만 넣어주세요.");
            }
            else if(state == GumballState.NOQUARTER)
            {
                state = GumballState.HASQUARTER;
                Console.WriteLine("동전을 넣으셨습니다.");
            }
            else if(state == GumballState.SOLDOUT)
            {
                Console.WriteLine("매진되었습니다. 다음 기회에 이용해 주세요");
            }
            else if(state == GumballState.SOLD)
            {
                Console.WriteLine("잠깐만 기다려 주세요. 알맹이가 나가고 있습니다.");
            }
        }

        public void EjectQuarter()
        {
            if(state == GumballState.HASQUARTER)
            {
                Console.WriteLine("동전이 반환됩니다.");
                state = GumballState.NOQUARTER;
            }
            else if(state == GumballState.NOQUARTER)
            {
                Console.WriteLine("동전을 넣어주세요.");
            }
            else if(state == GumballState.SOLD)
            {
                Console.WriteLine("이미 알맹이를 뽑으셨습니다.");
            }
            else if(state == GumballState.SOLDOUT)
            {
                Console.WriteLine("동전을 넣지 안으셨습니다. 동전이 반환되지 안습니다.");
            }
        }

        public void TurnCrank()
        {
            if(state == GumballState.SOLD)
            {
                Console.WriteLine("손잡이를 한번만 돌려주세요");
            }
            else if(state == GumballState.NOQUARTER)
            {
                Console.WriteLine("동전을 넣어주세요.");
            }
            else if(state == GumballState.SOLDOUT)
            {
                Console.WriteLine("매진되었습니다.");
            }
            else if(state == GumballState.HASQUARTER)
            {
                Console.WriteLine("손잡이를 돌리셨습니다.");
                state = GumballState.SOLD;
                dispense();
            }
        }

        public void Refill(int balls)
        {
            count += balls;
            state = GumballState.NOQUARTER;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("\nMighty Gumball, Inc.");
            result.AppendLine("C# 으로 돌아가는 2017년형 뽑기기계");
            result.AppendLine($"남은개수: {count} 개");

            result.Append("현재 뽑기상태는 : ");
            if (state == GumballState.SOLDOUT) {
                result.Append("매진");
            } else if (state == GumballState.NOQUARTER) {
                result.Append("동전 투입 대기중");
            } else if (state == GumballState.HASQUARTER) {
                result.Append("손잡이 돌리기 대기중");
            } else if (state == GumballState.SOLD) {
                result.Append("알맹이 나가는중");
            }
            result.AppendLine();

            return result.ToString();
        }
        #endregion

        #region private Method Area
        private void dispense()
        {
            if(state == GumballState.SOLD)
            {
                Console.WriteLine("알맹이가 나가고 있습니다.");
                count--;
                if(count <= 0)
                {
                    Console.WriteLine("더 이상 알맹이가 없습니다.");
                    state = GumballState.SOLDOUT;
                }
                else
                {
                    state = GumballState.NOQUARTER;
                }
            }
            else if(state == GumballState.NOQUARTER)
            {
                Console.WriteLine("동전을 넣어주세요.");
            }
            else if(state == GumballState.SOLDOUT)
            {
                Console.WriteLine("매진입니다.");
            }
            else if(state == GumballState.HASQUARTER)
            {
                Console.WriteLine("알맹이가 나갈 수 없습니다.");
            }
        }
        #endregion
        
    }
}