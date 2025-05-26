using System.ComponentModel.DataAnnotations;

namespace restApi.DTOs{
public class RegisterDto
{[DataType(DataType.EmailAddress)]
    
    public string? Username { get; set; }
   
    [DataType(DataType.Password)]
    public string? Password { get; set; }
    public string[]? Roles { get; set; }
}

public class UserResponseDto
{
    public Guid Id { get; set; }
    public string? Username { get; set; }
    public string? DisplayName { get; set; }
    public DateTime RegisteredAt { get; set; }
}
}