﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for QuyetDinhLuongController
/// </summary>
public class HoSoLuongController : LinqProvider
{
    public HoSoLuongController()
    {
    }

    /// <summary>
    /// Get history of employee 's salary
    /// </summary>
    /// <param name="prKeyHoSo"></param>
    /// <param name="start"></param>
    /// <param name="limit"></param>
    /// <param name="searchKey"></param>
    /// <param name="count"></param>
    /// <returns></returns>
    public IEnumerable<HosoLuongInfo> GetAll(decimal prKeyHoSo, int start, int limit, string searchKey, out int count)
    {
        var rs = from t in dataContext.HOSO_LUONGs
                 where t.PrKeyHoSo == prKeyHoSo
                 select new HosoLuongInfo
                 {
                     BacLuong = t.BacLuong,
                     BacLuongNB = t.BacLuongNB,
                     GhiChu = t.GhiChu,
                     GioiTinh = t.HOSO.MA_GIOITINH,
                     HeSoLuong = t.HeSoLuong,
                     HoTen = t.HOSO.HO_TEN,
                     ID = t.ID,
                     LoaiLuong = t.DM_LOAI_LUONG.TEN_LOAI_LUONG,
                     LuongCung = t.LuongCung,
                     LuongDongBHXH = t.LuongDongBHXH,
                     MaCB = t.HOSO.MA_CB,
                     NgayHieuLuc = t.NgayHieuLuc,
                     NgayHuongLuong = t.NgayHuongLuong,
                     NgayHuongLuongNB = t.NgayHuongLuongNB,
                     NgayKetThucHieuLuc = t.NgayKetThucHieuLuc,
                     NgayQuyetDinh = t.NgayQuyetDinh,
                     NgaySinh = t.HOSO.NGAY_SINH,
                     NguoiQuyetDinh = t.HOSO1.HO_TEN,
                     PhanTramHuongLuong = t.PhanTramHuongLuong,
                     SoQuyetDinh = t.SoQuyetDinh,
                     TrangThai = t.TrangThai,
                     LuongTrachNhiem = t.LuongTrachNhiem,
                     CreatedDate = t.CreatedDate
                 };
        count = rs.Count();
        return rs.Skip(start).Take(limit);
    }

