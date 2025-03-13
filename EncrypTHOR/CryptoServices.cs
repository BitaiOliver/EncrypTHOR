using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;

namespace EncrypTHOR
{
    class CryptoServices
    {
        private ConversionHandler myConverter = new ConversionHandler();
        //private EncrypTHOR EncrypT = new EncrypTHOR();

        private string AesKey = "";// EncrypT.GetAesKey_forEncrypt();
       // private hkj = EncrypT

        private string AesIV = "6D629094008F2A8FCD909E59DED015D5";

        /* old name PasswordEncrypt*/
        /* Takes a string (ex: password) and generates a hash(sha512) from it */
        private string StringToHasht(string text)
        {
            byte[] hashValue;
            SHA256CryptoServiceProvider mysha512 = new SHA256CryptoServiceProvider();

            hashValue = mysha512.ComputeHash(myConverter.StringToByteArray(text));
            return myConverter.ByteArrayToHexString(hashValue);
        }

        /* Takes a string and returns it cripted */
        private string EncryptString_AES(string text)
        {
            //Setting the key and IV
            byte[] Key = myConverter.HexStringToByteArray(AesKey);
            byte[] IV = myConverter.HexStringToByteArray(AesIV);
            byte[] encrypted;

            using (AesManaged myAes = new AesManaged())
            {
                // Check arguments.
                if (text == null || text.Length <= 0)
                    throw new ArgumentNullException("text");
                if (Key == null || Key.Length <= 0)
                    throw new ArgumentNullException("Key");
                if (IV == null || IV.Length <= 0)
                    throw new ArgumentNullException("IV");

                myAes.Key = Key;
                myAes.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = myAes.CreateEncryptor(myAes.Key, myAes.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(text);
                        }
                    }
                    encrypted = msEncrypt.ToArray();
                }
            }
            return (myConverter.ByteArrayToHexString(encrypted));
        }

        private string DecryptString_AES(string text)
        {
            byte[] Key = myConverter.HexStringToByteArray(AesKey);
            byte[] IV = myConverter.HexStringToByteArray(AesIV);
            string decrypted = null;

            // Check arguments.
            if (text == null || text.Length <= 0)
                throw new ArgumentNullException("text");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(myConverter.HexStringToByteArray(text)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            decrypted = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }
            return decrypted;
        }

        public string Encript(string passw, string plaintxt)
        {
            AesKey = StringToHasht(passw);
            return EncryptString_AES(plaintxt);
        }

        public string Decript(string passw, string plaintxt)
        {
            string retStr = null;
            try
            {
                AesKey = StringToHasht(passw);
                retStr = DecryptString_AES(plaintxt);
            }
            catch (CryptographicException e)
            {    
                MessageBox.Show("!!!   Wrong password.  !!!");
            }


            //AesKey = StringToHasht(passw);
            return retStr;
        }


    }
}
