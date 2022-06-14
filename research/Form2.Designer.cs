namespace research
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.r_korea = new System.Windows.Forms.RadioButton();
            this.r_china = new System.Windows.Forms.RadioButton();
            this.r_usa = new System.Windows.Forms.RadioButton();
            this.r_teo = new System.Windows.Forms.RadioButton();
            this.r_fastfood = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(178, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "다섯가지중 가장 선호하는 음식을 고르시오.";
            // 
            // r_korea
            // 
            this.r_korea.AutoSize = true;
            this.r_korea.Location = new System.Drawing.Point(347, 95);
            this.r_korea.Name = "r_korea";
            this.r_korea.Size = new System.Drawing.Size(60, 24);
            this.r_korea.TabIndex = 1;
            this.r_korea.TabStop = true;
            this.r_korea.Text = "한식";
            this.r_korea.UseVisualStyleBackColor = true;
            // 
            // r_china
            // 
            this.r_china.AutoSize = true;
            this.r_china.Location = new System.Drawing.Point(347, 170);
            this.r_china.Name = "r_china";
            this.r_china.Size = new System.Drawing.Size(60, 24);
            this.r_china.TabIndex = 1;
            this.r_china.TabStop = true;
            this.r_china.Text = "중식";
            this.r_china.UseVisualStyleBackColor = true;
            // 
            // r_usa
            // 
            this.r_usa.AutoSize = true;
            this.r_usa.Location = new System.Drawing.Point(347, 239);
            this.r_usa.Name = "r_usa";
            this.r_usa.Size = new System.Drawing.Size(60, 24);
            this.r_usa.TabIndex = 1;
            this.r_usa.TabStop = true;
            this.r_usa.Text = "양식";
            this.r_usa.UseVisualStyleBackColor = true;
            // 
            // r_teo
            // 
            this.r_teo.AutoSize = true;
            this.r_teo.Location = new System.Drawing.Point(347, 311);
            this.r_teo.Name = "r_teo";
            this.r_teo.Size = new System.Drawing.Size(60, 24);
            this.r_teo.TabIndex = 1;
            this.r_teo.TabStop = true;
            this.r_teo.Text = "분식";
            this.r_teo.UseVisualStyleBackColor = true;
            // 
            // r_fastfood
            // 
            this.r_fastfood.AutoSize = true;
            this.r_fastfood.Location = new System.Drawing.Point(347, 385);
            this.r_fastfood.Name = "r_fastfood";
            this.r_fastfood.Size = new System.Drawing.Size(105, 24);
            this.r_fastfood.TabIndex = 2;
            this.r_fastfood.TabStop = true;
            this.r_fastfood.Text = "패스트푸드";
            this.r_fastfood.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Next>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.r_fastfood);
            this.Controls.Add(this.r_teo);
            this.Controls.Add(this.r_usa);
            this.Controls.Add(this.r_china);
            this.Controls.Add(this.r_korea);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton r_korea;
        private RadioButton r_china;
        private RadioButton r_usa;
        private RadioButton r_teo;
        private RadioButton r_fastfood;
        private Button button1;
    }
}