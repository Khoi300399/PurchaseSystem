using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class RequestTCHeader
    {
        private string facility;
        private int requestNo;
        private DateTime requestDate;
        private string departmentRequest;
        private string productionLineRequest;
        private string departmentUsed;
        private string productinonLineUsed;
        private DateTime inputDate;
        private string inputUser;
        private bool conpleted;
        private string sites;
        private string statusApproved;

        public string Facility { get => facility; set => facility = value; }
        public int RequestNo { get => requestNo; set => requestNo = value; }
        public DateTime RequestDate { get => requestDate; set => requestDate = value; }
        public string DepartmentRequest { get => departmentRequest; set => departmentRequest = value; }
        public string ProductionLineRequest { get => productionLineRequest; set => productionLineRequest = value; }
        public string DepartmentUsed { get => departmentUsed; set => departmentUsed = value; }
        public string ProductinonLineUsed { get => productinonLineUsed; set => productinonLineUsed = value; }
        public DateTime InputDate { get => inputDate; set => inputDate = value; }
        public string InputUser { get => inputUser; set => inputUser = value; }
        public bool Conpleted { get => conpleted; set => conpleted = value; }
        public string Sites { get => sites; set => sites = value; }
        public string StatusApproved { get => statusApproved; set => statusApproved = value; }

        public RequestTCHeader
        (
            string _facility,
            int _requestNo,
            DateTime _requestDate,
            string _departmentRequest,
            string _productionLineRequest,
            string _departmentUsed, 
            string _productinonLineUsed,
            DateTime _inputDate,
            string _inputUser,
            bool _conpleted,
            string _sites,
            string _statusApproved
        )
        {
            this.facility = _facility;
            this.requestNo = _requestNo;
            this.requestDate = _requestDate;
            this.departmentRequest = _departmentRequest;
            this.productionLineRequest = _productionLineRequest;
            this.departmentUsed = _departmentUsed;
            this.productinonLineUsed = _productinonLineUsed;
            this.inputDate = _inputDate;
            this.inputUser = _inputUser;
            this.conpleted = _conpleted;
            this.sites = _sites;
            this.statusApproved = _statusApproved;
        }
    }
}
