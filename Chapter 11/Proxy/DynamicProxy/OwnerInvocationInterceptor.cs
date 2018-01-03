/*
    Castle.Core 를 이용한 Dynamic Proxy 구현
    참조 : https://github.com/castleproject/Core/blob/master/docs/dynamicproxy.md
*/
using System;
using Castle.DynamicProxy;

namespace DynamicProxy
{
    public class OwnerInvocationInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            try
            {
                if(invocation.Method.Name.StartsWith("get_", StringComparison.OrdinalIgnoreCase))
                {
                    invocation.Proceed();
                }
                else if(invocation.Method.Name.Equals("set_HotOrNotRating", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception("권한이 없습니다.");
                }
                else if(invocation.Method.Name.StartsWith("set_", StringComparison.OrdinalIgnoreCase))
                {
                    invocation.Proceed();
                }
            }
            catch(Exception e)
            {
                //var trace = e.StackTrace;
                throw new Exception(e.Message);
            }
        }
    }
}