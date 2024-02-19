using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class UserAccess
    {
        private string accessID;
        private string menuID;
        private bool fInsert;
        private bool fUpdate;
        private bool fDelete;
        private bool fEnable;
        private bool fDuplicate;
        private bool fSearch;

        public UserAccess(string accessID, string menuID, bool fInsert, bool fUpdate, bool fDelete, bool fEnable, bool fDuplicate, bool fSearch)
        {
            this.AccessID = accessID;
            this.MenuID = menuID;
            this.FInsert = fInsert;
            this.FUpdate = fUpdate;
            this.FDelete = fDelete;
            this.FEnable = fEnable;
            this.FDuplicate = fDuplicate;
            this.FSearch = fSearch;
        }

        public string AccessID { get => accessID; set => accessID = value; }
        public string MenuID { get => menuID; set => menuID = value; }
        public bool FInsert { get => fInsert; set => fInsert = value; }
        public bool FUpdate { get => fUpdate; set => fUpdate = value; }
        public bool FDelete { get => fDelete; set => fDelete = value; }
        public bool FEnable { get => fEnable; set => fEnable = value; }
        public bool FDuplicate { get => fDuplicate; set => fDuplicate = value; }
        public bool FSearch { get => fSearch; set => fSearch = value; }
    }
}