    /// <summary>
    /// Get data for filling to the grid
    /// </summary>
    /// <param name="maPhong"></param>
    /// <param name="maTo"></param>
    /// <param name="maDonVi"></param>
    /// <param name="start"></param>
    /// <param name="limit"></param>
    /// <param name="searchKey"></param>
    /// <param name="count"></param>
    /// <returns></returns>
    public IEnumerable<HosoLuongInfo> GetAll(string maDonVi, int start,
                                            int limit, string searchKey, out int count, string trangThai, int userID, int menuID)
    {
        string dsDonVi = new DepartmentRoleController().GetMaBoPhanByRole(userID, menuID);
        string[] dvList = new DM_DONVIController().GetAllMaDonVi(maDonVi).Split(',');
        string[] ds = dsDonVi.Split(',');

        var rs = from t in dataContext.HOSO_LUONGs
                 join hs in dataContext.HOSOs on t.PrKeyHoSo equals hs.PR_KEY
                 where ds.Contains(hs.MA_DONVI) && //System.Data.Linq.SqlClient.SqlMethods.Like("%" + str + "%", "%," + t.HOSO1.MA_DONVI + ",%") &&
                 (string.IsNullOrEmpty(maDonVi) || dvList.Contains(hs.MA_DONVI)) &&
                 (string.IsNullOrEmpty(trangThai) || System.Data.Linq.SqlClient.SqlMethods.Like(t.TrangThai, "%" + trangThai + "%")) &&
                 (string.IsNullOrEmpty(searchKey) || System.Data.Linq.SqlClient.SqlMethods.Like(hs.HO_TEN, "%" + searchKey + "%") || System.Data.Linq.SqlClient.SqlMethods.Like(hs.MA_CB, "%" + searchKey + "%"))
                 select new HosoLuongInfo
                 {
                     BacLuong = t.BacLuong,
                     BacLuongNB = t.BacLuongNB,
                     GhiChu = t.GhiChu,
                     GioiTinh = hs.MA_GIOITINH,
                     HeSoLuong = t.HeSoLuong,
                     HoTen = hs.HO_TEN,
                     TenBoPhan = (from p in dataContext.DM_DONVIs where p.MA_DONVI == hs.MA_DONVI select p).FirstOrDefault().TEN_DONVI,
                     ID = t.ID,
                     LoaiLuong = t.DM_LOAI_LUONG.TEN_LOAI_LUONG,
                     LuongCung = t.LuongCung,
                     LuongDongBHXH = t.LuongDongBHXH,
                     LuongTrachNhiem = t.LuongTrachNhiem,
                     MaCB = hs.MA_CB,
                     NgayHieuLuc = t.NgayHieuLuc,
                     NgayHuongLuong = t.NgayHuongLuong,
                     NgayHuongLuongNB = t.NgayHuongLuongNB,
                     NgayKetThucHieuLuc = t.NgayKetThucHieuLuc,
                     NgayQuyetDinh = t.NgayQuyetDinh,
                     NgaySinh = hs.NGAY_SINH,
                     NguoiQuyetDinh = t.HOSO.HO_TEN,
                     IdNguoiQuyetDinhPhuCap = t.HOSO.PR_KEY,
                     PhanTramHuongLuong = t.PhanTramHuongLuong,
                     SoQuyetDinh = t.SoQuyetDinh,
                     TrangThai = t.TrangThai,
                     TepTinDinhKem = t.TepTinDinhKem,                     
                     HasPhuCap = t.HOSO_PHUCAPs.Count() > 0
                 };
        count = rs.Count();
        return rs.OrderByDescending(p => p.NgayHieuLuc).Skip(start).Take(limit);
    }

    public DAL.HOSO_LUONG GetByID(int id)
    {
        return dataContext.HOSO_LUONGs.Where(t => t.ID == id).FirstOrDefault();
    }

    public List<HosoLuongInfo> GetByPrkeyHoSo(decimal prkeyHoSo)
    {
        var rs = from t in dataContext.HOSO_LUONGs
                 where t.PrKeyHoSo == prkeyHoSo
                 select new HosoLuongInfo()
                 {
                     BacLuong = t.BacLuong,
                     BacLuongNB = t.BacLuongNB,
                     GhiChu = t.GhiChu,
                     GioiTinh = t.HOSO1.MA_GIOITINH,
                     HeSoLuong = t.HeSoLuong,
                     HoTen = t.HOSO1.HO_TEN,
                     ID = t.ID,
                     LoaiLuong = t.DM_LOAI_LUONG.TEN_LOAI_LUONG,
                     LuongCung = t.LuongCung,
                     LuongDongBHXH = t.LuongDongBHXH,
                     LuongTrachNhiem = t.LuongTrachNhiem,
                     MaCB = t.HOSO1.MA_CB,
                     NgayHieuLuc = t.NgayHieuLuc,
                     NgayHuongLuong = t.NgayHuongLuong,
                     NgayHuongLuongNB = t.NgayHuongLuongNB,
                     NgayKetThucHieuLuc = t.NgayKetThucHieuLuc,
                     NgayQuyetDinh = t.NgayQuyetDinh,
                     NgaySinh = t.HOSO1.NGAY_SINH,
                     NguoiQuyetDinh = t.HOSO.HO_TEN,
                     IdNguoiQuyetDinhPhuCap = t.HOSO.PR_KEY,
                     PhanTramHuongLuong = t.PhanTramHuongLuong,
                     SoQuyetDinh = t.SoQuyetDinh,
                     TrangThai = t.TrangThai,
                     TepTinDinhKem = t.TepTinDinhKem,
                     HasPhuCap = t.HOSO_PHUCAPs.Count() > 0
                 };
        return rs.ToList();
    }

