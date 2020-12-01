using AppointmentSystem.Application.Contracts.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AppointmentSystem.API.Controllers
{
    /// <summary>
    /// Appointment controller
    /// </summary>
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        #region Properties
        private readonly IAppointmentService _appointmentService;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="appointmentService"></param>
        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }
        #endregion
        #region Methods

        /// <summary>
        ///Get by patient document
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetByPatientDocument")]
        public async Task<ActionResult> GetByPatientDocument([FromQuery] string Document)
        {
            return Ok(await _appointmentService.GetAppointmentsByPatientDocument(Document));
        }
        #endregion
    }
}
