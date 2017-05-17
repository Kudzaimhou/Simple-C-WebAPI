using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace WebAPI
{
    public class WorkerController : ApiController
    {
        WorkerDetails[] st = new WorkerDetails[]
       {
            new WorkerDetails
            {
                workerID = 1, workerName = "push clutch pedal", workerProcessID = 1
            },
            new WorkerDetails
            {
                workerID = 2, workerName = "Key start inginition", workerProcessID = 2
            },
            new WorkerDetails
            {
                workerID = 3, workerName = "push break pedal", workerProcessID = 3
            },
            new WorkerDetails
            {
                workerID = 4, workerName = "release handbreak", workerProcessID = 4
            },
            new WorkerDetails
            {
                workerID = 5, workerName = "Gear One", workerProcessID = 5
            },
            new WorkerDetails
            {
                workerID = 6, workerName = "Release Clutch and breaks", workerProcessID = 6
            },
            new WorkerDetails
            {
                workerID = 6, workerName = "Yey i am driving", workerProcessID = 7
            }
       };
        public IEnumerable<WorkerDetails> GetAll()
        {
            return st;
        }
        public IHttpActionResult Get(int P_id)
        {
            var process = st.FirstOrDefault((s) => s.workerID == P_id);
            if (process== null)
            {
                return NotFound();
            }
            return Ok(process);
        }
    }
}

