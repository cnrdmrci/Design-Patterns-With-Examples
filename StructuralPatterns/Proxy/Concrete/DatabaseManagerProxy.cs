using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Text;
using DesignPatterns.StructuralPatterns.Proxy.Abstract;

namespace DesignPatterns.StructuralPatterns.Proxy.Concrete
{
    public class DatabaseManagerProxy : IDatabase
    {
        private readonly DatabaseManager _databaseManager;
        private readonly bool _isLogin;

        public DatabaseManagerProxy(string userName,string password)
        {
            if (userName.Equals("caner") && password.Equals("12345"))
                _isLogin = true;
            _databaseManager = new DatabaseManager();
        }
        public string GetDataFromDatabase()
        {
            if (!_isLogin)
            {
                throw new AuthenticationException("You are not logged in.");
            }

            return _databaseManager.GetDataFromDatabase();
        }
    }
}
