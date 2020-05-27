using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMgrSystem.utils
{
    /// <summary>
    /// 系统数据字典表
    /// </summary>
    public class DataDictionaryUtils
    {
        /// <summary>
        /// 性别（0:男；1：女）
        /// </summary>
        public static DataTable GetSexDict()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("value");
            dt.Columns.Add("label");

            DataRow dr = dt.NewRow();
            dr["value"] = 0;
            dr["label"] = "男";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["value"] = 1;
            dr["label"] = "女";
            dt.Rows.Add(dr);

            return dt;
        }

        /// <summary>
        /// 学历（1：高中及高中以下:2：大专，3：本科，4：硕士，5：博士，6；博士后）
        /// </summary>
        public static DataTable GetEducationDict()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("value");
            dt.Columns.Add("label");

            DataRow dr = dt.NewRow();
            dr["value"] = 1;
            dr["label"] = "高中及高中以下";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["value"] = 2;
            dr["label"] = "大专";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["value"] = 3;
            dr["label"] = "本科";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["value"] = 4;
            dr["label"] = "硕士";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["value"] = 5;
            dr["label"] = "博士";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["value"] = 6;
            dr["label"] = "博士后";
            dt.Rows.Add(dr);

            return dt;
        }

        /// <summary>
        /// 政治面貌（1：群众，2：团员，3：党员）
        /// </summary>
        public static DataTable GetPoliticalStatusDict()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("value");
            dt.Columns.Add("label");

            DataRow dr = dt.NewRow();
            dr["value"] = 1;
            dr["label"] = "群众";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["value"] = 2;
            dr["label"] = "团员";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["value"] = 3;
            dr["label"] = "党员";
            dt.Rows.Add(dr);

            return dt;
        }

        /// <summary>
        /// 在职状态（1：在职；2：离职）
        /// </summary>
        public static DataTable GetStatusDict()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("value");
            dt.Columns.Add("label");

            DataRow dr = dt.NewRow();
            dr["value"] = 1;
            dr["label"] = "在职";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["value"] = 2;
            dr["label"] = "离职";
            dt.Rows.Add(dr);
            
            return dt;
        }


        /// <summary>
        /// 用户状态（1：可用；2：停用）
        /// </summary>
        public static DataTable GetUserStatusDict()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("value");
            dt.Columns.Add("label");

            DataRow dr = dt.NewRow();
            dr["value"] = 1;
            dr["label"] = "可用";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["value"] = 2;
            dr["label"] = "停用";
            dt.Rows.Add(dr);

            return dt;
        }

        /// <summary>
        /// 用户类型（1：普通用户；2：管理员用户）
        /// </summary>
        public static DataTable GetUserTypeDict()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("value");
            dt.Columns.Add("label");

            DataRow dr = dt.NewRow();
            dr["value"] = 1;
            dr["label"] = "普通用户";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["value"] = 2;
            dr["label"] = "管理员";
            dt.Rows.Add(dr);

            return dt;
        }

        /// <summary>
        /// 合同类型(1：新签合同; 2：续合同)
        /// </summary>
        public static DataTable GetContractTypeDict()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("value");
            dt.Columns.Add("label");

            DataRow dr = dt.NewRow();
            dr["value"] = 1;
            dr["label"] = "新签合同";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["value"] = 2;
            dr["label"] = "续合同";
            dt.Rows.Add(dr);

            return dt;
        }

        /// <summary>
        /// 1：年假，2：病假，3：婚假，4：产假，5：事假
        /// </summary>
        /// <returns></returns>
        public static DataTable GetLeaveDict()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("value");
            dt.Columns.Add("label");

            DataRow dr = dt.NewRow();
            dr["value"] = 1;
            dr["label"] = "年假";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["value"] = 2;
            dr["label"] = "病假";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["value"] = 3;
            dr["label"] = "婚假";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["value"] = 4;
            dr["label"] = "产假";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["value"] = 5;
            dr["label"] = "事假";
            dt.Rows.Add(dr);

            return dt;
        }

        /// <summary>
        /// 审批状态（1：保存，2：提交申请，3：审批通过，4：驳回）
        /// </summary>
        /// <returns></returns>
        public static DataTable GetLeaveStatusDict()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("value");
            dt.Columns.Add("label");

            DataRow dr = dt.NewRow();
            dr["value"] = 1;
            dr["label"] = "保存";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["value"] = 2;
            dr["label"] = "提交申请";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["value"] = 3;
            dr["label"] = "审批通过";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["value"] = 4;
            dr["label"] = "驳回";
            dt.Rows.Add(dr);

            return dt;
        }


    }
}
