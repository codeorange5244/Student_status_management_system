using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatusManageSystem.Model
{
    public class Student
    {
        public System.Guid Student_GUID { get; set; }
        public int Id { get; set; }
        /// <summary>
        /// 班级Id
        /// </summary>
        public int Class_id { get; set; }
        /// <summary>
        /// 专业Id
        /// </summary>
        public int Speciality_id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        public string ID_Card { get; set; }
        public Nullable<decimal> Sex { get; set; }
        /// <summary>
        /// 民族
        /// </summary>
        public string Nationality { get; set; }
        public string Address { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 政治面貌
        /// </summary>
        public string Political_role { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        public string Posecode { get; set; }
        public string Remark { get; set; }
        /// <summary>
        /// 照片
        /// </summary>
        public byte[] Photograph { get; set; }
        /// <summary>
        /// 删除标识，0---未删除 1---已删除
        /// </summary>
        public decimal DelFlag { get; set; }
        /// <summary>
        /// 提交人Id
        /// </summary>
        public Nullable<int> Submitter_id { get; set; }
    }
}
