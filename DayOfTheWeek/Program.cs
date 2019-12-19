using System;
using System.Collections.Generic;
using ProjectFile.Models;

namespace Project.Models {
  public class Program{
    static void Main()
    {
    
      Console.WriteLine("Hello! What date would you like to know the day of the week of?");
      Console.WriteLine("Write the date in the format Month/Day/19**");
      string stringDate = Console.ReadLine();
      string[] arr = stringDate.Split("/");
      int month = int.Parse(arr[0]);
      int day = int.Parse(arr[1]);
      int year = int.Parse(arr[2]);
      Date theDate = new Date(month, day, year);
      string answer = theDate.WhatDay();
      Console.WriteLine(answer);
     


      
    }
  }
}