using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace howdy 
{
    public class HomeController
    {

        [Route("/greeting")]
        public String Get()
        {
            if (File.Exists("slowdown")) {
                Thread.Sleep(9000);
            }
            return "Howdy!";
        }

        [Route("/slowdown")]
        public String Slowdown()
        {
            if (!(File.Exists("slowdown"))) {
		File.Create("slowdown");
            }
            return "Slowdown initiated...";
        }
        
        [Route("/normal")]
        public String Normal()
        {
 	    if (File.Exists("slowdown")) {
                File.Delete("slowdown");
            }
            return "Back to normal speed...";
        }
    }
}
