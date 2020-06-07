using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMgrSystem.vo;
using HRMgrSystem.utils;
using MySql.Data.MySqlClient;
using Dapper;

namespace HRMgrSystem.db
{
    public class LeaveDao : BaseDao
    {
        // 新增
        public int Add(HRLeave vo)
        {
            int ret = conn.Execute(@"insert HR_LEAVE(ID,EMP_ID,TYPE,LEAVE_DATE,LEAVE_DAY,CAUSE,STATUS) values (@Id,@EmpId,@Type, @LeaveDate, @LeaveDay,@Cause,@Status)",
                new[] { new { Id = vo.Id,
                    EmpId = vo.EmpId,
                    Type = vo.Type,
                    LeaveDate = vo.LeaveDate,
                    LeaveDay = vo.LeaveDay,
                    Cause = vo.Cause,
                    Status = vo.Status
                } });

            Console.WriteLine(string.Format("插入数据库成功{0}", ret));

            return ret;
        }

        /// <summary>
        /// 查询部门根据ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HRLeave FindById(string id)
        {
            List<HRLeave> list = conn.Query<HRLeave>("SELECT l.*, e.name as EMP_NAME FROM HR_LEAVE l, HR_EMPLOYEE e where l.EMP_ID = e.ID and Id = @Id", new { Id = id }).ToList();
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
        public List<HRLeave> FindAll()
        {
            return conn.Query<HRLeave>("SELECT l.*, e.name as EMP_NAME FROM HR_LEAVE l, HR_EMPLOYEE e where l.EMP_ID = e.ID").ToList();
        }

        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        public List<HRLeave> FindByEmpId(string empId)
        {
            return conn.Query<HRLeave>("SELECT l.*, e.name as EMP_NAME FROM HR_LEAVE l, HR_EMPLOYEE e where l.EMP_ID = e.ID and EMP_ID = @empId",new { empId = empId }).ToList();
        }

        /// <summary>
        /// 查询部门下未审批人员
        /// </summary>
        /// <param name="deptId"></param>
        /// <param name="empId"></param>
        /// <returns></returns>
        public List<HRLeave> FindByDeptMgr(int status, string deptId, string empId)
        {
            // select * from hr_leave where status = 1 and emp_id in (select emp_id from hr_employee where dept_id = '20200604101010000001') and emp_id != '20200604101010000001'
            return conn.Query<HRLeave>("SELECT * FROM HR_LEAVE WHERE STATUS = @status AND EMP_ID IN (SELECT EMP_ID FROM HR_EMPLOYEE WHERE DEPT_ID = @deptId) AND EMP_ID != @empId", new {
                empId = empId,
                deptId = deptId,
                status = status
            }).ToList();
        }

        public List<HRLeave> FindByAdmin(int status)
        {
            return conn.Query<HRLeave>("SELECT * FROM HR_LEAVE WHERE STATUS = @status AND EMP_ID IN(SELECT EMP_ID FROM HR_USER WHERE USER_TYPE = 2)", new
            {
                status = status
            }).ToList();
        }

        public List<HRLeave> FindByWhereForMgr(HRLeave vo, string mgrDeptId, string mgrEmpId)
        {
            string whereSql = "";
            if (!EmptyUtils.EmptyStr(vo.Id)) whereSql += " and id=@Id";
            if (vo.Status > 0) whereSql += " and Status=@Status";
            if (!EmptyUtils.EmptyStr(vo.EmpId)) whereSql += " and EMP_ID=@EmpId";

            string sql = "SELECT * FROM HR_LEAVE WHERE EMP_ID != @MgrEmpId ";
            sql = sql += whereSql;
            sql = sql += " AND EMP_ID IN (SELECT EMP_ID FROM HR_EMPLOYEE WHERE DEPT_ID = @mgrDeptId) ";

            return conn.Query<HRLeave>(sql, new
            {
                Id = vo.Id,
                Status = vo.Status,
                EmpId = vo.EmpId,
                MgrEmpId = mgrDeptId,
                mgrDeptId = mgrDeptId
            }).ToList();
        }


        public List<HRLeave> FindByWhereForAdmin(HRLeave vo)
        {
            string whereSql = "";
            if (!EmptyUtils.EmptyStr(vo.Id)) whereSql += " and id=@Id";
            if (vo.Status > 0) whereSql += " and Status=@Status";
            if (!EmptyUtils.EmptyStr(vo.EmpId)) whereSql += " and EMP_ID=@EmpId";

            string sql = "SELECT * FROM HR_LEAVE WHERE 1=1 ";
            sql = sql += whereSql;
            sql = sql += " AND EMP_ID IN(SELECT EMP_ID FROM HR_USER WHERE USER_TYPE = 2)";

            return conn.Query<HRLeave>(sql, new
            {
                Id = vo.Id,
                Status = vo.Status,
                EmpId = vo.EmpId
            }).ToList();
        }

        public List<HRLeave> FindByDate(string date)
        {
            return conn.Query<HRLeave>("SELECT * FROM HR_LEAVE WHERE LEAVE_DATE = @date", new
            {
                date = date
            }).ToList();
        }

        /// <summary>
        /// 查询指定区间的所有请假记录
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public List<HRLeave> FindByInterval(string startDate, string endDate)
        {
            return conn.Query<HRLeave>("select l.* from HR_CONTRACT c, HR_LEAVE l where c.EMP_ID = l.EMP_ID and STATUS = 2 and date(l.leave_date) between @startDate and @endDate", new
            {
                startDate = startDate,
                endDate = endDate
            }).ToList();
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <returns></returns>
        public int Update(HRLeave vo)
        {
            //return conn.Execute(@"update HR_LEAVE SET NAME=@Name,CREATE_TIME=@CreateTime WHERE id = @Id",
            //    new
            //    {
            //        Id = vo.Id,
            //        Name = vo.Name,
            //        CreateTime = vo.CreateTime
            //    });
            return 0;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <returns></returns>
        public int Update(string id, int status)
        {
            return conn.Execute(@"update HR_LEAVE SET status=@status WHERE id = @Id",
                new
                {
                    Id = id,
                    status = status
                });
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(string id)
        {
            return conn.Execute(@"DELETE FROM HR_LEAVE WHERE id = @id", new { id = id });
        }
    }
}
