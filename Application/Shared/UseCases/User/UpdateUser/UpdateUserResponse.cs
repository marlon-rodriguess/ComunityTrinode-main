namespace Trinode.Application.UseCases.UpdateUser
{
    public sealed class UpdateUserResponse 
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}

