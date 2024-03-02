using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializedFileWatcher
{
    public partial class FileWatcherForm : Form
    {
        private FileWatcherDAO fileWatcherDAO = new FileWatcherDAO();

        public FileWatcherForm()
        {
            InitializeComponent();
            RefreshBindings();
        }

        private void StartWatching()
        {
            fsWatcher.Path = watchPathTextBox.Text;
            fsWatcher.EnableRaisingEvents = true;

            SetWatchButtonState(true);
        }

        private void StopWatching()
        {
            fsWatcher.EnableRaisingEvents = false;

            SetWatchButtonState(false);
        }

        private void SetWatchButtonState(bool isWatching)
        {
            StartWatchBtn.Enabled = !isWatching;
            MenuStartWatchBtn.Enabled = !isWatching;
            StopWatchBtn.Enabled = isWatching;
            MenuStopWatchBtn.Enabled = isWatching;
        }
        private void OnCloseForm()
        {
            fsWatcher.EnableRaisingEvents = false;
        }

        private void HandleWatcherChanged(System.IO.FileSystemEventArgs e)
        {
            fileWatcherDAO.AddWatchEntry(e.Name, e.FullPath, e.ChangeType);
        }

        private void RefreshBindings()
        {
            fileWatcherConfigBindingSource.DataSource = fileWatcherDAO.FileWatcherConfig;
        }

        // #########################################################################
        //                            Event Handlers
        // #########################################################################

        private void FileWatcherForm_Load(object sender, EventArgs e)
        {

        }

        private void MenuNewBtn_Click(object sender, EventArgs e)
        {

        }

        private void MenuOpenBtn_Click(object sender, EventArgs e)
        {

        }

        private void MenuSaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void MenuCloseBtn_Click(object sender, EventArgs e)
        {
            Close();
            OnCloseForm();
        }

        private void MenuStartWatchBtn_Click(object sender, EventArgs e)
        {
            StartWatching();
        }

        private void MenuStopWatchBtn_Click(object sender, EventArgs e)
        {
            StopWatching();
        }

        private void StartWatchBtn_Click(object sender, EventArgs e)
        {
            StartWatching();
        }

        private void StopWatchBtn_Click(object sender, EventArgs e)
        {
            StopWatching();
        }

        private void FileWatcherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnCloseForm();
        }

        private void fsWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            HandleWatcherChanged(e);
        }
    }
}
