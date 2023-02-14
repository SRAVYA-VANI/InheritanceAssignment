using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAssignment
{
    internal class Person
    {
        public string Name { get; set; }
        public int id { get; set; }
        public string address { get; set; }
        public double phnum { get; set; }   
        public Person(string name, int id, string address, double phnum)
        {
            this.Name = name;
            this.id = id;
            this.address = address;
            this.phnum = phnum;
        }
        public virtual void details()
        {
            Console.WriteLine("id :" + id);
            Console.WriteLine("name :" + Name);
            Console.WriteLine("address :" + address);
            Console.WriteLine("phone : "+ phnum);
        }
    }
    class student : Person
    {
        public string studying { get; set; }
        public int marks { get; set; }
        public string grade { get; set; }
        public double fee { get; set; }

        public student(int id, string name, string address,double phnum,string studying,int marks,string grade,double fee):base(name,id,address,phnum)
        {
            this.studying = studying;
            this.marks = marks;
            this.grade= grade;
            this.fee = fee;
        }
        public override void details()
        {
            base.details();
            Console.WriteLine("studying class" + studying);
            Console.WriteLine("marks "+ marks);
            Console.WriteLine("grade" + grade);
            Console.WriteLine("fee" + fee);
        }

    }
    class staff : Person
    {
        public int staffid { get; set; }
        public string designation { get; set; }
        public double salary { get; set; }
        public string qualification { get; set; }

        public staff(int staffid, string name, string address, double phone, string designation, double salary, string qualification) : base(name, staffid, address, phone)
        {
            this.staffid = staffid;
            this.designation = designation;
            this.salary = salary;
            this.qualification = qualification;
        }
        public override void details()
        {
            base.details();
            Console.WriteLine("staffid " + staffid);
            Console.WriteLine("designation " + designation);
            Console.WriteLine("salary" + salary);
            Console.WriteLine("qualification" + qualification);

        }
    }
    class teachingstaff : staff
    {
        public string subject { get; set; }
        public teachingstaff(int staffid, string name, string address, double phone, string designation, double salary, string qualification, string subject) : base(staffid, name, address, phone, designation, salary, qualification)
        {
            this.subject= subject;
        }
        public override void details() {
            base.details();
            Console.WriteLine("subbject" + subject);

        }
    }
    class nonteachingstaff : staff {
        public string DeptName { get; set; }
        public int ManagerId { get; set; }
        public nonteachingstaff(int staffid, string name, string address, double phone, string designation, double salary, string qualification, string deptname, int managerid) : base(staffid, name, address, phone, designation, salary, qualification)
        {
            this.DeptName= deptname;
            this.ManagerId= managerid;
        }
        public override void details() { base.details();Console.WriteLine("deptname "+ DeptName);
            Console.WriteLine("manager id "+ ManagerId);
        }
    }




    }
