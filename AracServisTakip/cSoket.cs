using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //StreamReader ve StreamWriter siniflari için
using System.Net.Sockets; // Socket, TcpListener ve NetworkStrem siniflari için
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace AracServisTakip
{
    class cSocket
    {
        public void runDanismanBildirim()
        {
            Thread thread = new Thread(new ThreadStart(DanismanBildirimListener));
            thread.Start();
        }

        static void DanismanBildirimListener()
        {
            string mesaj;
            TcpListener listener = new TcpListener(1234);
            listener.Start();
            Socket socket = listener.AcceptSocket();
            if (!socket.Connected)
            {
                MessageBox.Show("baglanamadi");
            }
            else
            {
                while (true)
                {
                    try
                    {
                        Thread.Sleep(30);
                        NetworkStream inputStream = new NetworkStream(socket);
                        StreamWriter streamWriter = new StreamWriter(inputStream);
                        StreamReader streamReader = new StreamReader(inputStream);
                        mesaj = streamReader.ReadLine();
                        //Console.WriteLine(streamReader.ReadLine() + "burak");
                        if (mesaj.Trim() != "")
                        {
                            MessageBox.Show(mesaj);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }

            }
        }


    }


}
