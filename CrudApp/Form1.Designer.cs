namespace CrudApp
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            txtEmpName = new TextBox();
            txtEmpSalary = new TextBox();
            lblEmpSalary = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(85, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(590, 317);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(957, 337);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(830, 136);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 2;
            label1.Text = "EmpName";
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(937, 132);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(150, 31);
            txtEmpName.TabIndex = 3;
            // 
            // txtEmpSalary
            // 
            txtEmpSalary.Location = new Point(937, 205);
            txtEmpSalary.Name = "txtEmpSalary";
            txtEmpSalary.Size = new Size(150, 31);
            txtEmpSalary.TabIndex = 5;
            // 
            // lblEmpSalary
            // 
            lblEmpSalary.AutoSize = true;
            lblEmpSalary.Location = new Point(830, 209);
            lblEmpSalary.Name = "lblEmpSalary";
            lblEmpSalary.Size = new Size(95, 25);
            lblEmpSalary.TabIndex = 4;
            lblEmpSalary.Text = "EmpSalary";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(914, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(793, 84);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 7;
            label2.Text = "EmpId";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 614);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(txtEmpSalary);
            Controls.Add(lblEmpSalary);
            Controls.Add(txtEmpName);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private TextBox txtEmpName;
        private TextBox txtEmpSalary;
        private Label lblEmpSalary;
        private ComboBox comboBox1;
        private Label label2;
    }
}
