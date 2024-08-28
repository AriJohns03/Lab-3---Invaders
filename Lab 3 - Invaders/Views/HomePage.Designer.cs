namespace Lab_3___Invaders
{
	partial class HomePage
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
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.animationTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.button1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.Info;
			this.button1.Location = new System.Drawing.Point(345, 163);
			this.button1.Name = "button1";
			this.button1.Padding = new System.Windows.Forms.Padding(10);
			this.button1.Size = new System.Drawing.Size(270, 140);
			this.button1.TabIndex = 0;
			this.button1.Text = "Defeat Aliens";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// animationTimer
			// 
			this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
			// 
			// HomePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Desktop;
			this.ClientSize = new System.Drawing.Size(997, 576);
			this.Controls.Add(this.button1);
			this.Name = "HomePage";
			this.Text = "HomePage";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer animationTimer;
		private System.Windows.Forms.Button button1;
	}
}