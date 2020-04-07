using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using HRMgrSystem.vo;
using HRMgrSystem.utils;
using MySql.Data.MySqlClient;

namespace HRMgrSystem.db
{
    public class DeptDao : BaseDao
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="deptVo"></param>
        public int Add(HRDept deptVo)
        {
            int ret = conn.Execute(@"insert HR_DEPT(ID, NAME ) values (@id, @name)", 
                new[] { new { id = deptVo.Id, name = deptVo.Name } });
            Console.WriteLine(string.Format("插入数据库成功{0}", ret));
            return ret;
        }

        /// <summary>
        /// 查询部门根据ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HRDept FindById(string id)
        {
            List<HRDept> list = conn.Query<HRDept>("SELECT * FROM HR_DEPT where Id = @Id", new { Id = id }).ToList();
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
        public List<HRDept> FindAll()
        {
            return conn.Query<HRDept>("SELECT * FROM HR_DEPT").ToList();
        }

        public List<HRDept> FindByWhere(HRDept vo)
        {
            string whereSql = "";
            if (!EmptyUtils.EmptyStr(vo.Id)) whereSql += " and id=@Id";
            if (!EmptyUtils.EmptyStr(vo.Name)) whereSql += " and Name=@Name";

            return conn.Query<HRDept>("SELECT * FROM HR_DEPT where 1=1 " + whereSql, new {
                Id = vo.Id,
                Name = vo.Name,
            }).ToList();
        }


        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="deptVo"></param>
        /// <returns></returns>
        public int Update(HRDept deptVo)
        {
            return conn.Execute(@"update HR_DEPT SET NAME=@name WHERE id =@id",
                new { id = deptVo.Id, name = deptVo.Name}); 
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(string id)
        {
            return conn.Execute(@"DELETE FROM HR_DEPT WHERE id = @id", new { id = id });
        }
    }
}
