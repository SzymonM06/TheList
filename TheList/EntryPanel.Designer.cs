namespace TheList
{
    partial class EntryPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.entryPanel_ = new System.Windows.Forms.Panel();
            this.label_epCounter = new System.Windows.Forms.Label();
            this.button_epMinus = new System.Windows.Forms.Button();
            this.button_epPlus = new System.Windows.Forms.Button();
            this.delete_checkBox = new System.Windows.Forms.CheckBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.entryPanel_.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryPanel_
            // 
            this.entryPanel_.BackColor = System.Drawing.Color.LightGray;
            this.entryPanel_.Controls.Add(this.label_epCounter);
            this.entryPanel_.Controls.Add(this.button_epMinus);
            this.entryPanel_.Controls.Add(this.button_epPlus);
            this.entryPanel_.Controls.Add(this.delete_checkBox);
            this.entryPanel_.Controls.Add(this.label_Title);
            this.entryPanel_.Controls.Add(this.textBox_Title);
            this.entryPanel_.Location = new System.Drawing.Point(0, 0);
            this.entryPanel_.Name = "entryPanel_";
            this.entryPanel_.Size = new System.Drawing.Size(350, 100);
            this.entryPanel_.TabIndex = 0;
            // 
            // label_epCounter
            // 
            this.label_epCounter.AutoSize = true;
            this.label_epCounter.Location = new System.Drawing.Point(58, 35);
            this.label_epCounter.Name = "label_epCounter";
            this.label_epCounter.Size = new System.Drawing.Size(57, 13);
            this.label_epCounter.TabIndex = 5;
            this.label_epCounter.Text = "Episode: 0";
            // 
            // button_epMinus
            // 
            this.button_epMinus.Location = new System.Drawing.Point(32, 31);
            this.button_epMinus.Name = "button_epMinus";
            this.button_epMinus.Size = new System.Drawing.Size(20, 20);
            this.button_epMinus.TabIndex = 4;
            this.button_epMinus.Text = "-";
            this.button_epMinus.UseVisualStyleBackColor = true;
            this.button_epMinus.Click += new System.EventHandler(this.button_epMinus_Click);
            // 
            // button_epPlus
            // 
            this.button_epPlus.Location = new System.Drawing.Point(6, 31);
            this.button_epPlus.Name = "button_epPlus";
            this.button_epPlus.Size = new System.Drawing.Size(20, 20);
            this.button_epPlus.TabIndex = 3;
            this.button_epPlus.Text = "+";
            this.button_epPlus.UseVisualStyleBackColor = true;
            this.button_epPlus.Click += new System.EventHandler(this.button_epPlus_Click);
            // 
            // delete_checkBox
            // 
            this.delete_checkBox.AutoSize = true;
            this.delete_checkBox.Location = new System.Drawing.Point(241, 8);
            this.delete_checkBox.Name = "delete_checkBox";
            this.delete_checkBox.Size = new System.Drawing.Size(57, 17);
            this.delete_checkBox.TabIndex = 2;
            this.delete_checkBox.Text = "Delete";
            this.delete_checkBox.UseVisualStyleBackColor = true;
            this.delete_checkBox.CheckedChanged += new System.EventHandler(this.delete_checkBox_CheckedChanged);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(3, 8);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(30, 13);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Title:";
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(35, 5);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(200, 20);
            this.textBox_Title.TabIndex = 0;
            // 
            // EntryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.entryPanel_);
            this.Name = "EntryPanel";
            this.Size = new System.Drawing.Size(350, 100);
            this.entryPanel_.ResumeLayout(false);
            this.entryPanel_.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel entryPanel_;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.CheckBox delete_checkBox;
        private System.Windows.Forms.Button button_epMinus;
        private System.Windows.Forms.Button button_epPlus;
        private System.Windows.Forms.Label label_epCounter;
    }
}
