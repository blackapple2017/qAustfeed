var CheckSelectedRecord = function (grid, Store) {
    if (hdfRecordID.getValue() == '') {
        alert('Bạn chưa chọn nhân viên nào');
        return false;
    }

    var s = grid.getSelectionModel().getSelections();
    var count = 0;
    for (var i = 0, r; r = s[i]; i++) {
        count++;
    }
    if (count > 1) {
        alert('Bạn chỉ được chọn một nhân viên');
        return false;
    }
    return true;
}
 
var ShowReportAction = function () {
    var type = hdfTypeReport.getValue();
    switch (type) {
        case 'HoSo':
            wdShowReport.setTitle('Báo cáo hồ sơ nhân viên');
            pnReportPanel.remove(0); addHomePage(pnReportPanel, 'Homepage', '../Report/Baocao_Nhansu_Chitiet.aspx?prkey=' + hdfRecordID.getValue(), 'Báo cáo hồ sơ nhân viên');
            break;
        case 'TaiSan':
            wdShowReport.setTitle('Báo cáo tài sản cấp phát cho nhân viên');
            pnReportPanel.remove(0); addHomePage(pnReportPanel, 'Homepage', '../Report/BaoCao_Main.aspx?type=DanhSachTaiSanCapPhatChoNhanVien&prkey=' + hdfRecordID.getValue(), 'Báo cáo tài sản cấp phát cho nhân viên');
            break;
        case 'DanhSachNhanSu':
            wdShowReport.setTitle('Báo cáo danh sách nhân viên');
            pnReportPanel.remove(0); addHomePage(pnReportPanel, 'Homepage', '../Report/BaoCao_Main.aspx?type=DanhSachNhanVien&' + hdfQueryReport.getValue(), 'Báo cáo danh sách nhân viên');
            break;
    }
}
var enterKeyPressHandler = function (f, e) {
    if (e.getKey() == e.ENTER) {
        PagingToolbar1.pageIndex = 0;
        PagingToolbar1.doLoad();
        grp_HoSoNhanSu.getSelectionModel().clearSelections();
        hdfRecordID.setValue('');
        store_HoSoNhanSu.reload();
    }
    if (txtSearch.getValue() != '')
        this.triggers[0].show();
}

var RenderGender = function (value, p, record) {
    var nam = "<span style='color:blue'>Nam</span>";
    var nu = "<span style='color:red'>Nữ</span>";
    if (value == 'M')
        return nam;
    else
        return nu;
}
var enterKeyPressHandler1 = function (f, e) {
    if (e.getKey() == e.ENTER) {
        Ext.net.DirectMethods.SetValueQuery(); 
    }
}

var GetAge = function (birthday) {
    if (birthday == null) return "";
    birthday = birthday.replace(" ", "T");
    var temp = birthday.split("T");
    var date = temp[0].split("-");
    return new Date().getFullYear() * 1 - (date[0] * 1);
}

var getSelectedIndexRow = function () {
    var record = grp_HoSoNhanSu.getSelectionModel().getSelected();
    var index = grp_HoSoNhanSu.store.indexOf(record);
    if (index == -1)
        return 0;
    return index;
}

