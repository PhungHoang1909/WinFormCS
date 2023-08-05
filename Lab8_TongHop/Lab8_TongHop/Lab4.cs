using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab8_TongHop
{
    public partial class Lab4 : Form
    {

        // variables list for this quiz game
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Lab4()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 8;



        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);




            if (buttonTag == correctAnswer)
            {
                score++;


            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage here
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);


                MessageBox.Show("Quiz Ended" + Environment.NewLine +
                                "You have answered " + score + " questions correcly" + Environment.NewLine +
                                "Your total percentage is " + percentage + " %" + Environment.NewLine +
                                "Click Ok to play again"

                    );

                score = 0;
                questionNumber = 0;

                askQuestion(questionNumber);
            }

            questionNumber++;

            askQuestion(questionNumber);



        }

        private void askQuestion(int qnum)
        {

            string filePath = @"D:\LTGD\Quiz-Game-Tutorial-Windows-Form-main\quizGame\test.txt";
            string[] lines = File.ReadAllLines(filePath);

            int startIndex = (qnum - 1) * 39;
            switch (qnum)
            {

                case 1:

                    pictureBox1.Image = Resource.questions;
                    lblQuestion.Text = lines[startIndex*0];

                    button1.Text = lines[startIndex*0 + 1];
                    button2.Text = lines[startIndex*0 + 2];
                    button3.Text = lines[startIndex*0 + 3];
                    button4.Text = lines[startIndex*0 + 4];

                    correctAnswer = 4;

                    break;
                case 2:
                    pictureBox1.Image = Resource.questions;
                    lblQuestion.Text = lines[startIndex*0 + 5];

                    button1.Text = lines[startIndex*0 + 6 ];
                    button2.Text = lines[startIndex*0 + 7 ];
                    button3.Text = lines[startIndex*0 + 8 ];
                    button4.Text = lines[startIndex*0 + 9 ];

                    correctAnswer = 2;

                    break;

                case 3:

                    pictureBox1.Image = Resource.fortnite;

                    lblQuestion.Text = lines[startIndex * 0 + 10];

                    button1.Text = lines[startIndex * 0 + 11];
                    button2.Text = lines[startIndex * 0 + 12];
                    button3.Text = lines[startIndex * 0 + 13];
                    button4.Text = lines[startIndex * 0 + 14];

                    correctAnswer = 1;

                    break;

                case 4:

                    pictureBox1.Image = Resource.questions;

                    lblQuestion.Text = lines[startIndex * 0 + 15];

                    button1.Text = lines[startIndex * 0 + 16];
                    button2.Text = lines[startIndex * 0 + 17];
                    button3.Text = lines[startIndex * 0 + 18];
                    button4.Text = lines[startIndex * 0 + 19];

                    correctAnswer = 2;

                    break;

                case 5:

                    pictureBox1.Image = Resource.gears_of_war;

                    lblQuestion.Text = lines[startIndex * 0 + 20];

                    button1.Text = lines[startIndex * 0 + 21];
                    button2.Text = lines[startIndex * 0 + 22];
                    button3.Text = lines[startIndex * 0 + 23];
                    button4.Text = lines[startIndex * 0 + 24];

                    correctAnswer = 1;

                    break;

                case 6:

                    pictureBox1.Image = Resource.halo;

                    lblQuestion.Text = lines[startIndex * 0 + 25];

                    button1.Text = lines[startIndex * 0 + 26];
                    button2.Text = lines[startIndex * 0 + 27];
                    button3.Text = lines[startIndex * 0 + 28];
                    button4.Text = lines[startIndex * 0 + 29];

                    correctAnswer = 1;

                    break;

                case 7:

                    pictureBox1.Image = Resource.csgo;

                    lblQuestion.Text = lines[startIndex * 0 + 30];

                    button1.Text = lines[startIndex * 0 + 31];
                    button2.Text = lines[startIndex * 0 + 32];
                    button3.Text = lines[startIndex * 0 + 33];
                    button4.Text = lines[startIndex * 0 + 34];

                    correctAnswer = 1;

                    break;

                case 8:

                    pictureBox1.Image = Resource.witcher3;

                    lblQuestion.Text = lines[startIndex * 0 + 35];

                    button1.Text = lines[startIndex * 0 + 36];
                    button2.Text = lines[startIndex * 0 + 37];
                    button3.Text = lines[startIndex * 0 + 38];
                    button4.Text = lines[startIndex * 0 + 39];

                    correctAnswer = 1;

                    break;



            }




        }

    }
}
