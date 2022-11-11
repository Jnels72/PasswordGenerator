using Microsoft.AspNetCore.Mvc;

namespace PasswordGenerator.Models
{
    public class PasswordModel
    {
        public string rndPassword { get; set; }
        public int passwordLength { get; set; }
    }
}
