namespace TopologyGenerator
{
    partial class MainWnd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.listOfFilesListBox = new System.Windows.Forms.ListBox();
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.DeleteFileButton = new System.Windows.Forms.Button();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.DeleteFileButton);
            this.gb1.Controls.Add(this.LoadFileButton);
            this.gb1.Controls.Add(this.listOfFilesListBox);
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(220, 396);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Lista plików:";
            // 
            // listOfFilesListBox
            // 
            this.listOfFilesListBox.FormattingEnabled = true;
            this.listOfFilesListBox.Location = new System.Drawing.Point(6, 19);
            this.listOfFilesListBox.Name = "listOfFilesListBox";
            this.listOfFilesListBox.Size = new System.Drawing.Size(208, 329);
            this.listOfFilesListBox.TabIndex = 1;
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Location = new System.Drawing.Point(6, 354);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(99, 36);
            this.LoadFileButton.TabIndex = 1;
            this.LoadFileButton.Text = "Wczytaj Plik";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            // 
            // DeleteFileButton
            // 
            this.DeleteFileButton.Location = new System.Drawing.Point(111, 354);
            this.DeleteFileButton.Name = "DeleteFileButton";
            this.DeleteFileButton.Size = new System.Drawing.Size(103, 36);
            this.DeleteFileButton.TabIndex = 2;
            this.DeleteFileButton.Text = "Usuń plik";
            this.DeleteFileButton.UseVisualStyleBackColor = true;
            // 
            // gb2
            // 
            this.gb2.Location = new System.Drawing.Point(238, 12);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(507, 348);
            this.gb2.TabIndex = 1;
            this.gb2.TabStop = false;
            this.gb2.Text = "Topologia sieci: ";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(238, 366);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(147, 36);
            this.GenerateButton.TabIndex = 3;
            this.GenerateButton.Text = "Wygeneruj Topologię";
            this.GenerateButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(598, 366);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(147, 36);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Zamknij Program";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // MainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 420);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Name = "MainWnd";
            this.Text = "Topology Generator";
            this.gb1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button DeleteFileButton;
        private System.Windows.Forms.Button LoadFileButton;
        private System.Windows.Forms.ListBox listOfFilesListBox;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

