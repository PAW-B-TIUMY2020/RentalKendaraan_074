using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RentalKendaraan_074.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }
        [DisplayName("ID")]
        public int IdPeminjaman { get; set; }
        public DateTime? TglPeminjaman { get; set; }
        [DisplayName("Kendaraan")]
        public int? IdKendaraan { get; set; }
        [DisplayName("Costumer")]
        public int? IdCostumer { get; set; }
        [DisplayName("Jaminan")]
        public int? IdJaminan { get; set; }
        public int? Biaya { get; set; }

        [DisplayName("Customer")]
        public Customer IdCostumerNavigation { get; set; }
        [DisplayName("Jaminan")]
        public Jaminan IdJaminanNavigation { get; set; }
        [DisplayName("Kendaraan")]
        public Kendaraan IdKendaraanNavigation { get; set; }
        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
