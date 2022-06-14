namespace research
{
    partial class Form3
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
            this.rd_fastfood = new System.Windows.Forms.RadioButton();
            this.rd_teo = new System.Windows.Forms.RadioButton();
            this.rd_usa = new System.Windows.Forms.RadioButton();
            this.rd_china = new System.Windows.Forms.RadioButton();
            this.rd_korea = new System.Windows.Forms.RadioButton();
            this.favor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rd_fastfood
            // 
            this.rd_fastfood.AutoSize = true;
            this.rd_fastfood.Location = new System.Drawing.Point(360, 385);
            this.rd_fastfood.Name = "rd_fastfood";
            this.rd_fastfood.Size = new System.Drawing.Size(105, 24);
            this.rd_fastfood.TabIndex = 8;
            this.rd_fastfood.TabStop = true;
            this.rd_fastfood.Text = "패스트푸드";
            this.rd_fastfood.UseVisualStyleBackColor = true;
            // 
            // rd_teo
            // 
            this.rd_teo.AutoSize = true;
            this.rd_teo.Location = new System.Drawing.Point(360, 311);
            this.rd_teo.Name = "rd_teo";
            this.rd_teo.Size = new System.Drawing.Size(60, 24);
            this.rd_teo.TabIndex = 4;
            this.rd_teo.TabStop = true;
            this.rd_teo.Text = "분식";
            this.rd_teo.UseVisualStyleBackColor = true;
            // 
            // rd_usa
            // 
            this.rd_usa.AutoSize = true;
            this.rd_usa.Location = new System.Drawing.Point(360, 239);
            this.rd_usa.Name = "rd_usa";
            this.rd_usa.Size = new System.Drawing.Size(60, 24);
            this.rd_usa.TabIndex = 5;
            this.rd_usa.TabStop = true;
            this.rd_usa.Text = "양식";
            this.rd_usa.UseVisualStyleBackColor = true;
            // 
            // rd_china
            // 
            this.rd_china.AutoSize = true;
            this.rd_china.Location = new System.Drawing.Point(360, 170);
            this.rd_china.Name = "rd_china";
            this.rd_china.Size = new System.Drawing.Size(60, 24);
            this.rd_china.TabIndex = 6;
            this.rd_china.TabStop = true;
            this.rd_china.Text = "중식";
            this.rd_china.UseVisualStyleBackColor = true;
            // 
            // rd_korea
            // 
            this.rd_korea.AutoSize = true;
            this.rd_korea.Location = new System.Drawing.Point(360, 95);
            this.rd_korea.Name = "rd_korea";
            this.rd_korea.Size = new System.Drawing.Size(60, 24);
            this.rd_korea.TabIndex = 7;
            this.rd_korea.TabStop = true;
            this.rd_korea.Text = "한식";
            this.rd_korea.UseVisualStyleBackColor = true;
            // 
            // favor
            // 
            this.favor.AutoSize = true;
            this.favor.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.favor.Location = new System.Drawing.Point(236, 40);
            this.favor.Name = "favor";
            this.favor.Size = new System.Drawing.Size(348, 25);
            this.favor.TabIndex = 3;
            this.favor.Text = "배달로 가장 선호하는 음식을 고르시오.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Next>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rd_fastfood);
            this.Controls.Add(this.rd_teo);
            this.Controls.Add(this.rd_usa);
            this.Controls.Add(this.rd_china);
            this.Controls.Add(this.rd_korea);
            this.Controls.Add(this.favor);
            this.Name = "Form3";
            this.Text = "3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rd_fastfood;
        private RadioButton rd_teo;
        private RadioButton rd_usa;
        private RadioButton rd_china;
        private RadioButton rd_korea;
        private Label favor;
        private Button button1;
    }
}