using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
     
    public partial class AddStudent : Form
    {
        private List<Student> liststudent = new List<Student>();
        Student student = new Student();
        public AddStudent()
        {
            InitializeComponent();
            txtHovaTen.KeyPress += new KeyPressEventHandler(txtHovaTen_KeyPress);
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

            dataGridView1.Columns.Add("StudentID", "Mã SV");
            dataGridView1.Columns.Add("Name", "Họ và tên");
            dataGridView1.Columns.Add("Brithday", "Ngày Sinh");
            dataGridView1.Columns.Add("Age", "Tuổi");
            dataGridView1.Columns.Add("SEX", "Giới Tính");
            dataGridView1.Columns.Add("Address", "Địa Chỉ");
            dataGridView1.Columns.Add("Class", "Lớp");
            dataGridView1.Columns.Add("Math", "Toán");
            dataGridView1.Columns.Add("Literature", "Văn");
            dataGridView1.Columns.Add("Chemistry", "Hóa");
            dataGridView1.Columns.Add("AverageScore", "Điểm TB");

            string  newID = ID_Student();
            txtID.Text = newID.ToString();

            comboBox1.Items.Add("10");
            comboBox1.Items.Add("11");
            comboBox1.Items.Add("12");


        }
        private string ID_Student()
        {
            int max = 1;
            if(liststudent.Count > 0)
            {
                max = liststudent.Max(sv => sv.Student_ID1[0]);
                max++;
            }
            return "SV" + max.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            student.BrithDay1 = dateTimePicker1.Value;

            int age = CalculateAge();
            txtTuoi.Text = age.ToString();
        }
        private int CalculateAge()
        {
            int Age = DateTime.Now.Year - student.BrithDay1.Year;
            if(DateTime.Now.DayOfYear < student.BrithDay1.DayOfYear)
            {
                --Age;
            }

            return Age;
        }

        private void txtToan_TextChanged(object sender, EventArgs e)
        {
            if(double.TryParse(txtToan.Text, out double diem1))
            {
                
                
                    student.Math1 = diem1;
                    CalculateAverageScore();
                
                
                    
            }
        }

        private void txtDiemvan_TextChanged(object sender, EventArgs e)
        {
            if(double.TryParse(txtDiemvan.Text, out double diem2))
            {
               
                
                
                    student.Literature1 = diem2;
                    CalculateAverageScore();
                
                    
                    

            }

        }

        private void txtHoa_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtHoa.Text, out double diem3))
            {
                
                    student.Chemistry1 = diem3;
                    CalculateAverageScore();
                
                    
            }
        }
        
        private void CalculateAverageScore()
        {
            txtTrungBinh.Text = student.TDTB().ToString("0.00");
        }

        private void btSAVE_Click(object sender, EventArgs e)
        {
            

                student.Full_Name1 = txtHovaTen.Text;
            student.Student_ID1 = Convert.ToString(txtID.Text);
  
                student.Sex1 = txtGioiTinh.Text;
                student.BrithDay1 = dateTimePicker1.Value;
                student.Address1 = txtDiaChi.Text;
                student.Major1 = comboBox1.SelectedItem.ToString();
                student.Math1 = Convert.ToDouble(txtToan.Text);
                student.Chemistry1 = Convert.ToDouble(txtHoa.Text);
                student.Literature1 = Convert.ToDouble(txtDiemvan.Text);
                student.AverageScore1 = student.TDTB();

                liststudent.Add(student);
                dataGridView1.Rows.Add(student.Student_ID1, student.Full_Name1, student.BrithDay1, CalculateAge(), student.Sex1, student.Address1, student.Major1, student.Math1, student.Literature1, student.Chemistry1, student.AverageScore1);
                MessageBox.Show("Sinh Viên Đã Được Thêm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearTextBox();

           

            
        }
        private void ClearTextBox()
        {
            txtID.Clear();
            txtHovaTen.Clear();
            dateTimePicker1.ResetText();
            dateTimePicker1.Value = DateTime.Now;
            txtDiaChi.Clear();
            comboBox1.SelectedItem = null;
            txtToan.Clear();
            txtDiemvan.Clear();
            txtHoa.Clear();
            txtTrungBinh.Clear();
            txtTuoi.Clear();
           

        }

        private void btTroVe_Click(object sender, EventArgs e)
        {
            SyStem syStem = new SyStem();
            syStem.Show();
            this.Hide();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
           
            for(int i = liststudent.Count -1; i >= 0; i--)
            {
                if (liststudent[i].Student_ID1 == txtID.Text)
                {
                    liststudent.RemoveAt(i);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = liststudent;
                }
            }
           

        }

        private void btTim_Click(object sender, EventArgs e)
        {
            string maSv = txtID.Text;
            Student sv = Search(maSv);

            if(sv != null)
            {
                txtHovaTen.Text = sv.Full_Name1.ToString();
                dateTimePicker1.Value = sv.BrithDay1.ToLocalTime();
                txtGioiTinh.Text = sv.Sex1;
                txtDiaChi.Text = sv.Address1;
                comboBox1.Text = sv.Major1;
                txtToan.Text = sv.Math1.ToString();
                txtDiemvan.Text = sv.Literature1.ToString();
                txtHoa.Text = sv.Chemistry1.ToString();
                txtTrungBinh.Text = sv.AverageScore1.ToString();
                
                


            }
            else
            {
                MessageBox.Show("No", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Student Search(string ID)
        {
            foreach(Student sv in liststudent)
            {
                if(sv.Student_ID1 == ID)
                {
                    return sv;
                }
            }
            return null;
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            string maSv = txtID.Text;
            Student sv = Search(maSv);

            if (sv != null)
            {
                sv.Full_Name1 = txtHovaTen.Text;
                sv.BrithDay1 = dateTimePicker1.Value;
                sv.Sex1 = txtGioiTinh.Text;
                sv.Address1 = txtDiaChi.Text;
                sv.Major1 = comboBox1.Text;
                sv.Math1 = Convert.ToDouble(txtToan.Text);
                sv.Literature1 = Convert.ToDouble(txtDiemvan.Text);
                sv.Chemistry1 = Convert.ToDouble(txtHoa.Text);
                sv.AverageScore1 = student.TDTB();
                dataGridView1.DataSource = null;


            }
            else
            {
                MessageBox.Show("No", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtHovaTen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtHovaTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
               
            }
            
        }
    }
}
