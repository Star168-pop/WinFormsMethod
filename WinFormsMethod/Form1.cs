namespace WinFormsMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            InputDataValid(txtName, txtAge);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ดีครัช", "นี้คือโปรแกรมให้รู้ว่าYOUอ้วนแค่ไหน");
            clearForm();
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            InputDataValid(txtName, txtAge);
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);



            double height = 0;
            double weight = 0;
            if (CheckDouble(txtWeight, txtHeight))
            {
                height = Convert.ToDouble(txtWeight.Text);
                weight = Convert.ToDouble(txtWeight.Text);
            }

            double bmi = BMI(height, weight);


            lblResult.Text = bmi.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            txtAge.TextAlign = HorizontalAlignment.Right;
            txtHeight.TextAlign = HorizontalAlignment.Right;
            txtWeight.TextAlign = HorizontalAlignment.Right;
            txtName.Text = "";
            txtAge.Text = "0";
            txtHeight.Text = "0";
            txtWeight.Text = "0";
            txtName.Focus();

        }

        private void InputDataValid(TextBox name, TextBox age)
        {
            if (name.Text.Length != 0)
            {
                name.ForeColor = Color.DarkGreen;
            }
            else
            {
                name.ForeColor = Color.Black;
            }
            if (Convert.ToInt32(age.Text) > 0)
            {
                age.ForeColor = Color.DarkGreen;
            }
            else
            {
                age.ForeColor = Color.Black;
            }
        }

        private double BMI(double h, double w)
        {
            double bmi = w / Math.Pow(h / 100, 2);
            return bmi;
            //return w / Math.Pow(h / 100, 2);
        }

        private bool CheckDouble(TextBox txtW, TextBox txtH)
        {
            double w = 0;
            double h = 0;
            if ((double.TryParse(txtW.Text, out w) == false) || (double.TryParse(txtW.Text, out h) == false))
            {
                MessageBox.Show("ข้อผิดพลาด!!", "กรุณากรอกใหม่");
                return false;
            }
            return true;
        }
    }
}
