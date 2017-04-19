using Server.Context;
using Shared.Core.Context;
using System;
using System.Data.Entity;

namespace Server.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private BujinkanContext _modelContext;
        private DbContextTransaction _transaction;

        public UnitOfWork()
        {
            _modelContext = new BujinkanContext();

            //var watch = System.Diagnostics.Stopwatch.StartNew();
            //_modelContext = new BujinkanContext();
            //_modelContext.Set<User>().ToList();
            //watch.Stop();
            //var elapsedMs = watch.ElapsedMilliseconds;
        }
        public void StartTransaction()
        {
            if (_transaction == null)
            {
                if (_modelContext.Database.Connection.State != System.Data.ConnectionState.Open)
                {
                    _modelContext.Database.Connection.Open();
                }
                _transaction = _modelContext.Database.BeginTransaction();
            }
        }

        public void EndTransaction()
        {
            if (_transaction == null)
            {
                return;
            }

            try
            {
                Commit();
            }
            catch (Exception e)
            {
                Rollback();
            }
        }

        private void Commit()
        {
            //_modelContext.SaveChanges();
            _transaction.Commit();
        }

        private void Rollback()
        {
            _transaction.Rollback();
        }

        public void Dispose()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
            }
            _modelContext.Dispose();
        }

        public IDatabaseContext GetContext()
        {
            return _modelContext;
        }
    }
}
