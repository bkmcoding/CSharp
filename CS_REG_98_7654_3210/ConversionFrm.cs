using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CS_REG_98_7654_3210
{
    public partial class ConversionFrm : Form
    {
        public ConversionFrm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            // Creation of basic variables for the purpose of error checking and later calculations
            double userInput = 0;
            bool[] ConvertFromRb = [FromByteRb.Checked, FromKilobitRb.Checked, FromMegabitRb.Checked, FromGigabitRb.Checked, FromTerabitRb.Checked];
            bool[] ConvertToRb = [ToByteRb.Checked, ToKilobitRb.Checked, ToMegabitRb.Checked, ToGigabitRb.Checked, ToTerabitRb.Checked];
            string[] errorStatements = ["Please input a valid number to convert from", "Please select an data size to convert from", "Please select an data size to convert to"];
            bool[] errors = [false, true, true];
            bool error = false;
            string errorMessage = "";

            // Try catch statements for the purpose of error checking by user
            try
            {
                userInput = Convert.ToDouble(UserInputTxt.Text);
            }
            catch (Exception)
            {
                errors[0] = true;
            }
            foreach (bool rd in ConvertFromRb)
            {
                if (rd)
                {
                    errors[1] = false;
                }
                
            }
            foreach (bool rd in ConvertToRb)
            {
                if (rd)
                {
                    errors[2] = false;
                }
            }
            for (int index = 0; index < errorStatements.Length; index++)
            {
                if (errors[index])
                {
                    error = true;
                    errorMessage += errorStatements[index] + "\n";
                }
            }
            if (error)
            {
                MessageBox.Show(errorMessage,"Input Error");
            }
            else
            {
                ResultTxt.Text = ByteConversion.CheckConversion(userInput, ConvertFromRb, ConvertToRb).ToString();
            }
        }
    }
}
