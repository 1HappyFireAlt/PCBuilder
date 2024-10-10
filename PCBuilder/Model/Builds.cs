using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PCBuilder.Model
{
    public class Builds
    {
        public int Id { get; set; }

        public User User { get; set; }
        public Component Component { get; set; }
        public Community Community { get; set; }
    }
}
