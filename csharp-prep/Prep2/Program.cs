using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        // Prompt user for thier grade percentage
        Console.Write("What is your grade percentage(%)? ");
        string gradepercenttext = Console.ReadLine();
        // Convert string to int
        int gradepercent = int.Parse(gradepercenttext);
        // get ones place for grade sign
        int graderemainder = gradepercent % 10;
        // init variables
        string grade = "";
        string gradesign = "";

        // Determine Grade Letter
        if (gradepercent >= 90)
        {
             grade = "A";
        }     
        else if (gradepercent >= 80)
        {
             grade = "B";
        }     
        else if (gradepercent >= 70)
        {
             grade = "C";
        }
        else if (gradepercent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        // Determine Grade sign.
        if (graderemainder >= 7 && gradepercent < 97 && gradepercent > 60)
        {
            gradesign = "+";
        }
        else if (graderemainder <= 3 && gradepercent > 60)
        {
            gradesign = "-";
        }    
        else
        {
            gradesign = ""; 
        }
        // Display Grade results
        Console.WriteLine($"Your grade is {grade}{gradesign}.");       
    }
}

