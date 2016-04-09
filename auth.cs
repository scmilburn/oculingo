using System.Windows.Forms;
using LinqToTwitter;
 
namespace TrendingTopic
{
   public partial class Form1 : Form
   {
      private SingleUserAuthorizer authorizer =
         new SingleUserAuthorizer
      {
         CredentialStore =
            new SingleUserInMemoryCredentialStore
         {
            ConsumerKey =
                "BdQxSnT3t54Y0Ko3QnijviLFi",
            ConsumerSecret =
               "h8VrVXPyqoecnM3iwhuID8n0Vx0t6Vvcnfr48906ObCWrnpTF9",
            AccessToken =
               "605707646-Ks1JLdnU5ID5vYMyfxCrFxjIx20DHGe13WPTGES8",
            AccessTokenSecret =
               "XCZwrGBnmuZSzvz9DPbqzUXFiCZyzs7f5MwISaHg93why"
         }
      };
      
      private List<Status> currentTweets;

      public Form1()
      {
         InitializeComponent();

         GetMostRecent200HomeTimeLine();
         lstTweetList.Items.Clear();
         currentTweets.ForEach(tweet =>
            lstTweetList.Items.Add(tweet.Text));

      }

      private void GetMostRecent200HomeTimeLine()
      {
         var twitterContext = new TwitterContext(authorizer);
 
         var tweets = from tweet in twitterContext.Status
            where tweet.Type == StatusType.Home &&
            tweet.Count == 200
            select tweet;
 
         currentTweets = tweets.ToList();
      }
   }
}