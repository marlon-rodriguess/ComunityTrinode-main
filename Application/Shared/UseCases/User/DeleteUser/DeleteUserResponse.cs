namespace Trinode.Application.UseCases.DeleteUser
{
    public sealed class DeleteUserResponse 
    {
        public Guid? id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}

