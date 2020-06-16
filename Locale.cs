namespace 지역_검색
{
    public class Locale
    {
        public string Title { get; private set; }

        public string Lat { get; set; }

        public string Lng { get; set; }

        public Locale(string title, string lat, string lng)
        {
            Title = title;
            Lat = lat;
            Lng = lng;
        }
        public override string ToString()
        {
            return Title;
        }
    }
}