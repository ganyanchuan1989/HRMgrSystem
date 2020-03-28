using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMgrSystem.vo
{
    public class HREmployee : BaseVo
    {
        public string Name { get; set; }
        public int Sex { get; set; }
        public string IdCard { get; set; }
        public int Education { get; set; }
        public string School { get; set; }
        public string GraduationTime { get; set; }
        public string Profession { get; set; }
        public string Telephone { get; set; }
        public string Nation { get; set; }
        public int PoliticalStatus { get; set; }
        public string Address { get; set; }
        public string BankCard { get; set; }
        public string Email { get; set; }
        public string DeptId { get; set; }
        public string ContractId { get; set; }
        public string JobId { get; set; }
        public int Status { get; set; }
    }
}
