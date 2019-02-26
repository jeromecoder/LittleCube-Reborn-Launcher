using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace LittleCube_Reborn_Launcher.Classes
{
    class Fonctions
    {
        public static void WriteIdentifiantToRegistry(String user, String pass, Boolean defaut)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(Statics.RegRootIdentifiants + "\\" + user, true);
            RegistryKey regRoot = Registry.CurrentUser.OpenSubKey(Statics.RegRootIdentifiants, true);

            if (reg is null) {
                reg = Registry.CurrentUser.CreateSubKey(Statics.RegRootIdentifiants + "\\" + user);
            }
            reg.SetValue("User", user);
            reg.SetValue("Pass", pass);

            if (defaut) {
                reg.SetValue("Default", true);

                regRoot = Registry.CurrentUser.OpenSubKey(Statics.RegRootIdentifiants, true);

                foreach (String subkey in regRoot.GetSubKeyNames())
                {
                    RegistryKey reguser = Registry.CurrentUser.OpenSubKey(Statics.RegRootIdentifiants + "\\" + subkey, true);
                    if (!reguser.GetValue("User").Equals(user))
                    {
                        reguser.SetValue("Default", false);
                    }
                }
            }
            else
            {
                reg.SetValue("Default", false);
            }

            reg.Close();
            regRoot.Close();            
        }
        public static ArrayList GetAllUsers()
        {
            ArrayList liste = new ArrayList();
            RegistryKey regRoot = Registry.CurrentUser.OpenSubKey(Statics.RegRootIdentifiants, false);

            if (regRoot is null) return null;
        
            foreach(string subkey in regRoot.GetSubKeyNames())
            {
                RegistryKey reg = Registry.CurrentUser.OpenSubKey(Statics.RegRootIdentifiants + "\\" + subkey, false);
                if(reg.GetValue("Default").Equals("True"))
                {
                    liste.Add(reg.GetValue("User") + "[Défaut]");
                }
                else
                {
                    liste.Add(reg.GetValue("User"));
                }
                reg.Close();
            }

            regRoot.Close();
            return liste;
        }       
        public static ArrayList GetUser(string user)
        {
            ArrayList liste = new ArrayList();

            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\LittleCube\\Launcher\\Identifiants\\" + user, false);
            if (!(reg is null))
            {
                liste.Add(reg.GetValue("User"));
                liste.Add(reg.GetValue("Pass"));
            }
            reg.Close();

            return liste;
        }
        public static void deleteUserFromRegistry(string user)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(Statics.RegRootIdentifiants, true);
            reg.DeleteSubKey(user);
            reg.Close();
        }
        public static void WriteRAMAllocatedToRegistry(string user, string ram)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(Statics.RegRootIdentifiants + "\\" + user, true);

            if (!(reg == null))
                reg.SetValue("RAM", ram);

            reg.Close();
        }
        public static void WriteRJAVAVersionToUseToRegistry(string user, string java, string path)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(Statics.RegRootIdentifiants + "\\" + user, true);

            if (!(reg == null))
            {
                reg.SetValue("JAVAversion", java);
                reg.SetValue("JAVApath", path);
            }
            reg.Close();
        }
        public static string getJAVAFromUser(string user)
        {
            string java = "";

            RegistryKey reg = Registry.CurrentUser.OpenSubKey(Statics.RegRootIdentifiants + "\\" + user, false);
            if (!(reg == null))
                java = reg.GetValue("JAVAversion").ToString();

            reg.Close();
            return java;
        }
        public static void SetCompteAsDefault(string user)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(Statics.RegRootIdentifiants + "\\" + user, true);
            RegistryKey regRoot = Registry.CurrentUser.OpenSubKey(Statics.RegRootIdentifiants, true);

            if (!(reg == null))
            {
                reg.SetValue("Default", true);
                foreach (string subkey in regRoot.GetSubKeyNames())
                {
                    RegistryKey reguser = Registry.CurrentUser.OpenSubKey(Statics.RegRootIdentifiants + "\\" + subkey, true);
                    if (!reguser.GetValue("User").Equals(user))
                        reguser.SetValue("Default", false);
                }
                reg.Close();                
            }
            regRoot.Close();
        }
        public static Dictionary<string,string> getJavaHome()
        {
            Dictionary<string, string> javaVersionsList = new Dictionary<string, string>();
            try
            {
                foreach (string d in Directory.GetDirectories(@"C:\Program Files\Java\"))
                {
                    if (File.Exists(d + @"\bin\java.exe"))
                    {
                        string version = Fonctions.getJavaVersionFromDirectory(d);
                        if (!version.Equals(""))
                        {
                            if (Environment.Is64BitOperatingSystem)
                                javaVersionsList.Add(version + " (64 bit)", d + @"\bin\javaw.exe");
                            else
                                javaVersionsList.Add(version + " (32 bit)", d + @"\bin\javaw.exe");
                        }
                    }
                }
            }
            catch (Exception){}

            if (Environment.Is64BitOperatingSystem)
            {
                try
                {
                    foreach (string d in Directory.GetDirectories(@"C:\Program Files(x86)\Java\"))
                    {
                        if (File.Exists(d + @"\bin\java.exe"))
                        {
                            string version = Fonctions.getJavaVersionFromDirectory(d);
                            if (!version.Equals(""))
                                javaVersionsList.Add(version + " (32 bit)", d + @"\bin\javaw.exe");
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }

            return javaVersionsList;
        }
        public static string getJavaVersionFromDirectory(string d)
        {
            string version = "";
            try
            {
                StreamReader sr = new StreamReader(d + @"\release", System.Text.Encoding.Default);
                version = sr.ReadLine();
                sr.Close();
                sr.Dispose();
                version = version.Replace("\"", "").Replace("JAVA_VERSION=", "");                
            }
            catch (Exception){ }

            return version;
        }
        public static ArrayList Authentification(string user, string pass)
        {
            string RequestResult = "";
            string RequestHeader = "{\"agent\": {\"name\": \"Minecraft\",\"version\": 1},\"username\": \"" + user + "\",\"password\": \"" + pass + "\"}";
            string UserToken = "";
            string UUID = "";
            string AuthServer = "https://authserver.mojang.com/authenticate";
            string name = "";

            WebRequest AuthRequest;
            AuthRequest = WebRequest.Create(AuthServer);
            WebResponse RequestResponse;
            string PostData = RequestHeader;
            byte[] data = System.Text.Encoding.UTF8.GetBytes(PostData);

            AuthRequest.Method = "POST";
            AuthRequest.ContentType = "application/json";
            AuthRequest.ContentLength = data.Length;

            Stream RequestStream = AuthRequest.GetRequestStream();
            try
            {
                RequestStream.Write(data, 0, data.Length);
                RequestStream.Close();
            }
            catch
            {
                return new ArrayList { "Erreur" };
            }

            try
            {
                RequestResponse = AuthRequest.GetResponse();
                StreamReader ResponseReader = new StreamReader(RequestResponse.GetResponseStream());
                RequestResult = (ResponseReader.ReadToEnd());

                string[] ResponseArray = RequestResult.Split(new char[] { ':' });

                UserToken = ResponseArray[1].ToString().Split(new char[] { ':' })[0].Replace("\"", "").Replace(",clientToken","");
                UUID = ResponseArray[5].ToString().Split(new char[] { ',' })[0].Replace("\"", "");
                name = ResponseArray[6].ToString().Split(new char[] { ',' })[0].Replace("\"", "").Replace("}", "");
                return new ArrayList { user, pass, UserToken, UUID, name };
            }
            catch (WebException ConnexionFailed)
            {
                StreamReader ResponseReader = new StreamReader(ConnexionFailed.Response.GetResponseStream());
                RequestResult = (ResponseReader.ReadToEnd());

                string ErrorType = RequestResult.Split(new char[] { ':' })[1].Split(new char[] { ':' })[0].Replace("\"", "");
                string ErrorMessage = RequestResult.Split(new char[] { ':' })[2].Replace("}", null).Replace("\"", "");                              

                MessageBox.Show(ErrorMessage,"Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new ArrayList { "Erreur" };
        }

    }
}
