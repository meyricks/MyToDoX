﻿namespace ToDoList
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(147, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "List App";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(93, 137);
			this.textBox1.Name = "textBox1";
			this.textBox1.PlaceholderText = "Usuario";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(257, 23);
			this.textBox1.TabIndex = 1;
			this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
			this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(93, 198);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.PlaceholderText = "Clave";
			this.textBox2.Size = new System.Drawing.Size(257, 23);
			this.textBox2.TabIndex = 2;
			this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
			this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
			this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button1.Location = new System.Drawing.Point(93, 270);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(257, 53);
			this.button1.TabIndex = 3;
			this.button1.Text = "Iniciar Sesion";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(468, 407);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Opacity = 0.8D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Click += new System.EventHandler(this.Form1_Click);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private TextBox textBox2;
		private Button button1;
	}
}