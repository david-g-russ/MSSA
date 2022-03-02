using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace EncryptionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var password = "Pa$$w0rd";
            var salt = "S@lt";
            var rgb = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));

            // algorithm
            var algo = new AesManaged();

            // key and initialization vector (IV)
            var rgbKey = rgb.GetBytes(algo.KeySize/8);
            var rgbIV = rgb.GetBytes(algo.BlockSize/8);

            var bufferstream = new FileStream(@"C:\Files\Secretdata.txt", FileMode.OpenOrCreate);
            var encryptoralgo = algo.CreateEncryptor(rgbKey, rgbIV);

            var cryptostream = new CryptoStream(bufferstream, encryptoralgo, CryptoStreamMode.Write);
            byte[] transform = Encoding.Unicode.GetBytes("This is secret text.");
            cryptostream.Write(transform, 0, transform.Length);
            cryptostream.FlushFinalBlock();
            cryptostream.Close();
            bufferstream.Close();
            Console.WriteLine("Text encrypted");

            // decryption

            byte[] decryptedbuffer = new byte[200];
            var decryptoralgo = algo.CreateDecryptor(rgbKey,rgbIV);

            var stream = new FileStream(@"C:\Files\Secretdata.txt", FileMode.Open);
            var decryptostream = new CryptoStream(stream, decryptoralgo, CryptoStreamMode.Read);
            decryptostream.Read(decryptedbuffer, 0, decryptedbuffer.Length);
            string s = Encoding.Unicode.GetString(decryptedbuffer);
            Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
