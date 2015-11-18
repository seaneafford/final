using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//constructor practice

namespace ConsoleApplication89
{
    class Program
    {
        static void Main(string[] args)
        {
            student me = new student();//default constructor instatiated new object
            student he = new student("carl Jones", "math", "ohio", "inocare","333");//object accepts inputs for all fields
            he.Party();


        }
    }
        class student//creating class student
        {
           private string fullName = "";
           private string courseSubject = "";
           private string university = "";
           private string email = "";
           private string phoneNumber ="";

            public string Student//getting and setting the values of the fields
            {
                get
                {
                    return this.fullName;
                }
                set
                {
                    this.fullName = value;
                }
            } 
           public string Class
            {
                get
                {
                    return this.courseSubject;
                }
                set
                {
                    this.courseSubject = value;
                }
               
            }
            public string Uni
            {
                get
                {
                    return this.university;
                }
                set
                {
                    this.university = value;
                }

            }
            public string Emale
            {
                get
                {
                    return this.email;
                }
                set
                {
                    this.email = value;

                }
            }
            public string PhoneNubba
            {
                get
                {
                    return this.phoneNumber;
                }
                set
                {
                    this.phoneNumber = value;
                }
                
            }
            public student()//default values
            {
                this.phoneNumber="5555555555";
                this.courseSubject = "IT";
                this.email = "dontcaredudez@gmail.com";
                this.fullName = "Jonh Smith";
                this.university = "blah";

            }

        public student(string fullname, string courseSubject, string email, string phoneNumber, string university)
        {//accepting the inputs for 5 fields
            this.fullName = fullname;
            this.courseSubject = courseSubject;
            this.email = email ;
            this.phoneNumber = phoneNumber;
            this.university = university;
           
        }
        public void Party()
            {
                Console.Write("{0} goes to {1} his email adress is {2} and you can call him at {3} he is an {4} major.", fullName, university,  email, phoneNumber, courseSubject);
            }
        }
    }

