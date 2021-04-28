using Microsoft.AspNetCore.Mvc;

using Sales.Bussiness.Services;
using Sales.DataAccess.models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class invoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public invoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpPost("CreateInvoice")]
        public IActionResult CreateInvoice(Invoice invoice)
        {

            var result = _invoiceService.AddInvoice(invoice);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("GetInvoices")]
        public IActionResult GetInvoices()
        {
            var result = _invoiceService.GetInvoices();
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("GetInvoice/{id}")]
        public IActionResult GetInvoice(int id)
        {
            var result = _invoiceService.GetInvoiceById(id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("UpdateInvoice")]
        public IActionResult UpdateInvoice(Invoice invoice)
        {
            var result = _invoiceService.UpdateInvoice(invoice);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("DeleteInvoice/{id}")]
        public IActionResult DeleteInvoice(int id)
        {
            var result = _invoiceService.DeleteInvoice(id);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
