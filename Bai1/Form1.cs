namespace ontap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal donGia, giamGia;
            int soLuong;

            // Kiểm tra nhập liệu
            if (!decimal.TryParse(textBox1.Text, out donGia) ||
                !int.TryParse(textBox2.Text, out soLuong) ||
                !decimal.TryParse(textBox3.Text, out giamGia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số hợp lệ!");
                return;
            }

            // Kiểm tra giá trị
            if (donGia < 0 || soLuong <= 0 ||
                giamGia < 0 || giamGia > 100)
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
                return;
            }

            // Tính tiền
            decimal tongTien = donGia * soLuong *
                               (100 - giamGia) / 100;

            // Hiển thị kết quả
            lblTongTien.Text = "Tổng tiền thanh toán: " +
                               tongTien.ToString("N0") + " VNĐ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            lblTongTien.Text = "Tổng tiền thanh toán: 0 VNĐ";

            textBox1.Focus();
        }
    }
}
