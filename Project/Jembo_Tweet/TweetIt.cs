using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Twitterizer;

namespace Jembo_Tweet
{
    public static class TweetIt
    {
        public static void SendTweet(string message)
        {
            try
            {
                TwitterResponse<TwitterStatus> tweetResponse = TwitterStatus.Update(Tokens.tokens, message);
                if (tweetResponse.Result == RequestResult.Success)
                {
                    MessageBox.Show("Твит добавлен!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
