using System.Diagnostics;

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

            string[] options = { "rock", "paper", "scissor" };
            Random random = new Random();
            int optionIndex = random.Next(0, options.Length);
            string cpuSelection = options[optionIndex];
            txtCpuChoose.Text = cpuSelection;

            // switch para ver quien gana

            string whoWin = "";

            switch (txtYouChoose.Text)
            {
                case "rock":
                    switch(txtCpuChoose.Text)
                    {
                        case "rock":
                            whoWin = "IT´S A TIE";
                            break;
                        case "paper":
                            whoWin = "CPU WIN";
                            break;
                        case "scissor":
                            whoWin = "YOU WIN!!!";
                            break;
                    }
                    break;
                case "paper":
                    switch (txtCpuChoose.Text)
                    {
                        case "rock":
                            whoWin = "YOU WIN!!!";
                            break;
                        case "paper":
                            whoWin = "IT´S A TIE";
                            break;
                        case "scissor":
                            whoWin = "CPU WIN";
                            break;
                    }
                    break;
                case "scissor":
                    switch (txtCpuChoose.Text)
                    {
                        case "rock":
                            whoWin = "CPU WIN";
                            break;
                        case "paper":
                            whoWin = "YOU WIN!!!";
                            break;
                        case "scissor":
                            whoWin = "IT´S A TIE";
                            break;
                    }
                    break;

            }

            txtWhoWin.Text = whoWin;
        }
    }


                       

    }

    
   



