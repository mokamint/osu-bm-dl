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

namespace osu_bm_dl
{
    public partial class main : Form
    {
        def defs = new def();
        string amount;

        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayCount.SelectedIndex = 2;

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
            String a = defs.getRequest("http://example.com");
            MessageBox.Show(a);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (searchQuery.Text.Length < 3)
            {
                MessageBox.Show("검색어는 3글자 이상이어야 해요.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 리스트 클리어
            bmList.Rows.Clear();
            bmList.Refresh();

            // json 받아오기
            try
            {
                // 버튼 비활성화
                searchButton.Text = "검색 중"; searchButton.Enabled = false;
                String json = defs.getRequest("https://kitsu.moe/api/search?amount=" + amount + "&query=" + searchQuery.Text);
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
                    switch (status)
                    {
                        case "-1":
                            status = "WIP (제작 중)";
                            break;
                        case "-2":
                            status = "Graveyard";
                            break;
                        case "0":
                            status = "Pending";
                            break;
                        case "1":
                            status = "Ranked";
                            break;
                        case "2":
                            status = "Approved";
                            break;
                        case "3":
                            status = "Qualified";
                            break;
                        case "4":
                            status = "Loved";
                            break;
                    }
                    
                    // 추가
                    bmList.Rows.Add(setId, title, artist, creator, status);
                    added++;
                }

                if (added == 0) MessageBox.Show("검색된 비트맵이 없어요.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                searchButton.Enabled = true; searchButton.Text = "검색";
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류가 발생했어요 x_x\r\r" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == bmList.Columns["download"].Index && e.RowIndex >= 0)
            {
                MessageBox.Show(bmList.Rows[e.RowIndex].Cells[0].Value.ToString());
                // defs.fileDownload(bmList.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void displayCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            amount = displayCount.SelectedItem.ToString().Replace("개", "");
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
    }
}