    public void Delete(int id)
    {
        var tmp = GetByID(id);
        if (tmp != null)
        { 
            dataContext.HOSO_LUONGs.DeleteOnSubmit(tmp);
            Save();
            var hoso = new HoSoController().GetByPrKey(tmp.PrKeyHoSo);
            new HoSoLuongController().UpDateLuongTheoQuyetDinhLuong(hoso.MA_CB); 
        }
    }

    public void Add(DAL.HOSO_LUONG salarayDecison)
    { 
        dataContext.HOSO_LUONGs.InsertOnSubmit(salarayDecison);
        Save();
        var hoso = new HoSoController().GetByPrKey(salarayDecison.PrKeyHoSo);
        new HoSoLuongController().UpDateLuongTheoQuyetDinhLuong(hoso.MA_CB); 
    }

    public void Update(DAL.HOSO_LUONG salarayDecison)
    {
        DAL.HOSO_LUONG tmp = GetByID(salarayDecison.ID);
        tmp.BacLuong = salarayDecison.BacLuong;
        tmp.BacLuongNB = salarayDecison.BacLuongNB;
        tmp.GhiChu = salarayDecison.GhiChu;
        tmp.HeSoLuong = salarayDecison.HeSoLuong;
        tmp.LuongCung = salarayDecison.LuongCung;
        tmp.LuongDongBHXH = salarayDecison.LuongDongBHXH;
        tmp.MaLoaiLuong = salarayDecison.MaLoaiLuong;
        tmp.NgayHieuLuc = salarayDecison.NgayHieuLuc;
        tmp.NgayHuongLuong = salarayDecison.NgayHuongLuong;
        tmp.NgayHuongLuongNB = salarayDecison.NgayHuongLuongNB;
        tmp.NgayKetThucHieuLuc = salarayDecison.NgayKetThucHieuLuc;
        tmp.NgayQuyetDinh = salarayDecison.NgayQuyetDinh;
        tmp.PhanTramHuongLuong = salarayDecison.PhanTramHuongLuong;
        tmp.LuongTrachNhiem = salarayDecison.LuongTrachNhiem;
        tmp.PrKeyHoSo = salarayDecison.PrKeyHoSo;
        tmp.prKeyHoSoNguoiQuyetDinh = salarayDecison.prKeyHoSoNguoiQuyetDinh;
        tmp.SoQuyetDinh = salarayDecison.SoQuyetDinh;
        tmp.TenQuyetDinh = salarayDecison.TenQuyetDinh;
        tmp.MaNgach = salarayDecison.MaNgach;
        tmp.TepTinDinhKem = salarayDecison.TepTinDinhKem;
        tmp.TrangThai = salarayDecison.TrangThai;
        tmp.PrKeyHoSoHopDong = salarayDecison.PrKeyHoSoHopDong;
        Save();
        var hoso = new HoSoController().GetByPrKey(salarayDecison.PrKeyHoSo);
        new HoSoLuongController().UpDateLuongTheoQuyetDinhLuong(hoso.MA_CB); 
    }

    public DAL.HOSO_LUONG GetNewestSalaryDevelopment(decimal prkey, int currID)
    {
        var rs = (from t in dataContext.HOSO_LUONGs
                 where t.PrKeyHoSo == prkey && (currID == -1 || currID != t.ID)
                 select t).OrderByDescending(p => p.NgayHieuLuc);
        return rs.FirstOrDefault();
    }
    /// <summary>
    /// Đức anh viết để sau khi cập nhật lương sẽ cập nhật trên bảng lương luôn
    /// </summary>
    /// <param name="macb"></param>
    public void UpDateLuongTheoQuyetDinhLuong(string macb)
    {
        List<int> danhsachidbangluong = new BangThanhToanTienLuongController().LayTop10IDBangLuongGanNhat();
        foreach(var item in danhsachidbangluong)
        {
            DataController.DataHandler.GetInstance().ExecuteScalar("TienLuong_UpdateThongTinLuong1NhanVien", "@idBangLuong", "@MaNhanVien", item, macb);
            //new BangThanhToanTienLuongController().XuLiCongThuc(item, "", macb);
        } 
    }
}