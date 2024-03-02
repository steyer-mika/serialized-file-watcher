using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerializedFileWatcher
{
    [Serializable()]
    public enum SerializeOption
    {
        Xml,
        Json,
        Binary
    }

    [Serializable()]
    public class FileWatcherConfig: ISerializable
    {
        private string watchPath = String.Empty;

        private bool includeSubdirectories = false;

        private SerializeOption serializeOption = SerializeOption.Json;

        public string WatchPath { get => watchPath; set => watchPath = value; }
        public bool IncludeSubdirectories { get => includeSubdirectories; set => includeSubdirectories = value; }
        public SerializeOption SerializeOption { get => serializeOption; set => serializeOption = value; }
        public FileWatcherConfig()
        {
        }

        public FileWatcherConfig(SerializationInfo info, StreamingContext context)
        {
            watchPath = info.GetString("WatchPath");
            includeSubdirectories = info.GetBoolean("IncludeSubdirectories");
            serializeOption = (SerializeOption) info.GetValue("SerializeOption", typeof(SerializeOption));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("WatchPath", watchPath, typeof(string));
            info.AddValue("IncludeSubdirectories", includeSubdirectories, typeof(bool));
            info.AddValue("SerializeOption", serializeOption, typeof(SerializeOption));
        }
    }
}
