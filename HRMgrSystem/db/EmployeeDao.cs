using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMgrSystem.vo;
using Dapper;
using HRMgrSystem.utils;

namespace HRMgrSystem.db
{
    public class EmployeeDao : BaseDao
    {
        /// <summary>
        /// 新增
        /// </summary>
        public void Add(HREmployee vo)
        {
            var ret = conn.Execute(@"insert HR_EMPLOYEE(ID,NAME,SEX,ID_CARD,EDUCATION,SCHOOL,GRADUATION_TIME,PROFESSION,TELEPHONE,NATION,POLITICAL_STATUS,ADDRESS,BANK_CARD,EMAIL,DEPT_ID,CONTRACT_ID,JOB_ID,STATUS) " +
                   "values (@Id,@Name,@Sex,@IdCard,@Education,@School,@GraduationTime,@Profession,@Telephone,@Nation,@PoliticalStatus,@Address,@BankCard,@Email,@DeptId,@ContractId,@JobId,@Status)",
                new[] { new { Id = vo.Id,
                    Name = vo.Name,
                    Sex = vo.Sex,
                    IdCard = vo.IdCard,
                    Education = vo.Education,
                    School = vo.School,
                    GraduationTime = vo.GraduationTime,
                    Profession = vo.Profession,
                    Telephone = vo.Telephone,
                    Nation = vo.Nation,
                    PoliticalStatus = vo.PoliticalStatus,
                    Address = vo.Address,
                    BankCard = vo.BankCard,
                    Email = vo.Email,
                    DeptId = vo.DeptId,
                    ContractId = vo.ContractId,
                    JobId = vo.JobId,
                    Status = vo.Status } });

            Console.WriteLine(string.Format("插入数据库成功{0}", ret));
        }

        /// <summary>
        /// 查询部门根据ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HREmployee FindById(string id)
        {
            List<HREmployee> list = conn.Query<HREmployee>("SELECT * FROM HR_EMPLOYEE where Id = @Id", new { Id = id }).ToList();
            if (EmptyUtils.EmptyList(list))
            {
                return null;
            }
            else
            {
                return list[0];
            }
        }

        /// <summary>
        /// 查询所有部门
        /// </summary>
        /// <returns></returns>
        public List<HREmployee> FindAll()
        {
            return conn.Query<HREmployee>("SELECT * FROM HR_EMPLOYEE").ToList();
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <returns></returns>
        public int Update(HREmployee vo)
        {
            return conn.Execute(@"update HR_EMPLOYEE SET NAME=@Name,SEX=@Sex,ID_CARD=@IdCard,EDUCATION=@Education,SCHOOL=@School,GRADUATION_TIME=@GraduationTime,PROFESSION=@Profession,TELEPHONE=@Telephone,NATION=@Nation,POLITICAL_STATUS=@PoliticalStatus,ADDRESS=@Address,BANK_CARD=@BankCard,EMAIL=@Email,DEPT_ID=@DeptId,CONTRACT_ID=@ContractId,JOB_ID=@JobId,STATUS=@Status WHERE id = @Id",
                new
                {
                    Id = vo.Id,
                    Name = vo.Name,
                    Sex = vo.Sex,
                    IdCard = vo.IdCard,
                    Education = vo.Education,
                    School = vo.School,
                    GraduationTime = vo.GraduationTime,
                    Profession = vo.Profession,
                    Telephone = vo.Telephone,
                    Nation = vo.Nation,
                    PoliticalStatus = vo.PoliticalStatus,
                    Address = vo.Address,
                    BankCard = vo.BankCard,
                    Email = vo.Email,
                    DeptId = vo.DeptId,
                    ContractId = vo.ContractId,
                    JobId = vo.JobId,
                    Status = vo.Status
                });
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(string id)
        {
            return conn.Execute(@"DELETE FROM HR_EMPLOYEE WHERE id = @id", new { id = id });
        }
    }
}
