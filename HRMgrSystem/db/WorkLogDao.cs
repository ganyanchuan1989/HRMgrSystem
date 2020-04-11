using Dapper;
using HRMgrSystem.utils;
using HRMgrSystem.vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMgrSystem.db
{
    public class WorkLogDao : BaseDao
    {
        // 新增
        public int Add(HRWorkLog vo)
        {
            var ret = conn.Execute(@"insert HR_WORK_LOG(ID,EMP_ID,LOG_DATE,CONTENT) values (@Id,@EmpId,@LogDate,@Content)",
                new[] { new { Id = vo.Id,
                    EmpId = vo.EmpId,
                    LogDate = vo.LogDate,
                    Content = vo.Content} });

            Console.WriteLine(string.Format("插入数据库成功{0}", ret));
            return ret;
        }

        /// <summary>
        /// 查询部门根据ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HRWorkLog FindById(string id)
        {
            List<HRWorkLog> list = conn.Query<HRWorkLog>("SELECT * FROM HR_WORK_LOG where Id = @Id", new { Id = id }).ToList();
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
        /// 查询员工所有日志
        /// </summary>
        /// <param name="EmpId"></param>
        /// <returns></returns>
        /// <summary>
        public List<HRWorkLog> FindEmpId(string empId)
        {
            return conn.Query<HRWorkLog>("SELECT w.*, e.name as EMP_NAME FROM HR_WORK_LOG w, HR_EMPLOYEE e where w.EMP_ID = e.Id and w.Emp_Id=@EmpId", 
                new
                {
                    EmpId = empId
                }).ToList();
        }


        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        public List<HRWorkLog> FindAll()
        {
            return conn.Query<HRWorkLog>("SELECT w.*, e.name as EMP_NAME FROM HR_WORK_LOG w, HR_EMPLOYEE e where w.EMP_ID = e.Id").ToList();
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <returns></returns>
        public int Update(HRWorkLog vo)
        {
            return conn.Execute(@"update HR_WORK_LOG SET EMP_ID=@EmpId,LOG_DATE=@LogDate,Content=@Content WHERE id = @Id",
               new
               {
                   Id = vo.Id,
                   EmpId = vo.EmpId,
                   LogDate = vo.LogDate,
                   Content = vo.Content
               });
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(string id)
        {
            return conn.Execute(@"DELETE FROM HR_WORK_LOG WHERE id = @id", new { id = id });
        }
    }
}
