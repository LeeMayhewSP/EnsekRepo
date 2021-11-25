using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EnsekMeter2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUpload : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok("file uploading...");
        }
        [HttpPost]
        [Route("meter-reading-uploads")]
        public async Task<IActionResult> Upload(IFormFile file)
        {

            // full path to file in temp location
            var filePath = Path.GetTempFileName();

                if (file.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
          

           // this file is in a temp folder on the c drive,
           // wanted it in the project so I could read it from here

                // can't find an understandable way on google to do it yet

            return Ok(new {  filePath });

        }
    }
}
