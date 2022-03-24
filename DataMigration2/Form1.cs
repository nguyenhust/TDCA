using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuleDaoTao.LIB;
using DanhMuc.LIB;
using oldSoft;
using NETLINK.LIB;
using System.Threading;
using ModuleChiDaoTuyen.LIB;

namespace dataMigration
{
    public partial class Form1 : Form
    {
        Dictionary<int, Int64> Li_CanBo = new Dictionary<int, Int64>();
        Dictionary<int, int> Li_NguonKinhPhi = new Dictionary<int, int>();
        Dictionary<int, int> Li_DMLopHoc = new Dictionary<int, int>();
        Dictionary<int, int> Li_ChuyenKhoa = new Dictionary<int, int>();
        Dictionary<string, int> Li_TrinhDo = new Dictionary<string, int>();
        Dictionary<string, int> Li_TrinhDo2 = new Dictionary<string, int>();
        Dictionary<string, int> Li_User = new Dictionary<string, int>();
        Dictionary<string, long> Li_ThanhPho = new Dictionary<string, long>();
        Dictionary<int, int> Li_PhongQuanLy = new Dictionary<int, int>();
        Dictionary<int, string> Li_MaLopHoc = new Dictionary<int, string>();
        Dictionary<string, int> Li_KhungLopHoc = new Dictionary<string, int>();
        Dictionary<int, long> Li_DMBenhVien = new Dictionary<int, long>();
        DT_LienTuc_KhungLopHoc_Coll test;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
        #region Migrate DM

