﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace boss.az
{
    class Runner
    {

        public static void Run()
        {
            Worker w1 = new Worker("Nebi Nebili", "Nebi18", 18, "nnabili035@gmail.com", "Azerbaycan123");
            Worker w2 = new Worker("Kamal Eliyev", "KamalQazax", 15, "kamaleliyev7@gmail.com", "Salam qaqa");
            Category category1 = new Category("Software developer", 1);
            Category category2 = new Category("Web/Graphic design", 2);
            Category category3 = new Category("IT / Telecommunications", 3);
            Category category4 = new Category("Economy", 4);
            Category category5 = new Category("Marketing / Media / PR", 5);
            Category category6 = new Category("Human Resources / Staff Management ", 6);
            Announcement announcement1 = new Announcement(1, "React developer", "Sumgait", "18-25", new DateTime(2020, 09, 21), new DateTime(2020, 10, 21), 900, "1 to 3 years", "Amiraslan", "emiraslaneliyev45@gmail.com", "994557134655");
            Announcement announcement2 = new Announcement(1, "Php developer", "Baku", "20-40", new DateTime(2021, 02, 10), new DateTime(2020, 03, 10), 1500, "More than 1 year", "Kenan", "Kenan23@gmail.com", "994558557498");
            Announcement announcement3 = new Announcement(2, "UI/UX Designer", "Ganja", "25-40", new DateTime(2019, 03, 5), new DateTime(2019, 04, 10), 2100, "More than 3 year", "Nebi", "nnabili@gmail.com", "994557135755");
            Announcement announcement4 = new Announcement(2, "Graphic Designer", "Qabala", "20-30", new DateTime(2021, 10, 21, 23, 30, 40), new DateTime(2020, 11, 21), 3100, "More than 2 year", "Burak", "burakaktas@gmail.com", "9043239430");
            Announcement announcement5 = new Announcement(5, "Administrative assistant", "Ganja", "20-30", new DateTime(2021, 10, 21, 23, 30, 40), new DateTime(2020, 11, 21), 3500, "More than 2 year", "Burak", "burakaktas@gmail.com", "9043239430");
            Database.FilitrAnnoucments.Add(announcement5);
            Database.FilitrAnnoucments.Add(announcement4);
            Database.FilitrAnnoucments.Add(announcement3);
            Database.FilitrAnnoucments.Add(announcement2);
            Database.FilitrAnnoucments.Add(announcement1);
            CV cv1 = new CV(1, "Node.js + Java Senior backend engineer", "Nebi", 18, "Sumgait", new DateTime(2021, 10, 21, 23, 30, 00), new DateTime(2021, 11, 21, 23, 30, 00), "Java,Node.js", "More than 2 year");
            CV cv2 = new CV(2, "Product designer", "Akif", 20, "Ganja", new DateTime(2021, 8, 22, 22, 00, 10), new DateTime(2021, 9, 22, 23, 30, 00), "A high degree of technical knowledge balanced with creative ability and a hands-on approach.", "More than 1 year");
            CV cv3 = new CV(3, "Digital & Web Coordinator", "Ramiz", 24, "Baku", new DateTime(2021, 12, 19, 19, 00, 00), new DateTime(2022, 01, 21, 23, 30, 00), "Able to deliver quality results under time constraints in a fast-paced environment.", "Minimum 2 year");
            CV cv4 = new CV(4, "Junior Relationship Manager", "Samir", 18, "Lankaran", new DateTime(2021, 10, 21, 23, 30, 00), new DateTime(2021, 11, 21, 23, 30, 00), "Able to work with key stakeholders to a high level", "Minimum 1.5 year");
            CV cv5 = new CV(5, "English Copywriter UX/UI", "Samir", 18, "Shaki", new DateTime(2021, 10, 21, 23, 30, 00), new DateTime(2021, 11, 21, 23, 30, 00), "Creating, writing and reviewing varied content in English for Swissquotes web interfaces, particularly its applications.", "Minimum 1.5 year");
            CV cv6 = new CV(6, "HR Intern", "Rasim", 32, "Quba", new DateTime(2021, 10, 21, 23, 30, 00), new DateTime(2021, 11, 21, 23, 30, 00), "*Support the employee lifecycle through administrative tasks (contracts, addendums,…)\n*Prepare the onboarding of new joiners", "Minimum 1.5 year");
            w1.AddCv(cv1);
            w1.AddCv(cv2);
            w1.AddCv(cv3);
            w2.AddCv(cv4);
            w2.AddCv(cv5);
            w2.AddCv(cv6);
            Employee emp1 = new Employee("Kenan Idayatov", "Akula", 18, "kenannidayatov@gmail.com", "Progress32");
            Employee emp2 = new Employee("Hormet Hemidov", "idayatov.k", 19, "hhormethemidov@gmail.com", "29092001");
            emp1.AddAnnoucment(announcement1);
            emp1.AddAnnoucment(announcement2);
            emp1.AddAnnoucment(announcement3);
            emp1.AddAnnoucment(announcement4);
            emp2.AddAnnoucment(announcement5);
            Database db = new Database
            {
                Workers = new List<Worker> { w1, w2 },
                Employees = new List<Employee> { emp1, emp2 },
                Categories = new List<Category> { category1, category2, category3, category4, category5, category6 }
            };
        FirstPart:
            int choise1 = ConsoleHelper.MultipleChoice(44, 9, true, 1, "Worker", "Employee");
            if (choise1 == 0)
            {
            SecondPart:
                int choise2 = ConsoleHelper.MultipleChoice(44, 9, true, 2, "Sign up", "Sign in", "<-Back");
                if (choise2 == 0)
                {
                    while (true)
                    {
                        Console.Clear();
                        fullName:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Enter your Fullname: ");
                        string fullName = Console.ReadLine();
                        if (db.isString(fullName)) { }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Incorrect fullname try again!!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto fullName;
                        }
                        username:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Enter your Username: ");
                        string userName = Console.ReadLine();
                        if (db.isString(userName)) { }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Incorrect username try again!!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto username;
                        }
                    Age:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("--Age must be more than 18--");
                        Console.Write("Enter your Age: ");
                        string age = Console.ReadLine();
                        if (db.IsValidAge(age)) { }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Incorrect age try again!!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto Age;
                        }
                    Email:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Enter your email: ");
                        string email = Console.ReadLine();
                        if (db.IsValidEmail(email)) { }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Incorrect email try again!!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto Email;
                        }
                    Password:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("--Warning!!Password length min 8 max 15.Password must be 1 uppercase letter, 1 lower case lettter and 1 decimal digt---");
                        Console.Write("Enter your password: ");
                        string password = Console.ReadLine();
                        if (db.ValidatePassword(password)) { }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Incorrect password try again!!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto Password;
                        }
                        Worker worker = new Worker(fullName, userName, int.Parse(age), email, password);
                        db.Workers.Add(worker);
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("---You succesfully signed up---"); Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(1500);
                        goto SecondPart;
                    }
                }
                else if (choise2 == 1)
                {
                    Console.Clear();
                    int check = 0;
                email:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    db.ClearCurrentConsoleLine();
                    Console.Write("Enter your email:");
                    string email = Console.ReadLine();
                    foreach (var worker in db.Workers)
                    {
                        if (worker.Email == email)
                        {
                            while (true)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("Enter your password:");
                                string password = Console.ReadLine();
                                if (password == worker.Password)
                                {
                                    ++check;
                                workeroptions:
                                    int choise4 = ConsoleHelper.MultipleChoice(50, 9, true, 1, "Add Cv", "Delete Cv", "Update Cv", "Show your Cvs", "Find work", "<-Back");
                                    if (choise4 == 0)
                                    {
                                        Console.Clear();
                                        Console.SetCursorPosition(38, 7);
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("-----------Category-----------");
                                        int choise5 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "Software developer", "Web/Graphic design", "IT / Telecommunications", "Ecenomy", "Marketing / Media / PR", "Human Resources / Staff Management", "<-Back");
                                        switch (choise5)
                                        {
                                            case 0:
                                                worker.AddCv(Helper.CvObject(1));
                                                goto workeroptions;
                                                break;
                                            case 1:
                                                worker.AddCv(Helper.CvObject(2));
                                                goto workeroptions;
                                                break;
                                            case 2:
                                                worker.AddCv(Helper.CvObject(3));
                                                goto workeroptions;
                                                break;
                                            case 3:
                                                worker.AddCv(Helper.CvObject(4));
                                                goto workeroptions;
                                                break;
                                            case 4:
                                                worker.AddCv(Helper.CvObject(5));
                                                goto workeroptions;
                                                break;
                                            case 5:
                                                worker.AddCv(Helper.CvObject(6));
                                                goto workeroptions;
                                                break;
                                            case 6:
                                                goto workeroptions;
                                        }
                                    }
                                    if (choise4 == 1)
                                    {
                                        Console.Clear();
                                        worker.PrintCvs();
                                    deletecv:
                                        if (worker.IsListEmpty(worker.Cvs))
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("Your  cv list empty"); Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.Write("Which cv you want delete(with id): ");
                                        string id;
                                        int check1 = 0;
                                        if (db.isNumber(id = Console.ReadLine()))
                                        {
                                            foreach (var cv in worker.Cvs)
                                            {
                                                if (cv.ThisId.ToString() == id)
                                                {
                                                    ++check1;
                                                    break;
                                                }
                                            }
                                            if (check1 == 0)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("You haven't cv this id"); Console.ForegroundColor = ConsoleColor.White;
                                                goto deletecv;
                                            }
                                            var item = worker.Cvs.SingleOrDefault(x => x.ThisId == int.Parse(id));
                                            worker.Cvs.Remove(item);
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("Your cv deleted succesfully"); Console.ForegroundColor = ConsoleColor.White;
                                            Thread.Sleep(1500);
                                            goto workeroptions;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Incorrect Id"); Console.ForegroundColor = ConsoleColor.White;
                                            goto deletecv;
                                        }
                                    }
                                    if (choise4 == 2)
                                    {
                                        int check2 = 0;
                                        Console.Clear();
                                        worker.PrintCvs();
                                    updatecv:
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.WriteLine("Which cv you want update (with id)");
                                        string id = Console.ReadLine();
                                        if (db.isNumber(id))
                                        {
                                            foreach (var cv in worker.Cvs)
                                            {
                                                if (cv.ThisId.ToString() == id)
                                                {
                                                    ++check2;
                                                    break;
                                                }
                                            }
                                            if (check2 == 0)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("You haven't cv this id"); Console.ForegroundColor = ConsoleColor.White;
                                                goto updatecv;
                                            }
                                            var cvUpdate = worker.Cvs.SingleOrDefault(x => x.ThisId == int.Parse(id));
                                            Console.Clear();

                                        updateoptions:
                                            Console.Clear();
                                            Console.SetCursorPosition(38, 7);
                                            Console.WriteLine("Which parameter you want update: ");
                                            int choise8 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "Work Name", "Worker Name", "Age", "City", "Skills", "Experience", "<-Back");
                                            switch (choise8)
                                            {
                                                case 0:
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("New Work Name: "); Console.ForegroundColor = ConsoleColor.White;
                                                    string workName = Console.ReadLine();
                                                    cvUpdate.WorkName = workName;
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("Your Work name updated sucesfully"); Console.ForegroundColor = ConsoleColor.White;
                                                    break;
                                                case 1:
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("New Worker Name: "); Console.ForegroundColor = ConsoleColor.White;
                                                    string workerName = Console.ReadLine();
                                                    cvUpdate.Name = workerName;
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("Your Worker name updated sucesfully"); Console.ForegroundColor = ConsoleColor.White;
                                                    break;
                                                case 2:
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("---Age must be more than 18---");
                                                    Console.WriteLine("New Age: "); Console.ForegroundColor = ConsoleColor.White;
                                                    string age = Console.ReadLine();
                                                    if (db.IsValidAge(age)) { }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.WriteLine("Incorrect Age!!");
                                                        Thread.Sleep(1000);
                                                        goto case 2;
                                                    }
                                                    cvUpdate.Age = int.Parse(age);
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("Your Age updated sucesfully"); Console.ForegroundColor = ConsoleColor.White;
                                                    break;
                                                case 3:
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("New City: "); Console.ForegroundColor = ConsoleColor.White;
                                                    string city = Console.ReadLine();
                                                    cvUpdate.City = city;
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("Your City updated sucesfully"); Console.ForegroundColor = ConsoleColor.White;
                                                    break;
                                                case 4:
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("New Skills: "); Console.ForegroundColor = ConsoleColor.White;
                                                    string skills = Console.ReadLine();
                                                    cvUpdate.Skills = skills;
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("Your Skills updated sucesfully"); Console.ForegroundColor = ConsoleColor.White;
                                                    break;
                                                case 5:
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("New experience: "); Console.ForegroundColor = ConsoleColor.White;
                                                    string experience = Console.ReadLine();
                                                    cvUpdate.Experience = experience;
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("Your Expierence updated sucesfully"); Console.ForegroundColor = ConsoleColor.White;
                                                    break;
                                                case 6:
                                                    goto workeroptions;
                                                    break;

                                            }
                                            Console.SetCursorPosition(38, 7);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("Do you want continue or go back? ");
                                            int choise9 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "Continue", "Back");
                                            switch (choise9)
                                            {
                                                case 0:
                                                    goto updateoptions;
                                                    break;
                                                case 1:
                                                    goto workeroptions;
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Incorrect Id"); Console.ForegroundColor = ConsoleColor.White;
                                            goto updatecv;
                                        }
                                    }
                                    if (choise4 == 3)
                                    {
                                        Console.Clear();
                                        worker.PrintCvs();
                                        if (worker.IsListEmpty(worker.Cvs))
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("Your  cv list empty"); Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.Write("If you want back press any key->");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.ReadLine();
                                        goto workeroptions;
                                    }
                                    if (choise4 == 4)
                                    {
                                    advancedsearch:
                                        int choise6 = ConsoleHelper.MultipleChoice(50, 9, true, 2, "Advanced Search", "All annoucments", "<-Back");
                                        if (choise6 == 0)
                                        {
                                        filitroptions:
                                            Console.Clear();
                                            Console.SetCursorPosition(38, 1);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("--------Category--------");
                                            int choise7 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "Software developer", "Web/Graphic design", "It/Telecommunications", "Economy", "Marketing / Media / PR", "Human Resources / Staff Management", "<-Back");
                                            switch (choise7)
                                            {
                                                case 0:
                                                    FilitrClass.FilitrCategoryId = 1;
                                                    break;
                                                case 1:
                                                    FilitrClass.FilitrCategoryId = 2;
                                                    break;
                                                case 2:
                                                    FilitrClass.FilitrCategoryId = 3;
                                                    break;
                                                case 3:
                                                    FilitrClass.FilitrCategoryId = 4;
                                                    break;
                                                case 4:
                                                    FilitrClass.FilitrCategoryId = 5;
                                                    break;
                                                case 5:
                                                    FilitrClass.FilitrCategoryId = 6;
                                                    break;
                                                case 6:
                                                    goto advancedsearch;
                                                    break;
                                            }
                                            Console.Clear();
                                            Console.SetCursorPosition(38, 1);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("--------City--------");
                                            int choise8 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "Sumgait", "Ganja", "Baku", "Lankaran", "Shaki", "Quba", "<-Back");
                                            switch (choise8)
                                            {
                                                case 0:
                                                    FilitrClass.FilitrCity = "Sumgait";
                                                    break;
                                                case 1:
                                                    FilitrClass.FilitrCity = "Ganja";
                                                    break;
                                                case 2:
                                                    FilitrClass.FilitrCity = "Baku";
                                                    break;
                                                case 3:
                                                    FilitrClass.FilitrCity = "Lankaran";
                                                    break;
                                                case 4:
                                                    FilitrClass.FilitrCity = "Shaki";
                                                    break;
                                                case 5:
                                                    FilitrClass.FilitrCity = "Quba";
                                                    break;
                                                case 6:
                                                    goto advancedsearch;
                                                    break;
                                            }
                                            Console.Clear();
                                            Console.SetCursorPosition(38, 1);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("--------Salary--------");
                                            int choise9 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "800+ Azn", "1000+ Azn", "1500+ Azn", "2000+ Azn", "3000+ Azn", "<-Back");
                                            switch (choise9)
                                            {
                                                case 0:
                                                    FilitrClass.FilitrMinimumSalary = 800;
                                                    break;
                                                case 1:
                                                    FilitrClass.FilitrMinimumSalary = 1000;
                                                    break;
                                                case 2:
                                                    FilitrClass.FilitrMinimumSalary = 1500;
                                                    break;
                                                case 3:
                                                    FilitrClass.FilitrMinimumSalary = 2000;
                                                    break;
                                                case 4:
                                                    FilitrClass.FilitrMinimumSalary = 3000;
                                                    break;
                                                case 5:
                                                    goto advancedsearch;
                                                    break;
                                            }
                                            Database.FilitrAnnoucments = Database.FilitrAnnoucments.FindAll(a => a.CategoryId == FilitrClass.FilitrCategoryId && a.City == FilitrClass.FilitrCity && FilitrClass.FilitrMinimumSalary < a.Salary);
                                            if (Database.FilitrAnnoucments.Count == 0)
                                            {
                                                Database.FilitrAnnoucments.Add(announcement1);
                                                Database.FilitrAnnoucments.Add(announcement2);
                                                Database.FilitrAnnoucments.Add(announcement3);
                                                Database.FilitrAnnoucments.Add(announcement4);
                                                Database.FilitrAnnoucments.Add(announcement5);
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.SetCursorPosition(38, 0);
                                                Console.WriteLine("We havent find annoucment this properties!!"); Console.ForegroundColor = ConsoleColor.White;
                                                Console.SetCursorPosition(38, 1);
                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("If you want continue to search or go Back?"); Console.ForegroundColor = ConsoleColor.White;
                                                int choise10 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "Continue Searching", "<-Back");
                                                switch (choise10)
                                                {
                                                    case 0:
                                                        goto filitroptions;
                                                        break;
                                                    case 1:
                                                        goto advancedsearch;
                                                        break;
                                                }
                                                ///***************NOT COMPLETED HERE
                                            }
                                            Database.FilitrAnnoucments.ForEach(a => Console.WriteLine(a));
                                            Thread.Sleep(2000);
                                        }
                                        else if (choise6 == 1)
                                        {
                                            ///***************NOT COMPLETED HERE
                                            Database.FilitrAnnoucments.ForEach(a => Console.WriteLine(a));
                                            Thread.Sleep(2000);
                                        }
                                        else if (choise6 == 2)
                                        {
                                            goto workeroptions;
                                        }
                                    }
                                    if (choise4 == 5)
                                    {
                                        goto SecondPart;
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("Incorrect password try again!!\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    int choise3 = ConsoleHelper.MultipleChoice(50, 5, false, 1, "Continue", "<-Back");
                                    if (choise3 == 1) { goto SecondPart; }
                                    if (choise3 == 0) { db.ClearCurrentConsoleLine(); db.ClearLastLine(); Console.WriteLine(); continue; }
                                }
                            }
                        }
                    }
                    if (check == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Incorrect email try again!!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        int choise3 = ConsoleHelper.MultipleChoice(50, 9, false, 1, "Continue", "<-Back");
                        if (choise3 == 1) { goto SecondPart; }
                        if (choise3 == 0) { Console.Clear(); goto email; }
                    }
                }
                else if (choise2 == 2)
                {
                    goto FirstPart;
                }
            }
            else if (choise1 == 1)
            {
            SecondPart:
                int choise2 = ConsoleHelper.MultipleChoice(44, 9, true, 2, "Sign up", "Sign in", "<-Back");
                if (choise2 == 0)
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Enter your Fullname: ");
                        string fullName = Console.ReadLine();
                        Console.Write("Enter your Username: ");
                        string userName = Console.ReadLine();
                    Age:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("--Age must be more than 18--");
                        Console.Write("Enter your Age: ");
                        string age = Console.ReadLine();
                        if (db.IsValidAge(age)) { }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Incorrect age try again!!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto Age;
                        }
                    Email:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Enter your email: ");
                        string email = Console.ReadLine();
                        if (db.IsValidEmail(email)) { }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Incorrect email try again!!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto Email;
                        }
                    Password:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("--Warning!!Password length min 8 max 15.Password must be 1 uppercase letter, 1 lower case lettter and 1 decimal digt---");
                        Console.Write("Enter your password: ");
                        string password = Console.ReadLine();
                        if (db.ValidatePassword(password)) { }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Incorrect password try again!!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto Password;
                        }
                        Employee employee = new Employee(fullName, userName, int.Parse(age), email, password);
                        db.Employees.Add(employee);
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("---You succesfully signed up---"); Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(1500);
                        goto SecondPart;
                    }
                }
                if (choise2 == 1)
                {
                    Console.Clear();
                    int check = 0;
                email:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Enter your email:");
                    string email = Console.ReadLine();
                    foreach (var employee in db.Employees)
                    {
                        if (employee.Email ==email)
                        {
                            while (true)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("Enter your password:");
                                string password = Console.ReadLine();
                                if (password == employee.Password)
                                {
                                    ++check;
                                    employeeoptions:
                                    int choise4 = ConsoleHelper.MultipleChoice(50, 9, true, 1, "Add Annoucment", "Delete annoucment", "Update annoucment", "Show your annoucments", "Find work", "<-Back");
                                    if (choise4 == 0)
                                    {
                                        Console.Clear();
                                        Console.SetCursorPosition(38, 7);
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("-----------Category-----------");
                                        int choise5 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "Software developer", "Web/Graphic design", "IT / Telecommunications", "Ecenomy", "Marketing / Media / PR", "Human Resources / Staff Management", "<-Back");
                                        switch (choise5)
                                        {
                                            case 0:
                                                employee.AddAnnoucment(Helper.AnnoucmentObject(1));
                                                goto employeeoptions;
                                                break;
                                            case 1:
                                                employee.AddAnnoucment(Helper.AnnoucmentObject(2));
                                                goto employeeoptions;
                                                break;
                                            case 2:
                                                employee.AddAnnoucment(Helper.AnnoucmentObject(3));
                                                goto employeeoptions;
                                                break;
                                            case 3:
                                                employee.AddAnnoucment(Helper.AnnoucmentObject(4));
                                                goto employeeoptions;
                                                break;
                                            case 4:
                                                employee.AddAnnoucment(Helper.AnnoucmentObject(5));
                                                goto employeeoptions;
                                                break;
                                            case 5:
                                                employee.AddAnnoucment(Helper.AnnoucmentObject(6));
                                                goto employeeoptions;
                                                break;
                                            case 6:
                                                goto employeeoptions;
                                                break;
                                        }

                                    }
                                    else if (choise4 == 1)
                                    {
                                        Console.Clear();
                                        employee.PrintAnnoucments();
                                        deleteannoucment:
                                        if (employee.IsListEmpty(employee.Announcements))
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("Your  annoucment list empty"); Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.Write("Which announcment you want delete(with id): ");
                                        string id;
                                        int check1 = 0;
                                        id = Console.ReadLine();
                                        if (db.isNumber(id))
                                        {
                                            foreach (var announcement in employee.Announcements)
                                            {
                                                if (announcement.ThisId.ToString() == id)
                                                {
                                                    ++check1;
                                                    break;
                                                }
                                            }
                                            if (check1 == 0)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("You haven't annoucment this id"); Console.ForegroundColor = ConsoleColor.White;
                                                goto deleteannoucment;
                                            }
                                            var item = employee.Announcements.SingleOrDefault(x => x.ThisId == int.Parse(id));
                                            employee.Announcements.Remove(item);
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("Your announcment deleted succesfully"); Console.ForegroundColor = ConsoleColor.White;
                                            Thread.Sleep(1500);
                                            goto employeeoptions;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Incorrect Id"); Console.ForegroundColor = ConsoleColor.White;
                                            goto deleteannoucment;
                                        }

                                    }
                                    else if (choise4 == 2)
                                    {
                                        int check2 = 0;
                                        Console.Clear();
                                        employee.PrintAnnoucments();
                                        updateannouncment:
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.WriteLine("Which announcment you want update (with id)");
                                        string id = Console.ReadLine();
                                        if (db.isNumber(id))
                                        {
                                            foreach (var announcment in employee.Announcements)
                                            {
                                                if (announcment.ThisId.ToString() == id)
                                                {
                                                    ++check2;
                                                    break;
                                                }
                                            }
                                            if (check2 == 0)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("You haven't cv this id"); Console.ForegroundColor = ConsoleColor.White;
                                                goto updateannouncment;
                                            }
                                            var cvUpdate = employee.Announcements.SingleOrDefault(x => x.ThisId == int.Parse(id));
                                            Console.Clear();
                                        updateoptions:
                                            Console.Clear();
                                            Console.SetCursorPosition(38, 7);
                                            Console.WriteLine("Which parameter you want update: ");
                                            int choise8 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "Work Name", "Worker Name", "Age", "City", "Skills", "Experience", "<-Back");
                                            //*UPDATED NOT COMPLETED
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Incorrect Id"); Console.ForegroundColor = ConsoleColor.White;
                                            goto updateannouncment;
                                        }

                                    }
                                    else if (choise4 == 3)
                                    {
                                        Console.Clear();
                                        employee.PrintAnnoucments();
                                        if (employee.IsListEmpty(employee.Announcements))
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("Your  annoucment list empty"); Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.Write("If you want back press any key->");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.ReadLine();
                                        goto employeeoptions;
                                    }

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("Incorrect password try again!!\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    int choise3 = ConsoleHelper.MultipleChoice(50, 5, false, 1, "Continue", "<-Back");
                                    if (choise3 == 1) { goto SecondPart; }
                                    if (choise3 == 0) { db.ClearCurrentConsoleLine(); db.ClearLastLine(); Console.WriteLine(); continue; }
                                }
                            }
                        }
                    }
                    if (check == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Incorrect email try again!!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        int choise3 = ConsoleHelper.MultipleChoice(50, 9, false, 1, "Continue", "<-Back");
                        if (choise3 == 1) { goto SecondPart; }
                        if (choise3 == 0) { Console.Clear(); goto email; }
                    }
                }
                if (choise2 == 2)
                {
                    goto FirstPart;
                }
            }
        }

    }
}
