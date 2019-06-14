using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QLHS.DAO
{
    public class CheckType
    {
        private static CheckType instance;
        public static CheckType Instance { get { if (instance == null) instance = new CheckType(); return instance; } set => instance = value; }
        private CheckType() { }

        public bool CheckIsMail(string email)
        {
            string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex reg = new Regex(match);
            return reg.IsMatch(email);
        }
        public bool CheckIsPhone(string phone)
        {
            if (phone.Length > 11 || phone.Length < 10)
            {
                return false;
            }
            Regex reg = new Regex("(\\+84|0)\\d{9,10}");
            return reg.IsMatch(phone);
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        public bool CheckMaGV(string magv)
        {
            string match = @"^GV+[0-9]{3}";
            Regex regex = new Regex(match);
            return regex.IsMatch(magv);
        }
        public bool CheckMaNamHoc(string manamhoc)
        {
            string match = @"^NH+[0-9]{8}";
            Regex regex = new Regex(match);
            return regex.IsMatch(manamhoc);
        }
        public static string chuanHoaTen(string str)
        {
            string STRING = "";
            str = str.Trim().ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0)
                    STRING = STRING + str[i].ToString().ToUpper();
                else
                    STRING = STRING + str[i];
                if (str[i] == ' ')
                {
                    while (str[i] == ' ')
                        i++;
                    STRING = STRING + str[i].ToString().ToUpper();
                }
            }
            return STRING.ToString();
        }

        public static string chuanHoaMa(string str)
        {
            string STRING = "";
            str = str.Trim();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    while (str[i] == ' ')
                        i++;
                    STRING = STRING + str[i];
                }
                else
                    STRING = STRING + str[i];
            }
            return STRING.ToString().ToUpper();
        }

        public bool CheckMaHS(string mahs)
        {
            string match = @"^HS+[0-9]{4}";
            Regex regex = new Regex(match);
            return regex.IsMatch(mahs);
        }
        public bool CheckMaLop(string malop)
        {
            string match = @"(10A|11A|12A|10B|11B|12B|1OC|11C|12C)[0-9]{1}(NH+[0-9]{8})";
      
            Regex regex = new Regex(match);
            return regex.IsMatch(malop);
        }
        public String ArrayToString(String[] array, int n)
        {
            String str = "";
            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                    str += array[i] + ";";
                else
                    str += array[i];
            }
            return str;
        }
        public static void GooglePlace(TextBox textBox, ListView listView)
        {
            if (textBox != null)
            {
                listView.Items.Clear();
                if (textBox.Text.Length >= 1)
                {
                    listView.Show();
                    String input = textBox.Text;
                    String apiKey = "AIzaSyDF98ncP2yiAVc6VC_e9g_Y_lBw2CNwnYc";
                    String URLString = "https://maps.googleapis.com/maps/api/place/autocomplete/xml?&query=main&location=15.5393538,108.019102&radius=822400&input=" + input + "&types=geocode&language=vi&key=" + apiKey;
                    //String URLString = "http://maps.googleapis.com/maps/api/geocode/json?address=" + input + "&types=geocode&language=vi&sensor=false";
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(URLString);
                    listView.Items.Clear();
                    string temp;
                    foreach (XmlNode node in xmlDoc.GetElementsByTagName("prediction"))
                    {
                        foreach (XmlNode node1 in node.ChildNodes)
                        {
                            if (node1.Name == "description")
                            {
                                temp = node1.InnerText;
                                listView.Items.Add(temp);
                            }
                        }
                    }
                    xmlDoc.DocumentElement.RemoveAll();
                }

            }
        }
    }
}
