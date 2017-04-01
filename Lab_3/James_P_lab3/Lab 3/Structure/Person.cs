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
        private string zip2;
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
                    //check for inappropriate words
                    if (myValidate.HasBadWords(value))
                    {
                        feedback +="ERROR: Invalid First Name...Contains Bad Words";
                    }
                    //check to make sure field is filled in
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
                    //check for inappropriate words
                    if (myValidate.HasBadWords(value))
                    {
                        feedback += "ERROR: Invalid Middle Name...Contains Bad Words";
                    }
                    //check to make sure field is filled in
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
                    //check for inappropriate words
                    if (myValidate.HasBadWords(value))
                    {
                        feedback +="ERROR: Invalid Last Name...Contains Bad Words";
                    }
                    //check to make sure field is filled in
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
                    //check to make sure field is filled in
                    if (myValidate.FilledIn(value) == false)
                    {
                        feedback += "ERROR: Street1 Field Required.\n";
                    }
                    else
                    {
                        street1 = value;
                    }
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
                    //check to insure input is within acceptable range
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
                    //check for reqiured leangth
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
                    //check to insure input is numbers only
                    if (myValidate.IsDigit(value))
                    {
                        feedback += "ERROR: Zip must be Numbers.\n";
                    }
                    //check for reqiured leangth
                    else if (myValidate.LengthRequirement(value, 5))
                    {
                        feedback += "ERROR: Zip must be at least five \n" + 
                            "number in length.";
                    }
                    else
                    {
                        zip = value;
                    }
                }
            }

            public string Zip2
            {
                get { return zip2; }
                set
                {
                    //check to insure input is numbers only
                    if (myValidate.IsDigit(value))
                    {
                        feedback += "ERROR: Zip extension must be Numbers.\n" +
                            "or blank if N/A.\n";
                    }
                    //check for reqiured leangth
                    else if (myValidate.MinimumLength(value, 4) == false)
                    {
                        feedback += "ERROR: Zip extension must be four \n" +
                            "numbers in length or blank if N/A.";
                    }
                    else
                    {
                        zip2 = value;
                    }
                }
            }
            
        
            public string Phone
            {
                get { return phone; }
                set
                {
                    //check for reqiured leangth
                    if (myValidate.PhoneMaskRequirement(value, 14) == false)
                    {
                        feedback += "ERROR: Phone must be ten \n" +
                            "numbers in length or blank if N/A.";
                    }
                    //if phone textbox is not filled in, clear mask
                    else if (value == "(   )    -")
                    {
                        value = "";
                    }
                    else
                    {
                        phone = value;
                    }
                }
                
            }

            public string Email
            {
                get { return email; }
                set
                {
                    //check for valid email 
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
            //set constructor 
            public Person()
            {
                feedback = "";
            }

        };
            


    }

