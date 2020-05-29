using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using HRMgrSystem.vo;
using HRMgrSystem.utils;


namespace HRMgrSystem.db
{
    public class PayrollDao : BaseDao
    {
        // 新增
        public int Add(HRPayroll vo)
        {
            int ret = conn.Execute(@"insert HR_Payroll(ID,EMP_ID,PAYROLL_DATE,PROBATION_STATUS,SICK_LEAVE_DAY,LEAVE_DAY,REAL_SALARY) values (@Id,@EmpId, @PayrollDate,@ProbationStatus,@SickLeaveDay,@LeaveDay,@RealSalary)",
                new[] { new { Id = vo.Id,
                    EmpId = vo.EmpId,
                    PayrollDate = vo.PayrollDate,
                    ProbationStatus = vo.ProbationStatus,
                    SickLeaveDay = vo.SickLeaveDay,
                    LeaveDay = vo.LeaveDay,
                    RealSalary = vo.RealSalary
                } });

            Console.WriteLine(string.Format("插入数据库成功{0}", ret));

            return ret;
        }

        /// <summary>
        /// 查询部门根据ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HRPayroll FindById(string id)
        {
            List<HRPayroll> list = conn.Query<HRPayroll>("SELECT * FROM HR_Payroll where Id = @Id", new { Id = id }).ToList();
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
        public List<HRPayroll> FindAll()
        {
            return conn.Query<HRPayroll>("SELECT * FROM HR_Payroll").ToList();
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <returns></returns>
        public int Update(HRPayroll vo)
        {
            return conn.Execute(@"update HR_Payroll SET NAME=@Name WHERE id = @Id",
                new
                {
                    Id = vo.Id
                });
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(string id)
        {
            return conn.Execute(@"DELETE FROM HR_Payroll WHERE id = @id", new { id = id });
        }
    }
}
