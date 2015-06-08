using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// daibx   21/08/2013
/// Summary description for DanhSachBangPhanCaController
/// </summary>
public class DanhSachBangPhanCaController : LinqProvider
{
    public DanhSachBangPhanCaController()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    /// <summary>
    /// lay du lieu cho combobox theo năm và mã đơn vị
    /// </summary>
    /// <returns></returns>
    //public List<DanhSachBangPhanCaInfo> GetDanhSachBangPhanCaByMaDVAndYear( string MaDV, int Nam)
    //{
    //    var rs = (from t in dataContext.DanhSachBangPhanCas                
    //              where t.MaDonVi == MaDV && t.Nam==Nam
    //              select new DanhSachBangPhanCaInfo
    //              {
    //                  ID = t.ID
    //                  TenBangPhanCa = t.TenBangPhanCa,
    //              }).ToList();

    //    return rs.OrderByDescending(t => t.th).Skip(start).Take(limit).ToList();
    //}

    public DAL.DanhSachBangPhanCa GetByMonthAndYear(int month, int year, string maDonVi)
    {
        return dataContext.DanhSachBangPhanCas.FirstOrDefault(t => t.Thang == month && t.Nam == year && t.MaDonVi == maDonVi);
    }
    /// <summary>
    /// Thêm mới một bảng phân ca
    /// </summary>
    /// <param name="pc">Thông tin một bảng phân ca</param>
    /// <returns>Mã của bảng phân ca nếu thêm mới thành công, -1 nếu thất bại</returns>
    public int Insert(DAL.DanhSachBangPhanCa pc)
    {
        if (pc != null)
        {
            dataContext.DanhSachBangPhanCas.InsertOnSubmit(pc);
            Save();
            return pc.ID;
        }
        return -1;
    }

    /// <summary>
    /// Lấy danh sách các bảng phân ca dựa vào mã đơn vị
    /// </summary>
    /// <param name="maDonVi"></param>
    /// <param name="month"></param>
    /// <param name="year">-1 nếu lấy tất cả các năm</param>
    /// <returns></returns>
    public List<DanhSachBangPhanCaInfo> GetByMaDonVi(string maDonVi, int month, int year, int start, int limit, out int count, string thanghaynam)
    {
        var rs = (from t in dataContext.DanhSachBangPhanCas
                  join q in dataContext.BangPhanCaNams on t.ID equals q.IdDanhSachBangPhanCa
                  into tq
                  from apleftjoin in tq.DefaultIfEmpty()
                  where t.MaDonVi == maDonVi &&
                  (thanghaynam == "Nam" ? (t.Thang == -1) : (t.Thang != -1))
                  group apleftjoin by new { t.ID, t.TenBangPhanCa, t.Nam, t.MaDonVi } into g
                  select new DanhSachBangPhanCaInfo
                  {
                      ID = g.Key.ID,
                      TenBangPhanCa = g.Key.TenBangPhanCa,
                      Nam = g.Key.Nam,
                      MaDonVi = g.Key.MaDonVi,
                      SoNguoi = g.Count(t => t.MaCB != null)
                  }).ToList();
        count = rs.Count();
        return rs.OrderByDescending(t => t.Nam).Skip(start).Take(limit).ToList();
    }
    public DAL.DanhSachBangPhanCa GetByID(int id)
    {
        return dataContext.DanhSachBangPhanCas.Where(t => t.ID == id).FirstOrDefault();
    }

    public void Delete(int p)
    {
        DAL.DanhSachBangPhanCa tmp = GetByID(p);
        if (tmp != null)
        {
            dataContext.DanhSachBangPhanCas.DeleteOnSubmit(tmp);
            Save();
        }
    }
}