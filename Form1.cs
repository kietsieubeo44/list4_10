using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace list4_10
{
    public partial class Form1 : Form
    {
        private List<string> items = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newItem = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(newItem))
            {
                items.Add(newItem);
                listBox1.Items.Add(newItem); 
                textBox1.Clear();
            }
        }

      

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex >= 0)
            {
                items.RemoveAt(selectedIndex);
                listBox1.Items.RemoveAt(selectedIndex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = textBox1.Text.Trim(); // Lấy từ khóa tìm kiếm từ textBox1.

            if (!string.IsNullOrEmpty(searchKeyword))
            {
                // Xóa tất cả các mục trong listBoxSearchResults để hiển thị kết quả tìm kiếm mới.
                listBoxSearchResults.Items.Clear();

                foreach (string item in items)
                {
                    if (item.Contains(searchKeyword))
                    {
                        listBoxSearchResults.Items.Add(item); // Hiển thị mục thỏa mãn điều kiện tìm kiếm trong listBoxSearchResults.
                    }
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
