using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class UserMenuMaster
    {
        private string menuID;
        private string defaultName;
        private int menuOrder;
        private bool isActive;
        private string formName;
        private string parameter;
        private string parentID;
        private bool safeMode;
        private int maxNbCnxNormalMode;
        private int maxNbCnxDegradedMode;
        private string projName;

        public UserMenuMaster(string menuID, string defaultName, int menuOrder, bool isActive, string formName, string parameter, string parentID, bool safeMode, int maxNbCnxNormalMode, int maxNbCnxDegradedMode, string projName)
        {
            this.MenuID = menuID;
            this.DefaultName = defaultName;
            this.MenuOrder = menuOrder;
            this.IsActive = isActive;
            this.FormName = formName;
            this.Parameter = parameter;
            this.ParentID = parentID;
            this.SafeMode = safeMode;
            this.MaxNbCnxNormalMode = maxNbCnxNormalMode;
            this.MaxNbCnxDegradedMode = maxNbCnxDegradedMode;
            this.ProjName = projName;
        }

        public string MenuID { get => menuID; set => menuID = value; }
        public string DefaultName { get => defaultName; set => defaultName = value; }
        public int MenuOrder { get => menuOrder; set => menuOrder = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        public string FormName { get => formName; set => formName = value; }
        public string Parameter { get => parameter; set => parameter = value; }
        public string ParentID { get => parentID; set => parentID = value; }
        public bool SafeMode { get => safeMode; set => safeMode = value; }
        public int MaxNbCnxNormalMode { get => maxNbCnxNormalMode; set => maxNbCnxNormalMode = value; }
        public int MaxNbCnxDegradedMode { get => maxNbCnxDegradedMode; set => maxNbCnxDegradedMode = value; }
        public string ProjName { get => projName; set => projName = value; }
    }
}
