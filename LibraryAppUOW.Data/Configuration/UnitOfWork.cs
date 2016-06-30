using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAppUOW.Domain.Entities;
using LibraryAppUOW.Domain.Interfaces;
using LibraryAppUOW.Data.MappingOverrides;

namespace LibraryAppUOW.Data.Configuration
{
    public class UnitOfWork : IUnitOfWork
    {
        private static readonly ISessionFactory _sessionFactory;
        private ITransaction _transaction;

        public ISession Session { get; set; }

        static UnitOfWork()
        {
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(x => x.FromConnectionStringWithKey("Library")))
                .Mappings(x => x.AutoMappings.Add(
                    AutoMap.AssemblyOf<UserList>(new mappingConfiguration()).UseOverridesFromAssemblyOf<UserListOverrides>()))
                .ExposeConfiguration(config => new SchemaUpdate(config).Execute(true, true))
                .BuildSessionFactory();
        }

        public UnitOfWork()
        {
            Session = _sessionFactory.OpenSession();
        }

        public void BeginTransaction()
        {
            _transaction = Session.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                if (_transaction != null && _transaction.IsActive)
                    _transaction.Commit();
            }
            catch
            {
                if (_transaction != null && _transaction.IsActive)
                    _transaction.Rollback();

                throw;
            }
            finally
            {
                Session.Dispose();
            }
        }

        public void Rollback()
        {
            try
            {
                if (_transaction != null && _transaction.IsActive)
                    _transaction.Rollback();
            }
            finally
            {
                Session.Dispose();
            }
        }
    }
}
