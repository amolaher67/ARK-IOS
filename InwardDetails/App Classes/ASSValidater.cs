using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Data.SqlClient;
using System.Net;
using System.Management;
namespace InwardDetails
{
    public enum AssValidation
    {
        TelePhone,
        Mobile,
        Name,
        ProductName,
        Address,
        Amount,
        Number,
        Email,
        Web,
        Batch,
        EntryNo
    }
    public static class ASSValidater
    {

        public static void IsValid(char Char, AssValidation Validation)//Valid Character for Number,Mobile
        {
            if (Validation == AssValidation.Number)
            {
                if (char.IsDigit(Char) == false && Char != (char)Keys.Back && Char.ToString() != "\r" && Char!=(char)Keys.Escape)
                      throw new ApplicationException("In valid character " + Char + "! Please Insert valid character.");
            }

            if (Validation == AssValidation.Mobile)
            {
                if (char.IsDigit(Char) == false && Char.ToString() != "+" && Char != (char)Keys.Back && Char.ToString() != "\r" && Char != (char)Keys.Escape)
                    throw new ApplicationException("In valid character " + Char + " In Mobile! Please Insert valid character.");
            }

            if (Validation == AssValidation.TelePhone)
            {
                if (char.IsDigit(Char) == false && Char.ToString() != "(" && Char.ToString() != ")" && Char != (char)Keys.Back && Char.ToString() != "\r" && Char != (char)Keys.Escape)
                  throw new ApplicationException("In valid character " + Char + " In Telephone! Please Insert valid character eg.(0253)2518541");

            }

            if (Validation == AssValidation.Address)
            {
                //if (Char.ToString() == "~" || Char.ToString() == "`" || Char.ToString() == "@" || Char.ToString() == "#" || Char.ToString() == "$")
                //    throw new ApplicationException("In valid character " + Char + "! Please Insert valid character.");

            }

            if (Validation == AssValidation.Name)
            {
                if (char.IsLetter(Char) == false && Char.ToString() != "." && Char != ' ' && Char != (char)Keys.Back && Char.ToString() != "\r" && Char != (char)Keys.Escape)
                    throw new ApplicationException("In valid character " + Char + " In Name! Please Insert valid character");

            }

            if (Validation == AssValidation.ProductName)
            {
                if (char.IsLetterOrDigit(Char) == false && Char.ToString() != "*" && Char.ToString() != "." && Char.ToString() != "%" && Char.ToString() != "-" && Char.ToString() != "(" && Char.ToString() != ")" && Char != ' ' && Char != (char)Keys.Back && Char.ToString() != "\r" && Char != (char)Keys.Escape)
                    throw new ApplicationException("In valid character " + Char + " In Name! Please Insert valid character");
            }

            if (Validation == AssValidation.Batch)
            {
                if (char.IsLetterOrDigit(Char) == false && Char.ToString() != "*" && Char.ToString() != "%" && Char.ToString() != ":" && Char.ToString() != "." && Char.ToString() != "-" && Char.ToString() != "/" && Char.ToString() != "(" && Char.ToString() != ")" && Char != ' ' && Char != (char)Keys.Back && Char.ToString() != "\r" && Char != (char)Keys.Escape)
                    throw new ApplicationException("In valid character " + Char + " In Name! Please Insert valid character");
            }

            //if (Validation == AssValidation.Batch)
            //{
            //    if (char.IsLetterOrDigit(Char) == false && Char.ToString() != "." && Char.ToString() != "-" && Char.ToString() != "/" && Char.ToString() != "(" && Char.ToString() != ")" && Char != ' ' && Char != (char)Keys.Back && Char.ToString() != "\r" && Char != (char)Keys.Escape)
            //        throw new ApplicationException("In valid character " + Char + " In Name! Please Insert valid character");
            //}

            if (Validation == AssValidation.EntryNo)
            {
                if (char.IsLetterOrDigit(Char) == false && Char.ToString() != "-" && Char.ToString() != "/"  && Char != (char)Keys.Back && Char.ToString() != "\r" && Char != (char)Keys.Escape)
                    throw new ApplicationException("In valid character " + Char + " In Name! Please Insert valid character");
            }
        }
        public static void IsValid(string Amount, char Char, AssValidation Validation)//Valid Character for Amount
        {
            if (Validation == AssValidation.Amount)
            {
                if ((Amount.Contains(".") == true && Char.ToString() == ".") || (char.IsDigit(Char) == false && Char != (char)Keys.Back && Char.ToString() != "\r" && Char.ToString() != "."))
                    throw new ApplicationException("In valid character " + Char + " of Amount! Please Insert valid character.");
            }
        }

        public static void IsValid(string Text, AssValidation Validation)//Email & Web Reguler Expresstion validation
        {
            if (Validation == AssValidation.Email)
            {
                if ((Text != "") && (Regex.IsMatch(Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$") != true))
                    throw new ApplicationException("Invalid Email format.Valid format like akshasoftskills@gmail.com");
            }
            if (Validation == AssValidation.Web)
            {
                if ((Text != "") && (Regex.IsMatch(Text, @"((www)\.+[\w\d]+\.([a-zA-Z]{2,4}|[0-9]{1,3})(\]?))$") != true))
                    throw new ApplicationException("Invalid Web format.Valid format like www.akshasoftskills.com");

            }
        }

        public static void IsValid(Control cont, AssValidation Validation) //for Name Remove . 
        {
            if (Validation == AssValidation.Name && cont.Text.Trim() != string.Empty)
            {
                cont.Text = cont.Text.Trim('.');
                for (int i = 0; i < cont.Text.Length; i++)
                    cont.Text = cont.Text.Replace("..", ".");

            }
        }

        public static void TextTrim(Control cont, char[] trimchar) //Remove Litrals Witch you supplied 
        {
            if (cont.Text.Trim() != string.Empty)
            {
                cont.Text = cont.Text.Trim(trimchar);
                foreach (char temp in trimchar)
                for (int i = 0; i < cont.Text.Length; i++)
                    cont.Text = cont.Text.Replace(string.Concat(temp,temp), temp.ToString());

            }
        }

        public static bool TestConnection()
        {
            bool Valid = true;
           /* try
            {
                SqlConnection con = null;
                if (AgroSetting.Default.ServerAuthen == 0 && AgroSetting.Default.ServerNetwork == 0)
                    con = new SqlConnection(@"Data Source=" + Dns.GetHostName() + ";Initial Catalog=master;Integrated Security=True");

                if (AgroSetting.Default.ServerAuthen == 0 && AgroSetting.Default.ServerNetwork == 1)
                    con = new SqlConnection(@"Data Source=" + AgroSetting.Default.ServerIP + ";Initial Catalog=master;Integrated Security=True");

                if (AgroSetting.Default.ServerAuthen == 1 && AgroSetting.Default.ServerNetwork == 0)
                    con = new SqlConnection(@"Data Source=" + Dns.GetHostName() + ";Initial Catalog=master;User Id=" + AgroSetting.Default.ServerLogName + ";Password=" + AgroSetting.Default.ServerPassword + ";Integrated Security=True");

                if (AgroSetting.Default.ServerAuthen == 1 && AgroSetting.Default.ServerNetwork == 1)
                    con = new SqlConnection(@"Data Source=" + AgroSetting.Default.ServerIP + ";Initial Catalog=master;User Id=" + AgroSetting.Default.ServerLogName + ";Password=" + AgroSetting.Default.ServerPassword + ";Integrated Security=True");
                con.Open();
                con.Close();

            }
            catch (Exception ee)
            {
                Valid = false;
            }*/
            return Valid;
        }

    }

}
