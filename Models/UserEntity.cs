namespace CodeFirstRelation.Models
{
    public class UserEntity
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public List<PostEntity> Post { get; set; }
    }
}
