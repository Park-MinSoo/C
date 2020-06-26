namespace 인증_클라이언트
{
    partial class 인증_클라이언트_Form
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
            this.components = new System.ComponentModel.Container();
            this.tbox_id = new System.Windows.Forms.TextBox();
            this.tbox_pw = new System.Windows.Forms.TextBox();
            this.btn_join = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbox_bport = new System.Windows.Forms.TextBox();
            this.lbox_frd = new System.Windows.Forms.ListBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbox_id
            // 
            this.tbox_id.Location = new System.Drawing.Point(27, 25);
            this.tbox_id.Name = "tbox_id";
            this.tbox_id.Size = new System.Drawing.Size(100, 25);
            this.tbox_id.TabIndex = 0;
            // 
            // tbox_pw
            // 
            this.tbox_pw.Location = new System.Drawing.Point(27, 81);
            this.tbox_pw.Name = "tbox_pw";
            this.tbox_pw.Size = new System.Drawing.Size(100, 25);
            this.tbox_pw.TabIndex = 1;
            // 
            // btn_join
            // 
            this.btn_join.Location = new System.Drawing.Point(27, 135);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(100, 29);
            this.btn_join.TabIndex = 2;
            this.btn_join.Text = "가입";
            this.btn_join.UseVisualStyleBackColor = true;
            this.btn_join.Click += new System.EventHandler(this.btn_join_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(147, 134);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(112, 29);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "로그인";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(282, 134);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(108, 29);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "타이머 정지";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbox_bport
            // 
            this.tbox_bport.Location = new System.Drawing.Point(27, 219);
            this.tbox_bport.Name = "tbox_bport";
            this.tbox_bport.Size = new System.Drawing.Size(99, 25);
            this.tbox_bport.TabIndex = 5;
            // 
            // lbox_frd
            // 
            this.lbox_frd.FormattingEnabled = true;
            this.lbox_frd.ItemHeight = 15;
            this.lbox_frd.Location = new System.Drawing.Point(437, 23);
            this.lbox_frd.Name = "lbox_frd";
            this.lbox_frd.Size = new System.Drawing.Size(322, 379);
            this.lbox_frd.TabIndex = 6;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(147, 218);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(111, 25);
            this.btn_logout.TabIndex = 7;
            this.btn_logout.Text = "로그아웃";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // 인증_클라이언트_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbox_frd);
            this.Controls.Add(this.tbox_bport);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_join);
            this.Controls.Add(this.tbox_pw);
            this.Controls.Add(this.tbox_id);
            this.Name = "인증_클라이언트_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_id;
        private System.Windows.Forms.TextBox tbox_pw;
        private System.Windows.Forms.Button btn_join;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbox_bport;
        private System.Windows.Forms.ListBox lbox_frd;
        private System.Windows.Forms.Button btn_logout;
    }
}

