﻿namespace TheList
{
    partial class EntryPanelAnime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryPanelAnime));
            this.entryPanel_ = new System.Windows.Forms.Panel();
            this.label_NumberList = new System.Windows.Forms.Label();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.moveUp = new System.Windows.Forms.Button();
            this.moveDown = new System.Windows.Forms.Button();
            this.label_epCounter = new System.Windows.Forms.Label();
            this.button_epMinus = new System.Windows.Forms.Button();
            this.button_epPlus = new System.Windows.Forms.Button();
            this.delete_checkBox = new System.Windows.Forms.CheckBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.button_epClear = new System.Windows.Forms.Button();
            this.label_sCounter = new System.Windows.Forms.Label();
            this.button_sMinus = new System.Windows.Forms.Button();
            this.button_sPlus = new System.Windows.Forms.Button();
            this.button_sClear = new System.Windows.Forms.Button();
            this.textBox_Title = new TheList.CustomTextBox();
            this.entryPanel_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // entryPanel_
            // 
            this.entryPanel_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.entryPanel_.BackColor = System.Drawing.Color.LightGray;
            this.entryPanel_.Controls.Add(this.button_sClear);
            this.entryPanel_.Controls.Add(this.button_sPlus);
            this.entryPanel_.Controls.Add(this.button_sMinus);
            this.entryPanel_.Controls.Add(this.label_sCounter);
            this.entryPanel_.Controls.Add(this.button_epClear);
            this.entryPanel_.Controls.Add(this.label_NumberList);
            this.entryPanel_.Controls.Add(this.pictureBox_Image);
            this.entryPanel_.Controls.Add(this.moveUp);
            this.entryPanel_.Controls.Add(this.moveDown);
            this.entryPanel_.Controls.Add(this.label_epCounter);
            this.entryPanel_.Controls.Add(this.button_epMinus);
            this.entryPanel_.Controls.Add(this.button_epPlus);
            this.entryPanel_.Controls.Add(this.delete_checkBox);
            this.entryPanel_.Controls.Add(this.label_Title);
            this.entryPanel_.Controls.Add(this.textBox_Title);
            this.entryPanel_.Location = new System.Drawing.Point(0, 0);
            this.entryPanel_.Name = "entryPanel_";
            this.entryPanel_.Size = new System.Drawing.Size(1481, 429);
            this.entryPanel_.TabIndex = 0;
            // 
            // label_NumberList
            // 
            this.label_NumberList.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_NumberList.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_NumberList.Location = new System.Drawing.Point(1369, 165);
            this.label_NumberList.Name = "label_NumberList";
            this.label_NumberList.Size = new System.Drawing.Size(128, 55);
            this.label_NumberList.TabIndex = 10;
            this.label_NumberList.Text = "0";
            this.label_NumberList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox_Image.ImageLocation = "";
            this.pictureBox_Image.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Image.InitialImage")));
            this.pictureBox_Image.Location = new System.Drawing.Point(6, 5);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(354, 421);
            this.pictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Image.TabIndex = 9;
            this.pictureBox_Image.TabStop = false;
            this.pictureBox_Image.Click += new System.EventHandler(this.pictureBox_Image_Click);
            // 
            // moveUp
            // 
            this.moveUp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.moveUp.Font = new System.Drawing.Font("Wingdings 3", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.moveUp.Location = new System.Drawing.Point(1379, 5);
            this.moveUp.Name = "moveUp";
            this.moveUp.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.moveUp.Size = new System.Drawing.Size(99, 151);
            this.moveUp.TabIndex = 7;
            this.moveUp.Text = "#";
            this.moveUp.UseVisualStyleBackColor = true;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // moveDown
            // 
            this.moveDown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.moveDown.Font = new System.Drawing.Font("Wingdings 3", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.moveDown.Location = new System.Drawing.Point(1379, 230);
            this.moveDown.Name = "moveDown";
            this.moveDown.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.moveDown.Size = new System.Drawing.Size(99, 153);
            this.moveDown.TabIndex = 6;
            this.moveDown.Text = "$";
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // label_epCounter
            // 
            this.label_epCounter.AutoSize = true;
            this.label_epCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_epCounter.Location = new System.Drawing.Point(828, 230);
            this.label_epCounter.Name = "label_epCounter";
            this.label_epCounter.Size = new System.Drawing.Size(336, 73);
            this.label_epCounter.TabIndex = 5;
            this.label_epCounter.Text = "Episode: 0";
            // 
            // button_epMinus
            // 
            this.button_epMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_epMinus.Location = new System.Drawing.Point(561, 230);
            this.button_epMinus.Name = "button_epMinus";
            this.button_epMinus.Padding = new System.Windows.Forms.Padding(2, 0, 0, 8);
            this.button_epMinus.Size = new System.Drawing.Size(80, 80);
            this.button_epMinus.TabIndex = 4;
            this.button_epMinus.Text = "-";
            this.button_epMinus.UseVisualStyleBackColor = true;
            this.button_epMinus.Click += new System.EventHandler(this.button_epMinus_Click);
            // 
            // button_epPlus
            // 
            this.button_epPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_epPlus.Location = new System.Drawing.Point(742, 230);
            this.button_epPlus.Name = "button_epPlus";
            this.button_epPlus.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button_epPlus.Size = new System.Drawing.Size(80, 80);
            this.button_epPlus.TabIndex = 3;
            this.button_epPlus.Text = "+";
            this.button_epPlus.UseVisualStyleBackColor = true;
            this.button_epPlus.Click += new System.EventHandler(this.button_epPlus_Click);
            // 
            // delete_checkBox
            // 
            this.delete_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.delete_checkBox.AutoSize = true;
            this.delete_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delete_checkBox.Location = new System.Drawing.Point(1351, 389);
            this.delete_checkBox.Name = "delete_checkBox";
            this.delete_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.delete_checkBox.Size = new System.Drawing.Size(118, 37);
            this.delete_checkBox.TabIndex = 2;
            this.delete_checkBox.Text = "Delete";
            this.delete_checkBox.UseVisualStyleBackColor = true;
            this.delete_checkBox.CheckedChanged += new System.EventHandler(this.delete_checkBox_CheckedChanged);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Title.Location = new System.Drawing.Point(383, 31);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(171, 73);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Title:";
            // 
            // button_epClear
            // 
            this.button_epClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_epClear.Location = new System.Drawing.Point(647, 230);
            this.button_epClear.Name = "button_epClear";
            this.button_epClear.Size = new System.Drawing.Size(89, 80);
            this.button_epClear.TabIndex = 11;
            this.button_epClear.Text = "Clear";
            this.button_epClear.UseVisualStyleBackColor = true;
            // 
            // label_sCounter
            // 
            this.label_sCounter.AutoSize = true;
            this.label_sCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_sCounter.Location = new System.Drawing.Point(828, 147);
            this.label_sCounter.Name = "label_sCounter";
            this.label_sCounter.Size = new System.Drawing.Size(322, 73);
            this.label_sCounter.TabIndex = 12;
            this.label_sCounter.Text = "Season: 0";
            // 
            // button_sMinus
            // 
            this.button_sMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_sMinus.Location = new System.Drawing.Point(561, 144);
            this.button_sMinus.Name = "button_sMinus";
            this.button_sMinus.Padding = new System.Windows.Forms.Padding(2, 0, 0, 8);
            this.button_sMinus.Size = new System.Drawing.Size(80, 80);
            this.button_sMinus.TabIndex = 13;
            this.button_sMinus.Text = "-";
            this.button_sMinus.UseVisualStyleBackColor = true;
            this.button_sMinus.Click += new System.EventHandler(this.button_sMinus_Click);
            // 
            // button_sPlus
            // 
            this.button_sPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_sPlus.Location = new System.Drawing.Point(742, 144);
            this.button_sPlus.Name = "button_sPlus";
            this.button_sPlus.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button_sPlus.Size = new System.Drawing.Size(80, 80);
            this.button_sPlus.TabIndex = 14;
            this.button_sPlus.Text = "+";
            this.button_sPlus.UseVisualStyleBackColor = true;
            this.button_sPlus.Click += new System.EventHandler(this.button_sPlus_Click);
            // 
            // button_sClear
            // 
            this.button_sClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_sClear.Location = new System.Drawing.Point(647, 144);
            this.button_sClear.Name = "button_sClear";
            this.button_sClear.Size = new System.Drawing.Size(89, 80);
            this.button_sClear.TabIndex = 15;
            this.button_sClear.Text = "Clear";
            this.button_sClear.UseVisualStyleBackColor = true;
            this.button_sClear.Click += new System.EventHandler(this.button_sClear_Click);
            // 
            // textBox_Title
            // 
            this.textBox_Title.BackColor = System.Drawing.Color.LightGray;
            this.textBox_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Title.Location = new System.Drawing.Point(560, 5);
            this.textBox_Title.Multiline = true;
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(736, 129);
            this.textBox_Title.TabIndex = 0;
            // 
            // EntryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.entryPanel_);
            this.Name = "EntryPanel";
            this.Size = new System.Drawing.Size(1481, 429);
            this.entryPanel_.ResumeLayout(false);
            this.entryPanel_.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel entryPanel_;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.CheckBox delete_checkBox;
        private System.Windows.Forms.Button button_epMinus;
        private System.Windows.Forms.Button button_epPlus;
        private System.Windows.Forms.Label label_epCounter;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.Label label_NumberList;
        private CustomTextBox textBox_Title;
        private System.Windows.Forms.Button button_sClear;
        private System.Windows.Forms.Button button_sPlus;
        private System.Windows.Forms.Button button_sMinus;
        private System.Windows.Forms.Label label_sCounter;
        private System.Windows.Forms.Button button_epClear;
    }
}
