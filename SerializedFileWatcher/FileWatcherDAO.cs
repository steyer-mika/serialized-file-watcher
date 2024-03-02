using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializedFileWatcher
{
    public class FileWatcherDAO
    {
        private FileWatcherConfig fileWatcherConfig = new FileWatcherConfig();

        private List<WatchEntry> watchEntries = new List<WatchEntry>();

        public FileWatcherConfig FileWatcherConfig { get => fileWatcherConfig; }
        public List<WatchEntry> WatchEntries { get => watchEntries; }

        public void SaveData() { }

        public void LoadData() { }

        public void NewData() { }

        public void AddWatchEntry(string name, string fullPath, WatcherChangeTypes changeType) { 
            watchEntries.Add(new WatchEntry(name, fullPath, changeType));
        }

        private void Save() { }
        private void Load() { }
    }
}
