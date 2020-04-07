using Dapper.FluentColumnMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMgrSystem.vo
{
    public class VoMapping
    {
        /// <summary>
        /// 数据库ORM字段映射关系
        /// </summary>
        public static void Mapping()
        {
            var mappings = new ColumnMappingCollection();

            // HR_CONTRACT
            mappings.RegisterType<HRContract>()
                    .MapProperty(x => x.Id).ToColumn("ID")
                    .MapProperty(x => x.EmployeeId).ToColumn("EMPLOYEE_ID")
                    .MapProperty(x => x.StartTime).ToColumn("START_TIME")
                    .MapProperty(x => x.EndTime).ToColumn("END_TIME")
                    .MapProperty(x => x.Probation).ToColumn("PROBATION")
                    .MapProperty(x => x.ProbationSalary).ToColumn("PROBATION_SALARY")
                    .MapProperty(x => x.CorrectedSalary).ToColumn("CORRECTED_SALARY")
                    .MapProperty(x => x.ContractType).ToColumn("CONTRACT_TYPE")
                    .MapProperty(x => x.EmpName).ToColumn("EMP_NAME"); // 

            // HRDept
            mappings.RegisterType<HRDept>()
                    .MapProperty(x => x.Id).ToColumn("ID")
                    .MapProperty(x => x.Name).ToColumn("NAME");

            // HREmployee
            mappings.RegisterType<HREmployee>()
                    .MapProperty(x => x.Id).ToColumn("ID")
                    .MapProperty(x => x.Name).ToColumn("NAME")
                    .MapProperty(x => x.Sex).ToColumn("SEX")
                    .MapProperty(x => x.IdCard).ToColumn("ID_CARD")
                    .MapProperty(x => x.Education).ToColumn("EDUCATION")
                    .MapProperty(x => x.School).ToColumn("SCHOOL")
                    .MapProperty(x => x.GraduationTime).ToColumn("GRADUATION_TIME")
                    .MapProperty(x => x.Profession).ToColumn("PROFESSION")
                    .MapProperty(x => x.Telephone).ToColumn("TELEPHONE")
                    .MapProperty(x => x.PoliticalStatus).ToColumn("POLITICAL_STATUS")
                    .MapProperty(x => x.Address).ToColumn("ADDRESS")
                    .MapProperty(x => x.BankCard).ToColumn("BANK_CARD")
                    .MapProperty(x => x.Email).ToColumn("EMAIL")
                    .MapProperty(x => x.DeptId).ToColumn("DEPT_ID")
                    .MapProperty(x => x.JobId).ToColumn("JOB_ID")
                    .MapProperty(x => x.Status).ToColumn("STATUS")
                    .MapProperty(x => x.DeptName).ToColumn("DEPT_NAME")
                    .MapProperty(x => x.JobName).ToColumn("JOB_NAME");


            // HRJob
            mappings.RegisterType<HRJob>()
                    .MapProperty(x => x.Id).ToColumn("ID")
                    .MapProperty(x => x.Name).ToColumn("NAME")
                    .MapProperty(x => x.CreateTime).ToColumn("CREATE_TIME");


            // HRRewardsPunishments
            mappings.RegisterType<HRRewardsPunishments>()
                   .MapProperty(x => x.Id).ToColumn("ID")
                   .MapProperty(x => x.Type).ToColumn("TYPE")
                   .MapProperty(x => x.Title).ToColumn("TITLE")
                   .MapProperty(x => x.Content).ToColumn("CONTENT")
                   .MapProperty(x => x.Amount).ToColumn("AMOUNT");

            // HR_USER 
            mappings.RegisterType<HRUser>()
                   .MapProperty(x => x.Id).ToColumn("ID")
                   .MapProperty(x => x.EmpId).ToColumn("EMP_ID")
                   .MapProperty(x => x.Password).ToColumn("PASSWORD")
                   .MapProperty(x => x.UserName).ToColumn("USERNAME")
                   .MapProperty(x => x.Status).ToColumn("STATUS")
                   .MapProperty(x => x.UserType).ToColumn("USER_TYPE")
                   .MapProperty(x => x.EmpName).ToColumn("EMP_NAME");

            
            // HR_WORK_LOG 
            mappings.RegisterType<HRWorkLog>()
                   .MapProperty(x => x.Id).ToColumn("ID")
                   .MapProperty(x => x.EmpId).ToColumn("EMP_ID")
                   .MapProperty(x => x.LogDate).ToColumn("LOG_DATE")
                   .MapProperty(x => x.Content).ToColumn("CONTENT");


            // Tell Dapper to use our custom mappings
            mappings.RegisterWithDapper();
        }
    }
}
