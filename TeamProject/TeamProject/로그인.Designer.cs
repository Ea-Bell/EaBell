namespace TeamProject
{
    partial class LogInForm
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
            this.LogInForm_Text_ID = new System.Windows.Forms.TextBox();
            this.LogInForm_Text_Pw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginForm_Button_Account = new System.Windows.Forms.Button();
            this.LoginForm_Button_Cancel = new System.Windows.Forms.Button();
            this.LoginForm_Button_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogInForm_Text_ID
            // 
            this.LogInForm_Text_ID.Location = new System.Drawing.Point(178, 117);
            this.LogInForm_Text_ID.Name = "LogInForm_Text_ID";
            this.LogInForm_Text_ID.Size = new System.Drawing.Size(156, 25);
            this.LogInForm_Text_ID.TabIndex = 0;
            // 
            // LogInForm_Text_Pw
            // 
            this.LogInForm_Text_Pw.Location = new System.Drawing.Point(178, 164);
            this.LogInForm_Text_Pw.Name = "LogInForm_Text_Pw";
            this.LogInForm_Text_Pw.Size = new System.Drawing.Size(156, 25);
            this.LogInForm_Text_Pw.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호";
            // 
            // LoginForm_Button_Account
            // 
            this.LoginForm_Button_Account.Location = new System.Drawing.Point(288, 238);
            this.LoginForm_Button_Account.Name = "LoginForm_Button_Account";
            this.LoginForm_Button_Account.Size = new System.Drawing.Size(75, 23);
            this.LoginForm_Button_Account.TabIndex = 2;
            this.LoginForm_Button_Account.Text = "가입하기";
            this.LoginForm_Button_Account.UseVisualStyleBackColor = true;
            this.LoginForm_Button_Account.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // LoginForm_Button_Cancel
            // 
            this.LoginForm_Button_Cancel.Location = new System.Drawing.Point(184, 238);
            this.LoginForm_Button_Cancel.Name = "LoginForm_Button_Cancel";
            this.LoginForm_Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.LoginForm_Button_Cancel.TabIndex = 3;
            this.LoginForm_Button_Cancel.Text = "취소하기";
            this.LoginForm_Button_Cancel.UseVisualStyleBackColor = true;
            // 
            // LoginForm_Button_Login
            // 
            this.LoginForm_Button_Login.Location = new System.Drawing.Point(100, 238);
            this.LoginForm_Button_Login.Name = "LoginForm_Button_Login";
            this.LoginForm_Button_Login.Size = new System.Drawing.Size(65, 23);
            this.LoginForm_Button_Login.TabIndex = 4;
            this.LoginForm_Button_Login.Text = "로그인";
            this.LoginForm_Button_Login.UseVisualStyleBackColor = true;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 355);
            this.Controls.Add(this.LoginForm_Button_Login);
            this.Controls.Add(this.LoginForm_Button_Cancel);
            this.Controls.Add(this.LoginForm_Button_Account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogInForm_Text_Pw);
            this.Controls.Add(this.LogInForm_Text_ID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LogInForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LogInForm_Text_ID;
        private System.Windows.Forms.TextBox LogInForm_Text_Pw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginForm_Button_Account;
        private System.Windows.Forms.Button LoginForm_Button_Cancel;
        private System.Windows.Forms.Button LoginForm_Button_Login;
    }
}

