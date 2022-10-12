namespace AutoMapperExampleApi.Models
{
    public class UserInfoDto
    {
        public string? FullName { get; set; }
        public string? Status { get; set; }

        public enum UserStatusEnum
        {
            Active = 0,
            Pending = 1,
            Passive = 2
        }
    }
}