addUpdatedRecord = function (ma_cb, ho_ten, ten_gioitinh, ngay_sinh, ten_bophan, ten_chucvu, ten_trinhdo, ten_chuyennganh, ten_ngach, ten_loai_hdong, dia_chi_lh, di_dong, email,
        bi_danh, ngaycap_hochieu, ngay_tuyen_dtien, ngay_tuyen_chinhthuc, ngaycap_cmnd, noi_cap_hc, noi_cap_cmnd, dt_cq, dt_nha) {
    var rowindex = getSelectedIndexRow();
    var prkey = 0;
    //xóa bản ghi cũ
    var s = grp_HoSoNhanSu.getSelectionModel().getSelections();
    for (var i = 0, r; r = s[i]; i++) {
        prkey = r.data.PR_KEY;
        store_HoSoNhanSu.remove(r);
        store_HoSoNhanSu.commitChanges();
    }
    //Thêm bản ghi đã update
    grp_HoSoNhanSu.insertRecord(rowindex, {
        PR_KEY: prkey,
        MA_CB: ma_cb,
        HO_TEN: ho_ten,
        MA_GIOITINH: ten_gioitinh,
        NGAY_SINH: ngay_sinh,
        TEN_BOPHAN: ten_bophan,
        TEN_CHUCVU: ten_chucvu,
        TEN_TRINHDO: ten_trinhdo,
        TEN_CHUYENNGANH: ten_chuyennganh,
        TEN_NGACH: ten_ngach,
        TEN_LOAI_HDONG: ten_loai_hdong,
        DIA_CHI_LH: dia_chi_lh,
        DI_DONG: di_dong,
        EMAIL: email,
        TUOI: 25,
        BI_DANH: bi_danh,
        NGAYCAP_HOCHIEU: ngaycap_hochieu,
        NGAY_TUYEN_DTIEN: ngay_tuyen_dtien,
        NGAY_TUYEN_CHINHTHUC: ngay_tuyen_chinhthuc,
        NGAYCAP_CMND: ngaycap_cmnd,
        TEN_NOICAP_HOCHIEU: noi_cap_hc,
        TEN_NOICAP_CMND: noi_cap_cmnd,
        DT_NHA: dt_nha,
        DT_CQUAN: dt_cq
    });
    grp_HoSoNhanSu.getView().refresh();
    grp_HoSoNhanSu.getSelectionModel().selectRow(rowindex);
    store_HoSoNhanSu.commitChanges();
}

var addRecord = function (ma_cb, ho_ten, ten_gioitinh, ngay_sinh, ten_bophan, ten_chucvu, ten_trinhdo, ten_chuyennganh, ten_ngach, ten_loai_hdong, dia_chi_lh, di_dong, email,
        bi_danh, ngaycap_hochieu, ngay_tuyen_dtien, ngay_tuyen_chinhthuc, ngaycap_cmnd, noi_cap_hc, noi_cap_cmnd, dt_cq, dt_nha) {
    var rowindex = getSelectedIndexRow();
    grp_HoSoNhanSu.insertRecord(rowindex, {
        MA_CB: ma_cb,
        HO_TEN: ho_ten,
        MA_GIOITINH: ten_gioitinh,
        NGAY_SINH: ngay_sinh,
        TEN_PHONG: ten_bophan,
        TEN_CHUCVU: ten_chucvu,
        TEN_TRINHDO: ten_trinhdo,
        TEN_CHUYENNGANH: ten_chuyennganh,
        TEN_NGACH: ten_ngach,
        TEN_LOAI_HDONG: ten_loai_hdong,
        DIA_CHI_LH: dia_chi_lh,
        DI_DONG: di_dong,
        EMAIL: email,
        TUOI: 25,
        BI_DANH: bi_danh,
        NGAYCAP_HOCHIEU: ngaycap_hochieu,
        NGAY_TUYEN_DTIEN: ngay_tuyen_dtien,
        NGAY_TUYEN_CHINHTHUC: ngay_tuyen_chinhthuc,
        NGAYCAP_CMND: ngaycap_cmnd,
        TEN_NOICAP_HOCHIEU: noi_cap_hc,
        TEN_NOICAP_CMND: noi_cap_cmnd,
        DT_NHA: dt_nha,
        DT_CQUAN: dt_cq
    });
    grp_HoSoNhanSu.getView().refresh();
    grp_HoSoNhanSu.getSelectionModel().selectRow(rowindex);
    store_HoSoNhanSu.commitChanges();
}

