using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    public class Student:People
    {
        private  string   Student_ID;
        private string Class;
        private string Major;
        private double Math;
        private double Literature;
        private double Chemistry;
        private double AverageScore;



        
        public string Class1 { get => Class; set => Class = value; }
        public string Major1 { get => Major; set => Major = value; }
        public double Math1 { get => Math; set => Math = value; }
        public double Literature1 { get => Literature; set => Literature = value; }
        public double Chemistry1 { get => Chemistry; set => Chemistry = value; }
        public double AverageScore1 { get => AverageScore; set => AverageScore = value; }
        public string Student_ID1 { get => Student_ID; set => Student_ID = value; }

        public Student():base() { }

        private Student(string fullname, DateTime brithday, string sex, string address, string phonenumber, string email, string Educational_level, string  student_id, string class_1, string major, double math, double literature, double  chemistry, double average_Score, string cccd) : base()
        {
            this.Full_Name1 = fullname;
            this.BrithDay1 = brithday;
            this.Sex1 = sex;
            this.Address1 = address;
            this.PhoneNumber1 = phonenumber;
            this.Email1 = email;
            this.Educational_level = Educational_level;
            this.Email1 = email;
            this.Student_ID1 = student_id;
            this.Class = class_1;
            this.CCCD1 = cccd;
            this.Major1 = major;
            this.Math = math;
            this.Literature = literature;
            this.Chemistry = chemistry;
            
        }
       public  double   TDTB()
        {
           return (Math1 + Chemistry1 + Literature1) / 3;
        }
        
        

       
    }
}
