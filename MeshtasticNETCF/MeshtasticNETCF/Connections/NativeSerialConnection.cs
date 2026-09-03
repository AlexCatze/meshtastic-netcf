using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using MeshtasticNETCF.Protobufs;

namespace MeshtasticNETCF.Connections
{
    public class NativeSerialConnection : MeshtasticConnection
    {
        SerialPort serialPort;
        bool work = false;

        public NativeSerialConnection(string port, int baudrate)
        {
            serialPort = new SerialPort(port, baudrate);
            serialPort.ReadTimeout = 100;
        }

        public override void Open()
        {
            base.Open();
            serialPort.Open();
            work = true;
            new Thread(delegate()
            {
                ReceiveThread();
            }).Start();
        }

        void ReceiveThread()
        {
            while (work)
            {
                try
                {
                    ParsePackets((byte)serialPort.ReadByte(), PacketReceived);
                }
                catch (TimeoutException e)
                { }
                catch (Exception e)
                {
                    Close();
                }
            }
        }

        protected override void WriteToSerial(byte[] bytes)
        {
            serialPort.Write(bytes, 0, bytes.Length);
        }

        public override void Close()
        {
            base.Close();
            work = false;
            serialPort.Close();
        }
    }
}
