using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please choose if you will attend party!")]
        public bool? WillAttend { get; set; }
        private static List<GuestResponse> _guestResponses = new List<GuestResponse>();
        public static IEnumerable<GuestResponse> GuestResponses { 
            get
            {
                return _guestResponses;
            }
        }

        public static void AddResponse(GuestResponse response)
        {
            _guestResponses.Add(response);
        }
    }
}
