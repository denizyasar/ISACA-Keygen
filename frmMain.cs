using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ISACA_Keygen
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            cboxExam.SelectedIndex = 0;
        }

        private void GenActivation_Click(object sender, EventArgs e)
        {
            if (txtHardwareCode.Text != string.Empty)
            {
                try
                {
                    var str = Regex.Replace(txtInstallCode.Text, @"\s+", "");
                    txtActivationCode.Text = GenerateActivationCode(str.Substring(str.Length - 3)).ToUpperInvariant();
                }
                catch (Exception ex)
                {
                    txtActivationCode.Text = ex.Message;
                }
            }
        }

        private string GenerateActivationCode(string partsMask)
        {
            var str =
                StringToDigits(Encrypt(Encrypt(Encrypt("Activate", "MLS Inc."), txtInstallCode.Text),
                                       txtHardwareCode.Text))
                .Substring(0, 14);
            var builder = new StringBuilder();
            builder.Append(partsMask);
            builder.Append(str);
            var checkSum = GetCheckSum(builder.ToString(), 0x3e7);
            var builder2 = new StringBuilder();
            builder2.Append(checkSum);
            builder2.Append(str.Substring(0, 2));
            builder2.Append("-");
            builder2.Append(str.Substring(2, 5));
            builder2.Append("-");
            builder2.Append(str.Substring(7, 5));
            builder2.Append("-");
            builder2.Append(str.Substring(12));
            builder2.Append(partsMask);
            return builder2.ToString();
        }

        private void GenSerial_Click(object sender, EventArgs e)
        {
            string str3, checkSum, key = string.Empty;

            switch (cboxExam.SelectedIndex)
            {
                case 0:
                    key = "ICISA-2013.0-";
                    break;
                case 1:
                    key = "ICISM-2013.0-";
                    break;
                case 2:
                    key = "ICISA-2014.0-";
                    break;
                case 3:
                    key = "ICISM-2014.0-";
                    break;
                case 4:
                    key = "ICISA-2015.0-";
                    break;
                case 5:
                    key = "ICISM-2015.0-";
                    break;
                case 6:
                    key = "ICISA-2016.0-";
                    break;
                case 7:
                    key = "ICISM-2016.0-";
                    break;
                default:
                    break;
            }

            do
            {
                txtInstallCode.Text = key;

                var s = string.Empty;
                var generated = new HashSet<int>();
                var r = new Random();
                for (var i = 1; i < 3; i++)
                {
                    int a;
                    do
                    {
                        a = r.Next(10000, 99999);
                    } while (generated.Contains(a));
                    generated.Add(a);

                    s = s + a + "-";
                }
                txtInstallCode.Text = $"{txtInstallCode.Text}{s}987";
                var code = (Regex.Replace(txtInstallCode.Text, @"\s+", "")).ToUpperInvariant();

                var parts = code.Split('-');

                var builder = new StringBuilder();
                var str = parts[3].Substring(2) + parts[4].Substring(0, 2);
                builder.Append(parts[4].Substring(2));
                builder.Append(str);
                builder.Append(parts[2]);
                builder.Append(parts[1]);
                builder.Append(parts[0]);
                checkSum = GetCheckSum(builder.ToString(), 0x63);
                str3 = parts[3].Substring(0, 2);
            } while (str3 != checkSum);
        }

        private static int GetCharacterValue(string character)
        {
            if (character.Length != 1)
                throw new ArgumentException("Character string is too long.");
            return character.ToCharArray()[0];
        }

        private static PasswordDeriveBytes GetPasswordDerivedBytes(string password)
        {
            return new PasswordDeriveBytes(password,
                                           new byte[]
                { 0x49, 0x76, 0x61, 110, 0x20, 0x4d, 0x65, 100, 0x76, 0x65, 100, 0x65, 0x76 });
        }

        public static string Encrypt(string clearText, string password)
        {
            var clearData = Encoding.Unicode.GetBytes(clearText);
            var passwordDerivedBytes = GetPasswordDerivedBytes(password);
            return
                Convert.ToBase64String(Encrypt(clearData,
                                               passwordDerivedBytes.GetBytes(0x20),
                                               passwordDerivedBytes.GetBytes(0x10)));
        }

        public static byte[] Encrypt(byte[] clearData, byte[] key, byte[] IV)
        {
            var stream = new MemoryStream();
            var rijndael = Rijndael.Create();
            rijndael.Key = key;
            rijndael.IV = IV;
            var stream2 = new CryptoStream(stream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);
            stream2.Write(clearData, 0, clearData.Length);
            stream2.Close();
            return stream.ToArray();
        }


        public static string GetCheckSum(string chars, int maxValue)
        {
            chars = chars.ToUpperInvariant();
            var num = 0;
            for (var i = 0; i < chars.Length; i++)
            {
                num += GetCharacterValue(chars.Substring(i, 1));
                while (num > maxValue)
                    num = (num / 10) + (num % 10);
            }
            var length = maxValue.ToString().Length;
            var str = num.ToString();
            if (str.Length < length)
            {
                str = "000000000" + str;
                str = str.Substring(str.Length - length);
            }
            return str;
        }

        public static byte[] StringToBytes(string data) { return new ASCIIEncoding().GetBytes(data); }


        public static string StringToDigits(string data)
        {
            var buffer = StringToBytes(data);
            var builder = new StringBuilder();
            foreach (var num in buffer)
            {
                var str = "0000" + num;
                str = str.Substring(str.Length - 3);
                builder.Append(str.Substring(2, 1));
                builder.Append(str.Substring(0, 1));
                builder.Append(str.Substring(1, 1));
            }
            return builder.ToString();
        }
    }
}