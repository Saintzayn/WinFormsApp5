namespace RollandKnow
{
    internal class Questionpool
    {
        public string questiontext { get; set; }

        public string answerA { get; set; }
        public string answerB { get; set; }
        public string answerC { get; set; }
        public string answerD { get; set; }

        public string trueanswer { get; set; }
        public int difficultylevel { get; set; }

        public int score { get; set; }

        public Questionpool(string question, string A, string B, string C, string D, string trueanswer, int difficulty)
        {
            this.questiontext = question;
            this.answerA = A;
            this.answerB = B;
            this.answerC = C;
            this.answerD = D;
            this.trueanswer = trueanswer;
            this.difficultylevel = difficulty;
        }

    }
}
