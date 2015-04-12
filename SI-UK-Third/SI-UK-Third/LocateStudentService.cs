using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SI_UK_Third
{
  public  class LocateStudentService
    {
      //THIS IS LOCATE WHICH WORKS AS MEDIATOR BETWEEN CALLING METHOD AND MAIN SERVICE METHOD(MAIN METHOD)
      //ALL REQUEST VIA THIS LOCATOR 
      public static IService _Service { get; set; }

      public static IService GetStudentService()
      {
          if (_Service == null)
              _Service = new StudentService();

          return _Service;

      }
    }
}
