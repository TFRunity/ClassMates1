namespace ClassMates.Models
{
    public class Student
    {
        public int id { get; set; }
        public string Name { get; set; } = "Коля";
        public string Description { get; set; } = "Без";
        public int Memetr { get; set; }
        public string DateBirth { get; set; } 
        public Stand? Stand { get; set; }
        public List<string> Img { get; set; } = new List<string>() { "", "" };
        public string MainImg { get; set; } = "";
        public string FutureJob { get; set; }
        public string ImgLink { get; set; } = "";
    }
}
