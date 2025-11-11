using System.ComponentModel.DataAnnotations;

namespace Cake_Craft.Server.Models
{
    public class ApplicationUser
    {
        [StringLength(30)]
        public string Name { get; set; }
    }
}