var RemoveItemOnGrid = function (grid, Store) {
    Ext.Msg.confirm('Xác nhận', 'Bạn có chắc chắn muốn xóa không ?', function (btn) {
        if (btn == "yes") {
            Ext.net.DirectMethods.DeleteRecord();
        }
    });
}
var ReloadStoreOfTabIndex = function () {
    //Fill đầy đủ các thông tin chung
    var record = grp_HoSoNhanSu.getSelectionModel().getSelections();
    SouthHoSoNhanSu1_txtMaCB.setValue(record[0].data.MA_CB);
    SouthHoSoNhanSu1_txtFullName.setValue(record[0].data.HO_TEN);
    SouthHoSoNhanSu1_txtNgach.setValue(record[0].data.TEN_NGACH);
    if (checkboxSelection.getSelected().data.PHOTO != null && checkboxSelection.getSelected().data.PHOTO != '') {
        SouthHoSoNhanSu1_hsImage.setImageUrl(checkboxSelection.getSelected().data.PHOTO.replace('~/Modules', '..'));
    }
    else {
        SouthHoSoNhanSu1_hsImage.setImageUrl("../NhanSu/ImageNhanSu/No_person.jpg");
    }

    SouthHoSoNhanSu1_txtMaCB.setValue(checkboxSelection.getSelected().data.MA_CB);
    SouthHoSoNhanSu1_txtFullName.setValue(checkboxSelection.getSelected().data.HO_TEN);
    SouthHoSoNhanSu1_txtBiDanh.setValue(checkboxSelection.getSelected().data.BI_DANH);
    SouthHoSoNhanSu1_txtNgayThuViec.setValue(RenderDate(checkboxSelection.getSelected().data.NGAY_TUYEN_DTIEN, null, null));
    SouthHoSoNhanSu1_txtNgayNhan.setValue(RenderDate(checkboxSelection.getSelected().data.NGAY_TUYEN_CHINHTHUC, null, null));
    SouthHoSoNhanSu1_txtNgach.setValue(checkboxSelection.getSelected().data.TEN_NGACH);

    SouthHoSoNhanSu1_txtSoCMND.setValue(checkboxSelection.getSelected().data.SO_CMND);
    SouthHoSoNhanSu1_txtNgayCapCMND.setValue(RenderDate(checkboxSelection.getSelected().data.NGAYCAP_CMND, null, null));
    SouthHoSoNhanSu1_txtNoiCapCMND.setValue(checkboxSelection.getSelected().data.TEN_NOICAP_CMND);
    SouthHoSoNhanSu1_txtNguoiLienHe.setValue(checkboxSelection.getSelected().data.NguoiLienHe);
    SouthHoSoNhanSu1_txtMoiQuanHe.setValue(checkboxSelection.getSelected().data.QuanHeVoiCanBo);
    SouthHoSoNhanSu1_txtSDTNguoiLienHe.setValue(checkboxSelection.getSelected().data.SDTNguoiLienHe);

    SouthHoSoNhanSu1_txtDTCoQuan.setValue(checkboxSelection.getSelected().data.DT_CQUAN);
    SouthHoSoNhanSu1_txtDTNha.setValue(checkboxSelection.getSelected().data.DT_NHA);
    SouthHoSoNhanSu1_txtSoHoChieu.setValue(checkboxSelection.getSelected().data.SO_HOCHIEU);
    SouthHoSoNhanSu1_txtNgayCapHC.setValue(RenderDate(checkboxSelection.getSelected().data.NGAYCAP_HOCHIEU, null, null));
    SouthHoSoNhanSu1_txtNoiCapHC.setValue(checkboxSelection.getSelected().data.TEN_NOICAP_HOCHIEU);
    SouthHoSoNhanSu1_txtLoaiHD.setValue(checkboxSelection.getSelected().data.TEN_LOAI_HDONG);

    //refresh lại store
    var tabTitle = SouthHoSoNhanSu1_TabPanelBottom.getActiveTab().id;
    switch (tabTitle) {
        case "SouthHoSoNhanSu1_panelHoSoTuyenDung":
            SouthHoSoNhanSu1_StoreHoSoTuyenDung.reload();
            break;
        case "SouthHoSoNhanSu1_panelQuaTrinhDaoTao":
            SouthHoSoNhanSu1_StoreQuaTrinhDaoTao.reload();
            break;
        case "SouthHoSoNhanSu1_panelBaoHiem":
            SouthHoSoNhanSu1_StoreBaoHiem.reload();
            break;
        case "SouthHoSoNhanSu1_panelDaiBieu":
            SouthHoSoNhanSu1_StoreDaiBieu.reload();
            break;
        case "SouthHoSoNhanSu1_panelDanhGia":
            SouthHoSoNhanSu1_StoreDanhGia.reload();
            break;
        case "SouthHoSoNhanSu1_panelDienBienLuong":
            SouthHoSoNhanSu1_StoreDienBienLuong.reload();
            break;
        case "SouthHoSoNhanSu1_panelDeTai":
            SouthHoSoNhanSu1_StoreDetai.reload();
            break;
        case "SouthHoSoNhanSu1_panelHopDong":
            SouthHoSoNhanSu1_StoreHopDong.reload();
            break;
        case "SouthHoSoNhanSu1_panelKhaNang":
            SouthHoSoNhanSu1_StoreKhaNang.reload();
            break;
        case "SouthHoSoNhanSu1_panelKhenThuong":
            SouthHoSoNhanSu1_StoreKhenThuong.reload();
            break;
        case "SouthHoSoNhanSu1_panelKiLuat":
            SouthHoSoNhanSu1_StoreKyLuat.reload();
            break;
        case "SouthHoSoNhanSu1_panelQuanHeGiaDinh":
            SouthHoSoNhanSu1_StoreQHGD.reload();
            break;
        case "SouthHoSoNhanSu1_panelQuaTrinhCongTac":
            SouthHoSoNhanSu1_StoreQuaTrinhCongTac.reload();
            break;
        case "SouthHoSoNhanSu1_panelQuaTrinhDieuChuyen":
            SouthHoSoNhanSu1_StoreQuaTrinhDieuChuyen.reload();
            break;
        case "SouthHoSoNhanSu1_panelTaiSan":
            SouthHoSoNhanSu1_StoreTaiSan.reload();
            break;
        case "SouthHoSoNhanSu1_panelTaiNanLaoDong":
            SouthHoSoNhanSu1_StoreTaiNanLaoDong.reload();
            break;
        case "SouthHoSoNhanSu1_panelTepDinhKem":
            SouthHoSoNhanSu1_grpTepTinDinhKemStore.reload();
            break;
        case "SouthHoSoNhanSu1_panelBangCapChungChi":
            SouthHoSoNhanSu1_Store_BangCapChungChi.reload();
            break;
        case "SouthHoSoNhanSu1_panelKinhNghiemLamViec":
            SouthHoSoNhanSu1_StoreKinhNghiemLamViec.reload();
            break;
        case "SouthHoSoNhanSu1_panelQuaTrinhHocTap":
            SouthHoSoNhanSu1_Store_BangCap.reload();
            break;
        case "SouthHoSoNhanSu1_panelTheNganHang":
            SouthHoSoNhanSu1_hdf_PrKeyHoSo.setValue(SouthHoSoNhanSu1_hdfRecordID.getValue());
            SouthHoSoNhanSu1_StoregrpATM.reload();
            break;
    }
}
var GetMirrorBooleanIcon = function (value, p, record) {
    var sImageCheck = "<img  src='../../Resource/Images/check.png'>"
    var sImageUnCheck = "<img src='../../Resource/Images/uncheck.gif'>"
    if (value == "1") {
        return sImageUnCheck;
    }
    else if (value == "0") {
        return sImageCheck;
    }
    return "";
}
var ResetControl = function () {
    txt_sohieucbccvc.reset(); txt_hoten.reset();
    txt_bidanh.reset(); dfNgaySinh.reset(); cbx_gioitinh.reset(); hdfQuocTich.reset();
    txt_machamcong.reset(); txt_quequan.reset(); txt_noisinh.reset(); cbx_quoctich.reset();
    cbx_tinhthanh.reset(); hdfTinhThanh.reset(); cbx_dantoc.reset(); cbx_tongiao.reset(); cbx_tthonnhan.reset(); hdfHonNhan.reset();
    cbx_tpbanthan.reset(); cbx_tpgiadinh.reset(); txt_didong.reset(); txt_dtcoquan.reset();
    txt_email.reset(); txt_dtnha.reset(); txt_hokhau.reset(); txt_diachilienhe.reset(); hdfChucVu.reset(); hdfXepLoai.reset();
    hdfMaTruongDaoTao.reset(); cbxTruongDaoTao.reset(); hdfMaChuyenNganh.reset(); cbxChuyenNganh.reset(); cbx_xeploai.reset(); tf_namtotnghiep.reset();
    cbx_tinhoc.reset(); hdfTinHoc.reset(); cbx_ngoaingu.reset(); hdfNgoaiNgu.reset(); cbx_trinhdo.reset(); cbx_tdvanhoa.reset(); tdVanHoa.reset();
    cbx_bophan.reset(); hdfBoPhan.reset(); date_tuyendau.reset(); date_tuyendau.setMaxValue(); date_ngaynhanct.reset();
    date_ngaynhanct.setMinValue(); date_ngaynhanct.setMaxValue(); txt_emailkhac.reset(); hdfTrinhDo.reset();
    cbx_chucvu.reset(); cbx_congviec.reset(); txtSoNgayHocViec.reset(); txtThoiGianThuViec.reset();
    txt_sothebhyt.reset(); dfNgayDongBHYT.reset(); hdfHinhThucLamViec.reset();
    cbx_noikcb.reset(); txt_tiledongbh.reset(); txt_sothebhxh.reset(); cbx_noicapbhxh.reset();
    dfNgayCapBHXH.reset(); cbx_huongcs.reset(); hdfDanToc.reset();
    dfNgayHetHanBHYT.reset(); cbxHinhThucLamViec.reset();
    date_ketthucbh.reset(); txt_socmnd.reset(); date_capcmnd.reset(); cbx_noicapcmnd.reset();
    txt_sohochieu.reset(); date_ngaycaphc.reset(); date_ngaycaphc.setMaxValue();
    date_hethanhc.reset(); date_hethanhc.setMinValue(); cbx_noicaphc.reset();
    date_ngayvaodoan.reset(); cbx_chucvudoan.reset(); txt_noiketnapdoan.reset(); date_vaocongdoan.reset();
    txt_chucvucongdoan.reset(); cbx_trinhdochinhtri.reset(); date_thamgiacm.reset();
    chkLaDangVien.reset(); date_vaodang.reset(); date_vaodang.setMaxValue(); date_ngayvaodangct.reset();
    date_ngayvaodangct.setMinValue(); txt_noiketnapdang.reset(); cbx_chuvudang.reset();
    txt_noisinhhoatdang.reset(); chkDaThamGiaQuanDoi.reset(); date_nhapngu.reset(); date_nhapngu.setMaxValue();
    date_xuatngu.reset(); date_xuatngu.setMinValue(); cbx_bacquandoi.reset(); cbx_chucvuquandoi.reset();

    cbx_httuyen.reset(); date_bonhiemcv.reset(); cbx_ngach.reset(); date_bnngach.reset();
    cbx_trinhdoquanly.reset(); cbx_trinhdoquanlykt.reset(); txt_username.reset();
    txt_sotaikhoan.reset(); cbx_nganhang.reset(); txt_masothuecanhan.reset(); chk_danghi.reset();
    date_nghi.reset(); date_nghi.setMinValue(); cbx_lydonghi.reset(); txt_nguoilienhe.reset(); txt_sdtnguoilh.reset();
    txtMoiQH.reset(); txt_emailnguoilh.reset(); txt_diachinguoilienhe.reset(); cbNhommau.reset();
    txt_chieucao.reset(); txt_cannang.reset(); cbx_ttsuckhoe.reset(); txtSOTHICH.reset(); txt_UuDiem.reset();
    txt_NhuocDiem.reset(); chkLaThuongBinh.reset(); txt_HangThuongTat.reset(); txt_SoThuongTat.reset();
    txt_HinhThucThuongTat.reset(); cbx_congtrinh.reset();
    hdfCommandButton.setValue('Insert');
    Ext.net.DirectMethods.ResetWindowTitle();
}
var RenderHightLight = function (value, p, record) {
    if (value == null || value == "") {
        return "";
    }
    var keyword = document.getElementById("txtSearch").value;
    if (keyword == "" || keyword == "Nhập tên hoặc mã cán bộ")
        return value;

    var rs = "<p>" + value + "</p>";
    var keys = keyword.split(" ");
    for (i = 0; i < keys.length; i++) {
        if ($.trim(keys[i]) != "") {
            var o = { words: keys[i] };
            rs = highlight(o, rs);
        }
    }
    return rs;
}
function highlight(options, content) {
    var o = {
        words: '',
        caseSensitive: false,
        wordsOnly: true,
        template: '$1<span class="highlight">$2</span>$3'
    }, pattern;
    $.extend(true, o, options || {});

    if (o.words.length == 0) { return; }
    pattern = new RegExp('(>[^<.]*)(' + o.words + ')([^<.]*)', o.caseSensitive ? "" : "ig");

    return content.replace(pattern, o.template);
}