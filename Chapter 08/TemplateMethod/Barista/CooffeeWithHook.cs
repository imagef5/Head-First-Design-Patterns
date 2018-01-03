using System;

namespace Barista
{
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        protected override void Brew()
        {
            Console.WriteLine("필터로 커피를 우려내는 중");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("우유와 설탕을 추가하는 중");
        }

        protected override bool CustomerWantsCondiments()
        {
            string answer = getUserInput();
            if(answer.StartsWith("y"))
                return true;
            else
                return false;
        }

        string getUserInput()
        {
            string question = "커피에 우유와 설탕을 넣어 드릴까요?(y/n) : ";
            string answer = null;
            bool condition = true;
            
            while(condition){
                Console.Write(question);
                answer = Console.ReadLine().Replace(question, string.Empty).Trim().ToLower();
                if(!string.IsNullOrEmpty(answer) && (answer.StartsWith("y") || answer.StartsWith("n")))
                {
                    condition = false;
                }
            };

            return answer;
        }
    }
}