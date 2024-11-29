namespace WinFormsMethod
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            lblResult = new Label();
            btnBMI = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(125, 19);
            label1.Name = "label1";
            label1.Size = new Size(324, 45);
            label1.TabIndex = 0;
            label1.Text = "โปรแกรมคำนวณค่า BMI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(29, 113);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 1;
            label2.Text = "ชื่อ-นามสกุล";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(83, 163);
            label3.Name = "label3";
            label3.Size = new Size(33, 21);
            label3.TabIndex = 2;
            label3.Text = "อายุ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(30, 215);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 3;
            label4.Text = "ส่วนสูง (cm)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(29, 271);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 4;
            label5.Text = "น้ำหนัก (kg)";
            // 
            // txtName
            // 
            txtName.Location = new Point(171, 115);
            txtName.Name = "txtName";
            txtName.Size = new Size(248, 23);
            txtName.TabIndex = 5;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(171, 165);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 6;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(171, 217);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(100, 23);
            txtHeight.TabIndex = 7;
            txtHeight.TextChanged += txtHeight_TextChanged;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(171, 269);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 23);
            txtWeight.TabIndex = 8;
            txtWeight.TextChanged += txtWeight_TextChanged;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.PapayaWhip;
            lblResult.Font = new Font("Segoe UI", 24F);
            lblResult.ForeColor = Color.SeaGreen;
            lblResult.Location = new Point(12, 319);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(776, 289);
            lblResult.TabIndex = 9;
            lblResult.Text = "...";
            // 
            // btnBMI
            // 
            btnBMI.Font = new Font("Segoe UI", 12F);
            btnBMI.Location = new Point(477, 93);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(183, 95);
            btnBMI.TabIndex = 10;
            btnBMI.Text = "ค่า BMI";
            btnBMI.UseVisualStyleBackColor = true;
            btnBMI.Click += btnBMI_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(485, 227);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(175, 48);
            btnClear.TabIndex = 11;
            btnClear.Text = "เริ่มใหม่";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 617);
            Controls.Add(btnClear);
            Controls.Add(btnBMI);
            Controls.Add(lblResult);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Label lblResult;
        private Button btnBMI;
        private Button btnClear;
    }
}
