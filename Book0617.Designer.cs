namespace 도서_검색_pre0617
{
    partial class Book0617
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_search = new System.Windows.Forms.Button();
            this.tbox_query = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_book = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_search);
            this.splitContainer1.Panel1.Controls.Add(this.tbox_query);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lv_book);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 44;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(694, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(94, 25);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tbox_query
            // 
            this.tbox_query.Location = new System.Drawing.Point(75, 12);
            this.tbox_query.Name = "tbox_query";
            this.tbox_query.Size = new System.Drawing.Size(603, 25);
            this.tbox_query.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "질의 :";
            // 
            // lv_book
            // 
            this.lv_book.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_book.HideSelection = false;
            this.lv_book.Location = new System.Drawing.Point(0, 0);
            this.lv_book.Name = "lv_book";
            this.lv_book.Size = new System.Drawing.Size(800, 402);
            this.lv_book.TabIndex = 0;
            this.lv_book.UseCompatibleStateImageBehavior = false;
            this.lv_book.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "제목";
            this.columnHeader1.Width = 319;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "저자";
            this.columnHeader2.Width = 190;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ISBN";
            this.columnHeader3.Width = 151;
            // 
            // Book0617
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Book0617";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Book0617_FormClosed);
            this.Load += new System.EventHandler(this.Book0617_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tbox_query;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_book;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

