namespace CityQuizz
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
            this.label1 = new System.Windows.Forms.Label();
            this.lGrad = new System.Windows.Forms.Label();
            this.btnOdgovor1 = new System.Windows.Forms.Button();
            this.btnOdgovor2 = new System.Windows.Forms.Button();
            this.btnOdgovor3 = new System.Windows.Forms.Button();
            this.btnOdgovor4 = new System.Windows.Forms.Button();
            this.lTacnoNetacno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kojoj drzavi pripada sledeci grad?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lGrad
            // 
            this.lGrad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lGrad.Font = new System.Drawing.Font("Corbel", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGrad.Location = new System.Drawing.Point(12, 154);
            this.lGrad.Name = "lGrad";
            this.lGrad.Size = new System.Drawing.Size(543, 42);
            this.lGrad.TabIndex = 1;
            this.lGrad.Text = "Grad";
            this.lGrad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOdgovor1
            // 
            this.btnOdgovor1.Location = new System.Drawing.Point(41, 252);
            this.btnOdgovor1.Name = "btnOdgovor1";
            this.btnOdgovor1.Size = new System.Drawing.Size(184, 37);
            this.btnOdgovor1.TabIndex = 4;
            this.btnOdgovor1.Text = "Odgovor";
            this.btnOdgovor1.UseVisualStyleBackColor = true;
            this.btnOdgovor1.Click += new System.EventHandler(this.izaberiOdgovor);
            // 
            // btnOdgovor2
            // 
            this.btnOdgovor2.Location = new System.Drawing.Point(339, 252);
            this.btnOdgovor2.Name = "btnOdgovor2";
            this.btnOdgovor2.Size = new System.Drawing.Size(184, 37);
            this.btnOdgovor2.TabIndex = 5;
            this.btnOdgovor2.Text = "Odgovor";
            this.btnOdgovor2.UseVisualStyleBackColor = true;
            this.btnOdgovor2.Click += new System.EventHandler(this.izaberiOdgovor);
            // 
            // btnOdgovor3
            // 
            this.btnOdgovor3.Location = new System.Drawing.Point(41, 327);
            this.btnOdgovor3.Name = "btnOdgovor3";
            this.btnOdgovor3.Size = new System.Drawing.Size(184, 37);
            this.btnOdgovor3.TabIndex = 6;
            this.btnOdgovor3.Text = "Odgovor";
            this.btnOdgovor3.UseVisualStyleBackColor = true;
            this.btnOdgovor3.Click += new System.EventHandler(this.izaberiOdgovor);
            // 
            // btnOdgovor4
            // 
            this.btnOdgovor4.Location = new System.Drawing.Point(339, 327);
            this.btnOdgovor4.Name = "btnOdgovor4";
            this.btnOdgovor4.Size = new System.Drawing.Size(184, 37);
            this.btnOdgovor4.TabIndex = 7;
            this.btnOdgovor4.Text = "Odgovor";
            this.btnOdgovor4.UseVisualStyleBackColor = true;
            this.btnOdgovor4.Click += new System.EventHandler(this.izaberiOdgovor);
            // 
            // lTacnoNetacno
            // 
            this.lTacnoNetacno.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTacnoNetacno.Location = new System.Drawing.Point(12, 43);
            this.lTacnoNetacno.Name = "lTacnoNetacno";
            this.lTacnoNetacno.Size = new System.Drawing.Size(543, 48);
            this.lTacnoNetacno.TabIndex = 8;
            this.lTacnoNetacno.Text = "Tacnost";
            this.lTacnoNetacno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lTacnoNetacno.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 417);
            this.Controls.Add(this.lTacnoNetacno);
            this.Controls.Add(this.btnOdgovor4);
            this.Controls.Add(this.btnOdgovor3);
            this.Controls.Add(this.btnOdgovor2);
            this.Controls.Add(this.btnOdgovor1);
            this.Controls.Add(this.lGrad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lGrad;
        private System.Windows.Forms.Button btnOdgovor1;
        private System.Windows.Forms.Button btnOdgovor2;
        private System.Windows.Forms.Button btnOdgovor3;
        private System.Windows.Forms.Button btnOdgovor4;
        private System.Windows.Forms.Label lTacnoNetacno;
    }
}

