using System;
using System.Text.RegularExpressions;

namespace ClassRegister
{
    class Program


    {   
        
        static void Next(){


                List<Student> StudentList = new List<Student>();

                void DetailUpload (){

                //Firstname input 
                FirstNamehoice :
                string inputFirstName = "";
                Regex objFN = new Regex("^[a-zA-Z]{2,50}$");
                Console.WriteLine("\nEnter Student FirstName: ");
                string  FnChoice = Console.ReadLine();
                if(objFN.IsMatch(FnChoice)){      
                    inputFirstName = FnChoice;
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Coice");
                    Console.ForegroundColor = ConsoleColor.Green;
                    goto FirstNamehoice;
                }

                
            

                //Lastname input 
                lastNameChoice :
                Console.WriteLine("\nEnter Student LastName: ");
                string inputLastName;
                Regex objLN = new Regex("^[a-zA-Z]{2,50}$");
                string LNChoice = Console.ReadLine();
                if (objLN.IsMatch(LNChoice)){
                    inputLastName = LNChoice;
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input");
                    Console.ForegroundColor = ConsoleColor.Green;
                    goto lastNameChoice;
                }
                


                //Phone Number input 
                PhoneNoChoice :
                Console.WriteLine("\nEnter Student PhoneNumber: ");
                string inputPhoneNumber;
                Regex objPN = new Regex("^0[7-9]{1}[0-1]{1}[0-9]{8}$");
                string PnChoice = Console.ReadLine();
                if(objPN.IsMatch(PnChoice)){
                    inputPhoneNumber =PnChoice;
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input");
                    Console.ForegroundColor = ConsoleColor.Green;
                    goto PhoneNoChoice;
                }
                

                //Email input
                EmailChoice :
                string inputEmail;
                Console.WriteLine("\nEnter Student Email: ");
                Regex objEm = new Regex("^[a-zA-Z]{1,50}@[a-zA-Z]{1,50}.[a-zA-Z]{2,10}$");
                string EmChoice = Console.ReadLine();
                if (objEm.IsMatch(EmChoice)){
                    inputEmail  =EmChoice;
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input");
                    Console.ForegroundColor = ConsoleColor.Green;
                    goto EmailChoice;
                }
                
                Gender_Choice :
                Console.WriteLine("\n Select Student Gender \n Enter 'M' for male, 'F' for female and  'O' for other");

                string inputGenderCoice = Console.ReadLine();
                Gender inputGender = 0;
                switch (inputGenderCoice.ToLower())
                {
                    case "m":
                        inputGender = Gender.Male;
                        break;
                    case "f":
                        inputGender = Gender.Female;
                        break;
                    case "o":
                        inputGender = Gender.Other;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Inavid Choice");
                        Console.ForegroundColor = ConsoleColor.Green;
                        goto Gender_Choice;

                }


                Gadgets_Choice :
                Console.WriteLine("\n  Please Enter Some Gadgets for the Student... \nSeperate each item with a ','");

                string inputGadget;
                string GadgetC = Console.ReadLine();
                Regex objGC = new Regex("[a-zA-Z0-9],");
                if (objGC.IsMatch(GadgetC)){
                    inputGadget = GadgetC;
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input");
                    Console.ForegroundColor = ConsoleColor.Green;
                    goto Gadgets_Choice;
                }
                
                

                Student student1 = new Student(inputFirstName, inputGender, inputPhoneNumber, inputEmail, inputGadget, inputLastName);

                StudentList.Add(student1);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("To Enter Next Student details Enter 1 \nelse to Print list of Current Students Enter 0");
                string contineChoice = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                    if (contineChoice== "1") {
                        DetailUpload();
                    } else if (contineChoice == "0"){
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Student[] students = StudentList.ToArray();
                        DotNetClass netClass = new DotNetClass(students);
                        netClass.PrintClassDetails();
                        Console.ForegroundColor = ConsoleColor.Green;
                    } else {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Choice");
                        Console.ForegroundColor = ConsoleColor.Green;

                    }
            }
            DetailUpload();

            
        }
        
        
        

        static void Main()
        {
            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nWelcome to the DotNet Class Registry!\n Please fill in the details of each fellow");
            Console.WriteLine("\nPress C and Enter to Continue: ");


            if (Console.ReadLine().ToLower() == "c"){  
                    Next();
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect Entry");
                Console.ForegroundColor = ConsoleColor.Green;
            }

        }
    }
}

//class object
//field representing total number of students
//field representing the list of students in the class
//method to set the number of students
//method to add students to the class
//method to remove student from class
//class name
//class description


//student object
//student name
//student gender
//student gadgets
//student id