using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Linq;
using EventCalendar.EventType;

using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using EventCalendar;
using System.Text;
using System.Diagnostics.Tracing;

internal class Program
{
    public static void Main(string[] args)
    {
        Insturction(11);
    }

    public  static void Insturction(int v)
    {

        Console.WriteLine("Choose Event:");
        Console.WriteLine("1.Add New Event:");
        Console.WriteLine("2.Change Event:");
        Console.WriteLine("3.Remove Event:");
        Console.WriteLine("4.Change Event Status:");
        Console.WriteLine("5.View All Events:");
        Console.WriteLine("6.View All Event By Date:");
         int userInput = Convert.ToInt32(Console.ReadLine());


        if(userInput == 1)
        {
            Console.WriteLine("Type Of Event: ");
            Console.WriteLine("1.Birthady:");
            Console.WriteLine("2.Meeting:");
            Console.WriteLine("3.Party:");
            Console.WriteLine("4.Online Meeting");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            if(userInput1 == 1)
            {
                var newMeeting = new holiday();
                
                newMeeting.Holiday();
               
                Console.WriteLine("Want To Add New Event>: 1.Yes 2.No\n");
               
                int choice = Convert.ToInt32(Console.ReadLine());

              
                if(choice == 1)
                {
                 Insturction(11); 
                }
                else
                {
                    Console.WriteLine("Job Done");
                }

               


                    
                
                
            }
            else if (userInput1 == 2)
            {
                var newMeeting = new Meeting(); 
                newMeeting.Meeting();

              Console.WriteLine(" Want To Add New Event>: 1.Yes 2.No");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Insturction(11);
                }
                else if(choice == 2)
                {
                    Console.WriteLine("Job Done");
                }

               
            }
            else if (userInput1 == 3)
            {
                var newMeeting = new GeneralEvent();;
                
                newMeeting.GeneralEvent();
                Console.WriteLine("Want To Add New Event>: 1.Yes 2.No");
                int choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 1)
                {
                    Insturction(11);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Job Done"); 
                }
                

                
            }
            else if(userInput1 == 4)
            {
                var newMeeting = new OnlineMeeting();
                newMeeting.OnlineMeeting();

            }
        }
        else if(userInput == 2)
        {
            Console.WriteLine("Please Enter Event Name:");

            
        }
        else if(userInput == 3)
        {
           
           

            
        }
        else if(userInput == 4)
        {

        }
        else if (userInput==5) 
        {
            try
            {

                EventBase eventBase = new EventBase();
                Console.WriteLine("Please Enter Event Stard and End date:");
                var startDate = Console.ReadLine().ToString();

                Console.WriteLine("Event End Date");
                var endDate = Console.ReadLine().ToString(); 

               
              
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }
        else if (userInput == 6) 
        {

        }
        else
        {
            Console.WriteLine("invalid input");
        
            Insturction(11);  
        }
      /*  C:\Users\01101\Desktop\C#_Local\TEST\EventCalendar\EventCalendar\EventCalendar\EventType\UserInput 
       */

}


       

    
      

       



    
}

