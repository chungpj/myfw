//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            this.PhieuYeuCauAPs = new HashSet<PhieuYeuCauAP>();
            this.CtDeNghis = new HashSet<CtDeNghi>();
            this.CtDuKiens = new HashSet<CtDuKien>();
            this.CtTiepNhans = new HashSet<CtTiepNhan>();
            this.CtYeuCaus = new HashSet<CtYeuCau>();
            this.DmDeNghis = new HashSet<DmDeNghi>();
            this.DmDeNghis1 = new HashSet<DmDeNghi>();
            this.DmTiepNhans = new HashSet<DmTiepNhan>();
            this.DmTiepNhans1 = new HashSet<DmTiepNhan>();
            this.DmTiepNhans2 = new HashSet<DmTiepNhan>();
            this.DotGiaoNops = new HashSet<DotGiaoNop>();
            this.DotTieuHuys = new HashSet<DotTieuHuy>();
            this.HoSoes = new HashSet<HoSo>();
            this.KeHoachGiaoNops = new HashSet<KeHoachGiaoNop>();
            this.NguoiDungs = new HashSet<NguoiDung>();
            this.NhapKhaiThacs = new HashSet<NhapKhaiThac>();
            this.NhapKhaiThacs1 = new HashSet<NhapKhaiThac>();
            this.PhieuYeuCaus = new HashSet<PhieuYeuCau>();
            this.PhieuYeuCaus1 = new HashSet<PhieuYeuCau>();
            this.PhieuYeuCaus2 = new HashSet<PhieuYeuCau>();
            this.TongHopDmDuKiens = new HashSet<TongHopDmDuKien>();
            this.TongHopDmDuKiens1 = new HashSet<TongHopDmDuKien>();
            this.XuatKhaiThacs = new HashSet<XuatKhaiThac>();
            this.XuatKhaiThacs1 = new HashSet<XuatKhaiThac>();
            this.VaiTroes = new HashSet<VaiTro>();
        }
    
        public long Id { get; set; }
        public string Ma { get; set; }
        public string UserName { get; set; }
        public string Ten { get; set; }
        public string MieuTa { get; set; }
        public int TrangThai { get; set; }
        public string ChucDanh { get; set; }
        public Nullable<long> PhongBan_Id { get; set; }
        public string Email { get; set; }
        public Nullable<bool> EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<bool> PhoneNumberConfirmed { get; set; }
        public Nullable<long> Edoc_Id { get; set; }
        public string Edoc_Guid_Id { get; set; }
        public string Guid_Id { get; set; }
        public Nullable<long> CreateBy_Id { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<long> ModifyBy_Id { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public bool Is_Delete { get; set; }
        public bool Active { get; set; }
        public Nullable<bool> Has_Login { get; set; }
        public Nullable<int> AccessFailedCount { get; set; }
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<PhieuYeuCauAP> PhieuYeuCauAPs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<CtDeNghi> CtDeNghis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<CtDuKien> CtDuKiens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<CtTiepNhan> CtTiepNhans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<CtYeuCau> CtYeuCaus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<DmDeNghi> DmDeNghis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<DmDeNghi> DmDeNghis1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<DmTiepNhan> DmTiepNhans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<DmTiepNhan> DmTiepNhans1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<DmTiepNhan> DmTiepNhans2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<DotGiaoNop> DotGiaoNops { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<DotTieuHuy> DotTieuHuys { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<HoSo> HoSoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<KeHoachGiaoNop> KeHoachGiaoNops { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<NguoiDung> NguoiDungs { get; set; }
        public PhongBan PhongBan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<NhapKhaiThac> NhapKhaiThacs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<NhapKhaiThac> NhapKhaiThacs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<PhieuYeuCau> PhieuYeuCaus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<PhieuYeuCau> PhieuYeuCaus1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<PhieuYeuCau> PhieuYeuCaus2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<TongHopDmDuKien> TongHopDmDuKiens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<TongHopDmDuKien> TongHopDmDuKiens1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<XuatKhaiThac> XuatKhaiThacs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<XuatKhaiThac> XuatKhaiThacs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<VaiTro> VaiTroes { get; set; }
    }
}
