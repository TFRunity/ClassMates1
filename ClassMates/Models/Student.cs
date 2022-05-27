namespace ClassMates.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; } 
        public string? Description { get; set; } 
        public int Memetr { get; set; }
        public DateTime DateBirth { get; set; } 
        public Stand? Stand { get; set; }
        public List<string>? Img { get; set; } 
        public string? MainImg { get; set; } 
        public string? FutureJob { get; set; }
        public string? ImgLink { get; set; } 
    }
}
