using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.Model;
using StudentStatusManageSystem.AbstractDAL;
using System.Reflection;

namespace StudentStatusManageSystem.SimpleFactory
{
    /// <summary>
    /// 简单工厂
    /// </summary>
    public class DataBaseAccess
    {
        private DataBaseAccess()
        {
            //不允许建立此类的实例
        }
        //为了让DAL.dll出现在UI层文件夹里
        private const SqliteDAL.SqliteUserDAL a=null;
        private const SqlserverDAL.SqlserverUserDAL b = null;
        //


        private static readonly string dbName = System.Configuration.ConfigurationManager.AppSettings["dbName"];  //Sqlserver,Sqlite
        private static readonly string assemblyName = dbName + "DAL";   //SqlserverDAL,SqliteDAL
        

        /// <summary>
        /// 根据反射创建DAL层的对象，根据配置文件中参数，决定是实例化哪一种数据库的DAL层
        /// </summary>
        /// <returns></returns>
        public static IUserDAL CreateUserDAL()
        {    
            //由于这句不能让程序在生成时知道实例化哪一个数据库的实例，所以在最终层UI层里并没有SqlserverDAL.dll和SqliteDAL.dll,所以会异常，找不到程序集SqlserverDAL.dll和SqliteDAL.dll
            return (IUserDAL)System.Reflection.Assembly.Load(assemblyName).CreateInstance("StudentStatusManageSystem." + assemblyName + "." + dbName + "UserDAL", false);   
        }

        public static IStudentDAL CreateStudentDAL()
        {            
            return (IStudentDAL)System.Reflection.Assembly.Load(assemblyName).CreateInstance("StudentStatusManageSystem." + assemblyName + "." + dbName + "StudentDAL", false);
        }

        public static IRoleDAL CreateRoleDAL()
        {
            return (IRoleDAL)System.Reflection.Assembly.Load(assemblyName).CreateInstance("StudentStatusManageSystem." + assemblyName + "." + dbName + "RoleDAL", false);
        }

        public static IClassInfoDAL CreateClassInfoDAL()
        {
            return (IClassInfoDAL)System.Reflection.Assembly.Load(assemblyName).CreateInstance("StudentStatusManageSystem." + assemblyName + "." + dbName + "ClassInfoDAL", false);
        }

        public static ISpecialityDAL CreateSpecialityDAL()
        {
            return (ISpecialityDAL)System.Reflection.Assembly.Load(assemblyName).CreateInstance("StudentStatusManageSystem." + assemblyName + "." + dbName + "SpecialityDAL", false);
        }

        public static ICourseDAL CreateCourseDAL()
        {
            return (ICourseDAL)System.Reflection.Assembly.Load(assemblyName).CreateInstance("StudentStatusManageSystem." + assemblyName + "." + dbName + "CourseDAL", false);
        }

        public static IClassroomDAL CreateClassroomDAL()
        {
            return (IClassroomDAL)System.Reflection.Assembly.Load(assemblyName).CreateInstance("StudentStatusManageSystem." + assemblyName + "." + dbName + "ClassroomDAL", false);
        }

        public static ICollegeDAL CreateCollegeDAL()
        {
            return (ICollegeDAL)System.Reflection.Assembly.Load(assemblyName).CreateInstance("StudentStatusManageSystem." + assemblyName + "." + dbName + "CollegeDAL", false);
        }
    }

}
