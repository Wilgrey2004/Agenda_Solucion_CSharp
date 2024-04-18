namespace C_Entidades
{
    public class SimpleUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public SimpleUser(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public SimpleUser()
        {
            
        }

    }
}
