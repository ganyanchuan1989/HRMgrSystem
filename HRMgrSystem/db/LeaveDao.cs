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
            int ret = conn.Execute(@"insert HR_LEAVE(ID,EMP_ID,TYPE,LEAVE_DATE,LEAVE_DAY,CAUSE,STATUS) values (@Id,@EmpId,@Type, @LeaveDate, @LeaveDay @Cause,@Status)",
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
