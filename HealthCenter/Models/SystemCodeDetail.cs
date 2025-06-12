namespace HealthCenter.Models
{
    public class SystemCodeDetail : UserCreateActivity
    {
        public int Id {  get; set; }
        public int SystemCodeId { get; set; }
        public string Code { get; set; }

        public string Description {  get; set; }

        public int OrderNum {  get; set; }
        public SystemCode SystemCode { get; set; }
    }
}
