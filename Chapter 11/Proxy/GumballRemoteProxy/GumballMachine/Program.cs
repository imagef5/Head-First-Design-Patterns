/*
원격 통신
.NET Remoting은 문제가 있는 아키텍처로 확인되었으며 더 이상 지원되지 않는 AppDomain 간 통신에 사용됩니다. 
또한 원격 통신에는 유지 관리 비용이 많이 드는 런타임 지원이 필요합니다. 이러한 이유로 .NET Remoting은 .NET Core에서 지원되지 않으며 향후 지원을 추가할 계획이 없습니다.
프로세스 간 통신을 위해 System.IO.Pipes 또는 MemoryMappedFile 클래스 같은 IPC(Inter-process communication) 메커니즘을 원격 통신 대신 사용할 수 있습니다.
여러 컴퓨터에서 네트워크 기반 솔루션을 대신 사용하세요. HTTP와 같이 오버헤드가 낮은 일반 텍스트 프로토콜을 사용하는 것이 좋습니다. 
ASP.NET Core에서 사용하는 웹 서버인 Kestrel 웹 서버도 옵션이 될 수 있습니다. 또한 네트워크 기반, 컴퓨터 간 시나리오에서 System.Net.Sockets의 사용을 고려하세요. 
추가 옵션은 .NET 오픈 소스 개발자 프로젝트: 메시징을 참조하세요.
 */
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using GumballMachineRemote;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GumballMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server=null;
            try{
                IPAddress ip = IPAddress.Parse("127.0.0.1");
                server = new TcpListener(ip, 9999);
                
                while(true)
                {
                    server.Start();
                    Console.WriteLine("Waiting .....");

                    var client = server.AcceptTcpClient();
                    IGumballMachine machine = new GumballMachine("명동",125);
                    
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Converters.Add(new JavaScriptDateTimeConverter());
                    serializer.NullValueHandling = NullValueHandling.Ignore;


                    using (NetworkStream stream = client.GetStream())
                    using (TextWriter tw = new StreamWriter(stream, Encoding.UTF8))
                    using (JsonTextWriter writer = new JsonTextWriter(tw))
                    {
                        writer.QuoteChar = '\'';
                        serializer.Serialize(writer, machine);
                    }
                    
                    client.Close();
                    Console.WriteLine($"Response for ({machine}) \nSent ....." );
                }
            }
            catch (SocketException se)
            {
                Console.WriteLine($"SocketException : {se.Message} ");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                server.Stop();
            }
        }
    }
}
