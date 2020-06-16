namespace 지역_검색
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
            this.btn_search = new System.Windows.Forms.Button();
            this.lbox_locale = new System.Windows.Forms.ListBox();
            this.질의 = new System.Windows.Forms.Label();
            this.lb_lat = new System.Windows.Forms.Label();
            this.lb_lng = new System.Windows.Forms.Label();
            this.tbox_query = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(422, 38);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 33);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbox_locale
            // 
            this.lbox_locale.FormattingEnabled = true;
            this.lbox_locale.ItemHeight = 15;
            this.lbox_locale.Location = new System.Drawing.Point(31, 106);
            this.lbox_locale.Name = "lbox_locale";
            this.lbox_locale.Size = new System.Drawing.Size(189, 304);
            this.lbox_locale.TabIndex = 1;
            this.lbox_locale.SelectedIndexChanged += new System.EventHandler(this.lbox_locale_SelectedIndexChanged);
            // 
            // 질의
            // 
            this.질의.AutoSize = true;
            this.질의.Location = new System.Drawing.Point(28, 44);
            this.질의.Name = "질의";
            this.질의.Size = new System.Drawing.Size(45, 15);
            this.질의.TabIndex = 2;
            this.질의.Text = "label1";
            // 
            // lb_lat
            // 
            this.lb_lat.AutoSize = true;
            this.lb_lat.Location = new System.Drawing.Point(275, 133);
            this.lb_lat.Name = "lb_lat";
            this.lb_lat.Size = new System.Drawing.Size(22, 15);
            this.lb_lat.TabIndex = 3;
            this.lb_lat.Text = "lat";
            // 
            // lb_lng
            // 
            this.lb_lng.AutoSize = true;
            this.lb_lng.Location = new System.Drawing.Point(273, 185);
            this.lb_lng.Name = "lb_lng";
            this.lb_lng.Size = new System.Drawing.Size(26, 15);
            this.lb_lng.TabIndex = 4;
            this.lb_lng.Text = "lng";
            // 
            // tbox_query
            // 
            this.tbox_query.Location = new System.Drawing.Point(79, 44);
            this.tbox_query.Name = "tbox_query";
            this.tbox_query.Size = new System.Drawing.Size(312, 25);
            this.tbox_query.TabIndex = 6;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(404, 106);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(329, 304);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.Url = new System.Uri("http://localhost/kakaoMap/abc.html", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.tbox_query);
            this.Controls.Add(this.lb_lng);
            this.Controls.Add(this.lb_lat);
            this.Controls.Add(this.질의);
            this.Controls.Add(this.lbox_locale);
            this.Controls.Add(this.btn_search);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ListBox lbox_locale;
        private System.Windows.Forms.Label 질의;
        private System.Windows.Forms.Label lb_lat;
        private System.Windows.Forms.Label lb_lng;
        private System.Windows.Forms.TextBox tbox_query;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

