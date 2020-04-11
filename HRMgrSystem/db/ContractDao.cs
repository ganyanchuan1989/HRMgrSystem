using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using HRMgrSystem.utils;
using HRMgrSystem.vo;

namespace HRMgrSystem.db
{
    public class ContractDao : BaseDao
    {
        // 新增
        public int Add(HRContract vo)
        {
            var ret = conn.Execute(@"insert HR_CONTRACT(ID,EMP_ID,START_TIME,END_TIME,PROBATION,PROBATION_SALARY,CORRECTED_SALARY,CONTRACT_TYPE) " +
                    "values (@Id,@EmpId,@StartTime,@EndTime,@Probation,@ProbationSalary,@CorrectedSalary,@ContractType)",
                new[] { new { Id = vo.Id,
                    EmpId = vo.EmpId,
                    StartTime = vo.StartTime,
                    EndTime = vo.EndTime,
                    Probation = vo.Probation,
                    ProbationSalary = vo.ProbationSalary,
                    CorrectedSalary = vo.CorrectedSalary,
                    ContractType = vo.ContractType } });

            Console.WriteLine(string.Format("插入数据库成功{0}", ret));

            return ret;
        }

        /// <summary>
        /// 查询部门根据ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HRContract FindById(string id)
        {
            List<HRContract> list = conn.Query<HRContract>("SELECT * FROM HR_CONTRACT where Id = @Id", new { Id = id }).ToList();
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
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        public List<HRContract> FindAll()
        {
            return conn.Query<HRContract>("SELECT c.*, e.name as EMP_NAME FROM HR_CONTRACT c ,HR_EMPLOYEE e where c.EMP_ID = e.ID").ToList();
        }

        public List<HRContract> FindByWhere(HRContract vo)
        {
            string whereSql = "";
            if (!EmptyUtils.EmptyStr(vo.Id)) whereSql += " and c.id=@Id";
            if (!float.IsNaN(vo.CorrectedSalary)) whereSql += " and c.Corrected_Salary=@CorrectedSalary";
            if (vo.Probation > 0) whereSql += " and c.Probation=@Probation";
            if (!float.IsNaN(vo.ProbationSalary)) whereSql += " and c.Probation_Salary=@ProbationSalary";
            if (!EmptyUtils.EmptyStr(vo.EmpId)) whereSql += " and c.EMP_ID=@EmpId";
            if (vo.ContractType > 0) whereSql += " and c.Contract_Type=@ContractType";

            string sql = "SELECT c.*, e.name as EMP_NAME FROM HR_CONTRACT c ,HR_EMPLOYEE e where c.EMP_ID = e.ID";

            return conn.Query<HRContract>(sql + whereSql, new {
                Id = vo.Id,
                CorrectedSalary = vo.CorrectedSalary,
                Probation = vo.Probation,
                ProbationSalary = vo.ProbationSalary,
                EmpId = vo.EmpId,
                ContractType = vo.ContractType
            }).ToList();
        }

        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        public List<HRContract> FindAll2()
        {
            return conn.Query<HRContract>("SELECT * FROM HR_CONTRACT").ToList();
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <returns></returns>
        public int Update(HRContract vo)
        {
            return conn.Execute(@"update HR_CONTRACT SET EMP_ID=@EmpId,START_TIME=@StartTime,END_TIME=@EndTime,PROBATION=@Probation,PROBATION_SALARY=@ProbationSalary,CORRECTED_SALARY=@CorrectedSalary,CONTRACT_TYPE=@ContractType WHERE id = @Id",
                new
                {
                    Id = vo.Id,
                    EmpId = vo.EmpId,
                    StartTime = vo.StartTime,
                    EndTime = vo.EndTime,
                    Probation = vo.Probation,
                    ProbationSalary = vo.ProbationSalary,
                    CorrectedSalary = vo.CorrectedSalary,
                    ContractType = vo.ContractType
                });
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(string id)
        {
            return conn.Execute(@"DELETE FROM HR_CONTRACT WHERE id = @id", new { id = id });
        }
    }
}
