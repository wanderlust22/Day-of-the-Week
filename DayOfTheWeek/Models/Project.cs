using System;
using System.Collections.Generic;

namespace ProjectFile.Models
{
  class Date
  {
    Dictionary<int, int> monthCode = new Dictionary<int, int>() { {01, 1}, {02, 4}, {03, 4}, {04, 0}, {05, 2}, {06, 5}, {07, 0}, {08, 3}, {09, 6}, {10, 1}, {11, 4}, {12, 6}};
    Dictionary<int, int> centuryCode = new Dictionary<int, int>() { {15, 0}, {16, 6}, {17, 4}, {18, 2}, {19, 0}, {20, 6} };
    Dictionary<int, string> dayCode = new Dictionary<int, string>() { {0, "Saturday"}, {1, "Sunday"}, {2, "Monday"}, {3, "Tuesday"}, {4, "Wednesday"}, {5, "Thursday"}, {6, "Friday"} };

    public int Month { get; set; }
    public int Day { get; set; }
    public int Year { get; set; }

    public Date(int month, int day, int year) 
    {
      Month = month;
      Day = day;
      Year = year;
    }

    public string WhatDay()
    {
      int month = Month;
      int monthValue = monthCode[month];
      int dateValue = Day;

      int century = int.Parse(Year.ToString()[0].ToString() + Year.ToString()[1].ToString());
      int centuryValue =  centuryCode[century];

      int yearValue = int.Parse(Year.ToString()[3].ToString() + Year.ToString()[2].ToString());

      double doubler = yearValue / 4;
      double floor = Math.Floor(doubler);
      int otherValue = Convert.ToInt32(floor);


      int score = monthValue + dateValue + centuryValue + yearValue + otherValue;

      int remainder = score % 7;
      
      return dayCode[remainder];
    }


   
  }
}