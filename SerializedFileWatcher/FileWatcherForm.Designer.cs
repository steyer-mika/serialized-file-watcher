namespace SerializedFileWatcher
{
    partial class FileWatcherForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label watchPathLabel;
            System.Windows.Forms.Label serializeOptionLabel1;
            this.includeSubdirectoriesCheckBox = new System.Windows.Forms.CheckBox();
            this.fileWatcherConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.watchPathTextBox = new System.Windows.Forms.TextBox();
            this.serializeOptionComboBox = new System.Windows.Forms.ComboBox();
            this.StartWatchBtn = new System.Windows.Forms.Button();
            this.StopWatchBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNewBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpenBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuCloseBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStartWatchBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStopWatchBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.fsWatcher = new System.IO.FileSystemWatcher();
            watchPathLabel = new System.Windows.Forms.Label();
            serializeOptionLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcherConfigBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fsWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // watchPathLabel
            // 
            watchPathLabel.AutoSize = true;
            watchPathLabel.Location = new System.Drawing.Point(12, 40);
            watchPathLabel.Name = "watchPathLabel";
            watchPathLabel.Size = new System.Drawing.Size(255, 13);
            watchPathLabel.TabIndex = 4;
            watchPathLabel.Text = "Bitte geben Sie den Pfad zur Dateiüberwachung ein!";
            // 
            // serializeOptionLabel1
            // 
            serializeOptionLabel1.AutoSize = true;
            serializeOptionLabel1.Location = new System.Drawing.Point(244, 87);
            serializeOptionLabel1.Name = "serializeOptionLabel1";
            serializeOptionLabel1.Size = new System.Drawing.Size(91, 13);
            serializeOptionLabel1.TabIndex = 5;
            serializeOptionLabel1.Text = "Serialisierungstyp:";
            // 
            // includeSubdirectoriesCheckBox
            // 
            this.includeSubdirectoriesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.fileWatcherConfigBindingSource, "IncludeSubdirectories", true));
            this.includeSubdirectoriesCheckBox.Location = new System.Drawing.Point(12, 82);
            this.includeSubdirectoriesCheckBox.Name = "includeSubdirectoriesCheckBox";
            this.includeSubdirectoriesCheckBox.Size = new System.Drawing.Size(181, 24);
            this.includeSubdirectoriesCheckBox.TabIndex = 1;
            this.includeSubdirectoriesCheckBox.Text = "Unterverzeichnisse einbeziehen";
            this.includeSubdirectoriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // fileWatcherConfigBindingSource
            // 
            this.fileWatcherConfigBindingSource.DataSource = typeof(SerializedFileWatcher.FileWatcherConfig);
            // 
            // watchPathTextBox
            // 
            this.watchPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fileWatcherConfigBindingSource, "WatchPath", true));
            this.watchPathTextBox.Location = new System.Drawing.Point(12, 56);
            this.watchPathTextBox.Name = "watchPathTextBox";
            this.watchPathTextBox.Size = new System.Drawing.Size(776, 20);
            this.watchPathTextBox.TabIndex = 5;
            // 
            // serializeOptionComboBox
            // 
            this.serializeOptionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fileWatcherConfigBindingSource, "SerializeOption", true));
            this.serializeOptionComboBox.FormattingEnabled = true;
            this.serializeOptionComboBox.Items.AddRange(new object[] {
            "Json",
            "Xml",
            "Binary"});
            this.serializeOptionComboBox.Location = new System.Drawing.Point(341, 84);
            this.serializeOptionComboBox.Name = "serializeOptionComboBox";
            this.serializeOptionComboBox.Size = new System.Drawing.Size(121, 21);
            this.serializeOptionComboBox.TabIndex = 6;
            // 
            // StartWatchBtn
            // 
            this.StartWatchBtn.Location = new System.Drawing.Point(15, 144);
            this.StartWatchBtn.Name = "StartWatchBtn";
            this.StartWatchBtn.Size = new System.Drawing.Size(116, 23);
            this.StartWatchBtn.TabIndex = 7;
            this.StartWatchBtn.Text = "St&arte Überwachung";
            this.StartWatchBtn.UseVisualStyleBackColor = true;
            this.StartWatchBtn.Click += new System.EventHandler(this.StartWatchBtn_Click);
            // 
            // StopWatchBtn
            // 
            this.StopWatchBtn.Enabled = false;
            this.StopWatchBtn.Location = new System.Drawing.Point(661, 144);
            this.StopWatchBtn.Name = "StopWatchBtn";
            this.StopWatchBtn.Size = new System.Drawing.Size(127, 23);
            this.StopWatchBtn.TabIndex = 8;
            this.StopWatchBtn.Text = "St&oppe Überwachung";
            this.StopWatchBtn.UseVisualStyleBackColor = true;
            this.StopWatchBtn.Click += new System.EventHandler(this.StopWatchBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.bearbeitenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNewBtn,
            this.MenuOpenBtn,
            this.MenuSaveBtn,
            this.toolStripSeparator1,
            this.MenuCloseBtn});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem1.Text = "Datei";
            // 
            // MenuNewBtn
            // 
            this.MenuNewBtn.Name = "MenuNewBtn";
            this.MenuNewBtn.Size = new System.Drawing.Size(126, 22);
            this.MenuNewBtn.Text = "Neu";
            this.MenuNewBtn.Click += new System.EventHandler(this.MenuNewBtn_Click);
            // 
            // MenuOpenBtn
            // 
            this.MenuOpenBtn.Name = "MenuOpenBtn";
            this.MenuOpenBtn.Size = new System.Drawing.Size(126, 22);
            this.MenuOpenBtn.Text = "Öffnen";
            this.MenuOpenBtn.Click += new System.EventHandler(this.MenuOpenBtn_Click);
            // 
            // MenuSaveBtn
            // 
            this.MenuSaveBtn.Name = "MenuSaveBtn";
            this.MenuSaveBtn.Size = new System.Drawing.Size(126, 22);
            this.MenuSaveBtn.Text = "Speichern";
            this.MenuSaveBtn.Click += new System.EventHandler(this.MenuSaveBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(123, 6);
            // 
            // MenuCloseBtn
            // 
            this.MenuCloseBtn.Name = "MenuCloseBtn";
            this.MenuCloseBtn.Size = new System.Drawing.Size(126, 22);
            this.MenuCloseBtn.Text = "Be&enden";
            this.MenuCloseBtn.Click += new System.EventHandler(this.MenuCloseBtn_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStartWatchBtn,
            this.MenuStopWatchBtn});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // MenuStartWatchBtn
            // 
            this.MenuStartWatchBtn.Name = "MenuStartWatchBtn";
            this.MenuStartWatchBtn.Size = new System.Drawing.Size(188, 22);
            this.MenuStartWatchBtn.Text = "Starte Überwachung";
            this.MenuStartWatchBtn.Click += new System.EventHandler(this.MenuStartWatchBtn_Click);
            // 
            // MenuStopWatchBtn
            // 
            this.MenuStopWatchBtn.Enabled = false;
            this.MenuStopWatchBtn.Name = "MenuStopWatchBtn";
            this.MenuStopWatchBtn.Size = new System.Drawing.Size(188, 22);
            this.MenuStopWatchBtn.Text = "Stoppe Überwachung";
            this.MenuStopWatchBtn.Click += new System.EventHandler(this.MenuStopWatchBtn_Click);
            // 
            // fsWatcher
            // 
            this.fsWatcher.EnableRaisingEvents = true;
            this.fsWatcher.SynchronizingObject = this;
            this.fsWatcher.Changed += new System.IO.FileSystemEventHandler(this.fsWatcher_Changed);
            // 
            // FileWatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.StopWatchBtn);
            this.Controls.Add(this.StartWatchBtn);
            this.Controls.Add(serializeOptionLabel1);
            this.Controls.Add(this.serializeOptionComboBox);
            this.Controls.Add(watchPathLabel);
            this.Controls.Add(this.watchPathTextBox);
            this.Controls.Add(this.includeSubdirectoriesCheckBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FileWatcherForm";
            this.Text = "Dateiüberwachung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileWatcherForm_FormClosing);
            this.Load += new System.EventHandler(this.FileWatcherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcherConfigBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fsWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource fileWatcherConfigBindingSource;
        private System.Windows.Forms.CheckBox includeSubdirectoriesCheckBox;
        private System.Windows.Forms.TextBox watchPathTextBox;
        private System.Windows.Forms.ComboBox serializeOptionComboBox;
        private System.Windows.Forms.Button StartWatchBtn;
        private System.Windows.Forms.Button StopWatchBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuNewBtn;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenBtn;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuCloseBtn;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuStartWatchBtn;
        private System.Windows.Forms.ToolStripMenuItem MenuStopWatchBtn;
        private System.IO.FileSystemWatcher fsWatcher;
    }
}

