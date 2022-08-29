using SampleDataGridView.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SampleDataGridView
{
    public partial class FormMain : Form
    {
        private List<SampleDataSource> _dataList;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                _dataList = new List<SampleDataSource>()
                {
                    new SampleDataSource(){ Id = 1,  UserName = "Tom", Language = "C#", Age = 25},
                    new SampleDataSource(){ Id = 2,  UserName = "Jhon", Language = "PHP", Age = 32},
                    new SampleDataSource(){ Id = 3,  UserName = "Arthur", Language = "Python", Age = 21},
                    new SampleDataSource(){ Id = 4,  UserName = "Carl", Language = "Java", Age = 28},
                    new SampleDataSource(){ Id = 5,  UserName = "Eden", Language = "Rust", Age = 35},
                    new SampleDataSource(){ Id = 6,  UserName = "Billy", Language = "Go", Age = 36},
                    new SampleDataSource(){ Id = 7,  UserName = "Neal", Language = "Ruby", Age = 42},
                    new SampleDataSource(){ Id = 8,  UserName = "Jakob", Language = "C++", Age = 38},
                    new SampleDataSource(){ Id = 9,  UserName = "Frank", Language = "Swift", Age = 22},
                    new SampleDataSource(){ Id = 10,  UserName = "Madison", Language = "VB", Age = 29},
                };

                LoadDataIntoDataGridView(_dataList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error.",
                    MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadDataIntoDataGridView(List<SampleDataSource> dataList)
        {
            // 列とボタン追加
            dataGridViewMain.Columns.Add(new DataGridViewButtonColumn() { Name = "action", Text = "select",　Width = 50, UseColumnTextForButtonValue = true });

            // データを読み込む
            dataGridViewMain.DataSource = dataList;                       
        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // クリックした行のインデックスを取得
            string selectedRowIndex = e.RowIndex.ToString();
            MessageBox.Show(selectedRowIndex);
        }
    }
}
