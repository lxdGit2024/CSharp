﻿namespace lxd.MTHProject
{
    partial class FrmMsgBoxWithOutAck
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Content = new System.Windows.Forms.Label();
            this.btn_Sure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(21, 25);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(78, 23);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "退出系统";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(433, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(64, 54);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Content
            // 
            this.lbl_Content.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Content.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.lbl_Content.ForeColor = System.Drawing.Color.White;
            this.lbl_Content.Location = new System.Drawing.Point(65, 82);
            this.lbl_Content.Name = "lbl_Content";
            this.lbl_Content.Size = new System.Drawing.Size(384, 110);
            this.lbl_Content.TabIndex = 3;
            this.lbl_Content.Text = "是否确认要退出系统？";
            this.lbl_Content.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Sure
            // 
            this.btn_Sure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.btn_Sure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sure.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Sure.ForeColor = System.Drawing.Color.White;
            this.btn_Sure.Location = new System.Drawing.Point(144, 217);
            this.btn_Sure.Name = "btn_Sure";
            this.btn_Sure.Size = new System.Drawing.Size(203, 42);
            this.btn_Sure.TabIndex = 8;
            this.btn_Sure.Text = "确定";
            this.btn_Sure.UseVisualStyleBackColor = false;
            this.btn_Sure.Click += new System.EventHandler(this.btn_Sure_Click);
            // 
            // FrmMsgBoxWithOutAck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lxd.MTHProject.Properties.Resources.TitleBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 311);
            this.Controls.Add(this.btn_Sure);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_Content);
            this.Controls.Add(this.lbl_Title);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMsgBoxWithOutAck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMsgBoxWithAck";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Content;
        private System.Windows.Forms.Button btn_Sure;
    }
}