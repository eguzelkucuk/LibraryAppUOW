using LibraryAppUOW.Domain.Entities;
using LibraryAppUOW.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppUOW.Domain.Services
{
    public interface IUserListService
    {
        IList<UserList> GetAll();
        UserList GetById(int id);
        void Create(UserList User);
        void Update(UserList User);
        void Delete(int id);
    }

    public class UserListService : IUserListService
    {
        private IRepository<UserList> _productRepository;

        public UserListService(IRepository<UserList> productRepository)
        {
            _productRepository = productRepository;
        }

        public IList<UserList> GetAll()
        {
            return _productRepository
                .GetAll()
                .ToList();
        }

        public UserList GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void Create(UserList product)
        {
            _productRepository.Create(product);
        }

        public void Update(UserList product)
        {
            _productRepository.Update(product);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

    }
}
