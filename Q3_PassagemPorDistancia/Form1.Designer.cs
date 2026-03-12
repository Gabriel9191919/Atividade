namespace Q3_PassagemPorDistancia
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
            lblR = new Label();
            txtD = new TextBox();
            btnC = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 70);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Distância (km)";
            label1.Click += label1_Click;
            // 
            // lblR
            // 
            lblR.AutoSize = true;
            lblR.Location = new Point(357, 270);
            lblR.Name = "lblR";
            lblR.Size = new Size(0, 15);
            lblR.TabIndex = 1;
            lblR.Click += label2_Click;
            // 
            // txtD
            // 
            txtD.Location = new Point(339, 70);
            txtD.Name = "txtD";
            txtD.Size = new Size(100, 23);
            txtD.TabIndex = 2;
            // 
            // btnC
            // 
            btnC.ForeColor = SystemColors.ActiveCaptionText;
            btnC.Location = new Point(339, 206);
            btnC.Name = "btnC";
            btnC.Size = new Size(75, 23);
            btnC.TabIndex = 3;
            btnC.Text = "Calcular preço";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnC);
            Controls.Add(txtD);
            Controls.Add(lblR);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonFace;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblR;
        private TextBox txtD;
        private Button btnC;
    }
}
