﻿using System;
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
        public void Add(HRDept deptVo)
        {
            var ret = conn.Execute(@"insert HR_DEPT(ID, NAME, HEADER_ID) values (@id, @name, @headerId)", 
                new[] { new { id = deptVo.Id, name = deptVo.Name, headerId = deptVo.HeaderId } });
            Console.WriteLine(string.Format("插入数据库成功{0}", ret));
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

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="deptVo"></param>
        /// <returns></returns>
        public int Update(HRDept deptVo)
        {
            return conn.Execute(@"update HR_DEPT SET NAME=@name, HEADER_ID=@headerId WHERE id =@id",
                new { id = deptVo.Id, headerId = deptVo.HeaderId }); 
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