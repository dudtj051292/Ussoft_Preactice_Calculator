
namespace Ussoft_Preactice_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.numpad_1 = new System.Windows.Forms.Button();
            this.numpad_2 = new System.Windows.Forms.Button();
            this.numpad_3 = new System.Windows.Forms.Button();
            this.numpad_4 = new System.Windows.Forms.Button();
            this.numpad_5 = new System.Windows.Forms.Button();
            this.numpad_6 = new System.Windows.Forms.Button();
            this.numpad_7 = new System.Windows.Forms.Button();
            this.numpad_8 = new System.Windows.Forms.Button();
            this.numpad_9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_ClearAll = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Plus = new System.Windows.Forms.Button();
            this.button_Minus = new System.Windows.Forms.Button();
            this.numpad_0 = new System.Windows.Forms.Button();
            this.button_Divide = new System.Windows.Forms.Button();
            this.button_Multifly = new System.Windows.Forms.Button();
            this.button_ABS = new System.Windows.Forms.Button();
            this.button_sqrt = new System.Windows.Forms.Button();
            this.button_root = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Dot = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // numpad_1
            // 
            this.numpad_1.Location = new System.Drawing.Point(12, 136);
            this.numpad_1.Name = "numpad_1";
            this.numpad_1.Size = new System.Drawing.Size(90, 30);
            this.numpad_1.TabIndex = 0;
            this.numpad_1.Text = "1";
            this.numpad_1.UseVisualStyleBackColor = true;
            this.numpad_1.Click += new System.EventHandler(this.numpad_1_Click);
            // 
            // numpad_2
            // 
            this.numpad_2.Location = new System.Drawing.Point(108, 136);
            this.numpad_2.Name = "numpad_2";
            this.numpad_2.Size = new System.Drawing.Size(90, 30);
            this.numpad_2.TabIndex = 1;
            this.numpad_2.Text = "2";
            this.numpad_2.UseVisualStyleBackColor = true;
            this.numpad_2.Click += new System.EventHandler(this.numpad_2_Click);
            // 
            // numpad_3
            // 
            this.numpad_3.Location = new System.Drawing.Point(204, 136);
            this.numpad_3.Name = "numpad_3";
            this.numpad_3.Size = new System.Drawing.Size(90, 30);
            this.numpad_3.TabIndex = 2;
            this.numpad_3.Text = "3";
            this.numpad_3.UseVisualStyleBackColor = true;
            this.numpad_3.Click += new System.EventHandler(this.numpad_3_Click);
            // 
            // numpad_4
            // 
            this.numpad_4.Location = new System.Drawing.Point(12, 172);
            this.numpad_4.Name = "numpad_4";
            this.numpad_4.Size = new System.Drawing.Size(90, 30);
            this.numpad_4.TabIndex = 3;
            this.numpad_4.Text = "4";
            this.numpad_4.UseVisualStyleBackColor = true;
            this.numpad_4.Click += new System.EventHandler(this.numpad_4_Click);
            // 
            // numpad_5
            // 
            this.numpad_5.Location = new System.Drawing.Point(108, 172);
            this.numpad_5.Name = "numpad_5";
            this.numpad_5.Size = new System.Drawing.Size(90, 30);
            this.numpad_5.TabIndex = 4;
            this.numpad_5.Text = "5";
            this.numpad_5.UseVisualStyleBackColor = true;
            this.numpad_5.Click += new System.EventHandler(this.numpad_5_Click);
            // 
            // numpad_6
            // 
            this.numpad_6.Location = new System.Drawing.Point(204, 172);
            this.numpad_6.Name = "numpad_6";
            this.numpad_6.Size = new System.Drawing.Size(90, 30);
            this.numpad_6.TabIndex = 5;
            this.numpad_6.Text = "6";
            this.numpad_6.UseVisualStyleBackColor = true;
            this.numpad_6.Click += new System.EventHandler(this.numpad_6_Click);
            // 
            // numpad_7
            // 
            this.numpad_7.Location = new System.Drawing.Point(12, 208);
            this.numpad_7.Name = "numpad_7";
            this.numpad_7.Size = new System.Drawing.Size(90, 30);
            this.numpad_7.TabIndex = 8;
            this.numpad_7.Text = "7";
            this.numpad_7.UseVisualStyleBackColor = true;
            this.numpad_7.Click += new System.EventHandler(this.numpad_7_Click);
            // 
            // numpad_8
            // 
            this.numpad_8.Location = new System.Drawing.Point(108, 208);
            this.numpad_8.Name = "numpad_8";
            this.numpad_8.Size = new System.Drawing.Size(90, 30);
            this.numpad_8.TabIndex = 7;
            this.numpad_8.Text = "8";
            this.numpad_8.UseVisualStyleBackColor = true;
            this.numpad_8.Click += new System.EventHandler(this.numpad_8_Click);
            // 
            // numpad_9
            // 
            this.numpad_9.Location = new System.Drawing.Point(204, 208);
            this.numpad_9.Name = "numpad_9";
            this.numpad_9.Size = new System.Drawing.Size(90, 30);
            this.numpad_9.TabIndex = 6;
            this.numpad_9.Text = "9";
            this.numpad_9.UseVisualStyleBackColor = true;
            this.numpad_9.Click += new System.EventHandler(this.numpad_9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 29);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_ClearAll
            // 
            this.button_ClearAll.Location = new System.Drawing.Point(300, 94);
            this.button_ClearAll.Name = "button_ClearAll";
            this.button_ClearAll.Size = new System.Drawing.Size(90, 30);
            this.button_ClearAll.TabIndex = 10;
            this.button_ClearAll.Text = "CE";
            this.button_ClearAll.UseVisualStyleBackColor = true;
            this.button_ClearAll.Click += new System.EventHandler(this.button_ClearAll_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(12, 94);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(90, 30);
            this.button_Clear.TabIndex = 11;
            this.button_Clear.Text = "Anim";
            this.button_Clear.UseVisualStyleBackColor = true;
            // 
            // button_Plus
            // 
            this.button_Plus.Location = new System.Drawing.Point(300, 172);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(90, 30);
            this.button_Plus.TabIndex = 12;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = true;
            this.button_Plus.Click += new System.EventHandler(this.button_Plus_Click);
            // 
            // button_Minus
            // 
            this.button_Minus.Location = new System.Drawing.Point(300, 136);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(90, 30);
            this.button_Minus.TabIndex = 13;
            this.button_Minus.Text = "-";
            this.button_Minus.UseVisualStyleBackColor = true;
            this.button_Minus.Click += new System.EventHandler(this.button_Minus_Click);
            // 
            // numpad_0
            // 
            this.numpad_0.Location = new System.Drawing.Point(108, 244);
            this.numpad_0.Name = "numpad_0";
            this.numpad_0.Size = new System.Drawing.Size(90, 30);
            this.numpad_0.TabIndex = 14;
            this.numpad_0.Text = "0";
            this.numpad_0.UseVisualStyleBackColor = true;
            this.numpad_0.Click += new System.EventHandler(this.numpad_0_Click);
            // 
            // button_Divide
            // 
            this.button_Divide.Location = new System.Drawing.Point(108, 94);
            this.button_Divide.Name = "button_Divide";
            this.button_Divide.Size = new System.Drawing.Size(90, 30);
            this.button_Divide.TabIndex = 15;
            this.button_Divide.Text = "/";
            this.button_Divide.UseVisualStyleBackColor = true;
            this.button_Divide.Click += new System.EventHandler(this.button_Divide_Click);
            // 
            // button_Multifly
            // 
            this.button_Multifly.Location = new System.Drawing.Point(204, 94);
            this.button_Multifly.Name = "button_Multifly";
            this.button_Multifly.Size = new System.Drawing.Size(90, 30);
            this.button_Multifly.TabIndex = 16;
            this.button_Multifly.Text = "*";
            this.button_Multifly.UseVisualStyleBackColor = true;
            this.button_Multifly.Click += new System.EventHandler(this.button_Multifly_Click);
            // 
            // button_ABS
            // 
            this.button_ABS.Location = new System.Drawing.Point(300, 208);
            this.button_ABS.Name = "button_ABS";
            this.button_ABS.Size = new System.Drawing.Size(90, 30);
            this.button_ABS.TabIndex = 17;
            this.button_ABS.Text = "abs";
            this.button_ABS.UseVisualStyleBackColor = true;
            this.button_ABS.Click += new System.EventHandler(this.button_ABS_Click);
            // 
            // button_sqrt
            // 
            this.button_sqrt.Location = new System.Drawing.Point(12, 244);
            this.button_sqrt.Name = "button_sqrt";
            this.button_sqrt.Size = new System.Drawing.Size(90, 30);
            this.button_sqrt.TabIndex = 18;
            this.button_sqrt.Text = "x²";
            this.button_sqrt.UseVisualStyleBackColor = true;
            this.button_sqrt.Click += new System.EventHandler(this.button_sqrt_Click);
            // 
            // button_root
            // 
            this.button_root.Location = new System.Drawing.Point(300, 244);
            this.button_root.Name = "button_equal";
            this.button_root.Size = new System.Drawing.Size(90, 30);
            this.button_root.TabIndex = 19;
            this.button_root.Text = "=";
            this.button_root.UseVisualStyleBackColor = true;
            this.button_root.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(300, 52);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(90, 30);
            this.button_Del.TabIndex = 20;
            this.button_Del.Text = "◀";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Dot
            // 
            this.button_Dot.Location = new System.Drawing.Point(204, 244);
            this.button_Dot.Name = "button_Dot";
            this.button_Dot.Size = new System.Drawing.Size(90, 30);
            this.button_Dot.TabIndex = 21;
            this.button_Dot.Text = ".";
            this.button_Dot.UseVisualStyleBackColor = true;
            this.button_Dot.Click += new System.EventHandler(this.button_Dot_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 163);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Dot);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button_root);
            this.Controls.Add(this.button_sqrt);
            this.Controls.Add(this.button_ABS);
            this.Controls.Add(this.button_Multifly);
            this.Controls.Add(this.button_Divide);
            this.Controls.Add(this.numpad_0);
            this.Controls.Add(this.button_Minus);
            this.Controls.Add(this.button_Plus);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_ClearAll);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numpad_7);
            this.Controls.Add(this.numpad_8);
            this.Controls.Add(this.numpad_9);
            this.Controls.Add(this.numpad_6);
            this.Controls.Add(this.numpad_5);
            this.Controls.Add(this.numpad_4);
            this.Controls.Add(this.numpad_3);
            this.Controls.Add(this.numpad_2);
            this.Controls.Add(this.numpad_1);
            this.Name = "Form1";
            this.Text = "MyCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button numpad_1;
        private System.Windows.Forms.Button numpad_2;
        private System.Windows.Forms.Button numpad_3;
        private System.Windows.Forms.Button numpad_4;
        private System.Windows.Forms.Button numpad_5;
        private System.Windows.Forms.Button numpad_6;
        private System.Windows.Forms.Button numpad_7;
        private System.Windows.Forms.Button numpad_8;
        private System.Windows.Forms.Button numpad_9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_ClearAll;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.Button button_Minus;
        private System.Windows.Forms.Button numpad_0;
        private System.Windows.Forms.Button button_Divide;
        private System.Windows.Forms.Button button_Multifly;
        private System.Windows.Forms.Button button_ABS;
        private System.Windows.Forms.Button button_sqrt;
        private System.Windows.Forms.Button button_root;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Dot;
        private System.Windows.Forms.Panel panel1;
    }
}

