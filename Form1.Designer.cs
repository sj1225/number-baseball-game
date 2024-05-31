namespace number_baseball_game
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
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.ButtonInput = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.Divider = new System.Windows.Forms.Label();
            this.lbInform = new System.Windows.Forms.Label();
            this.lbResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox1.Font = new System.Drawing.Font("굴림", 33F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.TextBox1.Location = new System.Drawing.Point(36, 40);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(1);
            this.TextBox1.MaxLength = 1;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(50, 58);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // TextBox2
            // 
            this.TextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox2.Font = new System.Drawing.Font("굴림", 33F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.TextBox2.Location = new System.Drawing.Point(97, 40);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(1);
            this.TextBox2.MaxLength = 1;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(50, 58);
            this.TextBox2.TabIndex = 1;
            this.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // TextBox3
            // 
            this.TextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox3.Font = new System.Drawing.Font("굴림", 33F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.TextBox3.Location = new System.Drawing.Point(158, 40);
            this.TextBox3.Margin = new System.Windows.Forms.Padding(1);
            this.TextBox3.MaxLength = 1;
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(50, 58);
            this.TextBox3.TabIndex = 2;
            this.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // TextBox4
            // 
            this.TextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox4.Font = new System.Drawing.Font("굴림", 33F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.TextBox4.Location = new System.Drawing.Point(219, 40);
            this.TextBox4.Margin = new System.Windows.Forms.Padding(1);
            this.TextBox4.MaxLength = 1;
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(50, 58);
            this.TextBox4.TabIndex = 3;
            this.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // ButtonInput
            // 
            this.ButtonInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonInput.Font = new System.Drawing.Font("굴림", 16F);
            this.ButtonInput.Location = new System.Drawing.Point(282, 40);
            this.ButtonInput.Name = "ButtonInput";
            this.ButtonInput.Size = new System.Drawing.Size(70, 58);
            this.ButtonInput.TabIndex = 4;
            this.ButtonInput.Text = "입력";
            this.ButtonInput.UseVisualStyleBackColor = true;
            this.ButtonInput.Click += new System.EventHandler(this.ButtonInput_Click);
            this.ButtonInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ButtonInput_KeyPress);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClear.Font = new System.Drawing.Font("굴림", 12F);
            this.ButtonClear.Location = new System.Drawing.Point(7, 494);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(370, 31);
            this.ButtonClear.TabIndex = 5;
            this.ButtonClear.Text = "새게임";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // Divider
            // 
            this.Divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Divider.Location = new System.Drawing.Point(7, 117);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(370, 2);
            this.Divider.TabIndex = 6;
            // 
            // label1
            // 
            this.lbInform.AutoSize = true;
            this.lbInform.Location = new System.Drawing.Point(115, 15);
            this.lbInform.Name = "label1";
            this.lbInform.Size = new System.Drawing.Size(155, 12);
            this.lbInform.TabIndex = 7;
            this.lbInform.Text = "4자리 숫자를 입력해주세요.";
            // 
            // label2
            // 
            this.lbResults.AutoSize = true;
            this.lbResults.Location = new System.Drawing.Point(34, 129);
            this.lbResults.Name = "label2";
            this.lbResults.Size = new System.Drawing.Size(0, 12);
            this.lbResults.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 531);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.lbInform);
            this.Controls.Add(this.Divider);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonInput);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Name = "Form1";
            this.Text = "숫자 야구 게임";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.TextBox TextBox4;
        private System.Windows.Forms.Button ButtonInput;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Label Divider;
        private System.Windows.Forms.Label lbInform;
        private System.Windows.Forms.Label lbResults;
    }
}

