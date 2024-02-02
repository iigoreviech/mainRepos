using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProApp.Data;

namespace GameProApp.Data
{
    public static class Users
    {
        /// <summary>
        /// Статический метод. Получает пользователя по указанному логину и паролю. При остутствии результатов возвращает NULL
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns>Пользователь с указанным логином и паролем либо NULL, если такой пользователь не найден</returns>
        public static User GetUserByLoginPassword(string login, string password)
        {
            password = getMD5Hash(password);
            List<User> results = AppData.db.Users.Where(p => p.login == login && p.password == password).ToList();
            if (results.Count > 0 && login == results[0].login)
                return results[0];
            return null;
        }

        private static string getMD5Hash(string password)
        {
            MD5 md5 = MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                result.Append(data[i].ToString("x2"));
            }
            return result.ToString();
        }
    }
}
