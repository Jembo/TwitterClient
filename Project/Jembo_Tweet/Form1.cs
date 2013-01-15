using System;
using System.Windows.Forms;
using Twitterizer;

namespace Jembo_Tweet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void button1_Click(object sender, EventArgs e)
        {
            TweetIt.SendTweet(richTextBox1.Text);
            GC.Collect(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimelineOptions tloptions = new TimelineOptions();
            tloptions.Count = 3;
            for(int count =0; count <tloptions.Count; count++)
            {
                richTextBox2.Text += "\n****\n@" + TwitterTimeline.HomeTimeline(Tokens.tokens, tloptions).ResponseObject[count].User.ScreenName.ToString() +": " +TwitterTimeline.HomeTimeline(Tokens.tokens, tloptions).ResponseObject[count].CreatedDate.TimeOfDay.ToString();
                richTextBox2.Text += "\n" +TwitterTimeline.HomeTimeline(Tokens.tokens, tloptions).ResponseObject[count].Text.ToString();
                richTextBox2.Refresh();
            }            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(140 - richTextBox1.Text.Length);
            if (richTextBox1.Text.Length > 140)
            {
                label1.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(140 - richTextBox1.Text.Length);
        }



    }
}