using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DgwShowList();
        }

        public void DgwShowList()
        {
            dgwToDoList.ColumnCount = 3;
            dgwToDoList.Columns[0].Name = "Görev Adı";
            dgwToDoList.Columns[1].Name = "Görev Açıklaması";
            dgwToDoList.Columns[2].Name = "Durum";
            dgwToDoList.Columns[0].Width = 150;
            dgwToDoList.Columns[1].Width = 300;
            dgwToDoList.Columns[2].Width = 99;
            dgwToDoList.Rows.Add("Örnek Görev", "Örnek Görev Açıklaması", "Tamamlandı");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbxTaskNameAdd.Text != "" && tbxTaskDescAdd.Text != "")
            {
                dgwToDoList.Rows.Add(tbxTaskNameAdd.Text, tbxTaskDescAdd.Text, "Devam Ediyor");
                ClearTextBoxes();
            }
            
        }

        private void dgwToDoList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgwToDoList.CurrentRow.Cells[0].Value != null)
            {
                tbxTaskNameDelete.Text = dgwToDoList.CurrentRow.Cells[0].Value.ToString();
                tbxTaskDescDelete.Text = dgwToDoList.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgwToDoList.CurrentRow.Cells[0].Value != null)
            {
                int rowIndex = dgwToDoList.CurrentCell.RowIndex;
                dgwToDoList.Rows.RemoveAt(rowIndex);
                ClearTextBoxes();
            }
        }

        public void ClearTextBoxes()
        {
            tbxTaskNameAdd.Text = "";
            tbxTaskDescAdd.Text = "";
            tbxTaskNameDelete.Text = "";
            tbxTaskDescDelete.Text = "";
        }

        private void btnTaskComplete_Click(object sender, EventArgs e)
        {
            if (dgwToDoList.CurrentRow.Cells[0].Value != null)
            {
                dgwToDoList.CurrentRow.Cells[2].Value = "Tamamlandı";
            }
        }
    }
}
