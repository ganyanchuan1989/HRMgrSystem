﻿using Dapper;
using HRMgrSystem.utils;
using HRMgrSystem.vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMgrSystem.db
{
    public class JobDao : BaseDao
    {
        // 新增
        public int Add(HRJob vo)
        {
            int ret = conn.Execute(@"insert HR_JOB(ID,NAME) values (@Id,@Name)" ,
                new[] { new { Id = vo.Id,
                    Name = vo.Name} });

            Console.WriteLine(string.Format("插入数据库成功{0}", ret));

            return ret;
        }

        /// <summary>
        /// 查询部门根据ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HRJob FindById(string id)
        {
            List<HRJob> list = conn.Query<HRJob>("SELECT * FROM HR_JOB where Id = @Id", new { Id = id }).ToList();
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
        public List<HRJob> FindAll()
        {
            return conn.Query<HRJob>("SELECT * FROM HR_JOB").ToList();
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <returns></returns>
        public int Update(HRJob vo)
        {
            return conn.Execute(@"update HR_JOB SET NAME=@Name WHERE id = @Id",
                new
                {
                    Id = vo.Id,
                    Name = vo.Name
                });
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(string id)
        {
            return conn.Execute(@"DELETE FROM HR_JOB WHERE id = @id", new { id = id });
        }
    }
}
