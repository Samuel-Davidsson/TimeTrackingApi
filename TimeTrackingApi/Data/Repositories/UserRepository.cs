﻿using Data.DataContext;
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TimeTrackingContext _context;
        public UserRepository(TimeTrackingContext context)
        {
            _context = context;
        }

        public User GetUserById(int id)
        {
            var user = _context.Users.SingleOrDefault(x => x.Id == id);
            return user;
        }

        public User GetUserByLogin(string login)
        {
            var user = _context.Users.SingleOrDefault(x => x.Login == login);
            return user;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public void Add(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }
    }
}
