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
            this.fileWatcherConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            watchPathLabel = new System.Windows.Forms.Label();
            serializeOptionLabel1 = new System.Windows.Forms.Label();
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
            // fileWatcherConfigBindingSource
            // 
            this.fileWatcherConfigBindingSource.DataSource = typeof(SerializedFileWatcher.FileWatcherConfig);
            // 
            // FileWatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(serializeOptionLabel1);
            this.Controls.Add(this.serializeOptionComboBox);
            this.Controls.Add(watchPathLabel);
            this.Controls.Add(this.watchPathTextBox);
            this.Controls.Add(this.includeSubdirectoriesCheckBox);
            this.Name = "FileWatcherForm";
            this.Text = "Dateiüberwachung";
            this.Load += new System.EventHandler(this.FileWatcherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcherConfigBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource fileWatcherConfigBindingSource;
        private System.Windows.Forms.CheckBox includeSubdirectoriesCheckBox;
        private System.Windows.Forms.TextBox watchPathTextBox;
        private System.Windows.Forms.ComboBox serializeOptionComboBox;
    }
}

