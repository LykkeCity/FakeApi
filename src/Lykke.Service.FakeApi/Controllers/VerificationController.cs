using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Common.Log;
using Lykke.Common.Api.Contract.Responses;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lykke.Service.FakeApi.Controllers
{
    [Route("api/[controller]")]
    public class VerificationController : ControllerBase
    {
        [HttpPost("IdAndSelfie")]
        [SwaggerOperation("VerifyIdAndSelfie")]
        [ProducesResponseType(typeof(VerifyIdAndSelfieResponse), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> VerifyIdAndSelfie()
        {
            return Ok(new VerifyIdAndSelfieResponse()
            {
                JumioIdScanReference = Guid.NewGuid().ToString(),
                TimeStamp = DateTime.UtcNow
            });
        }

        [HttpGet("VerificationStatus")]
        [SwaggerOperation("GetVerificationStatus")]
        [ProducesResponseType(typeof(Verification), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> GetVerificationStatus()
        {
            return Ok(new Verification());
        }

        [HttpGet("IdSelfieSimilarity")]
        [SwaggerOperation("GetIdSelfieSimilarity")]
        [ProducesResponseType(typeof(int?), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> GetIdSelfieSimilarity()
        {
            return Ok(null);
        }

        [HttpGet("ScanResult")]
        [SwaggerOperation("GetScanResult")]
        [ProducesResponseType(typeof(object), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> GetScanResult()
        {
            return Ok(null);
        }

        [HttpGet("SupportedIdTypes")]
        [SwaggerOperation("GetSupportedIdTypes")]
        [ProducesResponseType(typeof(Dictionary<string, List<string>>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> GetSupportedIdTypes()
        {
            return Ok(new Dictionary<string, List<string>>());
        }


        [HttpGet("SupportedDocumentTypes")]
        [SwaggerOperation("GetSupportedDocumentTypes")]
        [ProducesResponseType(typeof(List<JumioDocumentTypesResponse>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> GetSupportedDocumentTypes()
        {
            return Ok(new JumioDocumentTypesResponse()
            {
                TimeStamp = DateTime.UtcNow,
                SupportedDocumentTypes = new List<JumioDocumentType>()
            });
        }
    }

    public class VerifyIdAndSelfieResponse
    {
        [JsonProperty]
        public DateTime TimeStamp { get; set; }

        [JsonProperty]
        public string JumioIdScanReference { get; set; }
    }

    public class Verification
    {
        public string State => "Started";
        public int? Status => null;
        public string ClientId => Guid.Empty.ToString();
        public string JumioScanId => Guid.Empty.ToString();
        public int? SelfieSimilarity => null;
        public DateTime JumioTimeStamp => DateTime.UtcNow;
    }

    public class JumioDocumentTypesResponse
    {
        public DateTime TimeStamp { get; set; }

        public List<JumioDocumentType> SupportedDocumentTypes { get; set; }
    }

    public class JumioDocumentType
    {
        public string Code { get; set; }

        public string Name { get; set; }
    }
}
