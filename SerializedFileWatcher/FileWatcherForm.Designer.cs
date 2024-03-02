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
            this.watchPathTextBox = new System.Windows.Forms.TextBox();
            this.serializeOptionComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FlieEntiresListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileWatcherConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starteÜberwachungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stoppeÜberwachungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            watchPathLabel = new System.Windows.Forms.Label();
            serializeOptionLabel1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcherConfigBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // watchPathLabel
            // 
            watchPathLabel.AutoSize = true;
            watchPathLabel.Location = new System.Drawing.Point(12, 40);
            watchPathLabel.Name = "watchPathLabel";
            watchPathLabel.Size = new System.Drawing.Size(255, 13);
            watchPathLabel.TabIndex = 4;
            watchPathLabel.Text = "Bitte geben Sie den Pfad zur Dateiüberwachung ein!";
            // 
            // watchPathTextBox
            // 
            this.watchPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fileWatcherConfigBindingSource, "WatchPath", true));
            this.watchPathTextBox.Location = new System.Drawing.Point(12, 56);
            this.watchPathTextBox.Name = "watchPathTextBox";
            this.watchPathTextBox.Size = new System.Drawing.Size(776, 20);
            this.watchPathTextBox.TabIndex = 5;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "St&arte Überwachung";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(661, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "St&oppe Überwachung";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FlieEntiresListBox
            // 
            this.FlieEntiresListBox.FormattingEnabled = true;
            this.FlieEntiresListBox.Location = new System.Drawing.Point(15, 190);
            this.FlieEntiresListBox.Name = "FlieEntiresListBox";
            this.FlieEntiresListBox.Size = new System.Drawing.Size(773, 212);
            this.FlieEntiresListBox.TabIndex = 9;
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
            this.neuToolStripMenuItem,
            this.öffnenToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.toolStripSeparator1,
            this.beendenToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem1.Text = "Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beendenToolStripMenuItem.Text = "Be&enden";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            // 
            // fileWatcherConfigBindingSource
            // 
            this.fileWatcherConfigBindingSource.DataSource = typeof(SerializedFileWatcher.FileWatcherConfig);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.starteÜberwachungToolStripMenuItem,
            this.stoppeÜberwachungToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // starteÜberwachungToolStripMenuItem
            // 
            this.starteÜberwachungToolStripMenuItem.Name = "starteÜberwachungToolStripMenuItem";
            this.starteÜberwachungToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.starteÜberwachungToolStripMenuItem.Text = "Starte Überwachung";
            // 
            // stoppeÜberwachungToolStripMenuItem
            // 
            this.stoppeÜberwachungToolStripMenuItem.Name = "stoppeÜberwachungToolStripMenuItem";
            this.stoppeÜberwachungToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.stoppeÜberwachungToolStripMenuItem.Text = "Stoppe Überwachung";
            // 
            // FileWatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.FlieEntiresListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(serializeOptionLabel1);
            this.Controls.Add(this.serializeOptionComboBox);
            this.Controls.Add(watchPathLabel);
            this.Controls.Add(this.watchPathTextBox);
            this.Controls.Add(this.includeSubdirectoriesCheckBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FileWatcherForm";
            this.Text = "Dateiüberwachung";
            this.Load += new System.EventHandler(this.FileWatcherForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcherConfigBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource fileWatcherConfigBindingSource;
        private System.Windows.Forms.CheckBox includeSubdirectoriesCheckBox;
        private System.Windows.Forms.TextBox watchPathTextBox;
        private System.Windows.Forms.ComboBox serializeOptionComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox FlieEntiresListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem starteÜberwachungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stoppeÜberwachungToolStripMenuItem;
    }
}

