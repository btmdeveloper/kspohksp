/*
SQLyog Ultimate v9.01 
MySQL - 5.1.29-rc-community : Database - ksp2
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`ksp2` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `ksp2`;

/*Data for the table `accheader` */

insert  into `accheader`(`id`,`nama`,`grupid`,`jenis`,`modal`,`keterangan`,`user`,`jam`) values ('100','AKTIVA',1,'0','0','','admin','2015-02-04 09:13:06'),('110','BANK',1,'0','0','','admin','2009-06-25 20:47:11'),('150','REK. PINJAMAN YANG DIBERIKAN',1,'0','0','','admin','2009-06-25 20:47:11'),('151','REK. SEWA DIBAYAR DIMUKA',1,'0','0','','admin','2009-06-25 20:47:12'),('153','PIUTANG ANGSURAN',1,'0','0','','admin','2009-06-25 20:47:12'),('155','PIUTANG KARYAWAN',1,'0','0','','admin','2009-06-25 20:47:12'),('160','PENYISIHAN PENGHAPUSAN A.PRO',1,'0','0','','admin','2009-06-25 20:47:12'),('170','SUPLIES KANTOR',1,'0','0','','admin','2009-06-25 20:47:12'),('200','INVENTARIS',2,'0','0','','admin','2009-06-25 20:47:12'),('201','INVENTARIS',2,'0','0','','admin','2009-06-25 20:47:12'),('400','BIAYA DIBAYAR DIMUKA',1,'0','0','','admin','2009-06-25 20:47:12'),('500','KEWAJIBAN SEGERA DIBAYAR',4,'0','0','','admin','2009-06-25 20:47:12'),('510','KEWAJIBAN REK. SIMPANAN ANGGOTA',4,'0','0','','admin','2009-06-25 20:47:12'),('520','KEWAJIBAN REK. SIMPANAN BERJANGKA',4,'0','0','','admin','2009-06-25 20:47:12'),('560','HUTANG LAIN-LAIN',4,'0','0','','admin','2009-06-25 20:47:12'),('561','HUTANG BANK',4,'0','0','','admin','2009-06-25 20:47:12'),('700','RUPA-RUPA PASIVA',5,'0','0','','admin','2009-06-25 20:47:12'),('800','MODAL',6,'0','0','','admin','2009-06-25 20:47:12'),('900','PEND. HASIL BUNGA PINJAMAN',7,'0','0','','admin','2009-06-25 20:47:12'),('901','PEND. HASIL BUNGA TABUNGAN',7,'0','0','','admin','2009-06-25 20:47:12'),('902','PEND. HASIL BUNGA GIRO',7,'0','0','','admin','2009-06-25 20:47:12'),('903','PEND. HASIL BUNGA SIMPANAN BERJANGKA',7,'0','0','','admin','2009-06-25 20:47:12'),('910','PEND. PROVISI PINJAMAN',7,'0','0','','admin','2009-06-25 20:47:12'),('931','PENDAPATAN',7,'0','0','','admin','2009-06-25 20:47:12'),('940','PEND. NONOPERASIONAL LAIN',7,'0','0','','admin','2009-06-25 20:47:12'),('950','RUPA-RUPA AKTIVA',8,'0','0','','admin','2009-06-25 20:47:12'),('960','BIAYA BUNGA SIMPANAN',8,'0','0','','admin','2009-06-25 20:47:12'),('961','BIAYA PAJAK BUNGA',8,'0','0','','admin','2009-06-25 20:47:12'),('962','PIUTANG ANGSURAN',8,'0','0','','admin','2009-06-25 20:47:12'),('970','BIAYA TENAGA KERJA',8,'0','0','','admin','2009-06-25 20:47:12'),('980','BIAYA SEWA',8,'0','0','','admin','2009-06-25 20:47:12'),('981','BIAYA',8,'0','0','','admin','2009-06-25 20:47:12'),('982','BIAYA PEMELIHARAAN',8,'0','0','','admin','2009-06-25 20:47:12'),('983','BIAYA PAJAK',8,'0','0','','admin','2009-06-25 20:47:12'),('984','BIAYA PENYUSUTAN A.PRODUKTIF',8,'0','0','','admin','2009-06-25 20:47:12'),('985','BIAYA ASURANSI',8,'0','0','','admin','2009-06-25 20:47:12'),('986','BIAYA PENYUSUTAN A. TETAP',8,'0','0','','admin','2009-06-25 20:47:12'),('990','BIAYA NONOPERASIONAL LAINNYA',8,'0','0','','admin','2009-06-25 20:47:12');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