        private void MappingThanhPho()
        {
            try
            {
                Li_ThanhPho = new Dictionary<string, long>();
                MA_TPHO_COLL oldI = MA_TPHO_COLL.GetMA_TPHO_COLL();
                DIC_Tinh_Coll newI = DIC_Tinh_Coll.GetDIC_Tinh_Coll();
                MA_TPHO_COLL errresult = MA_TPHO_COLL.NewMA_TPHO_COLL();
                MA_TPHO_COLL result = MA_TPHO_COLL.NewMA_TPHO_COLL();
              
                bool done = false;
                ProTask.Maximum = oldI.Count;
                ProTask.Value = 0;
                foreach (MA_TPHO_INFO itemI in oldI)
                {
                    foreach (DIC_Tinh_Info nI in newI)
                    {
                        if (itemI.TEN_TPHO.ToLower().Trim() == nI.Ten.ToLower().Trim())
                        {
                            Li_ThanhPho.Add(itemI.MA_TPHO, nI.ID);
                            result.Add(itemI);
                            done = true;
                            break;
                        }
                    }
                    if (!done)
                    {
                        errresult.Add(itemI);
                        DIC_Tinh itemx = DIC_Tinh.NewDIC_Tinh();
                        itemx.Ten = itemI.TEN_TPHO;
                        itemx.TieuDe = itemI.TEN_TPHO;
                        itemx.SuDung = true;
                        itemx.ApplyEdit();
                        itemx = itemx.Save();
                        Li_ThanhPho.Add(itemI.MA_TPHO, itemx.ID);
                    }
                    done = false;
                    ProTask.Value++;
                }
                //radGridView1.DataSource = result;
                //radGridView2.DataSource = errresult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MappingUser()
        {
            Li_User = new Dictionary<string, int>();
            Li_PhongQuanLy = new Dictionary<int, int>();
            string[] olN = new string[] { "chienhn", "oanhtp", "nganvt", "thinhnd", "admin", "giangph", "tuanka", "huongbm", "nuct", "huyenlx", "thulm", "landx" };
            int[] nn = new int[] { 12, 51, 55, 56, 2, 50, 45, 55, 43, 55, 54, 40 };
            int[] cbn = new int[] { 7, 2, 1, 1, 7, 2, 8, 1, 2, 1, 1, 4 };
            for (int i = 0; i < olN.Length; i++)
            {
                Li_User.Add(olN[i], nn[i]);
                try
                {
                    Li_PhongQuanLy.Add(nn[i], cbn[i]);
                }
                catch
                {
                }
            }

        }

        private void MappingCanBo()
        {
            Li_CanBo = new Dictionary<int, long>();
            NHAN_VIEN_COLL oldL = NHAN_VIEN_COLL.GetNHAN_VIEN_COLL();
            DIC_CanBo_Coll newL = DIC_CanBo_Coll.GetDIC_CanBo_Coll();
            ProTask.Maximum = oldL.Count;
            ProTask.Value = 0;
            
            foreach (NHAN_VIEN_INFO itemInfo in oldL)
            {
                foreach (DIC_CanBo_Info cb in newL)
                {
                    if (itemInfo.TEN_NV.ToLower().Trim().Replace("thị ", "") == cb.HoTen.ToLower().Trim().Replace("thị ", ""))
                    {
                        Li_CanBo.Add(itemInfo.NHAN_VIEN_ID, cb.ID);
                        break;
                    }
                }
                try
                {
                    Int64 test = Li_CanBo[itemInfo.NHAN_VIEN_ID];
                }
                catch
                {
                   // MessageBox.Show(itemInfo.TEN_NV);
                    // Loi -> Hoang Ngoc Chien
                    Li_CanBo.Add(itemInfo.NHAN_VIEN_ID, 15);
                }
                ProTask.Value++;
            }
          
        }

        private void MappingKhungLopHoc()
        {
            Li_DMLopHoc = new Dictionary<int, int>();
            DT_LienTuc_KhungLopHoc_Coll newI = DT_LienTuc_KhungLopHoc_Coll.GetDT_LienTuc_KhungLopHoc_Coll();
            DM_LOPHOC_COLL oldI = DM_LOPHOC_COLL.GetDM_LOPHOC_COLL();
            DM_LOPHOC_COLL result = DM_LOPHOC_COLL.NewDM_LOPHOC_COLL();
            DM_LOPHOC_COLL Errresult = DM_LOPHOC_COLL.NewDM_LOPHOC_COLL();

            DT_LienTuc_KhungLopHoc_Coll map = DT_LienTuc_KhungLopHoc_Coll.NewDT_LienTuc_KhungLopHoc_Coll();
            ProTask.Maximum = oldI.Count;
            ProTask.Value = 0;
            bool done = false ;
            foreach (DM_LOPHOC_INFO o in oldI)
            {
                string tenLHOld = ProcessTenKhungLopHoc(o.TEN_LH);
                foreach (DT_LienTuc_KhungLopHoc_Info n in newI)
                {
                    if (tenLHOld == ProcessTenKhungLopHoc(n.TenLop))
                    {
                        Li_DMLopHoc.Add(o.DM_LOPHOC_ID, n.Id);
                        result.Add(o);
                        map.Add(n);
                        done = true;
                        break;
                    }
                }
                if (!done)
                {
                    try
                    {
                        o.MA_CHUYENNGANH_ID = Li_ChuyenKhoa[Convert.ToInt32(o.MA_CHUYENNGANH_ID)];
                        /* Tự động thêm khung lớp học */

                        DT_LienTuc_KhungLopHoc itemx = DT_LienTuc_KhungLopHoc.NewDT_LienTuc_KhungLopHoc();
                        itemx.IdChuyenKhoa = o.MA_CHUYENNGANH_ID;
                        itemx.TenLop = o.TEN_LH;
                        itemx.ApplyEdit();
                        itemx = itemx.Save();
                        Li_DMLopHoc.Add(o.DM_LOPHOC_ID, itemx.Id);

                        /* Kết thúc tự động thêm khung lớp học */
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(o.TEN_LH + " " + o.MA_CHUYENNGANH_ID + " LV1  " + ex.ToString());
                    }
                    Errresult.Add(o);
                  
                }
                done = false;
                ProTask.Value++;
            }
            //MappingKhungLopHoc_Level2(Errresult,result);
           radGridView1.DataSource = newI;
           radGridView2.DataSource = Errresult;
          // radGridView2.DataSource = map;
           test = newI;
        }

        private void MappingKhungLopHoc_Level2(DM_LOPHOC_COLL oldI,DM_LOPHOC_COLL result)
        {
            DT_LienTuc_KhungLopHoc_Coll newI = DT_LienTuc_KhungLopHoc_Coll.GetDT_LienTuc_KhungLopHoc_Coll();
            //DM_LOPHOC_COLL oldI = DM_LOPHOC_COLL.GetDM_LOPHOC_COLL();
            result = DM_LOPHOC_COLL.NewDM_LOPHOC_COLL();
            DT_LienTuc_KhungLopHoc_Coll map = DT_LienTuc_KhungLopHoc_Coll.NewDT_LienTuc_KhungLopHoc_Coll();
            DM_LOPHOC_COLL Errresult = DM_LOPHOC_COLL.NewDM_LOPHOC_COLL();
            ProTask.Maximum = oldI.Count;
            ProTask.Value = 0;
            bool done = false;
            foreach (DM_LOPHOC_INFO o in oldI)
            {
                string tenLHOld = ProcessTenKhungLopHoc(o.TEN_LH).Replace(" ","");
                foreach (DT_LienTuc_KhungLopHoc_Info n in newI)
                {
                    if (tenLHOld.IndexOf(ProcessTenKhungLopHoc(n.TenLop).Replace(" ","")) >=0 )
                    {
                        Li_DMLopHoc.Add(o.DM_LOPHOC_ID, n.Id);
                        result.Add(o);
                        map.Add(n);
                        done = true;
                        break;
                    }
                }
                if (!done)
                {
                 
                    Errresult.Add(o);
                }
                done = false;
                ProTask.Value++;
            }
            radGridView1.DataSource = result;
            radGridView2.DataSource = map;
        }
        private void MappingChuyenNganh()
        {
            Li_ChuyenKhoa = new Dictionary<int, int>();
            DM_CHUYENNGANH_COLL oldI = DM_CHUYENNGANH_COLL.GetDM_CHUYENNGANH_COLL();
            DIC_ChuyenKhoa_Coll newI = DIC_ChuyenKhoa_Coll.GetDIC_ChuyenKhoa_Coll();
            DM_CHUYENNGANH_COLL result = DM_CHUYENNGANH_COLL.NewDM_CHUYENNGANH_COLL();
            DM_CHUYENNGANH_COLL Errresult = DM_CHUYENNGANH_COLL.NewDM_CHUYENNGANH_COLL();
            ProTask.Maximum = oldI.Count;
            ProTask.Value = 0;
            bool done = false;
            string[] Rlist = new string[] { "khoa","phòng","tt ","trung tâm ","- ","khth","kế hoạch tổng hợp"};
            foreach (DM_CHUYENNGANH_INFO o in oldI)
            {
                {
                    foreach (DIC_ChuyenKhoa_Info n in newI)
                        if (ProcessReplaceStr(o.TEN_CHUYENNGANH,Rlist) == ProcessReplaceStr(n.Ten,Rlist))
                        {
                            Li_ChuyenKhoa.Add(o.MA_CHUYENNGANH_ID, n.ID);
                            //result.Add(o);
                            done = true;
                            break;
                        }
                }
                if (!done)
                {
                    //Errresult.Add(o);
                    DIC_ChuyenKhoa item = DIC_ChuyenKhoa.NewDIC_ChuyenKhoa();
                    item.Ten = o.TEN_CHUYENNGANH;
                    item.GhiChu = o.MA_CHUYENNGANH;
                    item.SuDung = true;
                    item.ApplyEdit();
                    item = item.Save();
                    Li_ChuyenKhoa.Add(o.MA_CHUYENNGANH_ID, item.ID);

                }
                done = false;
                ProTask.Value++;
            }
            //radGridView1.DataSource = result;
            //radGridView2.DataSource = Errresult;
        }

        private void MappingNguonKinhPhi()
        {
            DM_NGUONKINHPHI_COLL oldI = DM_NGUONKINHPHI_COLL.GetDM_NGUONKINHPHI_COLL();
            DIC_NguonKinhPhi_Coll newI = DIC_NguonKinhPhi_Coll.GetDIC_NguonKinhPhi_Coll();
            bool done = false;
            foreach (DM_NGUONKINHPHI_INFO o in oldI)
            {
                foreach (DIC_NguonKinhPhi_Info n in newI)
                {
                    if (o.TEN_NGUONKINHPHI.ToLower().Trim() == n.Ten.ToLower().Trim())
                    {
                        Li_NguonKinhPhi.Add(o.MA_NGUONKINHPHI_ID, n.ID);
                        done = true;
                        break;

                    }
                }
                if (!done)
                {
                    DIC_NguonKinhPhi itemx = DIC_NguonKinhPhi.NewDIC_NguonKinhPhi();
                    itemx.Ten = o.TEN_NGUONKINHPHI;
                    itemx.ApplyEdit();
                    itemx = itemx.Save();
                    Li_NguonKinhPhi.Add(o.MA_NGUONKINHPHI_ID, itemx.ID);
                }
            }
        }

        private void MappingTrinhDo()
        {
            Li_TrinhDo = new Dictionary<string, int>();
            DM_TRINHDO_COLL oldI = DM_TRINHDO_COLL.GetDM_TRINHDO_COLL();
            DIC_HocVi_Coll newI = DIC_HocVi_Coll.GetDIC_HocVi_Coll();
            DM_TRINHDO_COLL result = DM_TRINHDO_COLL.NewDM_TRINHDO_COLL();
            DM_TRINHDO_COLL Errresult = DM_TRINHDO_COLL.NewDM_TRINHDO_COLL();
            
            bool done = false;
            string[] RLF = new string[] { "sỹ" };
            string[] RLT = new string[] { "sĩ" };
            ProTask.Maximum = oldI.Count;
            ProTask.Value = 0;
            foreach (DM_TRINHDO_INFO itemInfo in oldI)
            {
                foreach (DIC_HocVi_Info nItemInfo in newI)
                {
                    if (ProcessReplaceStr(itemInfo.TEN_TRINHDO,RLF,RLT) == ProcessReplaceStr(nItemInfo.TenHocVi,RLF,RLT))
                    {
                        try
                        {
                            Li_TrinhDo.Add(itemInfo.MA_TRINHDO, nItemInfo.ID);
                            result.Add(itemInfo);
                        }
                        catch
                        {
                            Errresult.Add(itemInfo);
                        }
                        done = true;
                        break;
                    }
                }
                if (!done)
                {
                   
                    DIC_HocVi newItem = DIC_HocVi.NewDIC_HocVi();
                    newItem.TenHocVi = itemInfo.TEN_TRINHDO;
                    newItem.ApplyEdit();
                    newItem = newItem.Save();
                    newI = DIC_HocVi_Coll.GetDIC_HocVi_Coll();
                    try
                    {
                        Li_TrinhDo.Add(itemInfo.MA_TRINHDO, newItem.ID);
                        result.Add(itemInfo);
                    }
                    catch
                    {
                        Errresult.Add(itemInfo);
                    }
                }
                done = false;
                ProTask.Value++;
            }
            radGridView1.DataSource = result;
            radGridView2.DataSource = Errresult;
        }

        private void MappingTrinhDo_ForCDT()
        {
            
        }

        private void MappingKhungLopHoc_ForKemCap()
        {
            Li_KhungLopHoc = new Dictionary<string, int>();
            DT_LienTuc_KhungLopHoc_Coll listKhung = DT_LienTuc_KhungLopHoc_Coll.GetDT_LienTuc_KhungLopHoc_Coll();
            HOC_VIEN_TT_COLL listHV = HOC_VIEN_TT_COLL.GetHOC_VIEN_TT_COLL();
            HOC_VIEN_TT_COLL ErrR = HOC_VIEN_TT_COLL.NewHOC_VIEN_TT_COLL();
            HOC_VIEN_TT_COLL R = HOC_VIEN_TT_COLL.NewHOC_VIEN_TT_COLL();
            ProTask.Maximum = listHV.Count;
            ProTask.Value = 0;
            bool done = false;
            foreach(HOC_VIEN_TT_INFO itemInfo in listHV)
            {
                if (itemInfo.HINH_THUC.ToLower().Trim() == "k")
                {
                    foreach(DT_LienTuc_KhungLopHoc_Info itemx in listKhung)
                    {
                        if (ProcessTenKhungLopHoc(itemInfo.NOI_DUNG_DT) == ProcessTenKhungLopHoc(itemx.TenLop))
                        {
                            R.Add(itemInfo);
                            done = true;
                            try
                            {
                                Li_KhungLopHoc.Add(itemInfo.NOI_DUNG_DT, itemx.Id);
                            }
                            catch
                            {
                            }
                            break;
                        }
                    }
                    if (!done)
                    {
                        ErrR.Add(itemInfo);
                        try
                        {
                            DT_LienTuc_KhungLopHoc itemxx = DT_LienTuc_KhungLopHoc.NewDT_LienTuc_KhungLopHoc();
                            itemxx.TenLop = itemInfo.NOI_DUNG_DT;
                            itemxx.IdChuyenKhoa = Convert.ToInt64(Li_ChuyenKhoa[Convert.ToInt32(itemInfo.CK_DK_ID)]);
                            itemxx.ApplyEdit();
                            Li_KhungLopHoc = new Dictionary<string, int>();
                            itemxx = itemxx.Save();
                            listKhung = DT_LienTuc_KhungLopHoc_Coll.GetDT_LienTuc_KhungLopHoc_Coll();
                            //i = 0;
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                    done = false;
                }
                ProTask.Value++;
            }
            radGridView1.DataSource = ErrR;
            radGridView2.DataSource = R;
            
        }

        private void MappingBenhVien()
        {
            MA_BVIEN_COLL olI = MA_BVIEN_COLL.GetMA_BVIEN_COLL();
            DIC_BenhVien_Coll newI = DIC_BenhVien_Coll.GetDIC_BenhVien_Coll();
            MA_BVIEN_COLL Err = MA_BVIEN_COLL.NewMA_BVIEN_COLL();
            MA_BVIEN_COLL R = MA_BVIEN_COLL.NewMA_BVIEN_COLL();
            ProTask.Maximum = olI.Count;
            ProTask.Value = 0;
            Li_DMBenhVien = new Dictionary<int, long>();
            bool done = false;
            string[] Re = new string[] { "bệnh viện","viện"};
            foreach (MA_BVIEN_INFO o in olI)
            {
                foreach (DIC_BenhVien_Info n in newI)
                {
                    if (ProcessReplaceStr(o.TEN_BVIEN.ToLower().Trim(), Re) == ProcessReplaceStr(n.Ten.ToLower().Trim(),Re))
                    {
                        try
                        {
                            Li_DMBenhVien.Add(o.MA_BVIEN_ID, n.ID);
                        }
                        catch
                        {
                        }
                        R.Add(o);
                        done = true;
                        break;
                    }
                }
                if (!done)
                {
                    DIC_BenhVien item = DIC_BenhVien.NewDIC_BenhVien();
                    item.Ten = o.TEN_BVIEN;
                    try
                    {
                        item.IDTinh = Li_ThanhPho[o.MA_TPHO];
                    }
                    catch
                    {
                    }
                    item.SuDung = true;
                    item.ApplyEdit();
                    item = item.Save();
                    newI = DIC_BenhVien_Coll.GetDIC_BenhVien_Coll();
                    try
                    {
                        Li_DMBenhVien.Add(o.MA_BVIEN_ID, item.ID);
                    }
                    catch
                    {
                    }
                    Err.Add(o);
                }
                done = false;
                ProTask.Value++;
            }
            radGridView1.DataSource = Err;
            radGridView2.DataSource = R;
        }

        #endregion

        #region Lop hoc

        private void MigLopHoc()
        {
            try
            {
                ProFull.Maximum = 5;
                ProFull.Value = 0;
                MappingChuyenNganh();
                ProFull.Value = 1;
                MappingKhungLopHoc();
                ProFull.Value = 2;
                MappingCanBo();
                ProFull.Value = 3;
                DeleteLopHoc();
                ProFull.Value = 4;
                CreateLopHoc();
                ProFull.Value = 5;
                MessageBox.Show("Xong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DeleteLopHoc()
        {
            DT_LienTuc_LopHoc_Coll itemColl = DT_LienTuc_LopHoc_Coll.GetDT_LienTuc_LopHoc_Coll();
            ProTask.Maximum = itemColl.Count;
            ProTask.Value = 0;
            foreach (DT_LienTuc_LopHoc_Info itemInfo in itemColl)
            {
                DT_LienTuc_LopHoc.DeleteDT_LienTuc_LopHoc(itemInfo.MaLop);
                ProTask.Value++;
            }
        }

        private void CreateLopHoc()
        {
            Li_MaLopHoc = new Dictionary<int, string>();
            LOP_HOC_COLL itemColl = LOP_HOC_COLL.GetLOP_HOC_COLL();
            ProTask.Maximum = itemColl.Count + 2;
            ProTask.Value = 0;
            string temp;
            foreach (LOP_HOC_INFO itemInfo in itemColl)
            {
                try
                {
                    if (ProTask.Value == 38)
                        temp = "";
                    DT_LienTuc_LopHoc newItem = DT_LienTuc_LopHoc.NewDT_LienTuc_LopHoc();
                    newItem.TenLop = itemInfo.TEN_LOP;
                    newItem.DoiTuong = itemInfo.DOI_TUONG;
                    try
                    {
                        newItem.IdCanBoPhuTrach = Li_CanBo[Convert.ToInt32(itemInfo.CBO_PTRACH_ID)];
                    }
                    catch
                    {
                        newItem.IdCanBoPhuTrach = 15;
                    }
                    try
                    {
                        newItem.IdKhungLopHoc = Li_DMLopHoc[Convert.ToInt32(itemInfo.DM_LOPHOC_ID)];
                    }
                    catch
                    {

                    }
                   // newItem.IdCanBoPhoiHop = Li_CanBo[Convert.ToInt32(itemInfo.CB_PHOP_ID)];
                    //newItem.MaLop = itemInfo.MA_LOP;
                    newItem.MaLop = ProTask.Value.ToString();
                    
                    newItem.NgayBatDau = ProcessDate(itemInfo.NGAY_BDAU);
                    temp = ProcessDate(itemInfo.NGAY_KTHUC);
                    if (string.IsNullOrEmpty(temp))
                        newItem.NgayKetThuc = newItem.NgayBatDau;
                    else
                        newItem.NgayKetThuc = temp;
                    //if (Convert.ToInt32(itemInfo.NAM) < 2014)
                    //{
                        newItem.MaLop = itemInfo.MA_LOP;
                   // }
                    newItem.IdNguonKinhPhi = itemInfo.DM_NGUONKINHPHI_ID;
                    newItem.TongSoTiet = ProcessStringToInt(itemInfo.TGIAN_DTAO);
                    newItem.HocPhi = itemInfo.HOC_PHI.ToString();
                    try
                    {
                        newItem.ApplyEdit();
                        newItem.Save();
                        Li_MaLopHoc.Add(itemInfo.LOP_HOC_ID, newItem.MaLop);
                    }
                    catch
                    {
                    }
                    ProTask.Value++;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ProTask.Value.ToString() +"     "+ex.ToString());
                }
            }
            //itemColl = LOP_HOC_COLL.GetLOP_HOC_COLL();
            radGridView1.DataSource = LOP_HOC_COLL.GetLOP_HOC_COLL();
            ProTask.Value++;
            radGridView2.DataSource = DT_LienTuc_LopHoc_Coll.GetDT_LienTuc_LopHoc_Coll();
            ProTask.Value++;

        }

        #endregion

        #region Hoc Vien

        private void DeleteHocVien()
        {
            DT_LienTuc_HocVien_Coll list = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(new NETLINK.LIB.BusinessFunction(NETLINK.LIB.BusinessFunctionMode.GetAllData));
            ProTask.Maximum = list.Count;
            ProTask.Value = 0;
            foreach (DT_LienTuc_HocVien_Info itemInfo in list)
            {
                DT_LienTuc_HocVien.DeleteDT_LienTuc_HocVien(itemInfo.Id);
                ProTask.Value++;
            }
        }

        private void CreateHocVien()
        {
            HOC_VIEN_TT_COLL oldI = HOC_VIEN_TT_COLL.GetHOC_VIEN_TT_COLL();
            ProTask.Maximum = oldI.Count;
            ProTask.Value = 0;
            int CMTCount = 0;
            DateTime tempDate;
            foreach (HOC_VIEN_TT_INFO itemInfo in oldI)
            {
                DT_LienTuc_HocVien nItem = DT_LienTuc_HocVien.NewDT_LienTuc_HocVien();
                nItem.HoTen = itemInfo.TEN_HOCVIEN;
                nItem.NamTotNghiep = itemInfo.NAM_TN;
                nItem.NgaySinh = itemInfo.NGAY_SINH.ToString();
                if (itemInfo.HINH_THUC.ToLower().Trim() == "k")
                {
                    nItem.HinhThucHoc = "Kèm cặp";
                    if (itemInfo.NGAY_BDAU != null && DateTime.TryParse(itemInfo.NGAY_BDAU.ToString(), out tempDate) && GlobalCommon.CheckDate(tempDate))
                        nItem.NgayBatDau = itemInfo.NGAY_BDAU.ToString();
                    if (itemInfo.NGAY_KTHUC != null && DateTime.TryParse(itemInfo.NGAY_KTHUC.ToString(), out tempDate) && GlobalCommon.CheckDate(tempDate))
                        nItem.NgayKetThuc = itemInfo.NGAY_KTHUC.ToString();
                }
                else
                    nItem.HinhThucHoc = "Theo Lớp";
                if (itemInfo.GIOI_TINH.ToLower().Trim() == "m")
                    nItem.GioiTinh = "Nam";
                else
                    nItem.GioiTinh = "Nữ";
                nItem.NgayDangKi = itemInfo.CREATE_DATE.ToString();
                nItem.LastEdited_Date = Convert.ToDateTime(itemInfo.CREATE_DATE);
                nItem.DiDong = itemInfo.DIEN_THOAI_DD;
                nItem.SoBang = itemInfo.SO_BANG_TN;
                nItem.MaHocVien = itemInfo.MA_HOC_VIEN;
                nItem.TruongTotNghiep = itemInfo.TenTruongTotNghiep;
                if (string.IsNullOrEmpty(itemInfo.MA_HOC_VIEN))
                {
                    nItem.TrangThai = DT_Common_value.TT_HocVien_ChuaHoc;
                }
                else
                {
                    nItem.TrangThai = DT_Common_value.TT_HocVien_ChuaCapChungChi;
                }
                nItem.IdNguoiQuanLy = Li_User[itemInfo.USER_CREATE];
                nItem.LastEdited_User = nItem.IdNguoiQuanLy;
                nItem.IdBoPhan = Li_PhongQuanLy[Convert.ToInt32(nItem.IdNguoiQuanLy)];
                //try
                //{
                //    nItem.IdChuyenNganhDangKi = Li_ChuyenKhoa[Convert.ToInt32(itemInfo.CK_DK_ID)];
                //}
                //catch
                //{
                //}
                try
                {
                    nItem.IdTinhThanh = Li_ThanhPho[itemInfo.MA_TPHO];
                }
                catch
                {
                }
                string[] HTSplit = itemInfo.TEN_HOCVIEN.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                if (HTSplit.Length > 0)
                {
                    nItem.Backup03 = HTSplit[HTSplit.Length - 1];
                }
                
                try
                {
                    nItem.IdTrinhDo = Li_TrinhDo[itemInfo.MA_TRINHDO];
                }
                catch
                {
                }
                if (!string.IsNullOrEmpty(itemInfo.SO_CMT))
                    nItem.SoCMT = itemInfo.SO_CMT;
                else
                {
                    nItem.SoCMT = string.Format("686868{0}", CMTCount.ToString());
                    CMTCount++;
                }
                if (itemInfo.HINH_THUC.ToLower().Trim() != "k")
                {
                    try
                    {
                        nItem.MaLopHoc = Li_MaLopHoc[Convert.ToInt32(itemInfo.LOP_DK_ID)];
                        DT_LienTuc_LopHoc xxx = DT_LienTuc_LopHoc.GetDT_LienTuc_LopHoc(nItem.MaLopHoc);
                        if (xxx != null)
                        {
                            nItem.IdKhungLopHoc = xxx.IdKhungLopHoc;
                            nItem.NgayBatDau = xxx.NgayBatDau;
                            nItem.NgayKetThuc = xxx.NgayKetThuc;
                            nItem.TongHocPhi = xxx.HocPhi;
                            nItem.NoiDungDaoTao = xxx.TenLop;
                            DT_LienTuc_KhungLopHoc yyy = DT_LienTuc_KhungLopHoc.GetDT_LienTuc_KhungLopHoc(Convert.ToInt32(xxx.IdKhungLopHoc));
                            if (yyy != null)
                                nItem.IdChuyenNganhDangKi = Convert.ToInt32(yyy.IdChuyenKhoa);
                        }
                    }
                    catch
                    {
                    }
                }
                else
                {
                    try
                    {
                        nItem.IdKhungLopHoc = Li_KhungLopHoc[itemInfo.NOI_DUNG_DT];
                        DT_LienTuc_KhungLopHoc uu = DT_LienTuc_KhungLopHoc.GetDT_LienTuc_KhungLopHoc(Convert.ToInt32(nItem.IdKhungLopHoc));
                        nItem.NoiDungDaoTao = uu.TenLop;
                        nItem.IdChuyenNganhDangKi = Convert.ToInt32(uu.IdChuyenKhoa);
                    }
                    catch
                    {
                    }
                }
                if (!string.IsNullOrEmpty(nItem.NgayBatDau))
                {
                    nItem.NgayDangKi = nItem.NgayBatDau;
                }
                try
                {
                    nItem.ApplyEdit();
                    nItem.Save();
                }
                catch
                {
                }
                ProTask.Value++;
            }
        }

        private void MigHocVien()
        {
            try
            {
                ProFull.Maximum = 6;

                ProFull.Value = 0;
                MappingUser();
                ProFull.Value = 1;
                MappingTrinhDo();
                ProFull.Value = 2;
                DeleteHocVien();
                ProFull.Value = 3;
                MappingThanhPho();
                ProFull.Value = 4;
                MappingChuyenNganh();
                ProFull.Value = 5;
                CreateHocVien();
                ProFull.Value = 6;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion

        #region Can Bo Di Tuyen

        private void DeleteCanBoDiTuyen()
        {
            CDT_CanBoDiTinh_Coll list = CDT_CanBoDiTinh_Coll.GetCDT_CanBoDiTinh_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
            foreach (CDT_CanBoDiTinh_Info i in list)
            {
                CDT_CanBoDiTinh.DeleteCDT_CanBoDiTinh(i.ID);
            }
        }

        private void CreateCanBoDiTuyen()
        {
            CTAC_TUYEN_CTIET_COLL ol = CTAC_TUYEN_CTIET_COLL.GetCTAC_TUYEN_CTIET_COLL();
            ProTask.Maximum = ol.Count;
            ProTask.Value = 0;
            foreach (CTAC_TUYEN_CTIET_INFO i in ol)
            {
                CDT_CanBoDiTinh ni = CDT_CanBoDiTinh.NewCDT_CanBoDiTinh();
                ni.HoTen = i.TEN_CB;
                ni.NgayBatDau = Convert.ToDateTime(i.NGAY_BDAU).ToShortDateString();
                ni.NgayKetThuc = Convert.ToDateTime(i.NGAY_KTHUC).ToShortDateString();
                ni.NoiDungHoatDong = i.NOI_DUNG;
                if (i.MA_BVIEN_ID>0)
                    ni.IdBenhVienNoiDen = Li_DMBenhVien[i.MA_BVIEN_ID];
                try
                {
                    ni.IdChuyenNganh = Li_TrinhDo[i.TRINH_DO];
                }
                catch
                {
                }
                ni.ApplyEdit();
                ni.Save();
                ProTask.Value++;
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MigLopHoc();
                radGridView1.DataSource = DT_LienTuc_LopHoc_Coll.GetDT_LienTuc_LopHoc_Coll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            MappingChuyenNganh();
            MappingKhungLopHoc();
              }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
            MappingChuyenNganh();
  }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }





        #region ProcessLT

        private List<DT_LienTuc_KhungLopHoc> listKhung;

        private int FindingTenKhungLopHoc(string TenKhung, long idChuyenKhoa)
        {
            if (listKhung == null)
            {
                listKhung = new List<DT_LienTuc_KhungLopHoc>();
                DT_LienTuc_KhungLopHoc_Coll listI = DT_LienTuc_KhungLopHoc_Coll.GetDT_LienTuc_KhungLopHoc_Coll();
                foreach (DT_LienTuc_KhungLopHoc_Info itemInfo in listI)
                {

                    if (ProcessTenKhungLopHoc(itemInfo.TenLop) == ProcessTenKhungLopHoc(TenKhung))
                    {
                        listKhung = null;
                        return itemInfo.Id;
                    }
                    else
                    {
                        DT_LienTuc_KhungLopHoc itemxx = DT_LienTuc_KhungLopHoc.NewDT_LienTuc_KhungLopHoc();
                        itemxx.TenLop = itemInfo.TenLop;
                        itemxx.IdChuyenKhoa = itemxx.IdChuyenKhoa;
                        listKhung.Add(itemxx);
                    }
                }

            }
            else
            {
                foreach (DT_LienTuc_KhungLopHoc itemInfo in listKhung)
                {

                    if (ProcessTenKhungLopHoc(itemInfo.TenLop) == ProcessTenKhungLopHoc(TenKhung))
                    {
                        return itemInfo.Id;
                    }
                }

            }
            DT_LienTuc_KhungLopHoc itemx = DT_LienTuc_KhungLopHoc.NewDT_LienTuc_KhungLopHoc();
            itemx.TenLop = TenKhung;
            itemx.IdChuyenKhoa = idChuyenKhoa;
            itemx.ApplyEdit();
            itemx = itemx.Save();
            listKhung.Add(itemx);
            return itemx.Id;

        }

        private string ProcessTenKhungLopHoc(string old)
        {
            string[] RlistFrom = new string[] {"cơ bản","rhm" };
            string[] RlistTo = new string[] { "","răng hàm mặt" };
            old = old.ToLower().Trim();
            old = ProcessReplaceStr(old, RlistFrom,RlistTo);
            old = ProcessKhoaKhungLopHoc(old);


            return old;
        }

        private int ProcessStringToInt(object item)
        {
            int x;
            if (item != null && !string.IsNullOrEmpty(item.ToString()))
            {
                if (int.TryParse(item.ToString(), out x))
                    return x;
            }
            return 0;
        }

        private string ProcessDate(object oldItem)
        {
            DateTime newItem;
            if (oldItem != null)
            {
                if (DateTime.TryParse(oldItem.ToString(), out newItem))
                {
                    if (newItem.Year < 1500)
                        newItem = newItem.AddYears(1000);
                    return newItem.ToShortDateString();
                }
            }
            return string.Empty;
        }

        private string ProcessReplaceStr(string str, string[] RList)
        {
            str = str.ToLower();
            foreach (string str2 in RList)
            {
                str = str.Replace(str2.ToLower(), string.Empty);
            }
            return str.Trim();
        }
        private string ProcessReplaceStr(string str, string[] RListFrom,string[] RListTo)
        {
            if (RListFrom.Length != RListTo.Length)
                return string.Empty;
            str = str.ToLower();
            for(int i=0;i<RListFrom.Length;i++)
            {
                str = str.Replace(RListFrom[i].ToLower(), RListTo[i].ToLower());
            }
         
            return str.Trim();
        }

        private string ProcessKhoaKhungLopHoc(string dauvao)
        {

            dauvao += " ";
            for (int i = 0; i < 101; i++)
            {
                if (dauvao == "siêu âm tổng quát k43" && i==43)
                    i = i;
                dauvao = dauvao.ToLower().Replace(string.Format(" k{0} ",i.ToString()), string.Empty);
            }

    

            return dauvao.Trim();
        }

        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            MigHocVien();
          //  Thread x = new Thread(new ThreadStart(MigHocVien));
          //  x.Start();
          //  x.Join();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
            MappingTrinhDo();
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MappingThanhPho();
        }

        private void radGridView2_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                DM_LOPHOC_INFO item = (DM_LOPHOC_INFO)radGridView2.CurrentRow.DataBoundItem;
                string x = ProcessTenKhungLopHoc(item.TEN_LH);
                string[] Arr = x.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                DT_LienTuc_KhungLopHoc_Coll listK = DT_LienTuc_KhungLopHoc_Coll.NewDT_LienTuc_KhungLopHoc_Coll();

                for (int i = 0; i < Arr.Length - 1; i++)
                {
                    foreach (DT_LienTuc_KhungLopHoc_Info itemInfo in test)
                    {
                        if (itemInfo.TenLop.IndexOf(Arr[i] + " " + Arr[i + 1]) >= 0)
                        {
                            listK.Add(itemInfo);
                        }
                    }
                }


                radGridView1.DataSource = listK;
            }
            catch
            {
            }
        }

        string a1 = string.Empty;
        string a2 = string.Empty;
        private void radGridView1_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                DM_LOPHOC_INFO item = (DM_LOPHOC_INFO)radGridView2.CurrentRow.DataBoundItem;
                if (GlobalCommon.AcceptUpdate())
                {
                    DT_LienTuc_KhungLopHoc_Info itemInfo = (DT_LienTuc_KhungLopHoc_Info)radGridView1.CurrentRow.DataBoundItem;
                    a1 += ","+item.DM_LOPHOC_ID.ToString();
                    a2 += "," + itemInfo.Id.ToString();
                }
            }
            catch
            {
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = a1 + "%" + a2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                ProFull.Maximum = 17;
                ProFull.Value = 0;
                MappingChuyenNganh();
                ProFull.Value = 1;
                MappingChuyenNganh();
                ProFull.Value = 2;
                MappingKhungLopHoc();
                ProFull.Value = 3;
                MappingKhungLopHoc();
                ProFull.Value = 4;
                MappingCanBo();
                ProFull.Value = 5;
                MappingCanBo();
                ProFull.Value = 6;
                MappingUser();
                ProFull.Value = 7;
                MappingUser();
                ProFull.Value = 8;
                MappingTrinhDo();
                ProFull.Value = 9;
                MappingTrinhDo();
                ProFull.Value = 10;
                MappingThanhPho();
                ProFull.Value = 11;
                MappingThanhPho();
                ProFull.Value = 12;
                DeleteLopHoc();
                ProFull.Value = 13;
                DeleteHocVien();
                ProFull.Value = 14;
                CreateLopHoc();
                ProFull.Value = 15;
                MappingKhungLopHoc_ForKemCap();
                ProFull.Value = 16;
                CreateHocVien();
                ProFull.Value = 17;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                MappingChuyenNganh();
                MappingKhungLopHoc_ForKemCap();
                MappingKhungLopHoc_ForKemCap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                MappingTrinhDo();
               // MappingChucVu();
                MappingThanhPho();
                MappingBenhVien();
                DeleteCanBoDiTuyen();
                CreateCanBoDiTuyen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
