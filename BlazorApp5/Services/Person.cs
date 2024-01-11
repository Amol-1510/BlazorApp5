using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BlazorApp5.Services
{
    public class Person
    {
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Invalid First Name format")]
        public string Fname { get; set; }
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Invalid Last Name format")]
        public string Lname { get; set; }
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }
        public int Age { get; set; }
        public string selectedOption { get; set; }
        public string radioOption { get; set; }
        public bool checkbox {  get; set; }
        public DateTime Date { get; set; }

        public void SetCheckbox(bool isChecked)
        {
            checkbox = isChecked;
        }

        public void SetFname(string fname)
        {
            Fname = fname;
        }

        public void SetLname(string lname)
        {
            Lname = lname;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }

        public void SetAge(int age)
        {
            Age = age;
        }
        public void SetSelectedOption(string option)
        {
            selectedOption = option;
        }
        public void SetRadioOption(string option)
        {
            radioOption = option;
        }
        public void SetDate(DateTime date)
        {
               Date = date;
        }
    }
}
