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
        public int Add(HREmployee vo)
        {
            var ret = conn.Execute(@"insert HR_EMPLOYEE(ID,NAME,SEX,ID_CARD,EDUCATION,SCHOOL,GRADUATION_TIME,PROFESSION,TELEPHONE,POLITICAL_STATUS,ADDRESS,BANK_CARD,EMAIL,DEPT_ID,JOB_ID,STATUS) " +
                   "values (@Id,@Name,@Sex,@IdCard,@Education,@School,@GraduationTime,@Profession,@Telephone,@PoliticalStatus,@Address,@BankCard,@Email,@DeptId,@JobId,@Status)",
                new[] { new { Id = vo.Id,
                    Name = vo.Name,
                    Sex = vo.Sex,
                    IdCard = vo.IdCard,
                    Education = vo.Education,
                    School = vo.School,
                    GraduationTime = vo.GraduationTime,
                    Profession = vo.Profession,
                    Telephone = vo.Telephone,
                    PoliticalStatus = vo.PoliticalStatus,
                    Address = vo.Address,
                    BankCard = vo.BankCard,
                    Email = vo.Email,
                    DeptId = vo.DeptId,
                    JobId = vo.JobId,
                    Status = vo.Status } });

            Console.WriteLine(string.Format("插入数据库成功{0}", ret));

            return ret;
        }

        /// <summary>
        /// 查询部门根据ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HREmployee FindById(string id)
        {
            List<HREmployee> list = conn.Query<HREmployee>("SELECT e.*, d.name as DEPT_NAME, j.name as JOB_NAME  FROM HR_EMPLOYEE e, HR_DEPT d, HR_JOB j where e.Dept_Id = d.ID and e.JOB_ID = j.ID and e.Id = @Id", new { Id = id }).ToList();
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
        public List<HREmployee> FindAll2()
        {
            return conn.Query<HREmployee>("SELECT * FROM HR_EMPLOYEE").ToList();
        }

        /// <summary>
        /// 查询所有部门
        /// </summary>
        /// <returns></returns>
        public List<HREmployee> FindAll()
        {
            return conn.Query<HREmployee>("SELECT e.*, d.name as DEPT_NAME, j.name as JOB_NAME  FROM HR_EMPLOYEE e, HR_DEPT d, HR_JOB j where e.Dept_Id = d.ID and e.JOB_ID = j.ID").ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<HREmployee> FindByWhere(string id, string name, string jobId, string deptId)
        {
            string whereSql = "";
            if(!EmptyUtils.EmptyStr(id))
            {
                whereSql += " and e.id=@Id";
            }

            if (!EmptyUtils.EmptyStr(name))
            {
                whereSql += " and e.name=@name";
            }

            

            if (!EmptyUtils.EmptyStr(deptId))
            {
                whereSql += " and e.dept_id=@deptId";
            }

            string baseSql = @"SELECT e.*, d.name as DEPT_NAME, j.name as JOB_NAME  FROM HR_EMPLOYEE e, HR_DEPT d, HR_JOB j where e.Dept_Id = d.ID and e.JOB_ID = j.ID" ;
            if(whereSql != "")
            {
                baseSql = string.Format("{0}{1}", baseSql, whereSql);
            }
            return conn.Query<HREmployee>(baseSql, new { Id = id, name = name, jobId= jobId, deptId=deptId }).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<HREmployee> FindByWhere(HREmployee vo)
        {
            string whereSql = "";
            if (!EmptyUtils.EmptyStr(vo.Id)) whereSql += " and e.id=@Id";
            if (!EmptyUtils.EmptyStr(vo.Name)) whereSql += " and e.Name=@Name";
            if (vo.Sex > -1) whereSql += " and e.Sex=@Sex";
            if (!EmptyUtils.EmptyStr(vo.IdCard)) whereSql += " and e.ID_CARD=@IdCard";
            if (vo.Education > -1) whereSql += " and e.Education=@Education";
            if (!EmptyUtils.EmptyStr(vo.School)) whereSql += " and e.School=@School";
            if (!EmptyUtils.EmptyStr(vo.Profession)) whereSql += " and e.Profession=@Profession";
            if (!EmptyUtils.EmptyStr(vo.Telephone)) whereSql += " and e.Telephone=@Telephone";
            if (vo.PoliticalStatus > -1) whereSql += " and e.POLITICAL_STATUS=@PoliticalStatus";
            if (!EmptyUtils.EmptyStr(vo.Address)) whereSql += " and e.Address=@Address";
            if (!EmptyUtils.EmptyStr(vo.BankCard)) whereSql += " and e.BANK_CARD=@BankCard";
            if (!EmptyUtils.EmptyStr(vo.Email)) whereSql += " and e.Email=@Email";
            if (!EmptyUtils.EmptyStr(vo.JobId)) { whereSql += " and e.job_id=@jobId"; }
            if (!EmptyUtils.EmptyStr(vo.DeptId)) { whereSql += " and e.dept_id=@deptId"; }
            if (vo.Status > -1) whereSql += " and e.Status=@Status";

            string baseSql = @"SELECT e.*, d.name as DEPT_NAME, j.name as JOB_NAME  FROM HR_EMPLOYEE e, HR_DEPT d, HR_JOB j where e.Dept_Id = d.ID and e.JOB_ID = j.ID";
            if (whereSql != "")
            {
                baseSql = string.Format("{0}{1}", baseSql, whereSql);
            }
            return conn.Query<HREmployee>(baseSql, new {
                Id = vo.Id,
                Name = vo.Name,
                Sex = vo.Sex,
                IdCard = vo.IdCard,
                Education = vo.Education,
                School = vo.School,
                GraduationTime = vo.GraduationTime,
                Profession = vo.Profession,
                Telephone = vo.Telephone,
                PoliticalStatus = vo.PoliticalStatus,
                Address = vo.Address,
                BankCard = vo.BankCard,
                Email = vo.Email,
                DeptId = vo.DeptId,
                JobId = vo.JobId,
                Status = vo.Status
            }).ToList();

        }

        public List<HREmployee> FindByDeptId(string deptId)
        {
            string baseSql = @"SELECT * from HR_EMPLOYEE where DEPT_ID=@DeptId";

            return conn.Query<HREmployee>(baseSql, new
            {
                DeptId = deptId
            }).ToList();
        }

        public List<HREmployee> FindByUserType(int userType)
        {
            string baseSql = @"SELECT * from HR_EMPLOYEE where id in (SELECT EMP_ID FROM HR_USER WHERE USER_TYPE=@UserType)";

            return conn.Query<HREmployee>(baseSql, new
            {
                UserType = userType
            }).ToList();
        }




        /// <summary>
        /// 更新
        /// </summary>
        /// <returns></returns>
        public int Update(HREmployee vo)
        {
            return conn.Execute(@"update HR_EMPLOYEE SET NAME=@Name,SEX=@Sex,ID_CARD=@IdCard,EDUCATION=@Education,SCHOOL=@School,GRADUATION_TIME=@GraduationTime,PROFESSION=@Profession,TELEPHONE=@Telephone,POLITICAL_STATUS=@PoliticalStatus,ADDRESS=@Address,BANK_CARD=@BankCard,EMAIL=@Email,DEPT_ID=@DeptId,JOB_ID=@JobId,STATUS=@Status WHERE id = @Id",
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
                    PoliticalStatus = vo.PoliticalStatus,
                    Address = vo.Address,
                    BankCard = vo.BankCard,
                    Email = vo.Email,
                    DeptId = vo.DeptId,
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
