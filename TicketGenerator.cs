// See https://aka.ms/new-console-template for more information
// Hello World! program
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TambolaTicketGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p=new Program();
            p. Maketickets();
            //Console.WriteLine("Fuck");
        }

public void Maketickets()
{
  //collect used numbers to delete while retriving random 
 int [] trashCollect=new int[90];
   for(int ticket=0;ticket<6;ticket++)
   {
        //Tickets
    int[,]Ticket=new int[3,9]; 
    for(int i=0;i<3;i++)
    {
        for(int j=0;j<9;j++)
        {
            Ticket[i,j]=0;
        }
    }
//Check if ticket filled or not if not do it again
    int countItems=0;
    //VALIDATE TICKET COUNT 
 while (countItems<15)
    {
//For each column of the ticket, randomly choose a row and number from the grouped list above
   // Select a random Row
    Random ran= new Random();
    int RandomRow=ran.Next(0,3);
    int R=RandomRow;

   // Select a random Column
   int ranC= ran.Next(0,9);
   int rC=ranC;
    //Random col number
    int RandomNumber=ColumnNumber(rC,trashCollect);

//If the row is not already full (<5) and the number in that location is 0
    //count row item (Validate)
    int Rowcounter=0;
    for(int row=0;row<9;row++)
    {   
        int temp=Ticket[R,row];
        if(temp!=0)
        {
            Rowcounter++;
        }
    }
    //count column item (Validate)
    int columnCounter=0;
    for(int col=0;col<3;col++)
    {
        if (Ticket[col,rC]!=0)
        {
            columnCounter++;
        }
    }

    //Add if row  count is <5
    if(Rowcounter<5 && columnCounter<2 && Ticket[R,rC]==0)
    { 
        Ticket[R,rC]=RandomNumber;
        trashCollect[countItems]=RandomNumber;
        countItems++;  
    }
     //Putting Trash On an array
        
    
    
  }
    
    //print ticket
    for(int k=0;k<3;k++)
    {
        for(int l=0;l<9;l++)
        {
            int a=Ticket[k,l];
            Console.Write(a);
             Console.Write("  ");
        }
        Console.WriteLine("\n");
    }
    Console.Write("*************************\n");
   }
} 


public int ColumnNumber(int columnNumber,int []Delete)
{
    Random ran=new Random(); 
    int c= 0;
switch(columnNumber)
     {    
         case 0: 
         {    
        var COLUMN=new List <int>{1,2,3,4,5,6,7,8,9,10}; 
        foreach(int items in Delete)
        {
            COLUMN.Remove(items);  
        } 
        int Number= ran.Next(COLUMN.Count);
        int RandomNumber=COLUMN[Number];
        c=RandomNumber;

             break;
         }
         case 1:
         {
            var COLUMN=new List <int>{11,12,13,14,15,16,17,18,19,20};
              foreach(int items in Delete)
             {
                 COLUMN.Remove(items);  
             } 
            int Number= ran.Next(COLUMN.Count);
            int RandomNumber=COLUMN[Number];
            c=RandomNumber;
            break; 

         }
         case 2:
         {
            var COLUMN=new List <int>{21,22,23,24,25,26,27,28,29,30}; 
            foreach(int items in Delete)
            {
                  COLUMN.Remove(items);  
            } 
            int Number= ran.Next(COLUMN.Count);
            int RandomNumber=COLUMN[Number];
            c=RandomNumber;
             break;
         }
         case 3:
         {
                 var COLUMN=new List <int>{31,32,33,34,35,36,37,38,39,40};
                 foreach(int items in Delete)
                  {
                         COLUMN.Remove(items);  
                  } 
                 int Number= ran.Next(COLUMN.Count);
                 int RandomNumber=COLUMN[Number];
                 c=RandomNumber;
             break;
         }
         case 4:
         {
            var COLUMN=new List <int>{41,42,43,44,45,46,47,48,49,50};
            foreach(int items in Delete)
            {
                COLUMN.Remove(items);  
            } 
            int Number= ran.Next(COLUMN.Count);
            int RandomNumber=COLUMN[Number];
            c=RandomNumber;
             break;
         }
         case 5:
         {
            var COLUMN=new List <int>{51,52,53,54,55,56,57,58,59,60};
             foreach(int items in Delete)
            {
                COLUMN.Remove(items);  
            } 
            int Number= ran.Next(COLUMN.Count);
            int RandomNumber=COLUMN[Number];
            c=RandomNumber;
             break;
         }
         case 6:
         {
            var COLUMN=new List <int>{61,62,63,64,65,66,67,68,69,70};
             foreach(int items in Delete)
            {
                COLUMN.Remove(items);  
            } 
            int Number= ran.Next(COLUMN.Count);
            int RandomNumber=COLUMN[Number];
            c=RandomNumber;
             break;
         }
         case 7:
         {
             var COLUMN=new List <int>{71,72,73,74,75,76,77,78,79,80};
              foreach(int items in Delete)
            {
                COLUMN.Remove(items);  
            } 
             int Number= ran.Next(COLUMN.Count);
             int RandomNumber=COLUMN[Number];
             c=RandomNumber;
            break;
         }
         case 8:
         {
              var COLUMN=new List <int>{81,82,83,84,85,86,87,88,89,90};
               foreach(int items in Delete)
            {
                COLUMN.Remove(items);  
            } 
              int Number= ran.Next(COLUMN.Count);
              int RandomNumber=COLUMN[Number];
              c=RandomNumber;
             break;
         }    
     }
     return c;
}
           
    }
}

