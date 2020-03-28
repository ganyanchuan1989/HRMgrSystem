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
    public class RewardsPunishmentsDao : BaseDao
    {
        // 新增
        public void Add(HRRewardsPunishments vo)
        {
            var ret = conn.Execute(@"insert HR_REWARDS_PUNISHMENTS(ID,TYPE,TITLE,CONTENT,AMOUNT) values (@Id,@Type,@Title,@Content,@Amount)",
                new[] { new { Id = vo.Id,
                    Type = vo.Type,
                    Title = vo.Title,
                    Content = vo.Content,
                    Amount= vo.Amount } });

            Console.WriteLine(string.Format("插入数据库成功{0}", ret));
        }

        /// <summary>
        /// 查询部门根据ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HRRewardsPunishments FindById(string id)
        {
            List<HRRewardsPunishments> list = conn.Query<HRRewardsPunishments>("SELECT * FROM HR_REWARDS_PUNISHMENTS where Id = @Id", new { Id = id }).ToList();
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
        public List<HRRewardsPunishments> FindAll()
        {
            return conn.Query<HRRewardsPunishments>("SELECT * FROM HR_REWARDS_PUNISHMENTS").ToList();
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <returns></returns>
        public int Update(HRRewardsPunishments vo)
        {
            return conn.Execute(@"update HR_REWARDS_PUNISHMENTS SET Type=@Type,Title=@Title,Content=@Content,Amount=@Amount WHERE id = @Id",
                new
                {
                    Id = vo.Id,
                    Type = vo.Type,
                    Title = vo.Title,
                    Content = vo.Content,
                    Amount = vo.Amount
                });
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(string id)
        {
            return conn.Execute(@"DELETE FROM HR_REWARDS_PUNISHMENTS WHERE id = @id", new { id = id });
        }
    }
}
