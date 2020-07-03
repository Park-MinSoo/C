namespace 데모_프로그램
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
            this.cs = new ColorSelectorLib.ColorSelector();
            this.tbox_red = new System.Windows.Forms.TextBox();
            this.tbox_green = new System.Windows.Forms.TextBox();
            this.tbox_blue = new System.Windows.Forms.TextBox();
            this.btn_set = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cs
            // 
            this.cs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cs.Location = new System.Drawing.Point(12, 12);
            this.cs.Name = "cs";
            this.cs.Size = new System.Drawing.Size(537, 411);
            this.cs.TabIndex = 0;
            // 
            // tbox_red
            // 
            this.tbox_red.Location = new System.Drawing.Point(589, 120);
            this.tbox_red.Name = "tbox_red";
            this.tbox_red.Size = new System.Drawing.Size(140, 25);
            this.tbox_red.TabIndex = 1;
            // 
            // tbox_green
            // 
            this.tbox_green.Location = new System.Drawing.Point(589, 189);
            this.tbox_green.Name = "tbox_green";
            this.tbox_green.Size = new System.Drawing.Size(140, 25);
            this.tbox_green.TabIndex = 2;
            // 
            // tbox_blue
            // 
            this.tbox_blue.Location = new System.Drawing.Point(589, 261);
            this.tbox_blue.Name = "tbox_blue";
            this.tbox_blue.Size = new System.Drawing.Size(139, 25);
            this.tbox_blue.TabIndex = 3;
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(589, 335);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(139, 28);
            this.btn_set.TabIndex = 4;
            this.btn_set.Text = "삽입";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.tbox_blue);
            this.Controls.Add(this.tbox_green);
            this.Controls.Add(this.tbox_red);
            this.Controls.Add(this.cs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorSelectorLib.ColorSelector cs;
        private System.Windows.Forms.TextBox tbox_red;
        private System.Windows.Forms.TextBox tbox_green;
        private System.Windows.Forms.TextBox tbox_blue;
        private System.Windows.Forms.Button btn_set;
    }
}

