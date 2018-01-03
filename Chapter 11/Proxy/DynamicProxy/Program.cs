/*
    Dynamic Proxy 를 생성하기 위해 Casle.Core 를 사용하였으며,
    Head First Design Patterns 의 java 코드를 C# 버전으로 단순 변경함.
    참조 : https://github.com/castleproject/Core/blob/master/docs/dynamicproxy.md
*/
using System;
using System.Collections.Generic;
using Castle.DynamicProxy;

namespace DynamicProxy
{
    class Program
    {
        Dictionary<string, IPerson> datingDB =  new Dictionary<string, IPerson>();

        public Program()
        {
            initializeDatabase();
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Program test = new Program();
            test.Drive();
        }

        public void Drive()
        {
            IPerson joe = getFromDatabase("Joe Javabean");
            /*
                보통의 경우 별도의 인증처리등을 통하여 OwnerProxy or NonOwnerProxy 를 생성하겠지만,
                단순 예제를 위해 아래코드를 사용하였습니다.
            */
            IPerson ownerProxy = getOwnerProxy(joe);
            Console.WriteLine($"Name is {ownerProxy.Name}");
            ownerProxy.Interests = "boling, Go";
            Console.WriteLine($"Interests set from owner proxy");
            try
            {
                ownerProxy.HotOrNotRating = 10;
            }
            catch
            {
                Console.WriteLine("Can't set rating from owner proxy");
            }
            Console.WriteLine($"Rating is {ownerProxy.HotOrNotRating}");
            Console.WriteLine("---------------------------");

            IPerson nonOwnerProxy = getNonOwnerProxy(joe);
            Console.WriteLine($"Name is {nonOwnerProxy.Name}");
            try
            {
                nonOwnerProxy.Interests = "bolling, Go";
            }
            catch
            {
                Console.WriteLine("Can't set interests from non owner proxy");
            }
            nonOwnerProxy.HotOrNotRating = 3;
            Console.WriteLine($"Rating set from non owner proxy");
            Console.WriteLine($"Rating is {nonOwnerProxy.HotOrNotRating}");
        }
        #region Private Method
        IPerson getOwnerProxy(IPerson person)
        {
            var proxy = (IPerson)new ProxyGenerator()
                        .CreateInterfaceProxyWithTarget(
                            typeof(IPerson), 
                            person,
                            new OwnerInvocationInterceptor());

            return proxy;
        }

        IPerson getNonOwnerProxy(IPerson person)
        {
            var proxy = (IPerson)new ProxyGenerator()
                        .CreateInterfaceProxyWithTarget(
                            typeof(IPerson), 
                            person,
                            new NonOwnerInvocationInterceptor());

            return proxy;
        }

        IPerson getFromDatabase(string name)
        {
            return datingDB[name];
        }
        void initializeDatabase() 
        {
            IPerson joe = new Person();
            joe.Name = "Joe Javabean";
            joe.Interests = "cars, computers, music";
            joe.HotOrNotRating = 7;
            datingDB.Add(joe.Name, joe);

            IPerson kelly = new Person();
            kelly.Name = "Kelly Klosure";
            kelly.Interests = "ebay, movies, music";
            kelly.HotOrNotRating = 6;
            datingDB.Add(kelly.Name, kelly);
        }
        #endregion
    }
}
