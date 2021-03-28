using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibs
{
    public static class CommonHelper
    {
        public static object StringToObject(string stringValue)
        {
            try
            {
                return Decimal.Parse(stringValue, CultureInfo.InvariantCulture);
            }
            catch
            {
                return DBNull.Value;
            }
        }

        public static string CheckDirectoryPath(string directoryPath)
        {
            if (directoryPath.Length < 3)
            {
                return "";
            }
            return directoryPath;
        }

        public static int ByteArrayToFile(byte[] array, string fileName)
        {
            try
            {
                FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                fileStream.Write(array, 0, array.Length);
                return 0;
            }
            catch
            {
                return -1;
            }
        }

        public static byte[] ByteArrayFromFile(string fileName)
        {
            try
            {
                using (FileStream fs = File.OpenRead(fileName))
                {
                    byte[] bytes = new byte[fs.Length];
                    fs.Read(bytes, 0, Convert.ToInt32(fs.Length));
                    fs.Close();
                    return bytes;
                }
            }
            catch
            {
                return null;
            }
        }

        public static string CreateDirectories(string path)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                List<string> list = new List<string>(path.Split('\\'));
                foreach (string item in list)
                {
                    if (item.Length > 0)
                    {
                        sb.Append(item);
                        sb.Append("\\");
                        path = sb.ToString();
                        if (Directory.Exists(path) == false)
                        {
                            Directory.CreateDirectory(path);
                        }
                    }
                }
                return path;
            }
            catch
            {
                //errorLog.Add("CommonHelper", "CreateDirectories", ex.Message);
                throw;
            }
        }

        public static string CreateDirectoriesForFiles(string path, DateTime dateTime)
        {
            try
            {
                if (string.IsNullOrEmpty(path) == false)
                {
                    if (path[path.Length - 1] != '\\')
                    {
                        path += "\\";
                    }
                }
                StringBuilder sb = new StringBuilder(path);
                sb.Append(dateTime.Year.ToString("D4"));
                sb.Append("\\");
                sb.Append(dateTime.Month.ToString("D2"));
                sb.Append("\\");
                sb.Append(dateTime.Day.ToString("D2"));
                sb.Append("\\");
                //sb.Append(dateTime.Year.ToString("D4"));
                //sb.Append(dateTime.Month.ToString("D2"));
                //sb.Append(dateTime.Day.ToString("D2"));
                //sb.Append("\\");
                return CreateDirectories(sb.ToString());
            }
            catch
            {
                //errorLog.Add("CommonHelper", "CreateDirectoriesForFiles", ex.Message);
                throw;
            }
        }

        private static string CryptoKey = "basdf*%*&%S-:37697edf7t6:L:LI#$(DFE";

        public static string Encrypt(string toEncrypt, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);
            string key = CryptoKey;
            if (string.IsNullOrEmpty(toEncrypt) == false)
            {
                if (useHashing)
                {
                    MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                    keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    hashmd5.Clear();
                }
                else
                {
                    keyArray = UTF8Encoding.UTF8.GetBytes(key);
                }
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tdes.CreateEncryptor();
                byte[] resultArray =
                  cTransform.TransformFinalBlock(toEncryptArray, 0,
                  toEncryptArray.Length);
                tdes.Clear();
                return Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }
            return "";
        }

        public static string Decrypt(string cipherString, bool useHashing)
        {
            byte[] keyArray;
            if (string.IsNullOrEmpty(cipherString) == false)
            {
                byte[] toEncryptArray = Convert.FromBase64String(cipherString);
                string key = CryptoKey;
                if (useHashing)
                {
                    MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                    keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    hashmd5.Clear();
                }
                else
                {
                    keyArray = UTF8Encoding.UTF8.GetBytes(key);
                }

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                tdes.Clear();
                return UTF8Encoding.UTF8.GetString(resultArray);
            }
            return "";
        }

        public static Encoding ParseEncoding(string encoding, Encoding defaultEncoding)
        {
            // koniecznie do poprawki
            try
            {
                if (encoding == "UTF-8")
                {
                    return Encoding.UTF8;
                }
                else if (encoding == "Unicode")
                {
                    return Encoding.Unicode;
                }
                else
                {
                    int codePage;
                    try
                    {
                        codePage = Convert.ToInt32(encoding);
                        return Encoding.GetEncoding(codePage);
                    }
                    catch
                    {
                        return defaultEncoding;
                    }
                }
            }
            catch
            {
                return defaultEncoding;
            }
        }

        public static string GetRegisterValue(string registryPath, string valueName)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(registryPath, true);
                string value = (string)key.GetValue(valueName);
                key.Close();
                return value;
            }
            catch
            {
                return "";
            }
        }

        public static int CreateRegisterKey(string registryPath, string keyName, string value)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.CreateSubKey(registryPath + "\\" + keyName);
                key.SetValue(keyName, value);
                return 0;
            }
            catch
            {
                return -1;
            }
        }


    }
}
