namespace 실습LAB1
{
    partial class Lab1Form1
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
            this.lbox_show = new System.Windows.Forms.ListBox();
            this.tbox_one = new System.Windows.Forms.TextBox();
            this.tbox_two = new System.Windows.Forms.TextBox();
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbox_show
            // 
            this.lbox_show.FormattingEnabled = true;
            this.lbox_show.ItemHeight = 15;
            this.lbox_show.Location = new System.Drawing.Point(19, 19);
            this.lbox_show.Name = "lbox_show";
            this.lbox_show.Size = new System.Drawing.Size(755, 304);
            this.lbox_show.TabIndex = 0;
            this.lbox_show.SelectedIndexChanged += new System.EventHandler(this.lbox_show_SelectedIndexChanged);
            // 
            // tbox_one
            // 
            this.tbox_one.Location = new System.Drawing.Point(18, 354);
            this.tbox_one.Name = "tbox_one";
            this.tbox_one.Size = new System.Drawing.Size(659, 25);
            this.tbox_one.TabIndex = 1;
            // 
            // tbox_two
            // 
            this.tbox_two.Location = new System.Drawing.Point(19, 413);
            this.tbox_two.Name = "tbox_two";
            this.tbox_two.Size = new System.Drawing.Size(658, 25);
            this.tbox_two.TabIndex = 2;
            // 
            // btn_one
            // 
            this.btn_one.Location = new System.Drawing.Point(683, 354);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(109, 25);
            this.btn_one.TabIndex = 3;
            this.btn_one.Text = "입력";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.btn_one_Click);
            // 
            // btn_two
            // 
            this.btn_two.Enabled = false;
            this.btn_two.Location = new System.Drawing.Point(683, 411);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(109, 25);
            this.btn_two.TabIndex = 4;
            this.btn_two.Text = "삭제";
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Click += new System.EventHandler(this.btn_two_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_two);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.tbox_two);
            this.Controls.Add(this.tbox_one);
            this.Controls.Add(this.lbox_show);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_show;
        private System.Windows.Forms.TextBox tbox_one;
        private System.Windows.Forms.TextBox tbox_two;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Button btn_two;
    }
}

