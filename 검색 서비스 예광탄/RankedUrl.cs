namespace 검색_서비스_예광탄
{
    public class RankedUrl
    {
        public string Title
        {
            get;
            private set;
        }

        public string Url
        {
            get;
            private set;
        }

        public double Score
        {
            get;
            private set;
        }

        public string Content
        {
            get;
            private set;
        }
        public RankedUrl(string title, string url, double score, string content)
        {
            Title = title;
            Url = url;
            Score = score;
            Content = content;
        }

        public static RankedUrl Merge(RankedUrl r1, RankedUrl r2)
        {
            r1.Score += r2.Score;
            return r1;
        }
    }
}