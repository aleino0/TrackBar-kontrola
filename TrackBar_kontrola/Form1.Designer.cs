namespace TrackBar_kontrola
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
            this.odabir = new System.Windows.Forms.TrackBar();
            this.prikaz = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.odabir)).BeginInit();
            this.SuspendLayout();
            // 
            // odabir
            // 
            this.odabir.Location = new System.Drawing.Point(40, 88);
            this.odabir.Maximum = 100;
            this.odabir.Minimum = 1;
            this.odabir.Name = "odabir";
            this.odabir.Size = new System.Drawing.Size(492, 56);
            this.odabir.TabIndex = 0;
            this.odabir.Value = 1;
            this.odabir.Scroll += new System.EventHandler(this.odabir_Scroll);
            // 
            // prikaz
            // 
            this.prikaz.Location = new System.Drawing.Point(252, 205);
            this.prikaz.Name = "prikaz";
            this.prikaz.ReadOnly = true;
            this.prikaz.Size = new System.Drawing.Size(100, 22);
            this.prikaz.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(40, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 15);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Postavljena je vrijednost :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.prikaz);
            this.Controls.Add(this.odabir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.odabir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar odabir;
        private System.Windows.Forms.TextBox prikaz;
        private System.Windows.Forms.TextBox textBox2;
    }
}

