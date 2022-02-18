using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;

namespace osu_bm_dl
{
    public partial class main : Form
    {
        def defs = new def();
        string amount = "50";
        int page = 1;

        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 첫 실행시 설정 필요
            string gameDir = Properties.Settings.Default.gameDir;
            if (gameDir.Length <= 0)
            {
                MessageBox.Show("처음 실행하셨군요!\rosu! Songs 폴더 경로를 설정하세요.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form setting = new setting();
                setting.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // 검색어 예외
            if (searchQuery.Text.Length < 3)
            {
                MessageBox.Show("검색어는 3글자 이상이어야 해요.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 리스트 클리어
            bmList.Rows.Clear();
            bmList.Refresh();

            try
            {
                // json 받아오기
                searchButton.Text = "검색 중"; searchButton.Enabled = false;
                String json = defs.getRequest("https://kitsu.moe/api/search?amount=" + amount + "&query=" + searchQuery.Text + "&offset=" + (Convert.ToInt32(amount) * (page - 1)).ToString());
                JArray jObject = JArray.Parse(json);

                int added = 0;
                for (int i = 0; i < jObject.Count; i++)
                {
                    String title = jObject[i]["Title"].ToString();
                    String artist = jObject[i]["Artist"].ToString();
                    String creator = jObject[i]["Creator"].ToString();
                    String status = jObject[i]["RankedStatus"].ToString();
                    String setId = jObject[i]["SetID"].ToString();

                    // 비트맵 상태
                    status = defs.bmStatus(status);

                    // 추가
                    bmList.Rows.Add(setId, title, artist, creator, status);
                    added++;
                }

                if (added == 0) MessageBox.Show("검색된 비트맵이 없어요.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                searchButton.Enabled = true; searchButton.Text = "검색";
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류가 발생했어요!\r\r" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == bmList.Columns["download"].Index && e.RowIndex >= 0)
            {
                dlFile(bmList.Rows[e.RowIndex].Cells[0].Value.ToString(), bmList.Rows[e.RowIndex].Cells[1].Value.ToString());
                bmList.Columns[5].Visible = false;
                statuslabel.Text = "다운로드 중.. 0%";
                downloadProgress.Value = 0;
            }
        }

        private void displayCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void searchQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1_Click_1(sender, e);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form setting = new setting();
            setting.ShowDialog();
        }

        private void sortList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void dlFile(string sid, String filename)
        {
            // 파일 다운로드
            String path = Properties.Settings.Default.gameDir + @"\" + filename + ".osz";

            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri("http://kitsu.moe/d/" + sid), @path);
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // 다운로드 퍼센티지 표시
            downloadProgress.Value = e.ProgressPercentage;
            statuslabel.Text = "다운로드 중.. " + e.ProgressPercentage.ToString() + "%";
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            // 다운로드 완료
            statuslabel.Text = "다운로드 완료!";
            bmList.Columns[5].Visible = true;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void aasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void count10_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // 표시 갯수 변경
            amount = e.ClickedItem.Text.Replace("개", "");
        }

        private void prePage_ButtonClick(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page -= 1;
                button1_Click_1(sender, e);
            }
            else
            {
                MessageBox.Show("이미 마지막 페이지에요!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void nextPage_ButtonClick(object sender, EventArgs e)
        {
            page += 1;
            button1_Click_1(sender, e);
        }
    }
}
