using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class User
    {
        private string userName;
        private string cryptedPassword;
        private string accessID;
        private bool status;
        private DateTime lastLogonDate;
        private string lastLogonProgramVersion;
        private string lastLogonComputerName;
        private string lastLogonUserName;
        private string lastLogonComputerOSVersion;
        private bool admin;
        private string sites;
        private string productionProcess;

        public User(string userName, string cryptedPassword, string accessID, bool status, DateTime lastLogonDate, string lastLogonProgramVersion, string lastLogonComputerName, string lastLogonUserName, string lastLogonComputerOSVersion, bool admin, string sites, string productionProcess)
        {
            this.UserName = userName;
            this.CryptedPassword = cryptedPassword;
            this.AccessID = accessID;
            this.Status = status;
            this.LastLogonDate = lastLogonDate;
            this.LastLogonProgramVersion = lastLogonProgramVersion;
            this.LastLogonComputerName = lastLogonComputerName;
            this.LastLogonUserName = lastLogonUserName;
            this.LastLogonComputerOSVersion = lastLogonComputerOSVersion;
            this.Admin = admin;
            this.Sites = sites;
            this.ProductionProcess = productionProcess;
        }

        public string UserName { get => userName; set => userName = value; }
        public string CryptedPassword { get => cryptedPassword; set => cryptedPassword = value; }
        public string AccessID { get => accessID; set => accessID = value; }
        public bool Status { get => status; set => status = value; }
        public DateTime LastLogonDate { get => lastLogonDate; set => lastLogonDate = value; }
        public string LastLogonProgramVersion { get => lastLogonProgramVersion; set => lastLogonProgramVersion = value; }
        public string LastLogonComputerName { get => lastLogonComputerName; set => lastLogonComputerName = value; }
        public string LastLogonUserName { get => lastLogonUserName; set => lastLogonUserName = value; }
        public string LastLogonComputerOSVersion { get => lastLogonComputerOSVersion; set => lastLogonComputerOSVersion = value; }
        public bool Admin { get => admin; set => admin = value; }
        public string Sites { get => sites; set => sites = value; }
        public string ProductionProcess { get => productionProcess; set => productionProcess = value; }
    }
}
