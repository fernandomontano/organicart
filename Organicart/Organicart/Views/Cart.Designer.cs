﻿namespace Organicart
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.panel2 = new System.Windows.Forms.Panel();
            this.profilebtn = new System.Windows.Forms.PictureBox();
            this.Cartbtn = new System.Windows.Forms.PictureBox();
            this.Productsbtn = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cartbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Productsbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Size = new System.Drawing.Size(1047, 121);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(125)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.profilebtn);
            this.panel2.Controls.Add(this.Cartbtn);
            this.panel2.Controls.Add(this.Productsbtn);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 538);
            this.panel2.TabIndex = 48;
            // 
            // profilebtn
            // 
            this.profilebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilebtn.Image = ((System.Drawing.Image)(resources.GetObject("profilebtn.Image")));
            this.profilebtn.Location = new System.Drawing.Point(11, 218);
            this.profilebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(43, 40);
            this.profilebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilebtn.TabIndex = 2;
            this.profilebtn.TabStop = false;
            this.profilebtn.Click += new System.EventHandler(this.profilebtn_Click);
            // 
            // Cartbtn
            // 
            this.Cartbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cartbtn.Image = ((System.Drawing.Image)(resources.GetObject("Cartbtn.Image")));
            this.Cartbtn.Location = new System.Drawing.Point(10, 160);
            this.Cartbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cartbtn.Name = "Cartbtn";
            this.Cartbtn.Size = new System.Drawing.Size(43, 38);
            this.Cartbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cartbtn.TabIndex = 1;
            this.Cartbtn.TabStop = false;
            // 
            // Productsbtn
            // 
            this.Productsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Productsbtn.Image = ((System.Drawing.Image)(resources.GetObject("Productsbtn.Image")));
            this.Productsbtn.Location = new System.Drawing.Point(11, 103);
            this.Productsbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Productsbtn.Name = "Productsbtn";
            this.Productsbtn.Size = new System.Drawing.Size(43, 39);
            this.Productsbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Productsbtn.TabIndex = 0;
            this.Productsbtn.TabStop = false;
            this.Productsbtn.Click += new System.EventHandler(this.Productsbtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(73, 127);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(826, 393);
            this.flowLayoutPanel1.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(460, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 41);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tu carrito";
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(92)))), ((int)(((byte)(53)))));
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(233)))), ((int)(((byte)(230)))));
            this.loginbtn.Location = new System.Drawing.Point(905, 422);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(110, 70);
            this.loginbtn.TabIndex = 22;
            this.loginbtn.Text = "Realizar pago";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 540);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cart";
            this.Text = "Cart";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.loginbtn, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cartbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Productsbtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox profilebtn;
        public System.Windows.Forms.PictureBox Cartbtn;
        public System.Windows.Forms.PictureBox Productsbtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button loginbtn;
    }
}