﻿namespace 테트리스
{
    partial class 테트리스Form
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
            this.tm_down = new System.Windows.Forms.Timer(this.components);
            this.tm_tm = new System.Windows.Forms.Timer(this.components);
            this.lb_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tm_down
            // 
            this.tm_down.Enabled = true;
            this.tm_down.Interval = 300;
            this.tm_down.Tick += new System.EventHandler(this.tm_down_Tick);
            // 
            // tm_tm
            // 
            this.tm_tm.Enabled = true;
            this.tm_tm.Interval = 1000;
            this.tm_tm.Tick += new System.EventHandler(this.tm_tm_Tick);
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Location = new System.Drawing.Point(632, 29);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(45, 15);
            this.lb_time.TabIndex = 0;
            this.lb_time.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_time);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tm_down;
        private System.Windows.Forms.Timer tm_tm;
        private System.Windows.Forms.Label lb_time;
    }
}

