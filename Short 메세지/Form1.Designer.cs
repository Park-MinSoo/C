namespace Tiny_메신저
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
            this.tbox_my_ip = new System.Windows.Forms.TextBox();
            this.tbox_my_smport = new System.Windows.Forms.TextBox();
            this.tbox_my_fport = new System.Windows.Forms.TextBox();
            this.btn_my_smset = new System.Windows.Forms.Button();
            this.btn_my_fset = new System.Windows.Forms.Button();
            this.btn_other_fset = new System.Windows.Forms.Button();
            this.btn_other_smset = new System.Windows.Forms.Button();
            this.tbox_other_fport = new System.Windows.Forms.TextBox();
            this.tbox_other_smport = new System.Windows.Forms.TextBox();
            this.tbox_other_ip = new System.Windows.Forms.TextBox();
            this.lbox_msg = new System.Windows.Forms.ListBox();
            this.tbox_msg = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbox_my_ip
            // 
            this.tbox_my_ip.Location = new System.Drawing.Point(30, 12);
            this.tbox_my_ip.Name = "tbox_my_ip";
            this.tbox_my_ip.Size = new System.Drawing.Size(258, 25);
            this.tbox_my_ip.TabIndex = 0;
            // 
            // tbox_my_smport
            // 
            this.tbox_my_smport.Location = new System.Drawing.Point(294, 12);
            this.tbox_my_smport.Name = "tbox_my_smport";
            this.tbox_my_smport.Size = new System.Drawing.Size(142, 25);
            this.tbox_my_smport.TabIndex = 1;
            // 
            // tbox_my_fport
            // 
            this.tbox_my_fport.Location = new System.Drawing.Point(547, 12);
            this.tbox_my_fport.Name = "tbox_my_fport";
            this.tbox_my_fport.Size = new System.Drawing.Size(145, 25);
            this.tbox_my_fport.TabIndex = 2;
            // 
            // btn_my_smset
            // 
            this.btn_my_smset.Location = new System.Drawing.Point(442, 12);
            this.btn_my_smset.Name = "btn_my_smset";
            this.btn_my_smset.Size = new System.Drawing.Size(99, 25);
            this.btn_my_smset.TabIndex = 3;
            this.btn_my_smset.Text = "설정";
            this.btn_my_smset.UseVisualStyleBackColor = true;
            this.btn_my_smset.Click += new System.EventHandler(this.btn_my_smset_Click);
            // 
            // btn_my_fset
            // 
            this.btn_my_fset.Location = new System.Drawing.Point(698, 12);
            this.btn_my_fset.Name = "btn_my_fset";
            this.btn_my_fset.Size = new System.Drawing.Size(90, 25);
            this.btn_my_fset.TabIndex = 4;
            this.btn_my_fset.Text = "설정";
            this.btn_my_fset.UseVisualStyleBackColor = true;
            // 
            // btn_other_fset
            // 
            this.btn_other_fset.Location = new System.Drawing.Point(698, 44);
            this.btn_other_fset.Name = "btn_other_fset";
            this.btn_other_fset.Size = new System.Drawing.Size(90, 25);
            this.btn_other_fset.TabIndex = 9;
            this.btn_other_fset.Text = "설정";
            this.btn_other_fset.UseVisualStyleBackColor = true;
            // 
            // btn_other_smset
            // 
            this.btn_other_smset.Location = new System.Drawing.Point(442, 46);
            this.btn_other_smset.Name = "btn_other_smset";
            this.btn_other_smset.Size = new System.Drawing.Size(99, 25);
            this.btn_other_smset.TabIndex = 8;
            this.btn_other_smset.Text = "설정";
            this.btn_other_smset.UseVisualStyleBackColor = true;
            this.btn_other_smset.Click += new System.EventHandler(this.btn_other_smset_Click);
            // 
            // tbox_other_fport
            // 
            this.tbox_other_fport.Location = new System.Drawing.Point(547, 44);
            this.tbox_other_fport.Name = "tbox_other_fport";
            this.tbox_other_fport.Size = new System.Drawing.Size(145, 25);
            this.tbox_other_fport.TabIndex = 7;
            // 
            // tbox_other_smport
            // 
            this.tbox_other_smport.Location = new System.Drawing.Point(294, 46);
            this.tbox_other_smport.Name = "tbox_other_smport";
            this.tbox_other_smport.Size = new System.Drawing.Size(142, 25);
            this.tbox_other_smport.TabIndex = 6;
            // 
            // tbox_other_ip
            // 
            this.tbox_other_ip.Location = new System.Drawing.Point(30, 44);
            this.tbox_other_ip.Name = "tbox_other_ip";
            this.tbox_other_ip.Size = new System.Drawing.Size(258, 25);
            this.tbox_other_ip.TabIndex = 5;
            // 
            // lbox_msg
            // 
            this.lbox_msg.FormattingEnabled = true;
            this.lbox_msg.ItemHeight = 15;
            this.lbox_msg.Location = new System.Drawing.Point(30, 82);
            this.lbox_msg.Name = "lbox_msg";
            this.lbox_msg.Size = new System.Drawing.Size(757, 319);
            this.lbox_msg.TabIndex = 10;
            // 
            // tbox_msg
            // 
            this.tbox_msg.Location = new System.Drawing.Point(30, 413);
            this.tbox_msg.Name = "tbox_msg";
            this.tbox_msg.Size = new System.Drawing.Size(662, 25);
            this.tbox_msg.TabIndex = 11;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(698, 413);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(89, 25);
            this.btn_send.TabIndex = 12;
            this.btn_send.Text = "보내기";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tbox_msg);
            this.Controls.Add(this.lbox_msg);
            this.Controls.Add(this.btn_other_fset);
            this.Controls.Add(this.btn_other_smset);
            this.Controls.Add(this.tbox_other_fport);
            this.Controls.Add(this.tbox_other_smport);
            this.Controls.Add(this.tbox_other_ip);
            this.Controls.Add(this.btn_my_fset);
            this.Controls.Add(this.btn_my_smset);
            this.Controls.Add(this.tbox_my_fport);
            this.Controls.Add(this.tbox_my_smport);
            this.Controls.Add(this.tbox_my_ip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_my_ip;
        private System.Windows.Forms.TextBox tbox_my_smport;
        private System.Windows.Forms.TextBox tbox_my_fport;
        private System.Windows.Forms.Button btn_my_smset;
        private System.Windows.Forms.Button btn_my_fset;
        private System.Windows.Forms.Button btn_other_fset;
        private System.Windows.Forms.Button btn_other_smset;
        private System.Windows.Forms.TextBox tbox_other_fport;
        private System.Windows.Forms.TextBox tbox_other_smport;
        private System.Windows.Forms.TextBox tbox_other_ip;
        private System.Windows.Forms.ListBox lbox_msg;
        private System.Windows.Forms.TextBox tbox_msg;
        private System.Windows.Forms.Button btn_send;
    }
}

