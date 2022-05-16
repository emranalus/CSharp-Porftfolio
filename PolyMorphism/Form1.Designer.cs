namespace PolyMorphism
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
            this.btn_Default = new System.Windows.Forms.Button();
            this.btn_iPhone = new System.Windows.Forms.Button();
            this.btn_Nokia = new System.Windows.Forms.Button();
            this.btn_Samsung = new System.Windows.Forms.Button();
            this.btn_def = new System.Windows.Forms.Button();
            this.btn_nok = new System.Windows.Forms.Button();
            this.btn_iPhon = new System.Windows.Forms.Button();
            this.btn_sam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Default
            // 
            this.btn_Default.Location = new System.Drawing.Point(54, 12);
            this.btn_Default.Name = "btn_Default";
            this.btn_Default.Size = new System.Drawing.Size(161, 81);
            this.btn_Default.TabIndex = 0;
            this.btn_Default.Text = "Default";
            this.btn_Default.UseVisualStyleBackColor = true;
            // 
            // btn_iPhone
            // 
            this.btn_iPhone.Location = new System.Drawing.Point(0, 0);
            this.btn_iPhone.Name = "btn_iPhone";
            this.btn_iPhone.Size = new System.Drawing.Size(75, 23);
            this.btn_iPhone.TabIndex = 0;
            // 
            // btn_Nokia
            // 
            this.btn_Nokia.Location = new System.Drawing.Point(0, 0);
            this.btn_Nokia.Name = "btn_Nokia";
            this.btn_Nokia.Size = new System.Drawing.Size(75, 23);
            this.btn_Nokia.TabIndex = 0;
            // 
            // btn_Samsung
            // 
            this.btn_Samsung.Location = new System.Drawing.Point(0, 0);
            this.btn_Samsung.Name = "btn_Samsung";
            this.btn_Samsung.Size = new System.Drawing.Size(75, 23);
            this.btn_Samsung.TabIndex = 0;
            // 
            // btn_def
            // 
            this.btn_def.Location = new System.Drawing.Point(71, 12);
            this.btn_def.Name = "btn_def";
            this.btn_def.Size = new System.Drawing.Size(125, 68);
            this.btn_def.TabIndex = 0;
            this.btn_def.Text = "Default";
            this.btn_def.UseVisualStyleBackColor = true;
            this.btn_def.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_nok
            // 
            this.btn_nok.Location = new System.Drawing.Point(71, 86);
            this.btn_nok.Name = "btn_nok";
            this.btn_nok.Size = new System.Drawing.Size(125, 64);
            this.btn_nok.TabIndex = 1;
            this.btn_nok.Text = "Nokia";
            this.btn_nok.UseVisualStyleBackColor = true;
            this.btn_nok.Click += new System.EventHandler(this.btn_nok_Click);
            // 
            // btn_iPhon
            // 
            this.btn_iPhon.Location = new System.Drawing.Point(71, 156);
            this.btn_iPhon.Name = "btn_iPhon";
            this.btn_iPhon.Size = new System.Drawing.Size(125, 68);
            this.btn_iPhon.TabIndex = 2;
            this.btn_iPhon.Text = "iPhone";
            this.btn_iPhon.UseVisualStyleBackColor = true;
            this.btn_iPhon.Click += new System.EventHandler(this.btn_iPhon_Click);
            // 
            // btn_sam
            // 
            this.btn_sam.Location = new System.Drawing.Point(71, 230);
            this.btn_sam.Name = "btn_sam";
            this.btn_sam.Size = new System.Drawing.Size(125, 66);
            this.btn_sam.TabIndex = 3;
            this.btn_sam.Text = "Samsung";
            this.btn_sam.UseVisualStyleBackColor = true;
            this.btn_sam.Click += new System.EventHandler(this.btn_sam_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 308);
            this.Controls.Add(this.btn_sam);
            this.Controls.Add(this.btn_iPhon);
            this.Controls.Add(this.btn_nok);
            this.Controls.Add(this.btn_def);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Default;
        private System.Windows.Forms.Button btn_iPhone;
        private System.Windows.Forms.Button btn_Nokia;
        private System.Windows.Forms.Button btn_Samsung;
        private System.Windows.Forms.Button btn_def;
        private System.Windows.Forms.Button btn_nok;
        private System.Windows.Forms.Button btn_iPhon;
        private System.Windows.Forms.Button btn_sam;
    }
}
