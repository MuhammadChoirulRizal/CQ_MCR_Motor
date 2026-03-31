namespace PraktikumADO
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
            this.Connect = new System.Windows.Forms.Button();
            this.HitungMhs = new System.Windows.Forms.Button();
            this.HitungMK = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(26, 344);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(97, 42);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.btnConnect);
            // 
            // HitungMhs
            // 
            this.HitungMhs.Location = new System.Drawing.Point(211, 344);
            this.HitungMhs.Name = "HitungMhs";
            this.HitungMhs.Size = new System.Drawing.Size(94, 42);
            this.HitungMhs.TabIndex = 1;
            this.HitungMhs.Text = "HitungMhs";
            this.HitungMhs.UseVisualStyleBackColor = true;
            this.HitungMhs.Click += new System.EventHandler(this.btnHitungMhs);
            // 
            // HitungMK
            // 
            this.HitungMK.Location = new System.Drawing.Point(390, 344);
            this.HitungMK.Name = "HitungMK";
            this.HitungMK.Size = new System.Drawing.Size(94, 43);
            this.HitungMK.TabIndex = 2;
            this.HitungMK.Text = "HitungMK";
            this.HitungMK.UseVisualStyleBackColor = true;
            this.HitungMK.Click += new System.EventHandler(this.btnHitungMK);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(634, 344);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(101, 45);
            this.Update.TabIndex = 3;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.btnUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hasil";
            this.label1.Click += new System.EventHandler(this.Hasil);
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(176, 91);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(416, 22);
            this.txtHasil.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.HitungMK);
            this.Controls.Add(this.HitungMhs);
            this.Controls.Add(this.Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button HitungMhs;
        private System.Windows.Forms.Button HitungMK;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHasil;
    }
}

