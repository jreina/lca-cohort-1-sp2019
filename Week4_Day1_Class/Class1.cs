using System;

namespace Week4_Day1_Class
{
    public class DriversLicense
    {
        public string FirstName;
        public string LastName;
        public string Gender;
        public string LicenseNumber;

        public DriversLicense(string fname, string lname, string gender, string licenseNum)
        {
            FirstName = fname;
            LastName = lname;
            Gender = gender;
            LicenseNumber = licenseNum;
        }

        public String GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }

    public class Book
    {
        public string Title;
        public string[] Authors; // this should allow for multiple authors
        public string Pages; // this should hold the number of pages
        public string SKU;
        public string Publisher;
        public double Price;
    }

    public class Airplane
    {
        public string Manufacturer;
        public string Model;
        public string Variant;
        public int Capacity;
        public int Engines;
    }
}
