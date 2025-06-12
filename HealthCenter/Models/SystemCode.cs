namespace HealthCenter.Models
{
    public class SystemCode : UserCreateActivity
    {
        public int Id {  get; set; }
        public string Code { get; set; }
        public string Description {get; set; }
        public int OrderNUm {  get; set; }

    }
}
