using System;
using System.Net.Sockets;
using System.Text;
using GumballMachineRemote;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GumballMonitor
{
    public class GumballMachineProxy : IGumballMachine
    {
        int count;
        string location;
        string stateComment;

        public GumballMachineProxy()
        {
            GetResponseFromServer();
        }

        #region Implement IGumballMachine Interface
        public int Count => count;

        public string Location => location;

        public string StateComment => stateComment;
        #endregion

        private void GetResponseFromServer()
        {
            TcpClient client = new TcpClient("127.0.0.1",9999); 
            try{    
                using(NetworkStream strm = client.GetStream())
                { 
                    byte[] bytes = new byte[client.ReceiveBufferSize];

                    // Read can return anything from 0 to numBytesToRead. 
                    // This method blocks until at least one byte is read.
                    strm.Read (bytes, 0, (int)client.ReceiveBufferSize);

                    // Returns the data received from the host to the console.
                    string returndata = Encoding.UTF8.GetString(bytes);
                    //서버쪽에서 받아온 스트링값의 맨 처음에 Unexpected character  삽입으로 인해 => . 으로 추정
                    //JsonConvert.DeserializeObject 시 parsing 에러가 발생하고 있음.
                    //왜 Unexpected character 가 삽입되고 있는지는 모르겠음.
                    returndata = returndata.Substring(1); 
                    Console.WriteLine ($"This is what the host returned to you:{returndata},");

                    var serializerSettings = new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver(),
                        DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                        NullValueHandling = NullValueHandling.Ignore,
                    };

                    dynamic results = JsonConvert.DeserializeObject(returndata, serializerSettings);
                    count = results.Count;
                    location = results.Location;
                    stateComment = results.StateComment;
                    //Console.WriteLine ("This is what the host returned to you: " + returndata);

                } 
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                client.Close(); 
            }
        }
    }
}