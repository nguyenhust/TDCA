using CrystalDecisions.CrystalReports.Engine;
using NETLINK.LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace NETLINK.UI
{
    public partial class NetLinkReport : Telerik.WinControls.UI.RadForm
    {
        FormMode formMode;
        public NetLinkReport(FormMode mode)
        {
            InitializeComponent();
            formMode = mode;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                if (formMode.Item != null)
                {
                    ReportDocument document = (ReportDocument)formMode.Item;
                    crystalReportViewer1.ReportSource = document;
                    crystalReportViewer1.Refresh();
                }
            }
            catch (Exception ex)
            {

            }
        }

    }
}
