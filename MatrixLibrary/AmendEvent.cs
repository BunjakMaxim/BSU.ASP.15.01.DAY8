using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLibrary
{
    public class AmendMatrixEvent
    {
        public event EventHandler<AmendMatrixEventArgs> amendIMatrixItem;

        public void OnAmendIMatrixItem(string massage)
        {
            AmendMatrixEventArgs c = new AmendMatrixEventArgs();

            if (amendIMatrixItem != null)
            {
                c.massage = massage;
                amendIMatrixItem(this, c);
            }
        }
    }
}
