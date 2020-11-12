using DocsVision.BackOffice.WebClient.Department;
using DocsVision.BackOffice.WebClient.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateServerExtension1.Models
{
    public class OrganizationDataModel
    {
        public string ExceptionMessage;

        public DepartmentModel StaffDepartment;

        public EmployeeModel CharityOrderMainBookKeeper;
        public EmployeeModel CharityOrderBookKeeper;
        public EmployeeModel CharityOrderController;
        public List<EmployeeModel> CharityOrderAgreementEmployees { get; set; }

        public EmployeeModel CandidateAgreementCPKBoss;
        public EmployeeModel CandidateAgreementOUandOTOBoss;
        public List<EmployeeModel> CandidateAgreementAgreementEmployees { get; set; }

        public EmployeeModel RecruitmentDocsHeadOfDepartment;
        public EmployeeModel RecruitmentDocsOUandOTOClerk;        
        public EmployeeModel RecruitmentDocsOUandOTOBoss;
        public List<EmployeeModel> RecruitmentDocsAgreementEmployees1 { get; set; }
        public List<EmployeeModel> RecruitmentDocsAgreementEmployees2 { get; set; }

        public EmployeeModel PayOrderMainBookKeeper;
        public EmployeeModel PayOrderBookKeeper;
        public List<EmployeeModel> PayOrderAgreementEmployees { get; set; }

        public OrganizationDataModel() { }
    }
}