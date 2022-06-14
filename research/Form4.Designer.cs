namespace research
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.rd_4 = new System.Windows.Forms.RadioButton();
            this.rd_3 = new System.Windows.Forms.RadioButton();
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rd_4
            // 
            this.rd_4.AutoSize = true;
            this.rd_4.Location = new System.Drawing.Point(79, 309);
            this.rd_4.Name = "rd_4";
            this.rd_4.Size = new System.Drawing.Size(340, 24);
            this.rd_4.TabIndex = 4;
            this.rd_4.TabStop = true;
            this.rd_4.Text = "선호하는 음식이 배달로 선호하는 음식과 같음";
            this.rd_4.UseVisualStyleBackColor = true;
            // 
            // rd_3
            // 
            this.rd_3.AutoSize = true;
            this.rd_3.Location = new System.Drawing.Point(79, 243);
            this.rd_3.Name = "rd_3";
            this.rd_3.Size = new System.Drawing.Size(225, 24);
            this.rd_3.TabIndex = 5;
            this.rd_3.TabStop = true;
            this.rd_3.Text = "배달시간이 너무 오래 걸려서";
            this.rd_3.UseVisualStyleBackColor = true;
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Location = new System.Drawing.Point(79, 173);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(240, 24);
            this.rd_2.TabIndex = 6;
            this.rd_2.TabStop = true;
            this.rd_2.Text = "배달이 가능한 종류가 아니라서";
            this.rd_2.UseVisualStyleBackColor = true;
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Location = new System.Drawing.Point(79, 106);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(225, 24);
            this.rd_1.TabIndex = 7;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "배달로 시키면 맛이 달라져서";
            this.rd_1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "선호하는 음식이 배달로 선호하는 음식과 다른 이유는 무엇인가";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rd_4);
            this.Controls.Add(this.rd_3);
            this.Controls.Add(this.rd_2);
            this.Controls.Add(this.rd_1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private RadioButton rd_4;
        private RadioButton rd_3;
        private RadioButton rd_2;
        private RadioButton rd_1;
        private Label label1;
    }
}