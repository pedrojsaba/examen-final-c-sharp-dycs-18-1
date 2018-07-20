using System;

namespace ExamenFinal
{
    public class Sharer
    {
        RedditPoster redditPoster = new RedditPoster();

        public void ShareEveryWhere(string message)
        {
            foreach (SharerType sharerType in Enum.GetValues(typeof(SharerType)))
            {
                Sharing sharer = SharerFactory.Instance.GetSharer(sharerType);
                if (sharer != null)
                {
                    sharer.Share(message);
                }
            }
            //Also share on Reddit
            redditPoster.Post(message);
        }

        public void Share(string message, SharerType sharerType)
        {
            if (sharerType == SharerType.Reddit)
            {
                redditPoster.Post(message);
            }
            else
            {
                Sharing sharer = SharerFactory.Instance.GetSharer(sharerType);
                sharer.Share(message);
            }
        }
    }
}