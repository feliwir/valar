using System;
using System.Net;
using System.Net.Sockets;

namespace valar
{
    public class DebugSession
    {
        string host = "127.0.0.1";
        TcpClient m_remote;
        TcpListener m_listener;
        
        bool m_connected = false;

        public DebugSession(short port = 2017)
        {
            m_listener = new TcpListener(IPAddress.Parse(host), port);
            m_listener.Start();
            m_listener.BeginAcceptTcpClient(new AsyncCallback(AcceptClient), m_listener);
        }

        void AcceptClient(IAsyncResult ar)
        {
            // Get the listener that handles the client request.
            TcpListener listener = (TcpListener)ar.AsyncState;

            // End the operation and display the received data on 
            // the console.
            m_remote = listener.EndAcceptTcpClient(ar);

            m_connected = true;
            // Process the connection here. (Add the client to a
            // server table, read data, etc.)
            Console.WriteLine("Client connected completed");

        }
    }
}
