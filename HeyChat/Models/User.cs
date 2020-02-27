using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace HeyChat.Models
{
    public class User
    {
        public User()
        {
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime createdAt { get; set; }
    }
}