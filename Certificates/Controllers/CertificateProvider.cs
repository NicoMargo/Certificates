using certificates.Models;
using certificates.Models.DB;
using System.Data.SqlClient;

namespace Certificates.Controllers
{
    public class CertificateProvider
    {
        public static Student getCertificateByCode(string code)
        {

            Student student = null;
            Certificate certificate = null;
            Dictionary<string, object> args = new Dictionary<string, object> {
                {"pCode", code}
            };

            try
            {
                SqlDataReader ConnectionReader = Helpers.CallProcedureReader("spCertificateGetByCode", args);
                if (ConnectionReader.Read())
                {
                    certificate = new Certificate(Convert.ToString(ConnectionReader["certificateName"]), Convert.ToDateTime(ConnectionReader["date"]) );

                    student = new Student( Convert.ToString(ConnectionReader["studentName"]), Convert.ToString(ConnectionReader["surname"]),certificate);

                }

               
            }
            catch (Exception e)
            {

            }

            Helpers.Disconect();
            return student;
        }

    }
}
