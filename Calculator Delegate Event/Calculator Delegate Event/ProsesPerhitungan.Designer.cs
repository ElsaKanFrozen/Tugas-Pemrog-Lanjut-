
namespace Calculator_Delegate_Event
{
    partial class ProsesPerhitungan
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
            this.txtOperasi = new System.Windows.Forms.ComboBox();
            this.texNilai_A = new System.Windows.Forms.TextBox();
            this.texNilai_B = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOperasi
            // 
            this.txtOperasi.FormattingEnabled = true;
            this.txtOperasi.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan ",
            "Perkalian ",
            "Pembagian"});
            this.txtOperasi.Location = new System.Drawing.Point(120, 33);
            this.txtOperasi.Name = "txtOperasi";
            this.txtOperasi.Size = new System.Drawing.Size(182, 33);
            this.txtOperasi.TabIndex = 0;
            // 
            // texNilai_A
            // 
            this.texNilai_A.Location = new System.Drawing.Point(120, 88);
            this.texNilai_A.Name = "texNilai_A";
            this.texNilai_A.Size = new System.Drawing.Size(182, 31);
            this.texNilai_A.TabIndex = 1;
            // 
            // texNilai_B
            // 
            this.texNilai_B.Location = new System.Drawing.Point(120, 142);
            this.texNilai_B.Name = "texNilai_B";
            this.texNilai_B.Size = new System.Drawing.Size(182, 31);
            this.texNilai_B.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(190, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Proses ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Operasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nilai B";
            // 
            // ProsesPerhitungan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 275);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.texNilai_B);
            this.Controls.Add(this.texNilai_A);
            this.Controls.Add(this.txtOperasi);
            this.Name = "ProsesPerhitungan";
            this.Text = "Calculator ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtOperasi;
        private System.Windows.Forms.TextBox texNilai_A;
        private System.Windows.Forms.TextBox texNilai_B;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}