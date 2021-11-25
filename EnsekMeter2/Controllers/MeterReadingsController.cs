using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EnsekMeter2.Data;
using EnsekMeter2.Models;
using EnsekMeter2.Code;

namespace EnsekMeter2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeterReadingsController : ControllerBase
    {
        private readonly EnsekMeter2Context _context;

        public MeterReadingsController(EnsekMeter2Context context)
        {
            _context = context;
        }

        // GET: api/MeterReadings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MeterReading>>> GetMeterReading()
        {
            return await _context.MeterReading.ToListAsync();
        }

        // GET: api/MeterReadings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MeterReading>> GetMeterReading(int id)
        {
            var meterReading = await _context.MeterReading.FindAsync(id);

            if (meterReading == null)
            {
                return NotFound();
            }

            return meterReading;
        }

        // PUT: api/MeterReadings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeterReading(int id, MeterReading meterReading)
        {
            if (id != meterReading.Id)
            {
                return BadRequest();
            }

            _context.Entry(meterReading).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeterReadingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MeterReadings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MeterReading>> PostMeterReading(MeterReading meterReading)
        {
            _context.MeterReading.Add(meterReading);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMeterReading", new { id = meterReading.Id }, meterReading);
        }
        [HttpPost("{filename}")]
   
        public async Task<IActionResult> MeterReadingUploads(string filename)
        {
            int successfulLoadCount = 0;
            int failedLoadCount = 0;

            List<CSVMeterReading> baseData = ReadCSV.Readfile(filename);
            List<MeterReading> validData = ReadCSV.ValidateData(baseData);
            // store the number that failed initial validation
            failedLoadCount = baseData.Count - validData.Count;

            foreach (MeterReading mr in validData)
            {
                // check that the account id given in the reading does exist
                var validAccount = await _context.Account
                 .FirstOrDefaultAsync(a => a.AccountId == mr.AccountId);
                if (validAccount != null)
                {
                    // Find a reading that exactly matches the csv provided data
                    var reading = await _context.MeterReading
                 .FirstOrDefaultAsync(m => m.AccountId == mr.AccountId & 
                 m.MeterReadingDateTime == mr.MeterReadingDateTime & 
                 m.MeterReadingValue == mr.MeterReadingValue);

                    if (reading == null)
                    {
                        _context.MeterReading.Add(mr);
                        await _context.SaveChangesAsync();
                        // accumulate a success count
                        successfulLoadCount = successfulLoadCount + 1;
                    }
                    else
                    {
                        // accumulate a fail count
                        failedLoadCount = failedLoadCount + 1;
                    }
                }
                else
                {
                    // accumulate a fail count
                    failedLoadCount = failedLoadCount + 1;
                }
            }
         
            return Ok("File loaded" + filename + ": Successful rows = " + successfulLoadCount + ", Failed rows = " + failedLoadCount);
        }
        

        // DELETE: api/MeterReadings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeterReading(int id)
        {
            var meterReading = await _context.MeterReading.FindAsync(id);
            if (meterReading == null)
            {
                return NotFound();
            }

            _context.MeterReading.Remove(meterReading);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MeterReadingExists(int id)
        {
            return _context.MeterReading.Any(e => e.Id == id);
        }
    }
}
