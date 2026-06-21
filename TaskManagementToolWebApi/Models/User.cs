using System.ComponentModel.DataAnnotations;
using TaskManagementToolWebApi.Models;

public class User
{
    [Key]
    public int UserId { get; set; }

    [Required, MaxLength(100)]
    public string Name { get; set; }

    [Required, EmailAddress]
    public string Email { get; set; }

    [Required]
    public string PasswordHash { get; set; }

    [Required]
    public UserRole Role { get; set; } = UserRole.Member;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public bool IsActive { get; set; } = true;

    public List<TaskItem> Tasks { get; set; } = new();

}