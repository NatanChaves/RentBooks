﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentBooks.DAL
{
    public class BaseDAL : IDisposable
    {
        #region Propriedades

        private bool disposed = false;

        #endregion

        #region Dispose

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Free other state (managed objects).
                }
                // Free your own state (unmanaged objects).
                // Set large fields to null.
                disposed = true;
            }
        }

        ~BaseDAL()
        {
            // Simply call Dispose(false).
            Dispose(false);
        }

        #endregion
    }
}