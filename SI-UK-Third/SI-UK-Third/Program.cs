using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SI_UK_Third
{
    class Program
    {
        //THIS PROGRAM MAIN CALSS IS NOT DEPEND ON THE MAIN Method
        //HERE I USED SERVICE LOCATER OF IOC DESIGN PATTERN
        //BY USING THIS CODE IS LOOSELY COUPLED 
        //NOT DIRECT DEPENDS ON SERVICE, IT'S DEPENDS VIA LOCATER SO, IF ANY CHANGES IN SERVICE THEN NO IMPACT ON CALLING METHOD 
        //I USED HERE SERICE LOCATER DESIGN PATTERN IN IOC
        //ITS DEPENDS ON INTERFACE NOT DIRECT TO MAIN METHO    

        static void Main(string[] args)
        {
            var _StudentService = new StartMain();
            _StudentService.Start();
        }
    }
}
