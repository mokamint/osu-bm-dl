
namespace osu_bm_dl
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.searchQuery = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.bmList = new System.Windows.Forms.DataGridView();
            this.setid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.download = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statuslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.downloadProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.displaycnt = new System.Windows.Forms.ToolStripDropDownButton();
            this.count100 = new System.Windows.Forms.ToolStripMenuItem();
            this.count75 = new System.Windows.Forms.ToolStripMenuItem();
            this.count50 = new System.Windows.Forms.ToolStripMenuItem();
            this.count25 = new System.Windows.Forms.ToolStripMenuItem();
            this.count10 = new System.Windows.Forms.ToolStripMenuItem();
            this.prePage = new System.Windows.Forms.ToolStripSplitButton();
            this.nextPage = new System.Windows.Forms.ToolStripSplitButton();
            ((System.ComponentModel.ISupportInitialize)(this.bmList)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchQuery
            // 
            this.searchQuery.Location = new System.Drawing.Point(12, 15);
            this.searchQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchQuery.Name = "searchQuery";
            this.searchQuery.Size = new System.Drawing.Size(696, 23);
            this.searchQuery.TabIndex = 0;
            this.searchQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchQuery_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(714, 14);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(74, 26);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "검색";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bmList
            // 
            this.bmList.AllowUserToAddRows = false;
            this.bmList.AllowUserToDeleteRows = false;
            this.bmList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bmList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.setid,
            this.Title,
            this.artist,
            this.creator,
            this.status,
            this.download});
            this.bmList.Location = new System.Drawing.Point(13, 50);
            this.bmList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bmList.MultiSelect = false;
            this.bmList.Name = "bmList";
            this.bmList.ReadOnly = true;
            this.bmList.RowHeadersWidth = 30;
            this.bmList.RowTemplate.Height = 23;
            this.bmList.Size = new System.Drawing.Size(1060, 498);
            this.bmList.TabIndex = 2;
            this.bmList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // setid
            // 
            this.setid.Frozen = true;
            this.setid.HeaderText = "setid";
            this.setid.Name = "setid";
            this.setid.ReadOnly = true;
            this.setid.Visible = false;
            // 
            // Title
            // 
            this.Title.HeaderText = "제목";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 300;
            // 
            // artist
            // 
            this.artist.HeaderText = "아티스트";
            this.artist.Name = "artist";
            this.artist.ReadOnly = true;
            this.artist.Width = 200;
            // 
            // creator
            // 
            this.creator.HeaderText = "제작자";
            this.creator.Name = "creator";
            this.creator.ReadOnly = true;
            this.creator.Width = 150;
            // 
            // status
            // 
            this.status.HeaderText = "상태";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // download
            // 
            this.download.HeaderText = "다운로드";
            this.download.Name = "download";
            this.download.ReadOnly = true;
            this.download.Text = "다운로드";
            this.download.UseColumnTextForButtonValue = true;
            this.download.Width = 80;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(794, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "설정";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statuslabel,
            this.downloadProgress,
            this.displaycnt,
            this.prePage,
            this.nextPage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1085, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(126, 17);
            this.toolStripStatusLabel1.Text = "Powered by kitsu.moe";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // statuslabel
            // 
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(643, 17);
            this.statuslabel.Spring = true;
            this.statuslabel.Text = "대기";
            this.statuslabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // downloadProgress
            // 
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // displaycnt
            // 
            this.displaycnt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.displaycnt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.count100,
            this.count75,
            this.count50,
            this.count25,
            this.count10});
            this.displaycnt.Image = ((System.Drawing.Image)(resources.GetObject("displaycnt.Image")));
            this.displaycnt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.displaycnt.Name = "displaycnt";
            this.displaycnt.Size = new System.Drawing.Size(72, 20);
            this.displaycnt.Text = "표시 개수";
            this.displaycnt.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripDropDownButton1_DropDownItemClicked);
            // 
            // count100
            // 
            this.count100.Name = "count100";
            this.count100.Size = new System.Drawing.Size(107, 22);
            this.count100.Text = "100개";
            // 
            // count75
            // 
            this.count75.Name = "count75";
            this.count75.Size = new System.Drawing.Size(107, 22);
            this.count75.Text = "75개";
            // 
            // count50
            // 
            this.count50.Name = "count50";
            this.count50.Size = new System.Drawing.Size(107, 22);
            this.count50.Text = "50개";
            // 
            // count25
            // 
            this.count25.Name = "count25";
            this.count25.Size = new System.Drawing.Size(107, 22);
            this.count25.Text = "25개";
            // 
            // count10
            // 
            this.count10.Name = "count10";
            this.count10.Size = new System.Drawing.Size(107, 22);
            this.count10.Text = "10개";
            this.count10.Click += new System.EventHandler(this.count10_Click);
            // 
            // prePage
            // 
            this.prePage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.prePage.DropDownButtonWidth = 0;
            this.prePage.Image = ((System.Drawing.Image)(resources.GetObject("prePage.Image")));
            this.prePage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prePage.Name = "prePage";
            this.prePage.Size = new System.Drawing.Size(48, 20);
            this.prePage.Text = "< 이전";
            this.prePage.ButtonClick += new System.EventHandler(this.prePage_ButtonClick);
            // 
            // nextPage
            // 
            this.nextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.nextPage.DropDownButtonWidth = 0;
            this.nextPage.Image = ((System.Drawing.Image)(resources.GetObject("nextPage.Image")));
            this.nextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(48, 20);
            this.nextPage.Text = "다음 >";
            this.nextPage.ButtonClick += new System.EventHandler(this.nextPage_ButtonClick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1085, 582);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bmList);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchQuery);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "osu! Beatmap downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bmList)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchQuery;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView bmList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn setid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn download;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton displaycnt;
        private System.Windows.Forms.ToolStripMenuItem count100;
        private System.Windows.Forms.ToolStripMenuItem count75;
        private System.Windows.Forms.ToolStripMenuItem count50;
        private System.Windows.Forms.ToolStripMenuItem count25;
        private System.Windows.Forms.ToolStripMenuItem count10;
        private System.Windows.Forms.ToolStripStatusLabel statuslabel;
        private System.Windows.Forms.ToolStripProgressBar downloadProgress;
        private System.Windows.Forms.ToolStripSplitButton prePage;
        private System.Windows.Forms.ToolStripSplitButton nextPage;
    }
}

