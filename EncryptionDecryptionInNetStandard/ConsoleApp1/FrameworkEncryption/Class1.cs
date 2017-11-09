using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
namespace FrameworkEncryption
{
    public class Class1
    {
        public EncrypDecryptModel GetStrValue()
        {
            EncrypDecryptModel encrypDecrypt = new EncrypDecryptModel();
            string encryptStr = "MyProtectionKey";
            byte[] x = Encoding.ASCII.GetBytes(encryptStr);
            var encryted = MachineKey.Protect(x);

            var decrypt = Encoding.ASCII.GetString(MachineKey.Unprotect(encryted));

            encrypDecrypt.protectedPayload = Encoding.ASCII.GetString(encryted);

            encrypDecrypt.unprotectedPayload = decrypt.ToString();
            return encrypDecrypt;
        }
        public class EncrypDecryptModel
        {
            public string unprotectedPayload { get; set; }
            public string protectedPayload { get; set; }

        }
    }
}
