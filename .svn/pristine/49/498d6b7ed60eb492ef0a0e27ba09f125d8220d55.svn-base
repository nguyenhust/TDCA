using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NETLINK.UI;
using NETLINK.LIB;
using ModuleChiDaoTuyen.LIB;
using ModuleChiDaoTuyen.UI;


namespace ModuleChiDaoTuyen.UserControl
{
    public partial class GridCDTReport : UsDictionary
    {
       // WordTemplates wordTemplate;
        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        public GridCDTReport()
        {
            InitializeComponent();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            HideToolBar();
          //  wordTemplate = new WordTemplates();
        }


        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.CDT_CDTReport;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.CDT_CDTReport;
        }

        protected override void ApplyAuthorizationRules()
        {

        }

        protected override void Save()
        {

        }

        protected override void LoadUS()
        {
            try
            {
         //       radbindingSource.DataSource = CDT_GoiKT_Coll.GetCDT_GoiKT_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            try
            {
        //        radbindingSource.DataSource = CDT_GoiKT_Coll.GetCDT_GoiKT_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Delete()
        {
            base.Delete();
        }

        protected override void MyClose()
        {
            try
            {

            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
               // GlobalCommon.ShowMessageInformation(wordTemplate.BaoCaoCanBoChuyenGiaoKyThuat("Bao Cao"));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {

            try
            {
                string[] congtacList = new string[]
                {
                    "Tài liệu đào tạo/Bệnh án hội chuẩn: Tốt, rõ ràng, đầy đủ.", "Công tác truyền thông: Tốt,", "Hậu cần: Tốt." 
                };
                string[] root_daotao = new string[]
            {
                "Chất lượng đường truyền: Ổn định rõ nét", "Mức độ tham gia của các bệnh viện và các tham dự viên: ", "Các nội dung chính đã trình bày: "
            };
                string[] sub_daotao = new string[] { 
                "", "Bệnh viện Sơn La tham gia rất tích cực. Bệnh viện Hà Đông tham ra tốt. Các bệnh viện tham gia nhiệt tình", "Bệnh án bệnh viện Sơn La chuẩn bị còn thiếu một vài thông tin. Bệnh án của BV Hà Đông thật sự có nhiều vấn đề bàn luận. Bệnh án Bạch Mai rất điển hình, các bác sĩ trong khoa tham gia nhiệt tình."
            };
              // GlobalCommon.ShowMessageInformation(wordTemplate.BaoCaoKetQuaDaoTao_HoiChuanTrucTuyen("temp1", DateTime.Now, @"PGS.TS Nguyễn Gia Bình - Trưởng khoa Hồi sức tích cực BV Bạch Mai", "BS Trịnh Kim Giang - Trung tâm Đào tạo và Chỉ đạo tuyến BV Bạch Mai \r CN. Lê Anh Tuấn -Trung tâm Đào tạo và Chỉ đạo tuyến BV Bạch Mai", congtacList, root_daotao));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            try
            {
               // GlobalCommon.ShowMessageInformation(wordTemplate.BaoCaoKetQua_HoatDongChuyenGiaoKyThuat("Bao cao"));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }




    }
}
