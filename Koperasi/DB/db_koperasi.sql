/*
SQLyog Ultimate v9.01 
MySQL - 5.1.29-rc-community : Database - db_koperasi
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`db_koperasi` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `db_koperasi`;

/*Table structure for table `akunting_akun` */

DROP TABLE IF EXISTS `akunting_akun`;

CREATE TABLE `akunting_akun` (
  `id_akun` varchar(11) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `header` int(11) DEFAULT NULL,
  `tipe` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id_akun`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `akunting_akun` */

insert  into `akunting_akun`(`id_akun`,`nama`,`header`,`tipe`) values ('100-01','KAS BESAR',100,'Debet'),('100-02','KAS KECIL',100,'Debet'),('100-03','BON SEMENTARA',100,'Debet'),('110-01','BANK BCA',110,'Debet'),('110-02','BANK LIPPO',110,'Debet'),('150-01','PINJAMAN ANUITAS',150,'Debet'),('150-02','PINJAMAN POKOK TETAP',150,'Debet'),('151-01','SEWA DIBAYAR DIMUKA',151,'Debet'),('153-01','PIUTANG BUNGA',153,'Debet'),('153-02','PIUTANG DENDA',153,'Debet'),('155-01','PIUTANG KARYAWAN',155,'Debet'),('155-02','PIUTANG LAIN',155,'Debet'),('160-01','CADANGAN PENGHAPUSAN A.PRO',160,'Debet'),('170-01','SUPLIES KANTOR',170,'Debet'),('170-02','PERSEDIAAN BEA MATERAI',170,'Debet'),('200-01','INVENTARIS KOMPUTER',200,'Debet'),('200-02','INVENTARIS KENDARAAN',200,'Debet'),('200-03','INVENTARIS KANTOR',200,'Debet'),('200-04','FURNITURE',200,'Debet'),('200-05','BANGUNAN',200,'Debet'),('200-06','TANAH',200,'Debet'),('201-01','AKUM. PENYUSUTAN INVESTARIS KOMPUTER',201,'Debet'),('201-02','AKUM. PENYUSUTAN KENDARAAN',201,'Debet'),('201-03','AKUM. PENYUSUTAN KANTOR',201,'Debet'),('201-04','AKUM. PENYUSUTAN FURNITURE',201,'Debet'),('201-05','AKUM. PENYUSUTAN BANGUNAN',201,'Debet'),('400-01','PENDAPATAN YANG AKAN DITERIMA',400,'Debet'),('400-02','PAJAK PBB DIBAYAR DIMUKA',400,'Debet'),('400-03','BEBAN DITANGGUHKAN',400,'Debet'),('400-04','SEWA DIBAYAR DIMUKA',400,'Debet'),('400-05','AGUNAN YANG DIAMBIL ALIH',400,'Debet'),('400-06','PENDIRIAN KOPERASI',400,'Debet'),('400-07','SOFTWARE KOMPUTER',400,'Debet'),('500-01','BEBAN PAJAK BUNGA SIMPANAN',500,'Kredit'),('500-02','BEBAN PAJAK SIMPANAN BERJANGKA',500,'Kredit'),('500-03','BEBAN BIAYA NOTARIS',500,'Kredit'),('500-04','BEBAN TITIPAN BUNGA BERJANGKA',500,'Kredit'),('500-05','BEBAN TITIPAN ANGSURAN',500,'Kredit'),('500-06','BAGIAN SHU ANGGOTA PENYIMPAN',500,'Kredit'),('500-07','BAGIAN SHU ANGGOTA BERJASA',500,'Kredit'),('500-08','BAGIAN SHU PEGURUS',500,'Kredit'),('500-09','DANA KESEJAHTERAAN KARYAWAN',500,'Kredit'),('500-10','DANA SOSIAL',500,'Kredit'),('500-11','DANA PENDIDIKAN',500,'Kredit'),('500-12','DANA TITIPAN ANGGOTA',500,'Kredit'),('510-01','SIMPANAN ANGGOTA',510,'Kredit'),('520-01','SIMPANAN BERJANGKA',520,'Kredit'),('560-01','HUTANG LAIN-LAIN',560,'Kredit'),('561-01','HUTANG BANK',561,'Kredit'),('700-01','B.BUNGA YMH DIBAYAR',700,'Kredit'),('700-02','PAJAK PENGHASILAN',700,'Kredit'),('700-03','PENDAPATAN DITERIMA DIMUKA',700,'Kredit'),('800-01','SISA HASIL USAHA',800,'Kredit'),('800-02','SIMPANAN POKOK',800,'Kredit'),('800-03','SIMPANAN WAJIB',800,'Kredit'),('800-04','MODAL PENYERTAAN PARTISIPASI ANGGOTA',800,'Kredit'),('800-05','MODAL CADANGAN',800,'Kredit'),('800-06','MODAL DONASI',800,'Kredit'),('900-01','HASIL BUNGA PINJAMAN',900,'Kredit'),('900-02','RETUR HASIL BUNGA PINJAMAN',900,'Debet'),('901-01','HASIL BUNGA TABUNGAN',901,'Kredit'),('902-01','HASIL BUNGA BANK',902,'Kredit'),('903-01','HASIL BUNGA SIMPANAN BERJANGKA',903,'Kredit'),('910-01','PROVISI PINJAMAN',910,'Kredit'),('931-01','PENDAPATAN ADMINISTRASI SIMPANAN',931,'Kredit'),('931-02','PENDAPATAN DENDA PINJAMAN',931,'Kredit'),('931-03','PENDAPATAN ASURANSI PINJAMAN',931,'Kredit'),('931-04','PENDAPATAN ADMINISTRASI PINALTI SIMPANAN BERJANGKA',931,'Kredit'),('931-05','PENDAPATAN ADMINISTRASI PINJAMAN',931,'Kredit'),('931-06','PENDAPATAN PINALTI PINJAMAN',931,'Kredit'),('931-07','PENDAPATAN BIAYA METERAI',931,'Kredit'),('931-08','PENDAPATAN BIAYA NOTARIS',931,'Kredit'),('931-09','PENDAPATAN PREMI RESIKO KREDIT',931,'Kredit'),('931-10','PAJAK SIMPANAN',931,'Kredit'),('940-01','LABA PENJUALAN AKTIVA TETAP',940,'Kredit'),('940-02','PENDAPATAN NONOPERASIONAL LAINNYA',940,'Kredit'),('950-01','AMOR. PENDAPATAN BUNGA DIMUKA',950,'Debet'),('950-02','AMOR. PAJAK PBB DIBAYAR DIMUKA',950,'Debet'),('950-03','AMOR. BEBAN DITANGGUHKAN',950,'Debet'),('950-04','AMOR. SEWA DIBAYAR DIMUKA',950,'Debet'),('950-05','AMOR. PENDIRIAN GEDUNG',950,'Debet'),('950-06','AMOR. PROGRAM KOMPUTER',950,'Debet'),('960-01','BIAYA BUNGA SIMPANAN ANGGOTA',960,'Debet'),('960-02','BIAYA BUNGA SIMPANAN BERJANGKA',960,'Debet'),('960-03','BIAYA BUNGA SIMPANAN YANG DITERIMA',960,'Debet'),('960-04','BIAYA BUNGA REKENING KORAN',960,'Debet'),('961-01','BIAYA PAJAK BUNGA REKENING KORAN',961,'Debet'),('961-02','BIAYA PAJAK DEPOSITO',961,'Debet'),('961-03','BIAYA PAJAK TABUNGAN',961,'Debet'),('962-01','POTONGAN BUNGA',962,'Debet'),('962-02','POTONGAN DENDA',962,'Debet'),('970-01','BIAYA GAJI/HONORARIUM',970,'Debet'),('970-02','BIAYA UANG LEMBUR',970,'Debet'),('970-03','BIAYA PENDIDIKAN',970,'Debet'),('970-04','BIAYA UANG MAKAN KARYAWAN',970,'Debet'),('970-05','BIAYA TK. LAINNYA',970,'Debet'),('970-06','BIAYA BONUS KARYAWAN',970,'Debet'),('980-01','BIAYA SEWA INVENTARIS',980,'Debet'),('980-02','BIAYA SEWA GEDUNG',980,'Debet'),('980-03','BIAYA SEWA KENDARAAN',980,'Debet'),('980-04','BIAYA SEWA LAINNYA',980,'Debet'),('981-01','BIAYA ALAT TULIS KANTOR',981,'Debet'),('981-02','BIAYA TELP/TELEX/TELEGRAM',981,'Debet'),('981-03','BIAYA FOTOCOPY',981,'Debet'),('981-04','BIAYA PERJALANAN DINAS',981,'Debet'),('981-05','BIAYA IKLAN/KONSULTAN',981,'Debet'),('981-06','BIAYA SURAT KABAR',981,'Debet'),('981-07','BIAYA PERJAMUAN',981,'Debet'),('981-08','BIAYA LISTRIK DAN PAM',981,'Debet'),('981-09','BIAYA METERAI LANNYA',981,'Debet'),('981-10','BIAYA AKTA NOTARIS',981,'Debet'),('981-11','BIAYA JASA ADMINISTRASI LAINNYA',981,'Debet'),('981-12','BIAYA BENSIN/TRANSPORT',981,'Debet'),('981-13','BIAYA RUMAH TANGGA KANTOR',981,'Debet'),('981-14','BIAYA BARANG CETAKAN',981,'Debet'),('981-15','BIAYA FILM DAN CETAK FOTO',981,'Debet'),('981-16','BIAYA KEAMANAN',981,'Debet'),('981-17','BIAYA KOMISI',981,'Debet'),('981-18','BIAYA PARKIR',981,'Debet'),('981-19','BIAYA BUNGA PINJAMAN BANK',981,'Debet'),('982-01','BIAYA PEMELIHARAAN INVENTARIS',982,'Debet'),('982-02','BIAYA PEMELIHARAAN GEDUNG',982,'Debet'),('982-03','BIAYA PEMELIHARAAN KENDARAAN',982,'Debet'),('982-04','BIAYA PEMELIHARAAN LAINNYA',982,'Debet'),('982-05','BIAYA PEMELIHARAAN KOMPUTER',982,'Debet'),('983-01','BIAYA PAJAK PBB',983,'Debet'),('983-02','BIAYA PAJAK INVENTARIS GEDUNG',983,'Debet'),('983-03','BEA METERAI KERTAS SEGEL',983,'Debet'),('983-04','BIAYA PAJAK REKLAME',983,'Debet'),('983-05','BIAYA PAJAK LAINNYA',983,'Debet'),('984-01','BIAYA PENYUSUTAN REKENING PINJAMAN',984,'Debet'),('984-02','BIAYA PENYUSUTAN A.PRO LAINNYA',984,'Debet'),('985-01','BIAYA ASURANSI INVENTARIS',985,'Debet'),('985-02','BIAYA ASURANSI KENDARAAN',985,'Debet'),('985-03','BIAYA ASURANSI KARYAWAN',985,'Debet'),('985-04','BIAYA OPERASIONAL LAINNYA',985,'Debet'),('986-01','BIAYA PENYUSUTAN INVENTARIS KOMPUTER',986,'Debet'),('986-02','BIAYA PENYUSUTAN KENDARAAN',986,'Debet'),('986-03','BIAYA PENYUSUTAN GEDUNG',986,'Debet'),('986-04','BIAYA PENYUSUTAN INVENTARIS LAINNYA',986,'Debet'),('990-01','PENJUALAN RUGI AKTIVA TETAP',990,'Debet'),('990-02','BIAYA SUMBANGAN',990,'Debet'),('990-03','BIAYA DENDA',990,'Debet'),('990-04','BIAYA NONOPERASIONAL LAINNYA',990,'Debet'),('990-05','BIAYA KERUGIAN',990,'Debet');

/*Table structure for table `akunting_grup` */

DROP TABLE IF EXISTS `akunting_grup`;

CREATE TABLE `akunting_grup` (
  `id_grup` int(11) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_grup`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `akunting_grup` */

insert  into `akunting_grup`(`id_grup`,`nama`) values (1,'AKTIVA LANCAR'),(2,'AKTIVA TETAP'),(3,'AKTIVA LAIN'),(4,'HUTANG LANCAR'),(5,'HUTANG JANGKA PANJANG'),(6,'MODAL'),(7,'PENDAPATAN'),(8,'BIAYA');

/*Table structure for table `akunting_header` */

DROP TABLE IF EXISTS `akunting_header`;

CREATE TABLE `akunting_header` (
  `id_header` varchar(11) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `grup` int(11) DEFAULT NULL,
  `keterangan` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id_header`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `akunting_header` */

insert  into `akunting_header`(`id_header`,`nama`,`grup`,`keterangan`) values ('100','AKTIVA',1,NULL),('110','BANK',1,NULL),('150','REK. PINJAMAN YANG DIBERIKAN',1,NULL),('151','REK. SEWA DIBAYAR DIMUKA',1,NULL),('153','PIUTANG ANGSURAN',1,NULL),('155','PIUTANG KARYAWAN',1,NULL),('160','PENYISIHAN PENGHAPUSAN A.PRO',1,NULL),('170','SUPLIES KANTOR',1,NULL),('200','INVENTARIS',2,NULL),('201','INVENTARIS',2,NULL),('400','BIAYA DIBAYAR DIMUKA',1,NULL),('500','KEWAJIBAN SEGERA DIBAYAR',4,NULL),('510','KEWAJIBAN REK. SIMPANAN ANGGOTA',4,NULL),('520','KEWAJIBAN REK. SIMPANAN BERJANGKA',4,NULL),('560','HUTANG LAIN-LAIN',4,NULL),('561','HUTANG BANK',4,NULL),('700','RUPA-RUPA PASIVA',5,NULL),('800','MODAL',6,NULL),('900','PEND. HASIL BUNGA PINJAMAN',7,NULL),('901','PEND. HASIL BUNGA TABUNGAN',7,NULL),('902','PEND. HASIL BUNGA GIRO',7,NULL),('903','PEND. HASIL BUNGA SIMPANAN BERJANGKA',7,NULL),('910','PEND. PROVISI PINJAMAN',7,NULL),('931','PENDAPATAN',7,NULL),('940','PEND. NONOPERASIONAL LAIN',7,NULL),('950','RUPA-RUPA AKTIVA',8,NULL),('960','BIAYA BUNGA SIMPANAN',8,NULL),('961','BIAYA PAJAK BUNGA',8,NULL),('962','PIUTANG ANGSURAN',8,NULL),('970','BIAYA TENAGA KERJA',8,NULL),('980','BIAYA SEWA',8,NULL),('981','BIAYA',8,NULL),('982','BIAYA PEMELIHARAAN',8,NULL),('983','BIAYA PAJAK',8,NULL),('984','BIAYA PENYUSUTAN A.PRODUKTIF',8,NULL),('985','BIAYA ASURANSI',8,NULL),('986','BIAYA PENYUSUTAN A. TETAP',8,NULL),('990','BIAYA NONOPERASIONAL LAINNYA',8,NULL);

/*Table structure for table `akunting_perkiraan` */

DROP TABLE IF EXISTS `akunting_perkiraan`;

CREATE TABLE `akunting_perkiraan` (
  `id_perkiraan` varchar(50) NOT NULL,
  `nama` varchar(300) DEFAULT NULL,
  `id_header` varchar(50) DEFAULT NULL,
  `header` enum('y','n') DEFAULT NULL,
  `tipe` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id_perkiraan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `akunting_perkiraan` */

/*Table structure for table `kolektor` */

DROP TABLE IF EXISTS `kolektor`;

CREATE TABLE `kolektor` (
  `id_kolektor` varchar(50) NOT NULL,
  `nama` varchar(200) DEFAULT NULL,
  `alamat` varchar(200) DEFAULT NULL,
  `no_ktp` varchar(20) DEFAULT NULL,
  `no_telp` varchar(20) DEFAULT NULL,
  `no_hp` varchar(20) DEFAULT NULL,
  `status` int(1) DEFAULT NULL,
  `foto` text,
  PRIMARY KEY (`id_kolektor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `kolektor` */

insert  into `kolektor`(`id_kolektor`,`nama`,`alamat`,`no_ktp`,`no_telp`,`no_hp`,`status`,`foto`) values ('K0001','I Gede Arya Maharta','Denpasar Bali','1212233454554','767565','09999222002',1,NULL);

/*Table structure for table `nasabah` */

DROP TABLE IF EXISTS `nasabah`;

CREATE TABLE `nasabah` (
  `id_nasabah` varchar(50) NOT NULL,
  `tanggal_daftar` datetime DEFAULT NULL,
  `nama_nasabah` varchar(200) DEFAULT NULL,
  `jenis_id` varchar(20) DEFAULT NULL,
  `no_id` varchar(50) DEFAULT NULL,
  `alamat` varchar(200) DEFAULT NULL,
  `tempat_lahir` varchar(200) DEFAULT NULL,
  `tanggal_lahir` date DEFAULT NULL,
  `jenis_kelamin` varchar(20) DEFAULT NULL,
  `agama` varchar(50) DEFAULT NULL,
  `pekerjaan` varchar(100) DEFAULT NULL,
  `no_telp` varchar(100) DEFAULT NULL,
  `no_hp` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_nasabah`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `nasabah` */

insert  into `nasabah`(`id_nasabah`,`tanggal_daftar`,`nama_nasabah`,`jenis_id`,`no_id`,`alamat`,`tempat_lahir`,`tanggal_lahir`,`jenis_kelamin`,`agama`,`pekerjaan`,`no_telp`,`no_hp`) values ('1510000001','2015-10-14 15:36:38','Raka Sidan','','','','','2015-10-14','Pilih Jenis Kelamin','Pilih Agama','Pilih Pekerjaan','',''),('1510000002','2015-10-13 06:03:48','','','','','','2015-10-13','Wanita','Hindu','PNS','',''),('1510000003','2015-10-13 07:11:06','ARYA MAHARTA','','32878327482397423','denpasar','rteroit','2015-10-13','Pria','Hindu','Wiraswasta','454534534','345345345345435'),('1510000004','2015-10-14 00:00:00','Dharma Raharja','KTP','51343343334334','Tabanan','Tabanan','1993-12-20','Pria','Hindu','Bos','234234','84545454454'),('1510000005','2015-10-14 00:00:00','Oka Gunawan','KTP','343242343423423','Mengwi','Badung','1993-10-12','Pria','Hindu','PNS','546565464564','8811132322'),('1510000006','2015-10-14 00:00:00','Gede Arya','KTP','3,28783274823974E+16','Denpasar','Buleleng','1993-10-13','Pria','Hindu','Wiraswasta','454534534','82334343434');

/*Table structure for table `pengingat` */

DROP TABLE IF EXISTS `pengingat`;

CREATE TABLE `pengingat` (
  `id_pengingat` int(11) NOT NULL AUTO_INCREMENT,
  `judul` varchar(100) DEFAULT NULL,
  `isi` text,
  `tanggal` date DEFAULT NULL,
  `waktu` time DEFAULT NULL,
  `status_aktif` int(1) DEFAULT NULL,
  PRIMARY KEY (`id_pengingat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `pengingat` */

/*Table structure for table `pinjaman` */

DROP TABLE IF EXISTS `pinjaman`;

CREATE TABLE `pinjaman` (
  `id_pinjaman` varchar(50) NOT NULL,
  `tanggal` datetime DEFAULT NULL,
  `id_nasabah` varchar(50) DEFAULT NULL,
  `plafon` double DEFAULT NULL,
  `jangka_waktu` double DEFAULT NULL,
  `satuan_waktu` varchar(50) DEFAULT NULL,
  `bunga` double DEFAULT NULL,
  `jenis_angsuran` int(1) DEFAULT NULL,
  `jumlah_angsuran` double DEFAULT NULL,
  `id_kolektor` varchar(11) DEFAULT NULL,
  `status` int(1) DEFAULT NULL,
  PRIMARY KEY (`id_pinjaman`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `pinjaman` */

/*Table structure for table `pinjaman_angsuran` */

DROP TABLE IF EXISTS `pinjaman_angsuran`;

CREATE TABLE `pinjaman_angsuran` (
  `id_transaksi` varchar(50) NOT NULL,
  `tanggal` datetime DEFAULT NULL,
  `id_pinjaman` varchar(50) DEFAULT NULL,
  `id_kolektor` varchar(10) DEFAULT NULL,
  `nominal` double DEFAULT NULL,
  `pembulatan` double DEFAULT NULL,
  `create_by` varchar(11) DEFAULT NULL,
  `create_date` datetime DEFAULT NULL,
  `update_by` varchar(11) DEFAULT NULL,
  `update_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id_transaksi`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `pinjaman_angsuran` */

/*Table structure for table `pinjaman_jenis` */

DROP TABLE IF EXISTS `pinjaman_jenis`;

CREATE TABLE `pinjaman_jenis` (
  `id_jenis` varchar(50) DEFAULT NULL,
  `nama` varchar(300) DEFAULT NULL,
  `id_akun` varchar(50) DEFAULT NULL,
  `bunga` double DEFAULT NULL,
  `id_akun_bunga` varchar(50) DEFAULT NULL,
  `insentif` varchar(9) DEFAULT NULL,
  `toleransi` double DEFAULT NULL,
  `angsuran` varchar(50) DEFAULT NULL,
  `create_by` varchar(11) DEFAULT NULL,
  `create_date` datetime DEFAULT NULL,
  `update_by` varchar(11) DEFAULT NULL,
  `update_date` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `pinjaman_jenis` */

/*Table structure for table `pinjaman_pengajuan` */

DROP TABLE IF EXISTS `pinjaman_pengajuan`;

CREATE TABLE `pinjaman_pengajuan` (
  `id_pengajuan` varchar(50) NOT NULL,
  `tanggal_pengajuan` datetime DEFAULT NULL,
  `id_nasabah` varchar(50) DEFAULT NULL,
  `plafon` double DEFAULT NULL,
  `jangka_waktu` double DEFAULT NULL,
  `satuan_waktu` varchar(50) DEFAULT NULL,
  `bunga` double DEFAULT NULL,
  `jenis_angsuran` int(1) DEFAULT NULL,
  `jumlah_angsuran` double DEFAULT NULL,
  `tanggal_pembayaran` date DEFAULT NULL,
  `id_kolektor` varchar(11) DEFAULT NULL,
  `status_disetujui` int(1) DEFAULT NULL,
  PRIMARY KEY (`id_pengajuan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `pinjaman_pengajuan` */

/*Table structure for table `pinjaman_transaksi` */

DROP TABLE IF EXISTS `pinjaman_transaksi`;

CREATE TABLE `pinjaman_transaksi` (
  `id_transaksi` varchar(50) NOT NULL,
  `tanggal` datetime DEFAULT NULL,
  `id_pinjaman` varchar(50) DEFAULT NULL,
  `no_bukti` varchar(50) DEFAULT NULL,
  `id_akun` varchar(50) DEFAULT NULL,
  `debet` double DEFAULT NULL,
  `kredit` double DEFAULT NULL,
  `keterangan` varchar(300) DEFAULT NULL,
  `create_by` varchar(11) DEFAULT NULL,
  `create_date` datetime DEFAULT NULL,
  `update_by` varchar(11) DEFAULT NULL,
  `update_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id_transaksi`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `pinjaman_transaksi` */

/*Table structure for table `profil` */

DROP TABLE IF EXISTS `profil`;

CREATE TABLE `profil` (
  `nama_koperasi` varchar(200) DEFAULT NULL,
  `badan_hukum` varchar(200) DEFAULT NULL,
  `tgl_pengukuhan_pkp` date DEFAULT NULL,
  `alamat` varchar(500) DEFAULT NULL,
  `telp_fax` varchar(200) DEFAULT NULL,
  `kabupaten` varchar(100) DEFAULT NULL,
  `provinsi` varchar(100) DEFAULT NULL,
  `logo` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `profil` */

insert  into `profil`(`nama_koperasi`,`badan_hukum`,`tgl_pengukuhan_pkp`,`alamat`,`telp_fax`,`kabupaten`,`provinsi`,`logo`) values ('Koperasi Mertha Sedana Ayu','123455645645','2015-10-12','Blahkiuh','090909090','Badung','Bali',NULL);

/*Table structure for table `ref_role` */

DROP TABLE IF EXISTS `ref_role`;

CREATE TABLE `ref_role` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `role` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `ref_role` */

insert  into `ref_role`(`id`,`role`) values (1,'administrator'),(2,'pegawai'),(3,'manajer');

/*Table structure for table `simpanan` */

DROP TABLE IF EXISTS `simpanan`;

CREATE TABLE `simpanan` (
  `id_simpanan` varchar(50) NOT NULL,
  `tanggal_daftar` datetime DEFAULT NULL,
  `id_nasabah` varchar(50) DEFAULT NULL,
  `jenis_simpanan` int(1) DEFAULT NULL,
  `saldo` double DEFAULT NULL,
  `id_kolektor` varchar(10) DEFAULT NULL,
  `bunga` double DEFAULT NULL,
  `aktif` int(1) DEFAULT NULL,
  `create_by` varchar(11) DEFAULT NULL,
  `create_date` datetime DEFAULT NULL,
  `update_by` varchar(11) DEFAULT NULL,
  `update_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id_simpanan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `simpanan` */

insert  into `simpanan`(`id_simpanan`,`tanggal_daftar`,`id_nasabah`,`jenis_simpanan`,`saldo`,`id_kolektor`,`bunga`,`aktif`,`create_by`,`create_date`,`update_by`,`update_date`) values ('SA-1510000001',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);

/*Table structure for table `simpanan_bunga` */

DROP TABLE IF EXISTS `simpanan_bunga`;

CREATE TABLE `simpanan_bunga` (
  `id_transaksi` varchar(50) NOT NULL,
  `tanggal` datetime DEFAULT NULL,
  `id_simpanan` varchar(50) DEFAULT NULL,
  `minimal` double DEFAULT NULL,
  `maksimal` double DEFAULT NULL,
  `bunga` double DEFAULT NULL,
  PRIMARY KEY (`id_transaksi`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `simpanan_bunga` */

/*Table structure for table `simpanan_jenis` */

DROP TABLE IF EXISTS `simpanan_jenis`;

CREATE TABLE `simpanan_jenis` (
  `id_jenis` varchar(50) NOT NULL,
  `nama` varchar(300) DEFAULT NULL,
  `id_akun` varchar(50) DEFAULT NULL,
  `minimum_awal` double DEFAULT NULL,
  `minimum_saldo` double DEFAULT NULL,
  `bunga` double DEFAULT NULL,
  `create_by` varchar(10) DEFAULT NULL,
  `create_date` datetime DEFAULT NULL,
  `update_by` varchar(10) DEFAULT NULL,
  `update_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id_jenis`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `simpanan_jenis` */

insert  into `simpanan_jenis`(`id_jenis`,`nama`,`id_akun`,`minimum_awal`,`minimum_saldo`,`bunga`,`create_by`,`create_date`,`update_by`,`update_date`) values ('1','Simpanan Sukarela',NULL,10000,50000,NULL,NULL,NULL,NULL,NULL);

/*Table structure for table `simpanan_kode` */

DROP TABLE IF EXISTS `simpanan_kode`;

CREATE TABLE `simpanan_kode` (
  `id_kode` varchar(50) NOT NULL,
  `nama` varchar(300) DEFAULT NULL,
  `id_akun_debet` varchar(50) DEFAULT NULL,
  `id_akun_kredit` varchar(50) DEFAULT NULL,
  `setoran` enum('y','n') DEFAULT NULL,
  `tarikan` enum('y','n') DEFAULT NULL,
  `transfer` enum('y','n') DEFAULT NULL,
  `pokok` enum('y','n') DEFAULT NULL,
  `wajib` enum('y','n') DEFAULT NULL,
  `sukarela` enum('y','n') DEFAULT NULL,
  `pinjaman` enum('y','n') DEFAULT NULL,
  `saham` enum('y','n') DEFAULT NULL,
  `keterangan` varchar(300) DEFAULT NULL,
  `create_by` varchar(11) DEFAULT NULL,
  `create_date` datetime DEFAULT NULL,
  `update_by` varchar(11) DEFAULT NULL,
  `update_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id_kode`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `simpanan_kode` */

/*Table structure for table `simpanan_penarikan` */

DROP TABLE IF EXISTS `simpanan_penarikan`;

CREATE TABLE `simpanan_penarikan` (
  `id_transaksi` varchar(50) NOT NULL,
  `tanggal` datetime DEFAULT NULL,
  `no_bukti` varchar(50) DEFAULT NULL,
  `no_setor` varchar(50) DEFAULT NULL,
  `id_simpanan` varchar(50) DEFAULT NULL,
  `id_kolektor` varchar(10) DEFAULT NULL,
  `nominal` double DEFAULT NULL,
  `create_by` varchar(11) DEFAULT NULL,
  `create_date` datetime DEFAULT NULL,
  `update_by` varchar(11) DEFAULT NULL,
  `update_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id_transaksi`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `simpanan_penarikan` */

/*Table structure for table `simpanan_setoran` */

DROP TABLE IF EXISTS `simpanan_setoran`;

CREATE TABLE `simpanan_setoran` (
  `id_setoran` varchar(50) NOT NULL,
  `tanggal` datetime DEFAULT NULL,
  `no_bukti` varchar(50) DEFAULT NULL,
  `no_setor` varchar(50) DEFAULT NULL,
  `id_simpanan` varchar(50) DEFAULT NULL,
  `id_kolektor` varchar(10) DEFAULT NULL,
  `nominal` double DEFAULT NULL,
  `create_by` varchar(11) DEFAULT NULL,
  `create_date` datetime DEFAULT NULL,
  `update_by` varchar(11) DEFAULT NULL,
  `update_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id_setoran`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `simpanan_setoran` */

/*Table structure for table `simpanan_transaksi` */

DROP TABLE IF EXISTS `simpanan_transaksi`;

CREATE TABLE `simpanan_transaksi` (
  `id_transaksi` varchar(50) NOT NULL,
  `tanggal` datetime DEFAULT NULL,
  `id_simpanan` varchar(50) DEFAULT NULL,
  `id_kode` varchar(50) DEFAULT NULL,
  `id_akun` varchar(50) DEFAULT NULL,
  `no_bukti` varchar(50) DEFAULT NULL,
  `debet` double DEFAULT NULL,
  `kredit` double DEFAULT NULL,
  `saldo` double DEFAULT NULL,
  `keterangan` varchar(300) DEFAULT NULL,
  `tipe` char(2) DEFAULT NULL,
  `create_by` varchar(11) DEFAULT NULL,
  `create_date` datetime DEFAULT NULL,
  `update_by` varchar(11) DEFAULT NULL,
  `update_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id_transaksi`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `simpanan_transaksi` */

/*Table structure for table `user` */

DROP TABLE IF EXISTS `user`;

CREATE TABLE `user` (
  `id_user` varchar(10) NOT NULL,
  `id_pegawai` varchar(10) DEFAULT NULL,
  `nama` varchar(200) DEFAULT NULL,
  `username` varchar(100) DEFAULT NULL,
  `userpassword` varchar(100) DEFAULT NULL,
  `role` varchar(100) DEFAULT NULL,
  `status` int(1) DEFAULT NULL,
  `last_login` datetime DEFAULT NULL,
  PRIMARY KEY (`id_user`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `user` */

insert  into `user`(`id_user`,`id_pegawai`,`nama`,`username`,`userpassword`,`role`,`status`,`last_login`) values ('00001',NULL,'Administrator','admin','admin','admin',0,'2015-10-12 21:33:13'),('00002',NULL,'arya','arya','arya','1',1,NULL),('00003',NULL,'gede','maharta','maharta','1',1,NULL);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
