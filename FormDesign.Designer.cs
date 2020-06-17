namespace 리스트_뷰어
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
            this.lv_book = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_title = new System.Windows.Forms.TextBox();
            this.tbox_author = new System.Windows.Forms.TextBox();
            this.tbox_publisher = new System.Windows.Forms.TextBox();
            this.tbox_price = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_book
            // 
            this.lv_book.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_book.HideSelection = false;
            this.lv_book.Location = new System.Drawing.Point(12, 12);
            this.lv_book.Name = "lv_book";
            this.lv_book.Size = new System.Drawing.Size(416, 426);
            this.lv_book.TabIndex = 0;
            this.lv_book.UseCompatibleStateImageBehavior = false;
            this.lv_book.View = System.Windows.Forms.View.Details;
            this.lv_book.SelectedIndexChanged += new System.EventHandler(this.lv_book_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "제목";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "저자";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "출판사";
            this.columnHeader3.Width = 101;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "가격";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "제목 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "저자 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "출판사 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "가격 :";
            // 
            // tbox_title
            // 
            this.tbox_title.Location = new System.Drawing.Point(535, 36);
            this.tbox_title.Name = "tbox_title";
            this.tbox_title.Size = new System.Drawing.Size(160, 25);
            this.tbox_title.TabIndex = 5;
            // 
            // tbox_author
            // 
            this.tbox_author.Location = new System.Drawing.Point(534, 94);
            this.tbox_author.Name = "tbox_author";
            this.tbox_author.Size = new System.Drawing.Size(160, 25);
            this.tbox_author.TabIndex = 6;
            // 
            // tbox_publisher
            // 
            this.tbox_publisher.Location = new System.Drawing.Point(534, 158);
            this.tbox_publisher.Name = "tbox_publisher";
            this.tbox_publisher.Size = new System.Drawing.Size(160, 25);
            this.tbox_publisher.TabIndex = 7;
            // 
            // tbox_price
            // 
            this.tbox_price.Location = new System.Drawing.Point(534, 203);
            this.tbox_price.Name = "tbox_price";
            this.tbox_price.Size = new System.Drawing.Size(160, 25);
            this.tbox_price.TabIndex = 8;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(456, 275);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(127, 28);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "추가";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Enabled = false;
            this.btn_remove.Location = new System.Drawing.Point(611, 275);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(127, 28);
            this.btn_remove.TabIndex = 10;
            this.btn_remove.Text = "삭제";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tbox_price);
            this.Controls.Add(this.tbox_publisher);
            this.Controls.Add(this.tbox_author);
            this.Controls.Add(this.tbox_title);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_book);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_book;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_title;
        private System.Windows.Forms.TextBox tbox_author;
        private System.Windows.Forms.TextBox tbox_publisher;
        private System.Windows.Forms.TextBox tbox_price;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
    }
}

