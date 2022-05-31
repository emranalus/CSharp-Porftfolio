namespace EF_PracticeLearnt
{
    partial class BookStockPanel
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
            this.dataBookView1 = new System.Windows.Forms.DataGridView();
            this.btn_Report = new System.Windows.Forms.Button();
            this.txt_BookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AuthorName = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.Label_ID = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBookView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBookView1
            // 
            this.dataBookView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBookView1.Location = new System.Drawing.Point(12, 122);
            this.dataBookView1.Name = "dataBookView1";
            this.dataBookView1.RowTemplate.Height = 25;
            this.dataBookView1.Size = new System.Drawing.Size(776, 316);
            this.dataBookView1.TabIndex = 0;
            // 
            // btn_Report
            // 
            this.btn_Report.Location = new System.Drawing.Point(699, 87);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(89, 29);
            this.btn_Report.TabIndex = 1;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = true;
            // 
            // txt_BookName
            // 
            this.txt_BookName.Location = new System.Drawing.Point(132, 16);
            this.txt_BookName.Name = "txt_BookName";
            this.txt_BookName.Size = new System.Drawing.Size(242, 23);
            this.txt_BookName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Author Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity";
            // 
            // txt_AuthorName
            // 
            this.txt_AuthorName.Location = new System.Drawing.Point(132, 45);
            this.txt_AuthorName.Name = "txt_AuthorName";
            this.txt_AuthorName.Size = new System.Drawing.Size(242, 23);
            this.txt_AuthorName.TabIndex = 6;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(132, 76);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(242, 23);
            this.txt_Quantity.TabIndex = 7;
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.Location = new System.Drawing.Point(12, 104);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(17, 15);
            this.Label_ID.TabIndex = 8;
            this.Label_ID.Text = "Id";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(604, 87);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(89, 29);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(509, 87);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(89, 29);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(414, 87);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(89, 29);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // BookStockPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.Label_ID);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_AuthorName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_BookName);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.dataBookView1);
            this.Name = "BookStockPanel";
            this.Text = "BookStockPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataBookView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataBookView1;
        private Button btn_Report;
        private TextBox txt_BookName;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_AuthorName;
        private TextBox txt_Quantity;
        private Label Label_ID;
        private Button btn_Save;
        private Button btn_Update;
        private Button btn_Delete;
    }
}