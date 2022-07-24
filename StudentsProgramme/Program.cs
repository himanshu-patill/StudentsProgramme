using System;
using System.Linq;
using System.Collections.Generic;

public partial class StudentsProgramme
{

    public static void Main(string[] args)
    {
        Student[] newstudent = new Student[8];
        newstudent[0] = new Student { RollNumber = 6, Age = 11, Standard = 6, Name = "Raj", Address = "Andheri" };
        newstudent[1] = new Student { RollNumber = 1, Age = 7, Standard = 2, Name = "Himanshu", Address = "Dombivli" };
        newstudent[2] = new Student { RollNumber = 4, Age = 9, Standard = 4, Name = "Prajval", Address = "Sion" };
        newstudent[3] = new Student { RollNumber = 5, Age = 10, Standard = 5, Name = "Rohit", Address = "Dadar" };
        newstudent[4] = new Student { RollNumber = 3, Age = 12, Standard = 7, Name = "Varun", Address = "Kalyan" };
        newstudent[5] = new Student { RollNumber = 7, Age = 13, Standard = 7, Name = "Varun", Address = "Kalyan" };
        newstudent[6] = new Student { RollNumber = 2, Age = 8, Standard = 3, Name = "Yash", Address = "Mumbai" };
        newstudent[7] = new Student { RollNumber = 8, Age = 13, Standard = 8, Name = "Yash", Address = "Thane" };


        //Sorting by AGE
        for (int i = 0; i < newstudent.Length; i++)
        {
            for (int j = 0; j < newstudent.Length - 1; j++)
            {
                if (newstudent[j].Age > newstudent[j+1].Age)
                {
                    Student temp = newstudent[j];
                    newstudent[j] = newstudent[j + 1];
                    newstudent[j + 1] = temp;
                }
            }
        }

        //Display the array
        for (int i = 0; i < newstudent.Length; i++)
        {
            Console.WriteLine(newstudent[i].RollNumber + " " +
                              newstudent[i].Age + " " +  
                              newstudent[i].Standard + " " +  
                              newstudent[i].Name + " " +  
                              newstudent[i].Address );
        }

        Console.WriteLine("\n");

        //Removing duplicates
        var uniqueArray = newstudent.GroupBy(stud => stud.Name)
                           .Select(grp => grp.First());
                           //.ToArray();




        //Display the array
        for (int i = 0; i < uniqueArray.Count(); i++)
        {
            Console.WriteLine(newstudent[i].RollNumber + " " +
                              newstudent[i].Age + " " +
                              newstudent[i].Standard + " " +
                              newstudent[i].Name + " " +
                              newstudent[i].Address);
        }


        //for (int i = 0; i < newstudent.Length; i++)
        //{
        //    if (newstudent[i].Name == "Yash")
        //    {
        //        Console.WriteLine(newstudent[i].RollNumber + " " +
        //                      newstudent[i].Age + " " +
        //                      newstudent[i].Standard + " " +
        //                      newstudent[i].Name + " " +
        //                      newstudent[i].Address);

        //        break;
        //    }
        //}

        //var SortRollNumber = from stud
        //                     in StudentsArray
        //                     orderby stud.RollNumber
        //                     select stud;


        //Console.WriteLine("Task - 1:");

        //foreach (Student stud in SortRollNumber)
        //{
        //    Console.WriteLine(stud.RollNumber + " " +
        //                      stud.Age + " " +
        //                      stud.Standard + " " +
        //                      stud.Name + " " +
        //                      stud.Address
        //                      );
        //}

        //Console.WriteLine("\n");

        //Console.WriteLine("Task - 2:");



        //var FetchName = from studen
        //                in StudentsArray
        //                where studen.Name == "Yash"

        //                select studen;

        //foreach (Student studen in FetchName)
        //{
        //    Console.WriteLine(studen.RollNumber + " " +
        //                      studen.Age + " " +
        //                      studen.Standard + " " +
        //                      studen.Name + " " +
        //                      studen.Address
        //                      );
        //    break;
        //}



    }
}