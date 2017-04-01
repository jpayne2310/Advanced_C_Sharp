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
        private string feedback;


        public string Feedback
        {
            get { return feedback; }
        }

            public string FName
            {
                get { return fName; }
                set
                {
                    if (myValidate.HasBadWords(value))
                    {
                        feedback +="ERROR: Invalid First Name...Contain Bad Words";
                    }
                    else if (myValidate.FilledIn(value) == false)
                    {
                        feedback += "ERROR: First Name Field Required.\n";
                    }
                    else
                    {
                        fName = value;
                    }
                
                }
            }

            public string MName
            {
                get { return mName; }
                set
                {
                    if (myValidate.HasBadWords(value))
                    {
                        feedback += "ERROR: Invalid Middle Name...Contain Bad Words";
                    }
                    else if (myValidate.FilledIn(value) == false)
                    {
                        feedback += "ERROR: Middle Name Field Required.\n";
                    }
                    else
                    {
                        mName = value;
                    }

                }
            }

            public string LName
            {
                get { return lName; }
                set
                {
                    if (myValidate.HasBadWords(value))
                    {
                        feedback +="ERROR: Invalid Last Name...Contain Bad Words";
                    }
                    else if (myValidate.FilledIn(value) == false)
                    {
                        feedback += "ERROR: First Last Field Required.\n";
                    }
                    else
                    {
                        lName = value;
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
                    if (myValidate.Between(value, 2, 20) == false)
                    {
                        feedback += "ERROR: City must be at least two letters and\n" + 
                            " not more than twenty letters in length.\n";
                    }
                    else
                    {
                        city = value;
                    }
                }
            }

            public string State
            {
                get { return state; }
                set
                {
                    if (myValidate.LengthRequirement(value, 2))
                    {
                        feedback += "ERROR: State must be two letters.\n";
                    }
                    else
                    {                   
                            state = value;                   
                    }
                }
            }

            public string Zip
            {
                get { return zip; }
                set
                {
                    if (myValidate.Between(value, 5, 10) == false)
                    {
                        feedback += "ERROR: Zip must be at least five and\n" +
                            " not more than nine numbers in length with a '-'.\n";
                    }
                    else
                    {
                        zip = value;
                    }
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
                    if (myValidate.IsEmailValid(value) == false)
                    {
                        feedback += "ERROR: Invalid Email format.\n";
                    }
                    else
                    {
                        email = value;
                    }
                }
            }
            public Person()
            {
                feedback = "";
            }

        };
            


    }

