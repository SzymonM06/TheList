namespace TheList
{
    partial class Form1
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
            this.controlPanel = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_newEntry = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.listPanel = new System.Windows.Forms.Panel();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.controlPanel.Controls.Add(this.button_Exit);
            this.controlPanel.Controls.Add(this.button_Delete);
            this.controlPanel.Controls.Add(this.button_newEntry);
            this.controlPanel.Controls.Add(this.Title);
            this.controlPanel.Location = new System.Drawing.Point(13, 13);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(775, 41);
            this.controlPanel.TabIndex = 0;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Exit.Location = new System.Drawing.Point(697, 4);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 34);
            this.button_Exit.TabIndex = 3;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = false;
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Delete.Location = new System.Drawing.Point(278, 4);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 34);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click_1);
            // 
            // button_newEntry
            // 
            this.button_newEntry.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_newEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_newEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_newEntry.Location = new System.Drawing.Point(195, 4);
            this.button_newEntry.Name = "button_newEntry";
            this.button_newEntry.Size = new System.Drawing.Size(75, 34);
            this.button_newEntry.TabIndex = 1;
            this.button_newEntry.Text = "New";
            this.button_newEntry.UseVisualStyleBackColor = false;
            this.button_newEntry.Click += new System.EventHandler(this.button_newEntry_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(189, 42);
            this.Title.TabIndex = 0;
            this.Title.Text = "Show List";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listPanel
            // 
            this.listPanel.AutoScroll = true;
            this.listPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listPanel.Location = new System.Drawing.Point(13, 60);
            this.listPanel.Name = "listPanel";
            this.listPanel.Padding = new System.Windows.Forms.Padding(5);
            this.listPanel.Size = new System.Drawing.Size(775, 454);
            this.listPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.listPanel);
            this.Controls.Add(this.controlPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.Button button_newEntry;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Exit;
    }
}

