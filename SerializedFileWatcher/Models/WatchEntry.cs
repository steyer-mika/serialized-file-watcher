using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SerializedFileWatcher
{
    [Serializable()]
    public class WatchEntry: ISerializable
    {
        private WatcherChangeTypes changeType;

        private string name;

        private string fullPath;

        public WatchEntry(string name, string fullPath, WatcherChangeTypes changeType) {
            this.name = name;
            this.fullPath = fullPath;
            this.changeType = changeType;
        }

        public WatchEntry(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ChangeType", changeType, typeof(WatcherChangeTypes));
            info.AddValue("Name", name, typeof(string));
            info.AddValue("FullPath", fullPath, typeof(string));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            changeType = (WatcherChangeTypes) info.GetValue("ChangeType", typeof(WatcherChangeTypes));
            name = info.GetString("Name");
            fullPath = info.GetString("FullPath");
        }

        public WatcherChangeTypes ChangeType { get => changeType; set => changeType = value; }
        public string Name { get => name; set => name = value; }
        public string FullPath { get => fullPath; set => fullPath = value; }
    }
}
