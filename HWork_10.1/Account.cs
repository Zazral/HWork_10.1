using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HWork_10._1
{
    public class Account
    {
        public string surname { get; private set; }
        public string firstname { get; private set; }
        public string lastname { get; private set; }
        public long phnumber { get; protected set; }
        public string pasport { get; protected set; }
        /// <summary>
        /// создание банковского счета
        /// </summary>
        /// <param name="surname">Фамилия</param>
        /// <param name="firstname">Имя</param>
        /// <param name="lastname">Отчество</param>
        /// <param name="phnumber">Номер телефона</param>
        /// <param name="pasport">Серия номер паспорта</param>
        public void Add(string surname, string firstname, string lastname, long phnumber, string pasport)
        {
            this.surname = surname;
            this.firstname = firstname;
            this.lastname = lastname;
            this.phnumber = phnumber;
            this.pasport = pasport;
        }
        public override string ToString()
        {
            return ($"{this.surname}#{this.firstname}#{this.lastname}#{Convert.ToString(this.phnumber)}#{this.pasport}");
        }
        /// <summary>
        /// Запись аккаунтов в файл
        /// </summary>
        /// <param name="accounts">лист аккаунтов</param>
        public void write(List<Account> accounts)
        {
            StreamWriter sw = new StreamWriter("Accounts.txt", false);
            foreach(Account el in accounts)
            {
                sw.WriteLine(el.ToString());
            }
            sw.Close();
        }
    }
}
