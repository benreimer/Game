using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Game.Characters;

namespace Game
{
    public static class Extensions
    {

        public static string XmlSerialize<T>(this T objectToSerialize)
        {
            var serializer = new XmlSerializer(typeof(Game), new Type[] { typeof(HeavyHitter), typeof(Gunner), typeof(FastRunner)});
            var settings = new XmlWriterSettings
            {
                Indent = false,
                NewLineHandling = NewLineHandling.None
            };

            using (var sw = new EncodingSwitchStringWriter(Encoding.UTF8))
            {
                using (var writer = XmlWriter.Create(sw, settings))
                {
                    serializer.Serialize(writer, objectToSerialize);
                    return sw.ToString();
                }
            }
        }

        private class EncodingSwitchStringWriter : StringWriter
        {
            public EncodingSwitchStringWriter(Encoding encoding)
            {
                Encoding = encoding;
            }

            public override Encoding Encoding { get; }
        }
    }
}
