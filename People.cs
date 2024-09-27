using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    public  class People
    {
        private string Full_Name;
        private DateTime BrithDay;
        private string CCCD;
        private string Sex;
        private string Address;
        private string PhoneNumber;
        private string Email;
        private string educational_level;

        public string Full_Name1 { get => Full_Name; set => Full_Name = value; }
        public DateTime BrithDay1 { get => BrithDay; set => BrithDay = value; }
        public string CCCD1 { get => CCCD; set => CCCD = value; }
        public string Sex1 { get => Sex; set => Sex = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string PhoneNumber1 { get => PhoneNumber; set => PhoneNumber = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Educational_level { get => educational_level; set => educational_level = value; }

        public People() { }

        public People(string fullname, DateTime brithday, string sex, string address, string phonenumber, string email, string Educational_level, string cccd)
        {
            this.Full_Name = fullname;
            this.BrithDay = brithday;
            this.Sex = sex;
            this.Address = address;
            this.PhoneNumber = phonenumber;
            this.Email = email;
            this.Educational_level = Educational_level;
            this.CCCD = cccd;
        }
    }
}
