namespace lecture9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Employee e1=new Employee(int.Parse(txtid.Text),txtName.Text,dotBirth.Value);
            MessageBox.Show(e1.employeeinfo());
        }
    }
}