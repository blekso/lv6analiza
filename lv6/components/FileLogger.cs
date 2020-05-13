using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace lv6.components
{
    class FileLogger : AbstractLogger
    {
        private string filePath;
        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;
        }

        protected override void WriteMessage(string message, MessageType type)
        {
            StreamWriter writer = new StreamWriter(filePath);
            StringBuilder s = new StringBuilder();
            s.Append(message);
            s.Append(type);
            s.Append(DateTime.Now);
            writer.WriteLine(s);
            writer.Close();
        }
    }
}
