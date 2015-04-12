using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SI_UK_Third
{
    public class StartMain
    {
        private IService Service; 

        public StartMain()
        {
            // CALL GETSTUDENTSERVICE AND CREATE THE INSTANCE HERE
            this.Service = LocateStudentService.GetStudentService();
        }

        public void Start()
        {
            //HERE CALL THE SERVE METHOD FOR REST OF THE WORK
            this.Service.Serve();
        }
    }
}
