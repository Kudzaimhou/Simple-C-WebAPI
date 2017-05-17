using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI
{
    public class WorkerDetails
    {

        public int workerID { set; get; }
        public string workerName { set; get; }
        public int workerProcessID { set; get; }
        public string workerStatus { set; get; }
    }
}