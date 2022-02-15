
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
            this.searchQuery = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.bmList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.displayCount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.downloadProgress = new System.Windows.Forms.ProgressBar();
            this.setid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.download = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bmList)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(12, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Powered by kitsu.moe";
            // 
            // displayCount
            // 
            this.displayCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displayCount.FormattingEnabled = true;
            this.displayCount.Items.AddRange(new object[] {
            "10개",
            "25개",
            "50개",
            "75개",
            "100개"});
            this.displayCount.Location = new System.Drawing.Point(797, 555);
            this.displayCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.displayCount.Name = "displayCount";
            this.displayCount.Size = new System.Drawing.Size(71, 23);
            this.displayCount.TabIndex = 4;
            this.displayCount.SelectedIndexChanged += new System.EventHandler(this.displayCount_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(734, 559);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "표시 개수";
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
            // downloadProgress
            // 
            this.downloadProgress.Location = new System.Drawing.Point(879, 554);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(194, 24);
            this.downloadProgress.TabIndex = 8;
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
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1085, 589);
            this.Controls.Add(this.downloadProgress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displayCount);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchQuery;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView bmList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox displayCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ProgressBar downloadProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn setid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn download;
    }
}

