using Konscious.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KlonsM.Classes
{
    public static class PasswordCrypt
    {
        public static string EncryptStrongPassword(string weakPassword, string strongPassword)
        {
            byte[] salt = GenerateRandomBytes(16); // Unique salt
            byte[] key = DeriveKeyFromWeakPassword(weakPassword, salt, 32); // AES-256 key
            byte[] iv = GenerateRandomBytes(12); // IV for AES-GCM

            using (AesGcm aes = new AesGcm(key, 16))
            {
                byte[] strongPasswordBytes = Encoding.UTF8.GetBytes(strongPassword);
                byte[] ciphertext = new byte[strongPasswordBytes.Length];
                byte[] tag = new byte[16]; // Authentication tag for AES-GCM

                aes.Encrypt(iv, strongPasswordBytes, ciphertext, tag);

                // Combine salt + IV + tag + ciphertext into a single array
                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(salt);
                    ms.Write(iv);
                    ms.Write(tag);
                    ms.Write(ciphertext);
                    var bytes = ms.ToArray();
                    var b64 = Convert.ToBase64String(bytes);
                    return b64;
                }
            }
        }

        public static string DecryptStrongPassword(string weakPassword, string encryptedDataB64)
        {
            var encryptedData = Convert.FromBase64String(encryptedDataB64);
            byte[] salt = new byte[16];
            byte[] iv = new byte[12];
            byte[] tag = new byte[16];
            byte[] ciphertext = new byte[encryptedData.Length - 16 - 12 - 16];

            using (MemoryStream ms = new MemoryStream(encryptedData))
            {
                ms.Read(salt);
                ms.Read(iv);
                ms.Read(tag);
                ms.Read(ciphertext);
            }

            byte[] key = DeriveKeyFromWeakPassword(weakPassword, salt, 32);

            using (AesGcm aes = new AesGcm(key, 16))
            {
                byte[] decryptedBytes = new byte[ciphertext.Length];
                aes.Decrypt(iv, ciphertext, tag, decryptedBytes);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }

        static byte[] GenerateRandomBytes(int length)
        {
            byte[] bytes = new byte[length];
            RandomNumberGenerator.Fill(bytes);
            return bytes;
        }

        static byte[] DeriveKeyFromWeakPassword(string password, byte[] salt, int keySize)
        {
            using (var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password)))
            {
                argon2.Salt = salt;
                argon2.DegreeOfParallelism = 2; // Use multiple CPU cores
                argon2.MemorySize = 65536; // 64 MB RAM usage (adjustable)
                argon2.Iterations = 15; // Number of iterations
                return argon2.GetBytes(keySize);
            }
        }

    }
}
