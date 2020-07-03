namespace ColorSelectorLib
{
    partial class ColorSelector
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_red = new System.Windows.Forms.TrackBar();
            this.tb_green = new System.Windows.Forms.TrackBar();
            this.tb_blue = new System.Windows.Forms.TrackBar();
            this.tbox_red = new System.Windows.Forms.TextBox();
            this.tbox_green = new System.Windows.Forms.TextBox();
            this.tbox_blue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_blue)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbox_blue);
            this.splitContainer1.Panel2.Controls.Add(this.tbox_green);
            this.splitContainer1.Panel2.Controls.Add(this.tbox_red);
            this.splitContainer1.Panel2.Controls.Add(this.tb_blue);
            this.splitContainer1.Panel2.Controls.Add(this.tb_green);
            this.splitContainer1.Panel2.Controls.Add(this.tb_red);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(798, 448);
            this.splitContainer1.SplitterDistance = 238;
            this.splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "G:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "R:";
            // 
            // tb_red
            // 
            this.tb_red.Location = new System.Drawing.Point(85, 20);
            this.tb_red.Maximum = 255;
            this.tb_red.Name = "tb_red";
            this.tb_red.Size = new System.Drawing.Size(190, 56);
            this.tb_red.TabIndex = 3;
            this.tb_red.Scroll += new System.EventHandler(this.tb_red_Scroll);
            // 
            // tb_green
            // 
            this.tb_green.Location = new System.Drawing.Point(85, 72);
            this.tb_green.Maximum = 255;
            this.tb_green.Name = "tb_green";
            this.tb_green.Size = new System.Drawing.Size(190, 56);
            this.tb_green.TabIndex = 4;
            this.tb_green.Scroll += new System.EventHandler(this.tb_green_Scroll);
            // 
            // tb_blue
            // 
            this.tb_blue.Location = new System.Drawing.Point(85, 133);
            this.tb_blue.Maximum = 255;
            this.tb_blue.Name = "tb_blue";
            this.tb_blue.Size = new System.Drawing.Size(190, 56);
            this.tb_blue.TabIndex = 5;
            this.tb_blue.Scroll += new System.EventHandler(this.tb_blue_Scroll);
            // 
            // tbox_red
            // 
            this.tbox_red.Location = new System.Drawing.Point(329, 19);
            this.tbox_red.Name = "tbox_red";
            this.tbox_red.ReadOnly = true;
            this.tbox_red.Size = new System.Drawing.Size(178, 25);
            this.tbox_red.TabIndex = 6;
            // 
            // tbox_green
            // 
            this.tbox_green.Location = new System.Drawing.Point(329, 72);
            this.tbox_green.Name = "tbox_green";
            this.tbox_green.ReadOnly = true;
            this.tbox_green.Size = new System.Drawing.Size(178, 25);
            this.tbox_green.TabIndex = 7;
            // 
            // tbox_blue
            // 
            this.tbox_blue.Location = new System.Drawing.Point(329, 123);
            this.tbox_blue.Name = "tbox_blue";
            this.tbox_blue.ReadOnly = true;
            this.tbox_blue.Size = new System.Drawing.Size(178, 25);
            this.tbox_blue.TabIndex = 8;
            // 
            // ColorSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ColorSelector";
            this.Size = new System.Drawing.Size(798, 448);
            this.Load += new System.EventHandler(this.ColorSelector_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_blue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tb_blue;
        private System.Windows.Forms.TrackBar tb_green;
        private System.Windows.Forms.TrackBar tb_red;
        private System.Windows.Forms.TextBox tbox_blue;
        private System.Windows.Forms.TextBox tbox_green;
        private System.Windows.Forms.TextBox tbox_red;
    }
}
