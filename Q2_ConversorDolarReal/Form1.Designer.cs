namespace Q2_ConversorDolarReal
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
            txtRes = new Label();
            label2 = new Label();
            label3 = new Label();
            btnConverter = new Button();
            txtC = new TextBox();
            txtD = new TextBox();
            SuspendLayout();
            // 
            // txtRes
            // 
            txtRes.AutoSize = true;
            txtRes.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRes.Location = new Point(266, 255);
            txtRes.Name = "txtRes";
            txtRes.Size = new Size(0, 45);
            txtRes.TabIndex = 0;
            txtRes.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 51);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantidade em dolares";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 46);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 2;
            label3.Text = "Cotação do dolar";
            // 
            // btnConverter
            // 
            btnConverter.BackColor = Color.AntiqueWhite;
            btnConverter.ForeColor = SystemColors.ActiveCaptionText;
            btnConverter.Location = new Point(312, 151);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(75, 23);
            btnConverter.TabIndex = 3;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = false;
            btnConverter.Click += btnConverter_Click;
            // 
            // txtC
            // 
            txtC.Location = new Point(152, 43);
            txtC.Name = "txtC";
            txtC.Size = new Size(100, 23);
            txtC.TabIndex = 4;
            // 
            // txtD
            // 
            txtD.Location = new Point(441, 43);
            txtD.Name = "txtD";
            txtD.Size = new Size(100, 23);
            txtD.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(txtD);
            Controls.Add(txtC);
            Controls.Add(btnConverter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtRes);
            ForeColor = SystemColors.ButtonFace;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtRes;
        private Label label2;
        private Label label3;
        private Button btnConverter;
        private TextBox txtC;
        private TextBox txtD;
    }
}
