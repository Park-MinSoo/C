namespace 웹_수집_로봇
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_url = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lview_candi = new System.Windows.Forms.ListView();
            this.사이트주소 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Depth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "seed :";
            // 
            // tbox_url
            // 
            this.tbox_url.Location = new System.Drawing.Point(113, 20);
            this.tbox_url.Name = "tbox_url";
            this.tbox_url.Size = new System.Drawing.Size(362, 25);
            this.tbox_url.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(518, 15);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(125, 34);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "등록";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(30, 393);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(105, 34);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "수집";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(164, 392);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(111, 34);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "수집 멈춤";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // lview_candi
            // 
            this.lview_candi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.사이트주소,
            this.Depth});
            this.lview_candi.HideSelection = false;
            this.lview_candi.Location = new System.Drawing.Point(29, 65);
            this.lview_candi.Name = "lview_candi";
            this.lview_candi.Size = new System.Drawing.Size(711, 303);
            this.lview_candi.TabIndex = 5;
            this.lview_candi.UseCompatibleStateImageBehavior = false;
            this.lview_candi.View = System.Windows.Forms.View.Details;
            // 
            // 사이트주소
            // 
            this.사이트주소.Text = "사이트 주소";
            this.사이트주소.Width = 420;
            // 
            // Depth
            // 
            this.Depth.Text = "Depth";
            this.Depth.Width = 242;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lview_candi);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tbox_url);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_url;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.ListView lview_candi;
        private System.Windows.Forms.ColumnHeader 사이트주소;
        private System.Windows.Forms.ColumnHeader Depth;
        private System.Windows.Forms.Timer timer1;
    }
}

