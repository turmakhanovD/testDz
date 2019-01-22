using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class User
    {
        
        public int Id { get; set; }
        //private int _id;

        //public int GetId()
        //{
        //    return _id;
        //}

        //public void SetId(int id)
        //{
        //    _id = id;
        //}

        // public возвр_тип Имя {модификатор_доступа get; модификатор_доступа set;}; - autoproperty

        /* private тип переменная;
         * public возвр_тип Имя
         * {
         *   get{
         *     code ;
         *     return переменная;
         *      };
         * 
         * 
         *     set {
         *      code;
         *       переменная = value;
         *     }
         */
        private string _login;
        public string Login
        {
            get
            {
                //тело
                return _login;
            }

            set
            {
                //тело
                _login = value;
            }

        }


        private string _password;
        public string Password
        {
            get
            {
                //тело
                return _password;
            }

            set
            {
                //тело
                _password = value;
            }

        }

        private string[] _nicknames;
        /* private тип_массива[] переменная
        
            public тип_массива this[тип index]
            {
            get{return переменная[index]}
            set{переменная[index]=value}
            }
        */
        public string this[int index]
        {
            get { return _nicknames[index]; }
            set { _nicknames[index] = value; }
        }

    }
}
