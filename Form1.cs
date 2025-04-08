// Grading ID S2407
// Lab 4

namespace Lab4
{
    public partial class Form1 : Form
    {
        private int acceptanceTotal = 0;
        private int rejectTotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // name changed to gpaBox
        }

        private void admissionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            string user_gpa = gpaBox.Text;
            string user_admission = admissionBox.Text;
            double gpa;
            int admissionScore;


            if (double.TryParse(user_gpa, out gpa))
            {
                Console.WriteLine(" ");
            }
            else
            {
                MessageBox.Show("Invalid GPA input.");
            }

            if (int.TryParse(user_admission, out admissionScore))
            {
                Console.WriteLine(" ");
            }
            else
            {
                MessageBox.Show("Invalid admission score input");
            }


            if (gpa >= 3.0 && admissionScore >= 60 || gpa < 3.0 && admissionScore >= 80)
            {
                resultBox.Text = ("Accepted");
                MessageBox.Show("Accepted");
                acceptanceTotal += 1;
                
            }
            else
            {
                resultBox.Text = ("Rejected");
                MessageBox.Show("Rejected");
                rejectTotal += 1;
                
            }
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
