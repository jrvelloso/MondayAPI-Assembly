namespace Monday.Models
{
    public class Job : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //public string ManagerName { get; set; } //ToDoMonday (OPTIONAL) // this is a N:N  situation.... if you want to try creating them... be my guest :)
                                                // tip: there will be a table connecting Job and Manager
    }
}
