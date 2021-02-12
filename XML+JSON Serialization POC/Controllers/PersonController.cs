using System.Web.Http;

namespace XML_JSON_Serialization_POC.Controllers
{
    public class PersonController : ApiController
    {
       public Person Post([FromBody] Person person)
        {
            return person;
        }
    }
}