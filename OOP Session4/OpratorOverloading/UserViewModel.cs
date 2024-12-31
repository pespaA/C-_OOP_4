using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session4.OpratorOverloading
{
    //ViewModel : Is A Calss That Represent The Date What Will Be 
    //Rendered In A View [Html Page]
    internal class UserViewModel
    {
        public int Id { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        //--------------------------------------
        public static explicit operator UserViewModel(User user)
        {
            string[]? Names = user.FullName?.Split(" ");
            return new UserViewModel()
            {
                Id = user?.Id?? 0,
                Fname = Names?.Length>0 ?Names[0] :string.Empty,
                Lname = Names?.Length>1 ?Names[1] :string.Empty,
                Email = user?.Email ?? string.Empty,
                Password = user?.Password ?? string.Empty,
            };
        }
    }
}
