namespace LearningEFCore.Models
{
    public class ToDo : BaseEntity
    {
        public string Text { get; set; }
        public bool Completed { get; set; }
    }
}