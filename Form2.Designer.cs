namespace 데이터_관리
{
    partial class Form2
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
            this.lbox_md = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_des = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbox_md
            // 
            this.lbox_md.FormattingEnabled = true;
            this.lbox_md.ItemHeight = 12;
            this.lbox_md.Location = new System.Drawing.Point(13, 25);
            this.lbox_md.Name = "lbox_md";
            this.lbox_md.Size = new System.Drawing.Size(120, 292);
            this.lbox_md.TabIndex = 0;
            this.lbox_md.SelectedIndexChanged += new System.EventHandler(this.lbox_md_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(140, 25);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "새로 추가";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "md 번호:";
            // 
            // tbox_no
            // 
            this.tbox_no.Location = new System.Drawing.Point(215, 68);
            this.tbox_no.Name = "tbox_no";
            this.tbox_no.ReadOnly = true;
            this.tbox_no.Size = new System.Drawing.Size(109, 21);
            this.tbox_no.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "제목:";
            // 
            // tbox_title
            // 
            this.tbox_title.Location = new System.Drawing.Point(215, 101);
            this.tbox_title.Name = "tbox_title";
            this.tbox_title.Size = new System.Drawing.Size(201, 21);
            this.tbox_title.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "설명:";
            // 
            // tbox_des
            // 
            this.tbox_des.Location = new System.Drawing.Point(142, 177);
            this.tbox_des.Multiline = true;
            this.tbox_des.Name = "tbox_des";
            this.tbox_des.Size = new System.Drawing.Size(274, 100);
            this.tbox_des.TabIndex = 7;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(142, 293);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "확인";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cc
            // 
            this.btn_cc.Location = new System.Drawing.Point(239, 293);
            this.btn_cc.Name = "btn_cc";
            this.btn_cc.Size = new System.Drawing.Size(75, 23);
            this.btn_cc.TabIndex = 9;
            this.btn_cc.Text = "취소";
            this.btn_cc.UseVisualStyleBackColor = true;
            this.btn_cc.Click += new System.EventHandler(this.btn_cc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 336);
            this.Controls.Add(this.btn_cc);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tbox_des);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_no);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbox_md);
            this.Name = "Form1";
            this.Text = "Dictionary 실습";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_md;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_des;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cc;
    }
}

