namespace ExamenFinal
{
    class SharerFactory
    {
        private SharerFactory()
        {
        }

        public static SharerFactory Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested
        {
            static Nested()
            {
            }

            internal static readonly SharerFactory instance = new SharerFactory();
        }

        public Sharing GetSharer(SharerType sharerType)
        {
            Sharing sharing = null;
            switch (sharerType)
            {
                case SharerType.Facebook: sharing = new FacebookSharer(); break;
                case SharerType.Twitter: sharing = new TwitterSharer(); break;
                default: break;
            }
            return sharing;
        }
    }
}