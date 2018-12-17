using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.DAL.Model
{
    public class Elema
    {
        public int ID { get; set; }
        public int MobileID { get; set; }
        public string UserName { get; set; }
        /// <summary>
        /// 明文密码
        /// </summary>
        public string Password { get; set; }
        public int IsValid { get; set; }
    }
}
