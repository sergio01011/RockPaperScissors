using System.Diagnostics;
using System.Drawing.Text;

namespace RockPaperScissors
{
    public partial class rock_paper_scissor : Form
    {
        public rock_paper_scissor()
        {
            InitializeComponent();
        }



        private void btnSelector_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtYouChoose.Text = button.Text;

            //seleccion de cpu
            string cpuSelection = getRandomOption();
            txtCpuChoose.Text = cpuSelection;

            //determinar ganador
            string whoWin = DetermineWinner(txtYouChoose.Text, txtCpuChoose.Text);

            //mostrar resultado
            txtWhoWin.Text = whoWin;

        }

        private string getRandomOption()
        {

            string[] options = { "rock", "paper", "scissor" };
            Random random = new Random();
            int optionIndex = random.Next(0, options.Length);
            return options[optionIndex];

        }

        private string DetermineWinner(string playerChoice, string cpuChoice)
        {

            if (playerChoice == cpuChoice) { return "Its a TIE!"; }
            if ((playerChoice == "rock" && cpuChoice == "scissor") ||
               (playerChoice == "paper" && cpuChoice == "rock") ||
               (playerChoice == "scissor" && cpuChoice == "paper"))
            {
                return "YOU WIN!!!";
            }
            else { return "CPU WINS"; }



        }
    }
}