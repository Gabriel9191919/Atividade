namespace Q4_TabuadaTradicional
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
            button1 = new Button();
            txtn = new TextBox();
            lstt = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(177, 33);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero:";
            // 
            // button1
            // 
            button1.Location = new Point(409, 29);
            button1.Name = "button1";
            button1.Size = new Size(171, 23);
            button1.TabIndex = 1;
            button1.Text = "Mostrar Tabuada";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtn
            // 
            txtn.ForeColor = SystemColors.InactiveCaptionText;
            txtn.Location = new Point(237, 29);
            txtn.Name = "txtn";
            txtn.Size = new Size(100, 23);
            txtn.TabIndex = 3;
            txtn.TextChanged += textBox1_TextChanged;
            // 
            // lstt
            // 
            lstt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstt.FormattingEnabled = true;
            lstt.ItemHeight = 30;
            lstt.Location = new Point(146, 84);
            lstt.Name = "lstt";
            lstt.Size = new Size(434, 334);
            lstt.TabIndex = 4;
            lstt.SelectedIndexChanged += lstt_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(lstt);
            Controls.Add(txtn);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tabuada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox txtn;
        private ListBox lstt;
    }
}
