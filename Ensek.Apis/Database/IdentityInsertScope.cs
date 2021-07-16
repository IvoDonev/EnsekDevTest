using Microsoft.EntityFrameworkCore;
using System;

namespace Ensek.Apis
{
    internal class IdentityInsertScope<T> : IDisposable
    {
        private DbContext context;

        public IdentityInsertScope(DbContext context)
        {
            this.context = context;
            SetIdentityInsert(true);
        }

        private void SetIdentityInsert(bool enable)
        {
            context.Database.OpenConnection();
            var entityType = context.Model.FindEntityType(typeof(T));
            var value = enable ? "ON" : "OFF";
            var command = $"SET IDENTITY_INSERT dbo.{entityType.GetTableName()} {value}";
            context.Database.ExecuteSqlRaw(command);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    SetIdentityInsert(false);
                    context.Database.CloseConnection();
                }
                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~IdentityInsertScope()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
