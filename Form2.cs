using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangmangame
{
    public partial class Form2 : Form

    {
        
        private bool newGameRequested = true;
        private List<string> words;
        private List<string> fruits;
        private List<string> countries;
        private List<string> animals;
        private List<string> randomstuff;
        private string chosenWord;
        private char[] hiddenWord;
        private int livesRemaining;
        private List<char> guessedLetters;
        public Form2()
        {
            InitializeComponent();
            DrawHangPost();
            InitializeHangmanGame();
        }
        private void InitializeHangmanGame()
        {

            fruits = new List<string>()
    {
        "APPLE", "BANANA", "ORANGE", "MANGO", "STRAWBERRY", "GRAPE", "WATERMELON", "PINEAPPLE", "KIWI", "PEAR",
        "APRICOT", "CHERRY", "LEMON", "BLUEBERRY", "RASPBERRY", "PEACH", "COCONUT", "FIG", "PLUM", "POMEGRANATE",
        "NECTARINE", "CANTALOUPE", "BLACKBERRY", "CRANBERRY", "GUAVA", "LYCHEE", "PAPAYA", "DATE", "MELON",
        "TANGERINE", "GRAPEFRUIT", "KIWIFRUIT", "CLEMENTINE", "PASSIONFRUIT", "PERSIMMON", "STARFRUIT", "LIME",
        "CARAMBOLA", "CHERRYTOMATO", "DRAGONFRUIT", "GOOSEBERRY", "JACKFRUIT", "KUMQUAT", "MANGOSTEEN", "RAMBUTAN",
        "SOURSOP", "TAMARILLO", "UGLI", "YUZU"
    };
            countries = new List<string>()
    {
        "USA", "CANADA", "INDIA", "BRAZIL", "AUSTRALIA", "CHINA", "RUSSIA", "JAPAN", "GERMANY", "FRANCE",
        "UK", "ITALY", "SOUTHKOREA", "SPAIN", "MEXICO", "INDONESIA", "TURKEY", "SAUDIARABIA", "SWITZERLAND", "EGYPT",
        "ARGENTINA", "THAILAND", "CANADA", "NIGERIA", "PAKISTAN", "POLAND", "NETHERLANDS", "SOUTHAFRICA", "PHILIPPINES",
        "BELGIUM", "SWEDEN", "AUSTRALIA", "NORWAY", "AUSTRIA", "UAE", "IRELAND", "ISRAEL", "DENMARK", "SINGAPORE",
        "MALAYSIA", "GREECE", "HONGKONG", "PORTUGAL", "FINLAND", "NEWZEALAND", "CZECHREPUBLIC", "HUNGARY", "ROMANIA"
    };
            animals = new List<string>()
    {
        "LION", "ELEPHANT", "TIGER", "ZEBRA", "GIRAFFE", "MONKEY", "HIPPOPOTAMUS", "CROCODILE", "RHINOCEROS", "LEOPARD",
        "CHEETAH", "WOLF", "BEAR", "FOX", "DEER", "KANGAROO", "WHALE", "DOLPHIN", "SHARK", "EAGLE",
        "PENGUIN", "OSTRICH", "CAMEL", "ALLIGATOR", "BUFFALO", "GORILLA", "HORSE", "COW", "SNAKE",
        "RABBIT", "FROG", "BEE", "SPIDER", "ANT", "WORM", "TURTLE", "CATERPILLAR", "LIZARD", "FLY",
        "MOSQUITO", "SCORPION", "SNAIL", "CENTIPEDE", "GRASSHOPPER", "CRICKET", "MOTH", "CICADA", "MILLIPEDE"
    };
            randomstuff = new List<string>()
    {
        "COMPUTER", "CAR", "PHONE", "TABLE", "CHAIR", "TELEVISION", "MICROWAVE", "REFRIGERATOR", "WASHINGMACHINE", "DISHWASHER",
        "OVEN", "BLENDER", "TOASTER", "KETTLE", "IRON", "VACUUMCLEANER", "FAN", "AIRCONDITIONER", "HEATER", "COFFEEMAKER",
        "MIXER", "SPEAKER", "PROJECTOR", "CAMERA", "PRINTER", "SCANNER", "MODEM", "ROUTER", "KEYBOARD",
        "MOUSE", "MONITOR", "HEADPHONES", "MICROPHONE", "WEBCAM", "GAMECONSOLE", "TABLET", "LAPTOP", "SMARTWATCH", "FITNESSTRACKER",
        "EBOOKREADER", "GPS", "DRONE", "FLASHLIGHT", "REMOTECONTROL", "WALKIETALKIE", "BINOCULARS", "COMPASS", "UMBRELLA"
    };
            // Create alphabet buttons
            CreateAlphabetButtons();

            // Start a new game
            StartNewGame();
        }
        private void CreateAlphabetButtons()
        {
            int buttonWidth = 35;
            int buttonHeight = 35;
            int startX = (ClientSize.Width - 8 * buttonWidth) / 2; // Adjust the horizontal spacing
            int startY = ClientSize.Height - 145; // Adjust the vertical position

            // Create buttons for all alphabet letters
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                Button button = new Button();
                button.Text = letter.ToString();
                button.Click += buttonLetter_Click;
                button.BackColor = Color.Black; // Change the background color
                button.ForeColor = Color.White; // Change the text color
                button.Font = new Font(button.Font, FontStyle.Bold);
                button.Width = buttonWidth;
                button.Height = buttonHeight;

                // Calculate the position of the button
                int col = (letter - 'A') % 9;
                int row = (letter - 'A') / 9;
                button.Left = startX + col * buttonWidth;
                button.Top = startY + row * buttonHeight;

                Controls.Add(button);
            }
     }
        private void StartNewGame()
        {

            if (newGameRequested)
            {

                SelectCategory();

                // Randomly select word based on the chosen category
                switch (labelCategory.Text)
                {
                    case "Category: Fruits":
                        chosenWord = fruits[new Random().Next(fruits.Count)];
                        break;
                    case "Category: Countries":
                        chosenWord = countries[new Random().Next(countries.Count)];
                        break;
                    case "Category: Animals":
                        chosenWord = animals[new Random().Next(animals.Count)];
                        break;
                    case "Category: Random Stuff":
                        chosenWord = randomstuff[new Random().Next(randomstuff.Count)];
                        break;
                }

                hiddenWord = new char[chosenWord.Length];
                hiddenWord[0] = chosenWord[0];
                bool gameOver = false; // Flag to track game state
                for (int i = 0; i < chosenWord.Length; i++)
                {
                    if (gameOver) // Check if game is over before assigning underscores
                    {
                        hiddenWord[i] = chosenWord[i]; // Reveal the entire word
                   
                    }
                    else
                    {
                        hiddenWord[i] = '_';
                    }
                }
                labelGuessedLetters.Text = string.Join(" ", hiddenWord);
                livesRemaining = 6; // Adjust as desired
                guessedLetters = new List<char>();
            }

            UpdateLabels();
        }

        private void playAgain_Click(object sender, EventArgs e)
        {

            labelGuessedLetters.Text = "";

            // Reset color of buttons

            foreach (Button button in Controls.OfType<Button>())
            {

                labelGuessedLetters.ForeColor = Color.White;

                labelLivesRemaining.ForeColor = Color.White;
                labelCategory.ForeColor = Color.White;
                button.BackColor = Color.Black; // Restore default button color
                button.Enabled = true;
                button1.BackColor = Color.Maroon;
            }


            panel1.Invalidate(); // Invalidate the panel to trigger a redraw
            DrawHangPost(); // Redraw the hangman

            // Reset game state

            StartNewGame();
        }

        private void SelectCategory()
        {
            Random random = new Random();
            int categoryIndex = random.Next(4); // 0: Fruits, 1: Countries, 2: Animals, 3: Things

            switch (categoryIndex)
            {
                case 0:
                    words = fruits;
                    labelCategory.Text = "Category: Fruits";
                    break;
                case 1:
                    words = countries;
                    labelCategory.Text = "Category: Countries";
                    break;
                case 2:
                    words = animals;
                    labelCategory.Text = "Category: Animals";
                    break;
                case 3:
                    words = randomstuff;
                    labelCategory.Text = "Category: Random Stuff";
                    break;
                default:
                    // Handle default case
                    break;
            }
        }
        private void UpdateLabels()
        {
            string hiddenWordString = new string(hiddenWord);
            labelHiddenWord.Text = hiddenWordString;

            labelLivesRemaining.Text = $"Lives: {livesRemaining}";

        }
        private void CheckWinLose()
        {
           
                if (new string(hiddenWord) == chosenWord)
            {
                labelGuessedLetters.ForeColor = Color.Black;
                MessageBox.Show("You win!");
                labelGuessedLetters.Text = "";
                labelLivesRemaining.ForeColor= Color.Black;
                labelCategory.ForeColor = Color.Black;
                DisableGameControls();
                    StartNewGame();
                    playAgain.Visible = true;
                }
                else if (livesRemaining == 0)
            {
                labelGuessedLetters.ForeColor = Color.Black;
                MessageBox.Show($"Game over. The word was: {chosenWord}");
               
                labelCategory.ForeColor = Color.Black;
                
                labelLivesRemaining.ForeColor = Color.Black;
                DisableGameControls();
                    StartNewGame();
                    playAgain.Visible = true;
                }

                
            
        }

        private void DisableGameControls()
        {
            // Disable all buttons used for guessing
            foreach (Button button in Controls.OfType<Button>())
            {
                if (button != button1 && button != playAgain)
                {
                    button.Enabled = false;
                }
            }
        }
        private void ProcessGuess(char letter)
        {
            if (guessedLetters.Contains(letter))
            {
                return; // Already guessed letter
            }
            guessedLetters.Add(letter);
            bool found = false;

            for (int i = 0; i < chosenWord.Length; i++)
            {
                if (chosenWord[i] == letter)
                {
                    hiddenWord[i] = letter;
                    found = true;
                }
            }
            if (!found)
            {
                livesRemaining--;

                DrawBodyPart((BodyParts)(6 - livesRemaining));


            }
            if (found)
            {
                // Change the color of the button to green if the guess is correct
                Button clickedButton = Controls.OfType<Button>().FirstOrDefault(b => b.Text == letter.ToString());
                if (clickedButton != null)
                {
                    clickedButton.BackColor = Color.Green;
                }
            }
            else
            {
                // Change the color of the button to red
                Button clickedButton = Controls.OfType<Button>().FirstOrDefault(b => b.Text == letter.ToString());
                if (clickedButton != null)
                {
                    clickedButton.BackColor = Color.Red;
                }
            }


            // Update labelGuessedLetters to display correctly placed letters and dashes
            labelGuessedLetters.Text = "";
            for (int i = 0; i < chosenWord.Length; i++)
            {
                if (hiddenWord[i] != ' ')
                {
                    labelGuessedLetters.Text += hiddenWord[i] + " ";
                    UpdateLabels();
                    CheckWinLose();
                }
                else
                {
                    labelGuessedLetters.Text += " ";
                }
            }
            UpdateLabels();
            CheckWinLose();

            labelGuessedLetters.Text = string.Join(" ", hiddenWord);

           

        }
        private void buttonLetter_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            char letter = clickedButton.Text[0]; // Get the first character from the button text
            ProcessGuess(letter);
        }

        enum BodyParts
        {
            Head,
            Right_Arm,
            Left_Arm,
            Body,
            Right_Leg,
            Left_Leg
        }
        void DrawHangPost()

        {

            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.White, 8);
            g.DrawLine(p, new Point(20, 260), new Point(20, 5));
            g.DrawLine(p, new Point(23, 9), new Point(83, 9));
            g.DrawLine(p, new Point(87, 5), new Point(87, 44));

            Pen P = new Pen(Color.White, 6);
            g.DrawLine(P, new Point(0, 257), new Point(115, 257));
            g.DrawLine(P, new Point(22, 40), new Point(60, 8));
            DrawBodyPart(BodyParts.Head);
            DrawBodyPart(BodyParts.Body);
            DrawBodyPart(BodyParts.Left_Arm);
            DrawBodyPart(BodyParts.Right_Arm);
            DrawBodyPart(BodyParts.Left_Leg);
            DrawBodyPart(BodyParts.Right_Leg);
        }
        void DrawBodyPart(BodyParts bp)
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.White, 3);
            if (livesRemaining < 6)
            {
                if (bp == BodyParts.Head)
                    g.DrawEllipse(p, 65, 45, 40, 40);
            }
            if (livesRemaining < 5)
            {
                if (bp == BodyParts.Body)
                    g.DrawLine(p, new Point(85, 87), new Point(85, 167));
            }
            if (livesRemaining < 4)
            {
                if (bp == BodyParts.Left_Arm)
                    g.DrawLine(p, new Point(84, 118), new Point(56, 90));
            }
            if (livesRemaining < 3)
            {
                if (bp == BodyParts.Right_Arm)
                    g.DrawLine(p, new Point(85, 118), new Point(113, 90));
            }
            if (livesRemaining < 2)
            {

                if (bp == BodyParts.Left_Leg)
                    g.DrawLine(p, new Point(85, 167), new Point(56, 210));
            }
            if (livesRemaining < 1)
            {
                if (bp == BodyParts.Right_Leg)
                    g.DrawLine(p, new Point(85, 167), new Point(116, 210));
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawHangPost();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelCategory_Click(object sender, EventArgs e)
        {
            SelectCategory();
            //DisplayCategory();
        }

        private void labelHiddenWord_Click(object sender, EventArgs e)
        {

        }

        private void labelGuessedLetters_Click(object sender, EventArgs e)
        {

        }

        private void labelLivesRemaining_Click(object sender, EventArgs e)
        {

        }
    }
}
