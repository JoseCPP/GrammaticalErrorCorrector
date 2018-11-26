using MLTextCorrector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace MLTextCorrector.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post([FromBody]dynamic value)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            PassedInParam paramobj = js.Deserialize<PassedInParam>(value);

            string text = paramobj.text;

            Verification verification = new Verification();
            string verifiedValue = verification.ModelSpellCheck(HttpUtility.UrlEncode(text));
            //string verifiedValue = verification.SpellCheck();
            string correctedText = "Corrected Text :: " + verifiedValue;
            return correctedText;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
