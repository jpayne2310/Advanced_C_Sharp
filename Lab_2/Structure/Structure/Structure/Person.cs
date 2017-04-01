using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structure
{
    public class Person
    {
        private string fName;
        private string mName;
        private string lName;
        private string street1;
        private string street2;
        private string city;
        private string state;
        private string zip;
        private string phone;
        private string email;



            
            public string FName
            {
                get { return fName; }
                set
                {
                    if (!value.ToUpper().Contains("POOP"))
                    {
                        fName = value;
                    }
                    else
                    {
                        fName = "invalid";
                    }
                }
            }

            public string MName
            {
                get { return mName; }
                set
                {
                    if (!value.ToUpper().Contains("POOP"))
                    {
                        mName = value;
                    }
                    else
                    {
                        mName = " invalid";
                    }
                }
            }

            public string LName
            {
                get { return lName; }
                set
                {
                    if (!value.ToUpper().Contains("POOP"))
                    {
                        lName = value;
                    }
                    else
                    {
                        lName = " invalid";
                    }
                }
            }

            public string Street1
            {
                get { return street1; }
                set
                {
                        street1 = value;
                }
            }

            public string Street2
            {
                get { return street2; }
                set
                {
                        street2 = value;
                }
            }

            public string City
            {
                get { return city; }
                set
                {               
                        city = value;                   
                }
            }

            public string State
            {
                get { return state; }
                set
                {                   
                        state = value;                   
                }
            }

            public string Zip
            {
                get { return zip; }
                set
                {
                        zip = value;
                }
            }
            
        
            public string Phone
            {
                get { return phone; }
                set
                {       
                        phone = value;
                }
            }

            public string Email
            {
                get { return email; }
                set
                {
                        email = value;
                }
            }

        };
            


    }

