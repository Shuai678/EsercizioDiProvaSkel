namespace EsGru2._0
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
            InviaDenaro = new Button();
            RiceviDenaro = new Button();
            numericUpDown1 = new NumericUpDown();
            QTAdenaro = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 1;
            label1.Text = "Saldo Residuo";
            label1.Click += label1_Click;
            // 
            // InviaDenaro
            // 
            InviaDenaro.Location = new Point(447, 68);
            InviaDenaro.Name = "InviaDenaro";
            InviaDenaro.Size = new Size(187, 101);
            InviaDenaro.TabIndex = 2;
            InviaDenaro.Text = "Invia Denaro";
            InviaDenaro.UseVisualStyleBackColor = true;
            InviaDenaro.Click += InviaDenaro_Click;
            // 
            // RiceviDenaro
            // 
            RiceviDenaro.Location = new Point(447, 190);
            RiceviDenaro.Name = "RiceviDenaro";
            RiceviDenaro.Size = new Size(187, 101);
            RiceviDenaro.TabIndex = 3;
            RiceviDenaro.Text = "Preleva Denaro";
            RiceviDenaro.UseVisualStyleBackColor = true;
            RiceviDenaro.Click += RiceviDenaro_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(316, 194);
            numericUpDown1.Maximum = new decimal(new int[] { -1530494977, 232830, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(125, 31);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // QTAdenaro
            // 
            QTAdenaro.AutoSize = true;
            QTAdenaro.Location = new Point(316, 144);
            QTAdenaro.Name = "QTAdenaro";
            QTAdenaro.Size = new Size(108, 25);
            QTAdenaro.TabIndex = 5;
            QTAdenaro.Text = "QTA Denaro";
            QTAdenaro.Click += QTAdenaro_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 46);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 6;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(QTAdenaro);
            Controls.Add(numericUpDown1);
            Controls.Add(RiceviDenaro);
            Controls.Add(InviaDenaro);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button InviaDenaro;
        private Button RiceviDenaro;
        private NumericUpDown numericUpDown1;
        private Label QTAdenaro;
        private Label label2;
    }
}
