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
    public class UserDao : BaseDao
    {
        // 新增
        public void Add(HRUser vo)
        {
            var ret = conn.Execute(@"insert HR_USER(ID,EMP_ID,PASSWORD,USERNAME,STATUS,USER_TYPE) values (@Id,@EmpId,@Password,@Username,@Status,@UserType)",
                new[] { new { Id = vo.Id,
                    EmpId = vo.EmpId,
                    Password = vo.Password,
                    Username = vo.Username,
                    Status = vo.Status,
                    UserType = vo.UserType} });

            Console.WriteLine(string.Format("插入数据库成功{0}", ret));
        }

        /// <summary>
        /// 查询部门根据ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HRUser FindById(string id)
        {
            List<HRUser> list = conn.Query<HRUser>("SELECT * FROM HR_USER where Id = @Id", new { Id = id }).ToList();
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
        public List<HRUser> FindAll()
        {
            return conn.Query<HRUser>("SELECT * FROM HR_USER").ToList();
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <returns></returns>
        public int Update(HRUser vo)
        {
            return conn.Execute(@"update HR_USER SET Id=@Id,EMP_ID=@EmpId,PASSWORD=@Password,USERNAME=@Username,STATUS=@Status,USER_TYPE=@UserType WHERE id = @Id",
                new
                {
                    Id = vo.Id,
                    EmpId = vo.EmpId,
                    Password = vo.Password,
                    Username = vo.Username,
                    Status = vo.Status,
                    UserType = vo.UserType,
                });
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(string id)
        {
            return conn.Execute(@"DELETE FROM HR_USER WHERE id = @id", new { id = id });
        }
    }
}
