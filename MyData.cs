namespace 데이터_관리
{
    public class MyData
    {
        readonly int no;
        public int No {  get  { return no; } }
        public string Title { get; set; }
        public string Des { get; set; }
        public MyData(int no, string title, string des)
        {
            this.no = no;
            Title = title;
            Des = des;
        }
        public override string ToString()
        {
            return no.ToString();
        }
    }
}