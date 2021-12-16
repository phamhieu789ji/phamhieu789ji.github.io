namespace HE141028_HieuPT_PRN211_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(roomtype.SelectedIndex >=1 || anothermoney.Text != "" || checkedListBox1.SelectedItem != null)
            {
                string n = roommoney.Text.Substring(16);
                label10.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
                submit.Visible = true;
                label21.Text = "* Phí học lại: ";
                label22.Text = "* Phí ký túc xá: " + n;
                label23.Text = "* Phí phụ trội KTX: ";
                label24.Text = "* Phí khác: "+ anothermoney.Text;
                label10.Text = "Tổng tiền yêu cầu : "+"";
            }
            else
            {
                label10.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(roomtype.SelectedIndex == 1)
            {
                roommoney.Text = "Tiền phòng KTX: 1,900,000";
            }
            if (roomtype.SelectedIndex == 2)
            {
                roommoney.Text = "Tiền phòng KTX: 1,700,000";
            }
            if (roomtype.SelectedIndex == 3)
            {
                roommoney.Text = "Tiền phòng KTX: 1,400,000";
            }
            if (roomtype.SelectedIndex == 4)
            {
                roommoney.Text = "Tiền phòng KTX: 4,600,000";
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex == 1)
            {

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}