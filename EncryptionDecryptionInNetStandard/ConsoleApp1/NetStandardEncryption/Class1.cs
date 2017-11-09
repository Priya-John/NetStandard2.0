using System;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;

namespace NetStandardEncryption
{
    public class Class1
    {
        IDataProtector _protector;

        // the 'provider' parameter is provided by DI
        public Class1(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("Contoso.MyClass.v1");
        }
        public EncrypDecryptModel GetStrValue()
        {
            EncrypDecryptModel encrypDecrypt = new EncrypDecryptModel();
            string encryptStr = "MyProtectionKey";
            encrypDecrypt.protectedPayload = _protector.Protect(encryptStr);


            // unprotect the payload
            encrypDecrypt.unprotectedPayload = _protector.Unprotect(encrypDecrypt.protectedPayload);



            return encrypDecrypt;
        }
        public class EncrypDecryptModel
        {
            public string unprotectedPayload { get; set; }
            public string protectedPayload { get; set; }

        }
    }
}
