using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace SpeechRecognition
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer voice = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Choices Reference (compare -> spoke voice)
            Choices command = new Choices();
            command.Add(new string[] {"Hello World", "Open Notepad", "Hi", "Time Check", "Print My Name", "Open Facebook" });

            GrammarBuilder gbuilder = new GrammarBuilder(); //Build Grammar

            gbuilder.Append(command); //Append The Command

            Grammar grammar = new Grammar(gbuilder); //Initialize Grammar

            recEngine.LoadGrammarAsync(grammar); //Load The Grammar To The Speech Recognition Engine

            recEngine.SetInputToDefaultAudioDevice(); //Select Input Device (microphone)

            recEngine.SpeechRecognized += RecEngine_SpeechRecognized; //Event Handler
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void EnableBtn_Click(object sender, EventArgs e)
        {
            DisableBtn.Enabled = true;
            recEngine.RecognizeAsync( RecognizeMode.Multiple); //Enable Voice Recognition
            EnableBtn.Enabled = false;
        }


        private void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            Console.WriteLine(e.Result.Text);

            switch (e.Result.Text)
            {
                case "Hello World":
                    MessageBox.Show("Hello World");
                    break;

                case "Hi":
                    voice.SpeakAsync("Hello Master");
                    break;

                case "Print My Name":
                    richTextBox1.Text += "\n \t Rolando A. Goloya Jr.";
                    break;

                case "Time Check":
                    MessageBox.Show("Time: " + DateTime.Now.ToString("h:m:s"));
                    break;

                case "Open Facebook":
                    System.Diagnostics.Process.Start("https://www.facebook.com");
                    break;

                case "Open Notepad":
                    System.Diagnostics.Process.Start("Notepad.exe");
                    break;

            }
        }

        private void DisableBtn_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            EnableBtn.Enabled = true;
            DisableBtn.Enabled= false;
        }

        private void LabelCommandList_Click(object sender, EventArgs e)
        {

        }
    }
}
