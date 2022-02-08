using System;

namespace ClassRegister
{
    public class Student
    {   
        public Guid Id;
        private string _Firstname;
        private string _PhoneNumber;
        private string _Email;
        private string _Lastname;
        private string _Gadgets;

        public Student(string firstname, Gender gender, string phoneNumber, string email, string gadgets, string lastame = default)
        {
            Id = Guid.NewGuid();
            this._Firstname = firstname;
            this.Gender = gender;
            this._PhoneNumber = phoneNumber;
            this._Email = email;
            this._Lastname = lastame;
            this._Gadgets = gadgets;
            
        }
        
        public string Fullname
        {
            get
            {
                return !string.IsNullOrWhiteSpace(_Lastname) ? $"{_Lastname} {_Firstname}" : _Firstname;
            }
        }
        public Gender Gender { get; set; }
        // public string[] Gadgets { get; set; }

        public override string ToString()
        {
            return $"\nId: {Id}\nFullname: {Fullname}\nGender: {Gender}\n Phone Number : {_PhoneNumber}\n Email : {_Email}\nGadgets: {string.Join(", ", _Gadgets)}\n";
        }
    }
}