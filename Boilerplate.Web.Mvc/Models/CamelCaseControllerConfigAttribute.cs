using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using Newtonsoft.Json.Serialization;

namespace Boilerplate.Web.Mvc.Models
{
    /// <summary>
    /// Forces an ApiController class that is marked with this attribute to return results in camel-cased JSON format.
    /// </summary>
    /// <remarks>
    /// Rather than make a global change that causes all controllers to return camel-cased json, this can be used selectively
    /// to ensure existing calls will still work as expected. (Client behavior will not change on classes not marked
    /// with this attribute)
    /// </remarks>
    public sealed class CamelCaseControllerConfigAttribute : Attribute, IControllerConfiguration
    {
        public void Initialize(HttpControllerSettings controllerSettings, HttpControllerDescriptor controllerDescriptor)
        {
            var formatter = controllerSettings.Formatters.OfType<JsonMediaTypeFormatter>().Single();
            controllerSettings.Formatters.Remove(formatter);

            formatter = new JsonMediaTypeFormatter
            {
                SerializerSettings = { ContractResolver = new CamelCasePropertyNamesContractResolver() },
                SupportedMediaTypes = { new System.Net.Http.Headers.MediaTypeHeaderValue("text/html") }
            };

            controllerSettings.Formatters.Add(formatter);
        }
    }
}
