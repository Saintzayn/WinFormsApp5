namespace RollandKnow
{
    using Achievements;
    using Microsoft.VisualBasic.Devices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Media;

    public partial class Questionscreen : Form
    {
        private readonly User CurrentUser;
        private Questionpool currentquestion;
        private Random rastgele = new Random();
        int totalscore = 0;
        int checkpoint = 0;
        int checkpointcounter = 0;
        int questioncounter = 0;

        int gamestarted = 0;

        int animCount = 0;

        int spectatorjoker = 0;
        int fiftyjoker = 0;
        int questionchangejoker = 0;


        List<int> checkpoints = new List<int> { };


        private void buttonC_Click(object sender, EventArgs e)
        {
            checkanswer("C");
        }






        private void pictureBox50joker_Click(object sender, EventArgs e)
        {

            if (gamestarted == 0)
            {

                MessageBox.Show("You can't use this right now.");

            }
            else
            {
                MessageBox.Show("50/50 joker is used");

                pictureBox50joker.Enabled = false;

                fiftyjoker = 1;

                pictureBox50joker.Image = Image.FromFile("jokerler/fiftyjokerused.jpg");

                // 1. Doðru cevabý bul
                string correct = currentquestion.trueanswer; // "A","B","C","D"

                // 2. Tüm þýklarý listele
                List<string> allChoices = new List<string> { "A", "B", "C", "D" };

                // 3. Yanlýþ olanlarý bul
                List<string> wrongChoices = allChoices.Where(x => x != correct).ToList();

                // 4. Rastgele iki yanlýþ seç
                var removed = wrongChoices.OrderBy(x => rastgele.Next()).Take(2).ToList();

                // 5. Seçilen iki yanlýþ þýkký kapat
                foreach (var choice in removed)
                {
                    switch (choice)
                    {
                        case "A":
                            buttonA.Enabled = false;
                            buttonA.Text = "";
                            break;
                        case "B":
                            buttonB.Enabled = false;
                            buttonB.Text = "";
                            break;
                        case "C":
                            buttonC.Enabled = false;
                            buttonC.Text = "";
                            break;
                        case "D":
                            buttonD.Enabled = false;
                            buttonD.Text = "";
                            break;
                    }
                }
            }
        }
        private void pictureBoxspectatorjoker_Click(object sender, EventArgs e)
        {


            if (gamestarted == 0)
            {

                MessageBox.Show("You can't use this right now");
            }
            else
            {

                MessageBox.Show("Spectator joker is used");

                pictureBoxspectatorjoker.Enabled = false;

                spectatorjoker = 1;

                pictureBoxspectatorjoker.Image = Image.FromFile("jokerler/spectatorjokerused.jpg");

                labelA.Text = currentquestion.answerA;
                labelB.Text = currentquestion.answerB;
                labelC.Text = currentquestion.answerC;
                labelD.Text = currentquestion.answerD;

                string correct = currentquestion.trueanswer; // A B C D

                Random rnd = new Random();

                // Doðru cevabýn yüzdesi (yüksek)
                int correctPercent = rnd.Next(50, 70);

                // Kalan yüzdeler
                int remaining = 100 - correctPercent;

                // 3 yanlýþ þýk arasýnda daðýt
                int wrong1 = rnd.Next(0, remaining);
                int wrong2 = rnd.Next(0, remaining - wrong1);
                int wrong3 = remaining - wrong1 - wrong2;

                // Sonuçlarý depolama
                Dictionary<string, int> percents = new Dictionary<string, int>();
                percents["A"] = 0;
                percents["B"] = 0;
                percents["C"] = 0;
                percents["D"] = 0;

                // Doðru olan
                percents[correct] = correctPercent;

                // Yanlýþ olanlarýn daðýtýmý
                List<string> wrongs = new List<string> { "A", "B", "C", "D" };
                wrongs.Remove(correct);

                percents[wrongs[0]] = wrong1;
                percents[wrongs[1]] = wrong2;
                percents[wrongs[2]] = wrong3;

                if (!buttonA.Enabled) percents["A"] = 0;
                if (!buttonB.Enabled) percents["B"] = 0;
                if (!buttonC.Enabled) percents["C"] = 0;
                if (!buttonD.Enabled) percents["D"] = 0;

                progressBarA.Value = percents["A"];
                progressBarB.Value = percents["B"];
                progressBarC.Value = percents["C"];
                progressBarD.Value = percents["D"];

                labelApercent.Text = "% " + percents["A"];
                labelBpercent.Text = "% " + percents["B"];
                labelCpercent.Text = "% " + percents["C"];
                labelDpercent.Text = "% " + percents["D"];

                labelApercent.Visible = true;
                labelBpercent.Visible = true;
                labelCpercent.Visible = true;
                labelDpercent.Visible = true;

                labelA.Visible = true;
                labelB.Visible = true;
                labelC.Visible = true;
                labelD.Visible = true;

                progressBarA.Visible = true;
                progressBarB.Visible = true;
                progressBarC.Visible = true;
                progressBarD.Visible = true;

                if (!buttonA.Enabled)
                {
                    labelA.Visible = false;
                    progressBarA.Visible = false;
                    labelApercent.Visible = false;
                }
                if (!buttonB.Enabled)
                {
                    labelB.Visible = false;
                    progressBarB.Visible = false;
                    labelBpercent.Visible = false;
                }
                if (!buttonC.Enabled)
                {
                    labelC.Visible = false;
                    progressBarC.Visible = false;
                    labelCpercent.Visible = false;
                }
                if (!buttonD.Enabled)
                {
                    labelD.Visible = false;
                    progressBarD.Visible = false;
                    labelDpercent.Visible = false;
                }
            }


        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox50joker.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox50joker.BorderStyle = BorderStyle.None;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxquestionchangejoker.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxquestionchangejoker.BorderStyle = BorderStyle.None;
        }
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxspectatorjoker.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxspectatorjoker.BorderStyle = BorderStyle.None;
        }
        private void richTextBoxSorumetni_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            checkanswer("D");
        }

        private void buttonwithdraw_Click(object sender, EventArgs e)

        {

            withdraw confirmDialog = new withdraw();
            DialogResult result = confirmDialog.ShowDialog();

            if (result == DialogResult.Yes)
            {
                // The score to save is the current total score
                int finalScore = totalscore;

                MessageBox.Show("You have withdrawn. Your score: " + finalScore.ToString(), "Game Over.");

                // Call the centralized handler
                HandleGameOver(finalScore);

                this.Close(); // Close the game form
            }
        }

        public void RollDice_Click(object sender, EventArgs e)
        {
            gamestarted = 1;

            animCount = 0;
            rollingdicetimer.Start();

            pictureBoxspectatorjoker.Enabled = true;
            pictureBox50joker.Enabled = true;
            pictureBoxquestionchangejoker.Enabled = true;

            if (spectatorjoker == 1) pictureBoxspectatorjoker.Enabled = false;
            if (fiftyjoker == 1) pictureBox50joker.Enabled = false;
            if (questionchangejoker == 1) pictureBoxquestionchangejoker.Enabled = false;

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            checkanswer("A");
        }

        private void pictureBoxquestionchangejoker_Click(object sender, EventArgs e)
        {

            if (gamestarted == 0)
            {

                MessageBox.Show("You can't use this right now.");
            }
            else
            {

                MessageBox.Show("Question change joker is used");

                pictureBoxquestionchangejoker.Enabled = false;

                questionchangejoker = 1;

                pictureBoxquestionchangejoker.Image = Image.FromFile("jokerler/questionchangejokerused.jpg");

                Random rastgele = new Random();

                int zarSonucu = rastgele.Next(1, 7);

                labeldifficulty.Text = "Difficulty: " + zarSonucu;

                var suitablequestions = questionpools
                .Where(m => m.difficultylevel == zarSonucu)
                .ToList();

                pictureBoxspectatorjoker.Enabled = true;
                pictureBox50joker.Enabled = true;
                pictureBoxquestionchangejoker.Enabled = true;

                if (spectatorjoker == 1) pictureBoxspectatorjoker.Enabled = false;
                if (fiftyjoker == 1) pictureBox50joker.Enabled = false;
                if (questionchangejoker == 1) pictureBoxquestionchangejoker.Enabled = false;

                if (suitablequestions.Count() == 0)
                {
                    MessageBox.Show("No more questions this level");
                }

                currentquestion = suitablequestions[rastgele.Next(suitablequestions.Count)];

                questionpools.Remove(currentquestion);

                shownewquestion(currentquestion);

            }
        }

        private void labeldifficulty_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }


        private List<Questionpool> questionpools = new List<Questionpool>();

        public Questionscreen(User currentUser)
        {
            InitializeComponent();
            AddQuestions();
            CurrentUser = currentUser;
            this.FormClosed += Questionscreen_FormClosed;
        }
        private void Questionscreen_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void AddQuestions()
        {
            questionpools.Add(new Questionpool(
        "Where is the capital of Türkiye?",
        "Ýstanbul", "Ankara", "Ýzmir", "Bursa",
        "B", 1));
            questionpools.Add(new Questionpool(
                "When was Atatürk born?",
                "1880", "1900", "1881", "1938",
                "C", 1));
            questionpools.Add(new Questionpool(
    "What is the capital city of the United Kingdom?",
    "Paris", "London", "Rome", "Berlin",
    "B", 1
));

            questionpools.Add(new Questionpool(
                "What is the largest organ in the human body?",
                "Heart", "Brain", "Skin", "Liver",
                "C", 3
            ));

            questionpools.Add(new Questionpool(
    "Which country is famous for the Great Wall?",
    "Japan", "China", "India", "South Korea",
    "B", 2
));

            questionpools.Add(new Questionpool(
                "What is the main ingredient in guacamole?",
                "Tomato", "Onion", "Avocado", "Chili Pepper",
                "C", 3
            ));

            questionpools.Add(new Questionpool(
    "Which planet is known as the 'Red Planet'?",
    "Venus", "Mars", "Jupiter", "Saturn",
    "B", 2
));

            questionpools.Add(new Questionpool(
                "Which famous scientist developed the theory of relativity?",
                "Isaac Newton", "Galileo Galilei", "Albert Einstein", "Nikola Tesla",
                "C", 3
            ));

            questionpools.Add(new Questionpool(
    "The currency of Japan is the:",
    "Won", "Yen", "Yuan", "Ringgit",
    "B", 2
));

            questionpools.Add(new Questionpool(
                "Which famous Renaissance artist painted the ceiling of the Sistine Chapel?",
                "Leonardo da Vinci", "Raphael", "Donatello", "Michelangelo",
                "D", 4
            ));

            questionpools.Add(new Questionpool(
    "In Greek mythology, who was the God of the Sea?",
    "Zeus", "Hades", "Poseidon", "Ares",
    "C", 5
));

            questionpools.Add(new Questionpool(
                "What is the process by which plants make their food using sunlight?",
                "Respiration", "Transpiration", "Photosynthesis", "Germination",
                "C", 2
            ));

            questionpools.Add(new Questionpool(
    "What is the name of the smallest country in the world by land area?",
    "Monaco", "Nauru", "Vatican City", "San Marino",
    "C", 6
));

            questionpools.Add(new Questionpool(
                "Which element has the chemical symbol 'Hg'?",
                "Gold", "Silver", "Mercury", "Lead",
                "C", 5
            ));

            questionpools.Add(new Questionpool(
    "What is the largest planet in our solar system?",
    "Earth", "Jupiter", "Mars", "Venus",
    "B", 1));

            questionpools.Add(new Questionpool(
                "How many days are in a week?",
                "5", "6", "7", "8",
                "C", 1));

            questionpools.Add(new Questionpool(
                "Which animal is known as the King of the Jungle?",
                "Lion", "Tiger", "Elephant", "Leopard",
                "A", 1));

            questionpools.Add(new Questionpool(
                "What do bees produce?",
                "Milk", "Honey", "Wax", "Butter",
                "B", 1));

            questionpools.Add(new Questionpool(
                "What color are bananas when ripe?",
                "Red", "Yellow", "Green", "Blue",
                "B", 1));

            questionpools.Add(new Questionpool(
                "How many letters are in the English alphabet?",
                "24", "25", "26", "27",
                "C", 1));

            questionpools.Add(new Questionpool(
                "What is H2O commonly known as?",
                "Water", "Oxygen", "Hydrogen", "Salt",
                "A", 1));

            questionpools.Add(new Questionpool(
                "Which shape has three sides?",
                "Square", "Triangle", "Circle", "Pentagon",
                "B", 1));

            questionpools.Add(new Questionpool(
                "What planet do we live on?",
                "Mars", "Earth", "Jupiter", "Mercury",
                "B", 1));

            questionpools.Add(new Questionpool(
                "What gas do humans breathe in to survive?",
                "Oxygen", "Carbon dioxide", "Nitrogen", "Helium",
                "A", 1));

            questionpools.Add(new Questionpool(
                "Which animal says 'meow'?",
                "Dog", "Cow", "Cat", "Horse",
                "C", 1));

            questionpools.Add(new Questionpool(
                "How many days are in a year?",
                "364", "365", "366", "360",
                "B", 1));

            questionpools.Add(new Questionpool(
                "Which fruit is red and often used in salads?",
                "Banana", "Tomato", "Kiwi", "Grapes",
                "B", 1));

            questionpools.Add(new Questionpool(
                "What is the opposite of 'big'?",
                "Small", "Tall", "Long", "Wide",
                "A", 1));

            questionpools.Add(new Questionpool(
                "Which country is famous for pizza?",
                "France", "Italy", "China", "India",
                "B", 1));

            questionpools.Add(new Questionpool(
                "What is the fastest land animal?",
                "Lion", "Cheetah", "Horse", "Leopard",
                "B", 1));

            questionpools.Add(new Questionpool(
                "What is the first month of the year?",
                "February", "January", "March", "April",
                "B", 1));

            questionpools.Add(new Questionpool(
                "What color is the sky on a clear day?",
                "Blue", "Black", "Green", "Grey",
                "A", 1));

            questionpools.Add(new Questionpool(
                "How many legs does a spider have?",
                "6", "8", "4", "10",
                "B", 1));

            questionpools.Add(new Questionpool(
                "Which animal gives us milk?",
                "Dog", "Cow", "Sheep", "Chicken",
                "B", 1));

            questionpools.Add(new Questionpool(
                "What is the opposite of 'hot'?",
                "Warm", "Cold", "Cool", "Dry",
                "B", 1));

            questionpools.Add(new Questionpool(
                "Which shape is round?",
                "Square", "Triangle", "Circle", "Rectangle",
                "C", 1));

            questionpools.Add(new Questionpool(
                "What does a thermometer measure?",
                "Speed", "Temperature", "Weight", "Height",
                "B", 1));

            questionpools.Add(new Questionpool(
                "How many hours are in a day?",
                "20", "22", "24", "26",
                "C", 1));

            questionpools.Add(new Questionpool(
                "Which animal can fly?",
                "Fish", "Bird", "Dog", "Snake",
                "B", 1));

            questionpools.Add(new Questionpool(
                "What is 2 + 2?",
                "3", "4", "5", "6",
                "B", 1));

            questionpools.Add(new Questionpool(
                "Which ocean is the largest?",
                "Indian", "Pacific", "Arctic", "Atlantic",
                "B", 1));

            questionpools.Add(new Questionpool(
                "What do plants need to grow?",
                "Sand", "Sunlight", "Metal", "Stone",
                "B", 1));

            questionpools.Add(new Questionpool(
                "Where do fish live?",
                "Trees", "Water", "Land", "Air",
                "B", 1));

            questionpools.Add(new Questionpool(
                "What is the opposite of 'up'?",
                "Left", "Down", "Right", "Over",
                "B", 1));


            questionpools.Add(new Questionpool(
    "Which continent is the largest by land area?",
    "Africa", "Asia", "Europe", "South America",
    "B", 2));

            questionpools.Add(new Questionpool(
                "What is the main gas found in Earth's atmosphere?",
                "Oxygen", "Carbon dioxide", "Nitrogen", "Hydrogen",
                "C", 2));

            questionpools.Add(new Questionpool(
                "Who painted the Mona Lisa?",
                "Leonardo da Vinci", "Michelangelo", "Van Gogh", "Picasso",
                "A", 2));

            questionpools.Add(new Questionpool(
                "How many bones are in the adult human body?",
                "106", "206", "250", "300",
                "B", 2));

            questionpools.Add(new Questionpool(
                "What is the capital city of Japan?",
                "Osaka", "Kyoto", "Tokyo", "Nagoya",
                "C", 2));

            questionpools.Add(new Questionpool(
                "Which natural disaster is measured with the Richter scale?",
                "Tornado", "Earthquake", "Flood", "Hurricane",
                "B", 2));

            questionpools.Add(new Questionpool(
                "What is the process by which plants make food?",
                "Digestion", "Photosynthesis", "Respiration", "Absorption",
                "B", 2));

            questionpools.Add(new Questionpool(
                "Which organ pumps blood throughout the body?",
                "Lungs", "Kidney", "Heart", "Liver",
                "C", 2));

            questionpools.Add(new Questionpool(
                "Which metal is liquid at room temperature?",
                "Iron", "Gold", "Mercury", "Copper",
                "C", 2));

            questionpools.Add(new Questionpool(
                "What is the hardest natural substance on Earth?",
                "Diamond", "Steel", "Quartz", "Granite",
                "A", 2));

            questionpools.Add(new Questionpool(
                "What is the nearest star to Earth?",
                "Sirius", "Alpha Centauri", "Sun", "Polaris",
                "C", 2));

            questionpools.Add(new Questionpool(
                "Which country has the largest population?",
                "India", "USA", "China", "Indonesia",
                "A", 2));

            questionpools.Add(new Questionpool(
                "What instrument measures air pressure?",
                "Thermometer", "Barometer", "Hygrometer", "Anemometer",
                "B", 2));

            questionpools.Add(new Questionpool(
                "Which vitamin is produced when sunlight hits the skin?",
                "Vitamin A", "Vitamin B", "Vitamin C", "Vitamin D",
                "D", 2));

            questionpools.Add(new Questionpool(
                "Which planet is known as the Red Planet?",
                "Mars", "Venus", "Saturn", "Mercury",
                "A", 2));

            questionpools.Add(new Questionpool(
                "How many chambers does the human heart have?",
                "2", "3", "4", "5",
                "C", 2));

            questionpools.Add(new Questionpool(
                "What is the currency of the United Kingdom?",
                "Euro", "Pound Sterling", "Dollar", "Franc",
                "B", 2));

            questionpools.Add(new Questionpool(
                "Which of these is a renewable energy source?",
                "Coal", "Oil", "Solar", "Natural Gas",
                "C", 2));

            questionpools.Add(new Questionpool(
                "Which planet has rings around it?",
                "Mercury", "Mars", "Saturn", "Venus",
                "C", 2));

            questionpools.Add(new Questionpool(
                "Which ocean lies between Africa and Australia?",
                "Atlantic", "Arctic", "Indian", "Pacific",
                "C", 2));

            questionpools.Add(new Questionpool(
                "What is the chemical symbol for Gold?",
                "Ag", "Au", "Pb", "Go",
                "B", 2));

            questionpools.Add(new Questionpool(
                "Which scientist proposed the three laws of motion?",
                "Einstein", "Galileo", "Newton", "Tesla",
                "C", 2));

            questionpools.Add(new Questionpool(
                "Which country invented paper?",
                "Egypt", "China", "Greece", "Persia",
                "B", 2));

            questionpools.Add(new Questionpool(
                "What is the largest internal organ in the human body?",
                "Heart", "Liver", "Lung", "Stomach",
                "B", 2));

            questionpools.Add(new Questionpool(
                "Which gas do plants absorb from the atmosphere?",
                "Oxygen", "Carbon dioxide", "Nitrogen", "Hydrogen",
                "B", 2));


            questionpools.Add(new Questionpool(
    "Which part of the cell contains genetic material?",
    "Cytoplasm", "Nucleus", "Mitochondria", "Ribosome",
    "B", 3));

            questionpools.Add(new Questionpool(
                "Who developed the theory of general relativity?",
                "Isaac Newton", "Albert Einstein", "Max Planck", "Niels Bohr",
                "B", 3));

            questionpools.Add(new Questionpool(
                "Which layer of Earth lies directly below the crust?",
                "Inner core", "Outer core", "Mantle", "Lithosphere",
                "C", 3));

            questionpools.Add(new Questionpool(
                "What is the smallest unit of life?",
                "Atom", "Molecule", "Cell", "Organ",
                "C", 3));

            questionpools.Add(new Questionpool(
                "Which gas is responsible for the greenhouse effect?",
                "Oxygen", "Carbon dioxide", "Nitrogen", "Argon",
                "B", 3));

            questionpools.Add(new Questionpool(
                "In which year did World War II end?",
                "1942", "1943", "1945", "1947",
                "C", 3));

            questionpools.Add(new Questionpool(
                "Which element has the atomic number 1?",
                "Helium", "Oxygen", "Hydrogen", "Carbon",
                "C", 3));

            questionpools.Add(new Questionpool(
                "What is the powerhouse of the cell?",
                "Ribosome", "Chloroplast", "Mitochondria", "Nucleus",
                "C", 3));

            questionpools.Add(new Questionpool(
                "Which scientist proposed the law of universal gravitation?",
                "Darwin", "Newton", "Galileo", "Pascal",
                "B", 3));

            questionpools.Add(new Questionpool(
                "Which blood type is known as the universal donor?",
                "A", "B", "AB", "O negative",
                "D", 3));

            questionpools.Add(new Questionpool(
                "Which continent has the most countries?",
                "Europe", "Asia", "Africa", "South America",
                "C", 3));

            questionpools.Add(new Questionpool(
                "What is the chemical formula for table salt?",
                "H2O", "CO2", "NaCl", "KCl",
                "C", 3));

            questionpools.Add(new Questionpool(
                "Which planet has the most moons?",
                "Jupiter", "Saturn", "Uranus", "Neptune",
                "B", 3));

            questionpools.Add(new Questionpool(
                "Which civilization built Machu Picchu?",
                "Aztecs", "Mayans", "Incas", "Olmecs",
                "C", 3));

            questionpools.Add(new Questionpool(
                "What do we call animals that eat both plants and meat?",
                "Herbivores", "Carnivores", "Omnivores", "Detritivores",
                "C", 3));

            questionpools.Add(new Questionpool(
                "What is the longest river in the world?",
                "Amazon River", "Nile River", "Yangtze River", "Congo River",
                "A", 3));

            questionpools.Add(new Questionpool(
                "Which scientist discovered penicillin?",
                "Alexander Fleming", "Marie Curie", "Louis Pasteur", "Gregor Mendel",
                "A", 3));

            questionpools.Add(new Questionpool(
                "What is the largest desert in the world?",
                "Sahara", "Gobi", "Antarctic Desert", "Arabian Desert",
                "C", 3));

            questionpools.Add(new Questionpool(
                "What type of energy is stored in a stretched spring?",
                "Thermal", "Kinetic", "Elastic potential", "Chemical",
                "C", 3));

            questionpools.Add(new Questionpool(
                "Which organ in the human body is primarily responsible for detoxification?",
                "Heart", "Kidney", "Liver", "Pancreas",
                "C", 3));


            questionpools.Add(new Questionpool(
    "Which law states that the pressure of a gas is inversely proportional to its volume at constant temperature?",
    "Boyle's Law", "Charles's Law", "Avogadro's Law", "Newton's Law",
    "A", 4));

            questionpools.Add(new Questionpool(
                "Which structure in the brain is responsible for balance and coordination?",
                "Cerebrum", "Cerebellum", "Medulla oblongata", "Hypothalamus",
                "B", 4));

            questionpools.Add(new Questionpool(
                "What is the main function of red blood cells?",
                "Fight infections", "Transport oxygen", "Produce hormones", "Store nutrients",
                "B", 4));

            questionpools.Add(new Questionpool(
                "Which phenomenon explains the bending of light as it passes through different mediums?",
                "Reflection", "Refraction", "Diffraction", "Interference",
                "B", 4));

            questionpools.Add(new Questionpool(
                "What is the approximate age of the Earth?",
                "1.2 billion years", "2.5 billion years", "4.5 billion years", "6.5 billion years",
                "C", 4));

            questionpools.Add(new Questionpool(
                "Which mathematical concept describes a quantity with both magnitude and direction?",
                "Scalar", "Vector", "Matrix", "Tensor",
                "B", 4));

            questionpools.Add(new Questionpool(
                "Which blood vessels carry blood back to the heart?",
                "Arteries", "Veins", "Capillaries", "Arterioles",
                "B", 4));

            questionpools.Add(new Questionpool(
                "In which layer of the atmosphere does most weather occur?",
                "Stratosphere", "Mesosphere", "Troposphere", "Thermosphere",
                "C", 4));

            questionpools.Add(new Questionpool(
                "Which organelle is responsible for protein synthesis?",
                "Golgi apparatus", "Ribosome", "Lysosome", "Vacuole",
                "B", 4));

            questionpools.Add(new Questionpool(
                "What type of rock is formed from cooled magma or lava?",
                "Sedimentary", "Igneous", "Metamorphic", "Basaltic",
                "B", 4));

            questionpools.Add(new Questionpool(
                "Which philosopher wrote 'The Republic'?",
                "Aristotle", "Plato", "Socrates", "Descartes",
                "B", 4));

            questionpools.Add(new Questionpool(
                "Which physics principle states that no two electrons can have the same set of quantum numbers?",
                "Heisenberg uncertainty principle", "Pauli exclusion principle", "Hooke's law", "Gauss's law",
                "B", 4));


            questionpools.Add(new Questionpool(
    "Which particle is responsible for mediating the electromagnetic force?",
    "Gluon", "Photon", "W boson", "Z boson",
    "B", 5));

            questionpools.Add(new Questionpool(
                "In economics, what term describes a market structure with only one seller?",
                "Oligopoly", "Monopoly", "Perfect competition", "Duopoly",
                "B", 5));

            questionpools.Add(new Questionpool(
                "Which branch of mathematics deals with the study of change and motion?",
                "Algebra", "Calculus", "Topology", "Number Theory",
                "B", 5));

            questionpools.Add(new Questionpool(
                "What is the primary function of the mitochondria in eukaryotic cells?",
                "Protein synthesis", "ATP production", "Genetic storage", "Ion transport",
                "B", 5));

            questionpools.Add(new Questionpool(
                "Which theory describes the behavior of very small particles at the quantum scale?",
                "Special relativity", "Quantum mechanics", "String theory", "Chaos theory",
                "B", 5));

            questionpools.Add(new Questionpool(
                "What is the term for an organism’s observable characteristics?",
                "Genotype", "Phenotype", "Allele", "Trait set",
                "B", 5));

            questionpools.Add(new Questionpool(
                "Which branch of physics studies the deformation and motion of objects under applied forces?",
                "Optics", "Mechanics", "Thermodynamics", "Electrodynamics",
                "B", 5));

            questionpools.Add(new Questionpool(
                "Which mathematical function describes exponential decay?",
                "f(x) = ax^2", "f(x) = e^-x", "f(x) = ln(x)", "f(x) = 1/x",
                "B", 5));


            questionpools.Add(new Questionpool(
    "According to quantum mechanics, which principle states that certain pairs of physical properties cannot be known simultaneously with arbitrary precision?",
    "Superposition principle", "Uncertainty principle", "Correspondence principle", "Exclusion principle",
    "B", 6));

            questionpools.Add(new Questionpool(
                "In advanced mathematics, which field studies sets with infinitely many dimensions, such as function spaces?",
                "Linear algebra", "Real analysis", "Functional analysis", "Abstract algebra",
                "C", 6));

            questionpools.Add(new Questionpool(
                "Which cosmological model proposes that the universe expanded extremely rapidly immediately after the Big Bang?",
                "Steady-state theory", "Inflation theory", "Oscillating universe theory", "Quantum foam model",
                "B", 6));

            questionpools.Add(new Questionpool(
                "What is the name of the mathematical method used to approximate integrals, particularly in quantum field theory?",
                "Laplace transform", "Fourier series", "Path integral formulation", "Taylor expansion",
                "C", 6));

            questionpools.Add(new Questionpool(
                "Which concept in computer science describes problems for which solutions can be verified in polynomial time, but may not be solvable in polynomial time?",
                "P class", "NP class", "Decidable problems", "Turing-complete problems",
                "B", 6));



            questionpools.Add(new Questionpool(
                "Who wrote the play 'Romeo and Juliet'?",
                "Charles Dickens", "Mark Twain", "William Shakespeare", "Oscar Wilde",
                "C", 1));

            questionpools.Add(new Questionpool(
                "Which genre features magical elements and imaginary worlds?",
                "Mystery", "Fantasy", "Biography", "Poetry",
                "B", 1));

            questionpools.Add(new Questionpool(
                "What do we call a short story that teaches a moral lesson?",
                "Novel", "Fable", "Drama", "Essay",
                "B", 1));

            questionpools.Add(new Questionpool(
                "Which of the following is a type of poem?",
                "Sonnet", "Chapter", "Stanza", "Article",
                "A", 1));



            questionpools.Add(new Questionpool(
                "Who is the author of '1984'?",
                "George Orwell", "Aldous Huxley", "F. Scott Fitzgerald", "Ernest Hemingway",
                "A", 2));

            questionpools.Add(new Questionpool(
                "Which country did the poet Rumi originally come from?",
                "Italy", "Persia", "India", "Spain",
                "B", 2));

            questionpools.Add(new Questionpool(
                "Which book begins with the line 'Call me Ishmael'?",
                "Moby-Dick", "The Great Gatsby", "Frankenstein", "Dracula",
                "A", 2));

            questionpools.Add(new Questionpool(
                "Which literary device gives human traits to non-human things?",
                "Metaphor", "Irony", "Personification", "Alliteration",
                "C", 2));



            questionpools.Add(new Questionpool(
                "Which author wrote 'Pride and Prejudice'?",
                "Jane Austen", "Emily Brontë", "Virginia Woolf", "Charlotte Brontë",
                "A", 3));

            questionpools.Add(new Questionpool(
                "What is the central theme of the novel 'The Catcher in the Rye'?",
                "War and peace", "Adolescent alienation", "Political corruption", "Family heritage",
                "B", 3));

            questionpools.Add(new Questionpool(
                "Which Shakespeare play features the characters Rosencrantz and Guildenstern?",
                "Macbeth", "Othello", "Hamlet", "King Lear",
                "C", 3));

            questionpools.Add(new Questionpool(
                "Which literary movement emphasized emotion, nature, and individualism?",
                "Realism", "Romanticism", "Modernism", "Naturalism",
                "B", 3));



            questionpools.Add(new Questionpool(
                "Which dystopian novel features the oppressive state of Gilead?",
                "Brave New World", "The Handmaid's Tale", "Fahrenheit 451", "Animal Farm",
                "B", 4));

            questionpools.Add(new Questionpool(
                "In Greek mythology, who is the muse of epic poetry?",
                "Calliope", "Erato", "Thalia", "Urania",
                "A", 4));

            questionpools.Add(new Questionpool(
                "In literary analysis, what does 'stream of consciousness' refer to?",
                "A realistic narrative style", "A chronological life story",
                "A flow of inner thoughts", "A historical overview",
                "C", 4));

            questionpools.Add(new Questionpool(
                "Who wrote the epic poem 'Paradise Lost'?",
                "Geoffrey Chaucer", "John Milton", "John Donne", "Christopher Marlowe",
                "B", 4));



            questionpools.Add(new Questionpool(
                "Which modernist novel is known for its complex structure and takes place entirely in one day?",
                "Mrs Dalloway", "Ulysses", "The Sound and the Fury", "To the Lighthouse",
                "B", 5));

            questionpools.Add(new Questionpool(
                "Which philosophy heavily influenced existentialist literature, particularly the works of Sartre and Camus?",
                "Stoicism", "Absurdism", "Idealism", "Marxism",
                "B", 5));



            questionpools.Add(new Questionpool(
                "Which post-structuralist theorist introduced the concept of 'deconstruction' in literary criticism?",
                "Michel Foucault", "Jacques Derrida", "Roland Barthes", "Noam Chomsky",
                "B", 6));

            questionpools.Add(new Questionpool(
                "In narratology, what term describes a narrative that disrupts chronological order to reveal hidden psychological meaning?",
                "Metalepsis", "Anachrony", "Focalization", "Palimpsest",
                "B", 6));

            questionpools.Add(new Questionpool(
    "Which country is the largest by total land area?",
    "Russia", "Canada", "China", "United States",
    "A", 1));

            questionpools.Add(new Questionpool(
                "Which invention is Thomas Edison most famous for improving?",
                "Telephone", "Light bulb", "Radio", "Television",
                "B", 1));

            questionpools.Add(new Questionpool(
                "Which continent is the Sahara Desert located on?",
                "Asia", "Africa", "Australia", "South America",
                "B", 1));

            questionpools.Add(new Questionpool(
                "What is the currency of Japan?",
                "Won", "Yuan", "Yen", "Ringgit",
                "C", 2));

            questionpools.Add(new Questionpool(
                "Who painted the ceiling of the Sistine Chapel?",
                "Leonardo da Vinci", "Michelangelo", "Raphael", "Donatello",
                "B", 2));

            questionpools.Add(new Questionpool(
                "Which scientist proposed the three laws of motion?",
                "Albert Einstein", "Isaac Newton", "Galileo Galilei", "Niels Bohr",
                "B", 2));

            questionpools.Add(new Questionpool(
                "Which ocean is the deepest point on Earth located in?",
                "Atlantic Ocean", "Pacific Ocean", "Indian Ocean", "Arctic Ocean",
                "B", 3));

            questionpools.Add(new Questionpool(
                "Machu Picchu was built by which ancient civilization?",
                "Aztecs", "Mayans", "Incas", "Olmecs",
                "C", 3));

            questionpools.Add(new Questionpool(
                "Which ancient text is considered the foundation of Western philosophy?",
                "The Republic", "Meditations", "The Iliad", "Politics",
                "A", 3));

            questionpools.Add(new Questionpool(
                "Which nation was the first to send a human into space?",
                "United States", "Soviet Union", "China", "France",
                "B", 4));

            questionpools.Add(new Questionpool(
                "Which African country was formerly known as Abyssinia?",
                "Sudan", "Ethiopia", "Eritrea", "Somalia",
                "B", 4));

            questionpools.Add(new Questionpool(
                "What is the longest river in Europe?",
                "Danube", "Volga", "Rhine", "Dnieper",
                "B", 4));

            questionpools.Add(new Questionpool(
                "In Greek mythology, who is the god of the underworld?",
                "Ares", "Hades", "Apollo", "Hermes",
                "B", 4));

            questionpools.Add(new Questionpool(
                "Which empire built the Hagia Sophia in its original form?",
                "Ottoman Empire", "Roman Empire", "Byzantine Empire", "Persian Empire",
                "C", 5));

            questionpools.Add(new Questionpool(
                "Which ancient philosopher taught Alexander the Great?",
                "Socrates", "Plato", "Aristotle", "Zeno",
                "C", 5));

            questionpools.Add(new Questionpool(
                "What is the second-highest mountain in the world?",
                "K2", "Kangchenjunga", "Lhotse", "Makalu",
                "A", 5));

            questionpools.Add(new Questionpool(
                "The Rosetta Stone was crucial in deciphering which ancient writing system?",
                "Cuneiform", "Hieroglyphs", "Linear B", "Runes",
                "B", 6));

            questionpools.Add(new Questionpool(
                "Which civilization is known for creating the first known legal code?",
                "Hittites", "Sumerians", "Babylonians", "Assyrians",
                "C", 6));

            questionpools.Add(new Questionpool(
                "Which medieval Islamic scholar is known as the 'father of algebra'?",
                "Al-Ghazali", "Ibn Sina", "Al-Kindi", "Al-Khwarizmi",
                "D", 6));

            questionpools.Add(new Questionpool(
                "The term ‘Renaissance’ originated from which language?",
                "Latin", "French", "Italian", "Greek",
                "B", 6));



        }

        private void shownewquestion(Questionpool currentquestion)
        {

            RollDice.Enabled = false;

            richTextBoxSorumetni.Text = currentquestion.questiontext;


            buttonA.Text = currentquestion.answerA;
            buttonB.Text = currentquestion.answerB;
            buttonC.Text = currentquestion.answerC;
            buttonD.Text = currentquestion.answerD;

            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;





        }

        private void checkanswer(string selected)
        {
            if (currentquestion == null)
                return;

            if (selected == currentquestion.trueanswer)
            {
                MessageBox.Show("correct answer roll dice again");

                labelA.Visible = false;
                labelB.Visible = false;
                labelC.Visible = false;
                labelD.Visible = false;

                labelApercent.Visible = false;
                labelBpercent.Visible = false;
                labelCpercent.Visible = false;
                labelDpercent.Visible = false;

                progressBarA.Visible = false;
                progressBarB.Visible = false;
                progressBarC.Visible = false;
                progressBarD.Visible = false;

                int point = score(currentquestion.difficultylevel);

                totalscore += point;

                labelpoint.Text = "Total Score " + totalscore.ToString();

                checkpointcounter++;

                if (checkpointcounter % 5 == 0)
                    checkpoint = totalscore;

                labelcheckpointpoint.Text = "Checkpoint " + checkpoint.ToString();

                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;

                pictureBox50joker.Enabled = false;
                pictureBoxspectatorjoker.Enabled = false;
                pictureBoxquestionchangejoker.Enabled = false;

                RollDice.Enabled = true;

                // update solved counts immediately
                questioncounter++;
                CurrentUser.SolvedQuestions++;              // persist player's solved count as they answer
                CheckAndShowAchievements();                 // check thresholds and show toast(s) immediately

                // optionally persist solved count (achievements already persisted inside CheckAndShowAchievements)
                UserDatabase.UpdateUser(CurrentUser);
            }

            else
            {
                MessageBox.Show("wrong answer,game over you get " + checkpoint + " point");
                HandleGameOver(checkpoint);


                this.Close();   // burda ana menüye dönme kodu gelecek þu an olmadýðý için kapatýyor. 
            }
        }

        private void labelpoint_Click(object sender, EventArgs e)
        {

        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            checkanswer("B");
        }

        private int score(int difficultylevel)
        {
            int score = 0;
            switch (difficultylevel)
            {
                case 1:
                    score = 100;
                    break;
                case 2:
                    score = 300;
                    break;
                case 3:
                    score = 1000;
                    break;
                case 4:
                    score = 3000;
                    break;
                case 5:
                    score = 10000;
                    break;
                case 6:
                    score = 25000;
                    break;
                default:
                    break;

            }
            return score;
        }

        private void HandleGameOver(int finalScoreToSave)
        {
            // 1. Check for New High Score
            if (finalScoreToSave > CurrentUser.highScore)
            {
                CurrentUser.highScore = finalScoreToSave;
                MessageBox.Show($"Tebrikler! Yeni Yüksek Skor: {CurrentUser.highScore}!", "Yüksek Skor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CurrentUser.TotalScore += finalScoreToSave;
            CurrentUser.TotalPlay += 1;
            CurrentUser.AverageScore = CurrentUser.TotalScore / CurrentUser.TotalPlay;
            CurrentUser.SolvedQuestions += questioncounter;

            // 2. Save the User Object
            UserDatabase.UpdateUser(CurrentUser); // Assumes we implemented this method

            // 3. Return to Main Menu (pass the updated CurrentUser object)
            Anamenü anaMenu = new Anamenü(CurrentUser);
            anaMenu.Show();
        }

        private void labelcheckpointpoint_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Add this helper method inside the Questionscreen class (near other helper methods)
        private void CheckAndShowAchievements()
        {
            // thresholds and corresponding messages
            int[] thresholds = new[] { 1, 5, 10, 50, 100, 300 };
            string[] messages = new[]
            {
        "The Beginning! (Solve 1 Question)",
        "Getting Started! (Solve 5 Questions)",
        "On a Roll! (Solve 10 Questions)",
        "50 Shades of Knowledge! (Solve 50 Questions)",
        "Century Club! (Solve 100 Questions)",
        "Quiz Master! (Solve 300 Questions)"
    };
            var unlocked = CurrentUser.UnlockedAchievements;
            for (int i = 0; i < thresholds.Length && i < unlocked.Length; i++)
            {
                if (unlocked[i] == 0 && CurrentUser.SolvedQuestions >= thresholds[i])
                {
                    unlocked[i] = 1;
                    CurrentUser.AchievementUnlockedDate[i] = (int)DateTimeOffset.Now.ToUnixTimeSeconds();
                    // show the popup immediately, positioned relative to this form
                    AchievementEarnedPopup.ShowPopup(this, "Achievement Unlocked", messages[i]);
                    // persist change
                    UserDatabase.UpdateUser(CurrentUser);
                }
            }

            // making sure the in-memory array is kept
            CurrentUser.UnlockedAchievements = unlocked;

        }

        private void rollingdicetimer_Tick(object sender, EventArgs e)
        {
            animCount++;

            Random rastgele = new Random();

            int zarSonucu = rastgele.Next(1, 7);

            switch (zarSonucu)
            {
                case 1:
                    pictureBoxdice.Image = Image.FromFile("jokerler/zar1.jpg");
                    break;
                case 2:
                    pictureBoxdice.Image = Image.FromFile("jokerler/zar2.jpg");
                    break;
                case 3:
                    pictureBoxdice.Image = Image.FromFile("jokerler/zar3.jpg");
                    break;
                case 4:
                    pictureBoxdice.Image = Image.FromFile("jokerler/zar4.jpg");
                    break;
                case 5:
                    pictureBoxdice.Image = Image.FromFile("jokerler/zar5.jpg");
                    break;
                case 6:
                    pictureBoxdice.Image = Image.FromFile("jokerler/zar6.jpg");
                    break;
            }

            if (animCount >= 15)
            {
                rollingdicetimer.Stop();

                int finalResult = rastgele.Next(1, 7);

                switch (finalResult)
                {
                    case 1:
                        pictureBoxdice.Image = Image.FromFile("jokerler/zar1.jpg");
                        break;
                    case 2:
                        pictureBoxdice.Image = Image.FromFile("jokerler/zar2.jpg");
                        break;
                    case 3:
                        pictureBoxdice.Image = Image.FromFile("jokerler/zar3.jpg");
                        break;
                    case 4:
                        pictureBoxdice.Image = Image.FromFile("jokerler/zar4.jpg");
                        break;
                    case 5:
                        pictureBoxdice.Image = Image.FromFile("jokerler/zar5.jpg");
                        break;
                    case 6:
                        pictureBoxdice.Image = Image.FromFile("jokerler/zar6.jpg");
                        break;
                }
                labeldifficulty.Text = "Difficulty: " + finalResult;

                var suitablequestions = questionpools
                .Where(m => m.difficultylevel == finalResult)
                .ToList();

                if (suitablequestions.Count() == 0)
                {
                    MessageBox.Show("No more questions this level");
                }

                currentquestion = suitablequestions[rastgele.Next(suitablequestions.Count)];

                questionpools.Remove(currentquestion);

                shownewquestion(currentquestion);
            }
        }
    }
}