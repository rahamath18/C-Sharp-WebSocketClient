using System;
using System.Threading.Tasks;
using WebSocketSharp;

namespace C_Sharp_WebSocketClient
{
    class Program
    {
        static void Main(string[] args)
        {

            WebSocket wsClient = new WebSocket("ws://localhost:8080");
            wsClient.Connect();
            wsClient.Send("Hi I am websocket client.");
            
            wsClient.OnOpen += (sender, e) =>
            {
                Console.WriteLine("OnOpen : server msg : " + e);
            };

            wsClient.OnMessage += (sender, e) =>
            {
                Console.WriteLine("New Message Received From Server : " + e.Data);
            };

            wsClient.OnClose += (sender, e) =>
            {
                Console.WriteLine("OnClose : server msg : " + e);
            };

            wsClient.OnError += (sender, e) =>
            {
                Console.WriteLine("OnError : server msg : " + e);
            };

            wsClient.Send("Bye from websocket client.");
            Console.ReadKey(true);
           
        }
    }
}
