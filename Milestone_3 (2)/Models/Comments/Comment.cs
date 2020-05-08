using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


using Milestone_3.Models.Categories;
using Milestone_3.Models.Goods;
using Milestone_3.Models.Users;


namespace Milestone_3.Models.Comments
{
    public class Comment
    {
        public Comment(string v1, string v2, User us)
        {
        }

        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "Text")]
        public string Text { get; set; }

        [Display(Name = "Author")]
        public User Author{ get; set; }

        public static implicit operator List<object>(Comment v)
        {
            throw new NotImplementedException();
        }
    }
}
