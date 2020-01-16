using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Question> questions = new List<Question>();
        private Random rnd = new Random();
        int level = 0;
        Question currentQuestion;

        public Button[] btns;

        public Form1()
        {
            InitializeComponent();

            btns = new Button[]
            { btnAnswerA, btnAnswerB,
              btnAnswerC, btnAnswerD };

            ReadFile();
            startGame(); 
        }

        private void ReadFile()
        {
            string path = @"Вопросы.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    questions.Add(new Question(line.Split('\t')));
                }
            }
        }
        private void ShowQuestion(Question q)
        {
            lbQuestionText.Text = q.Text;
            for(int i = 0; i < btns.Length; i++)
                btns[i].Text = q.Answers[i];
        }

        private Question GetQuestion(int level)
        {
            var questionsWithLevel = questions.Where(q => q.Level == level).ToList();
            return questionsWithLevel[rnd.Next(questionsWithLevel.Count)];
        }

        private void NextStep()
        {
            foreach (Button btn in btns)
                btn.Enabled = true;

            level++;
            currentQuestion = GetQuestion(level);
            ShowQuestion(currentQuestion);
            listLevels.SelectedIndex = listLevels.Items.Count - level;
        }

        private void startGame()
        {
            level = 0;
            NextStep();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
                NextStep();
            else
            {
                MessageBox.Show("Неверный ответ!");
                startGame();
            }
        }

        private void bntFiftyFifty_Click(object sender, EventArgs e)
        {
            int count = 0;
            while (count < 2)
            {
                int n = rnd.Next(4);
                int answer = int.Parse(btns[n].Tag.ToString());

                if (answer != currentQuestion.RightAnswer && btns[n].Enabled)
                {
                    btns[n].Enabled = false;
                    count++;
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            int TotalWatchers = 100;

            Random rnd = new Random();

            float[] answer = new float[4];
            float sum = 0;
            for(int i = 0; i < btns.Length; i++)
            {
               if (i == currentQuestion.RightAnswer - 1) 
                    answer[i] = rnd.Next((int)(0 + (15+1-level)/(2*15- level) *100), (int)(100-(15+1- level) /(2*15- level) *100)) ;  
                    //answer[i] = rnd.Next((int)(100 - (15+1-level)/(2*15- level) *100), (int)(0+(15+1- level) /(2*15- level) *100)) ;  
               else
                    answer[i] = rnd.Next((int)(0 + (15 + 1 - level) / (2 * 15 - level) * 100), (int)(100- (15 + 1 - level) / (2 * 15 - level) * 100));

                sum += answer[i];
            }
            float s = 0;
            for (int i = 0; i < btns.Length; i++)
            {
                answer[i] = TotalWatchers * answer[i] / sum;

                s += answer[i];
            }

            MessageBox.Show($"{s}\n==\n{answer[0]}\n{answer[1]}\n{answer[2]}\n{answer[3]}\n"); 
        }

        private void btnFriendly_Click(object sender, EventArgs e)
        {

        }

        private void btnMarginError_Click(object sender, EventArgs e)
        {

        }

        private void btnReplaceQuest_Click(object sender, EventArgs e)
        {

        }
    }
}
