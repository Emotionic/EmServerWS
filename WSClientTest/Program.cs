using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;

namespace WSClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("w: WebSocket, h: HTTP");
            switch (Console.ReadKey(true).KeyChar)
            {
                case 'w':
                    WSTest();
                    break;
                case 'h':
                    Console.Write("action => ");
                    var act = Console.ReadLine();
                    if (act == "pin")
                    {
                        Console.Write("pin => ");
                        Pin = Console.ReadLine();
                    }
                    Console.WriteLine(CheckToServer(act));

                    break;

                default:
                    break;

            }

        }

        static void WSTest()
        {
            var url = "ws://localhost/ws";
            var socket = new WebSocket(url);
            bool connected = false;

            socket.OnOpen += (s, e) =>
            {
                connected = true;
                Console.WriteLine("[" + DateTime.Now + "] Opened.");
            };

            socket.OnMessage += (s, e) =>
            {
                Console.WriteLine("[" + DateTime.Now + "] Recieved : " + e.Data);
            };

            socket.Connect();
            while (!connected) socket.Connect();

            while (true)
            {
                bool quit = false;

                var com = Console.ReadKey(intercept: true);
                switch (com.KeyChar)
                {
                    case 'q':
                        quit = true;
                        break;

                    case 's':
                        socket.Send("Test");
                        break;

                    default:
                        break;
                }

                if (quit)
                    break;

            }

            socket.Close();
            socket = null;

        }

        private static string Pin { get; set; }

        private static bool CheckToServer(string action)
        {
            string url = "http://localhost/" + action;

            try
            {
                var wc = new System.Net.WebClient();

                string resText = "";
                if (action == "check")
                {
                    byte[] resData = wc.DownloadData(url);
                    resText = System.Text.Encoding.UTF8.GetString(resData);
                }
                else if (action == "pin")
                {
                    var ps = new System.Collections.Specialized.NameValueCollection();
                    ps.Add("pin", Pin);
                    byte[] resData = wc.UploadValues(url, ps);
                    resText = System.Text.Encoding.UTF8.GetString(resData);
                }
                else
                {
                    throw new Exception();
                }

                wc.Dispose();

                if (resText != "ok")
                {
                    throw new Exception();
                }

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

    }
}
