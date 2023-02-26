using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWork_10._1
{
    internal class Konsult : Account
    {
        public long PhNumber
        {
            get { return phnumber; }
            set { phnumber = value; }
        }
        public string Pasport
        {
            get { return "**** ******"; }
            private set { }
        }
        /// <summary>
        /// чтение аккаунтов из файла
        /// </summary>
        /// <returns>возвращает лист аккаунтов</returns>
        public List<Account> read()
        {
            Account ac = new Account();
            StreamReader sr = new StreamReader("Accounts.txt");
            List<Account> accs = new List<Account>();
            string[] acc = new string[4];
            while (!sr.EndOfStream)
            {
                ac = new Konsult();
                acc = sr.ReadLine().Split('#');
                ac.Add(acc[0], acc[1], acc[2], Convert.ToInt64(acc[3]), acc[4]);
                accs.Add(ac);
            }
            sr.Close();
            return accs;
        }
    }
}
