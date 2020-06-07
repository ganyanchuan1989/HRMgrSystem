using Dapper;
using HRMgrSystem.utils;
using HRMgrSystem.vo;
using System;
using System.Collections.Generic;
using System.Linq;


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
        /// 根据工资单日期区间查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<HRPayroll> FindByDateInterval(int year, int month)
        {
            string startDate = string.Format("{0}-{1}-01", year, month);
            string endDate = string.Format("{0}-{1}-31", year, month);
            List<HRPayroll> list = conn.Query<HRPayroll>("select * from HR_PAYROLL where date(PAYROLL_DATE) between @startDate and @endDate", new {
                startDate = startDate,
                endDate = endDate
            }).ToList();

            return list;
        }

        /// <summary>
        /// 根据工资单日期区间查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<HRPayroll> FindByWhere(HRPayroll vo)
        {
            string whereSql = "";
            if (!EmptyUtils.EmptyStr(vo.PayrollDate)) whereSql += " and PAYROLL_DATE=@PayrollDate";
            if (!EmptyUtils.EmptyStr(vo.EmpId)) whereSql += " and EMP_ID=@EmpId";

            string baseSql = "select p.*, e.NAME as EMP_NAME from HR_PAYROLL p, HR_EMPLOYEE e where p.EMP_ID = e.ID ";
            List<HRPayroll> list = conn.Query<HRPayroll>(baseSql + whereSql, new
            {
                PayrollDate = vo.PayrollDate,
                EmpId = vo.EmpId
            }).ToList();

            return list;
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
