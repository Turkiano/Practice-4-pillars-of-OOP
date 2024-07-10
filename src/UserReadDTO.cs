using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace Practice{

    public class UserReadDTO {

        public string Name {get; set;}
        public string Email {get; set;}
    }

    // public UserReadDTO ConvertToRead(){
    //     return new UserReadDTO {
    //         Name = Name,
    //         email = email
    //     };
    // }
}