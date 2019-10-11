using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FacturaElectronicaSii.Extensions
{
    public class SimpleClientMessageInspector : IClientMessageInspector
    {
        public static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            // Implement this method to inspect/modify messages after a message
            // is received but prior to passing it back to the client
            Console.WriteLine("AfterReceiveReply called");
            File.WriteAllText($@"C:\Temp\Response_{DateTimeOffset.Now.ToUnixTimeSeconds()}.xml", reply.ToString());
            string seedReturn;
            //var writer = XmlDictionaryReader.CreateTextReader();
            using (var ms = new MemoryStream())
            {
                var doc = new XmlDocument();
                var writer = XmlWriter.Create(ms);

                reply.WriteMessage(writer);
                writer.Flush();
                ms.Position = 0;
                doc.Load(ms);

                seedReturn = doc.GetElementsByTagName("ns1:getSeedReturn")[0].InnerText;
            }

            using (var ms = new MemoryStream())
            {
                var sfs = GenerateStreamFromString(seedReturn);
                XmlReader reader = XmlReader.Create(sfs);
                reply = Message.CreateMessage(reader, int.MaxValue, reply.Version);
            }
        }

        public object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, IClientChannel channel)
        {
            // Implement this method to inspect/modify messages before they
            // are sent to the service
            Console.WriteLine("BeforeSendRequest called");
            File.WriteAllText($@"C:\Temp\Request_{DateTimeOffset.Now.ToUnixTimeSeconds()}.xml", request.ToString());
            return null;
        }
    }
}
