namespace App1
{
    partial class 형태소_분석기Form
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
            this.tbox_org = new System.Windows.Forms.TextBox();
            this.tbox_par = new System.Windows.Forms.TextBox();
            this.tbox_dat = new System.Windows.Forms.TextBox();
            this.btn_set = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_mo_parse = new System.Windows.Forms.Button();
            this.lbox_org = new System.Windows.Forms.ListBox();
            this.lbox_par = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbox_org
            // 
            this.tbox_org.Location = new System.Drawing.Point(59, 59);
            this.tbox_org.Name = "tbox_org";
            this.tbox_org.ReadOnly = true;
            this.tbox_org.Size = new System.Drawing.Size(310, 25);
            this.tbox_org.TabIndex = 0;
            // 
            // tbox_par
            // 
            this.tbox_par.Location = new System.Drawing.Point(59, 153);
            this.tbox_par.Name = "tbox_par";
            this.tbox_par.ReadOnly = true;
            this.tbox_par.Size = new System.Drawing.Size(310, 25);
            this.tbox_par.TabIndex = 1;
            // 
            // tbox_dat
            // 
            this.tbox_dat.Location = new System.Drawing.Point(59, 245);
            this.tbox_dat.Name = "tbox_dat";
            this.tbox_dat.ReadOnly = true;
            this.tbox_dat.Size = new System.Drawing.Size(310, 25);
            this.tbox_dat.TabIndex = 2;
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(59, 359);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(122, 29);
            this.btn_set.TabIndex = 3;
            this.btn_set.Text = "디렉토리 설정";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_mo_parse
            // 
            this.btn_mo_parse.Enabled = false;
            this.btn_mo_parse.Location = new System.Drawing.Point(233, 359);
            this.btn_mo_parse.Name = "btn_mo_parse";
            this.btn_mo_parse.Size = new System.Drawing.Size(136, 29);
            this.btn_mo_parse.TabIndex = 4;
            this.btn_mo_parse.Text = "형태소 분석";
            this.btn_mo_parse.UseVisualStyleBackColor = true;
            this.btn_mo_parse.Click += new System.EventHandler(this.btn_mo_parse_Click);
            // 
            // lbox_org
            // 
            this.lbox_org.FormattingEnabled = true;
            this.lbox_org.ItemHeight = 15;
            this.lbox_org.Location = new System.Drawing.Point(399, 65);
            this.lbox_org.Name = "lbox_org";
            this.lbox_org.Size = new System.Drawing.Size(178, 334);
            this.lbox_org.TabIndex = 5;
            // 
            // lbox_par
            // 
            this.lbox_par.FormattingEnabled = true;
            this.lbox_par.ItemHeight = 15;
            this.lbox_par.Location = new System.Drawing.Point(606, 65);
            this.lbox_par.Name = "lbox_par";
            this.lbox_par.Size = new System.Drawing.Size(182, 334);
            this.lbox_par.TabIndex = 6;
            // 
            // 형태소_분석기Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbox_par);
            this.Controls.Add(this.lbox_org);
            this.Controls.Add(this.btn_mo_parse);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.tbox_dat);
            this.Controls.Add(this.tbox_par);
            this.Controls.Add(this.tbox_org);
            this.Name = "형태소_분석기Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_org;
        private System.Windows.Forms.TextBox tbox_par;
        private System.Windows.Forms.TextBox tbox_dat;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button btn_mo_parse;
        private System.Windows.Forms.ListBox lbox_org;
        private System.Windows.Forms.ListBox lbox_par;
    }
}

