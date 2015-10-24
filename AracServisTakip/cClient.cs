
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
    class cClient
    {
        TcpClient tcpClient;
        NetworkStream inputStream;
        StreamWriter streamWriter;
        StreamReader streamReader;
        public cClient()
        {
            try
            {
                tcpClient = new TcpClient("192.168.39.110", 1234);
                inputStream = tcpClient.GetStream();
                streamWriter = new StreamWriter(inputStream);
                streamReader = new StreamReader(inputStream);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void SendBildirim()
        {
            try
            {
                streamWriter.WriteLine("Ustadan yeni bildirim geldi !!");
                streamWriter.Flush();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
