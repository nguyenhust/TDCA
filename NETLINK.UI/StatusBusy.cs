using System;
using System.Windows.Forms;

namespace NETLINK.UI
{
    public class StatusBusy : IDisposable
    {
        private Cursor _oldCursor;

        public StatusBusy(string statusText)
        {
            _oldCursor = Dictionary.Instance.Cursor;
            Dictionary.Instance.Cursor = Cursors.WaitCursor;
        }

        // IDisposable
        private bool _disposedValue = false; // To detect redundant calls

        protected void Dispose(bool disposing)
        {
            if (!_disposedValue)
                if (disposing)
                {
                    Dictionary.Instance.Cursor = _oldCursor;
                }
            _disposedValue = true;
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
