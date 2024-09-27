using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    public  class Teacher:People
    {
        private int Teacher_ID;
        private string Subject_taught;
        private string Username;
        private string Password;
        private bool IsLock;

        public int Teacher_ID1 { get => Teacher_ID; set => Teacher_ID = value; }
        public string Subject_taught1 { get => Subject_taught; set => Subject_taught = value; }
        public string Username1 { get => Username; set => Username = value; }
        public string Password1 { get => Password; set => Password = value; }
        public bool IsLock1 { get => IsLock; set => IsLock = value; }

        public Teacher() { }

        public Teacher(string fullname, DateTime brithday, string sex, string address, string phonenumber, string email, string Educational_level, int teacher_id, string subject_taught, string cccd, string username, string password) : base()
        {
            this.Full_Name1 = fullname;
            this.BrithDay1 = brithday;
            this.Sex1 = sex;
            this.Address1 = address;
            this.PhoneNumber1 = phonenumber;
            this.Email1 = email;
            this.Educational_level = Educational_level;
            this.Teacher_ID = teacher_id;
            this.Subject_taught = subject_taught;
            this.CCCD1 = cccd;
            this.Username1 = username;
            this.Password1 = password;
            this.IsLock = false;
            


        }
    }

}
