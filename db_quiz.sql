-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 25, 2018 at 07:47 PM
-- Server version: 10.1.26-MariaDB
-- PHP Version: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_quiz`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `dosenDaftar` (IN `Nidn` VARCHAR(20), IN `Nama` VARCHAR(28), IN `Email` VARCHAR(30), IN `Pass` VARCHAR(256), IN `Fak` VARCHAR(8))  NO SQL
BEGIN
	IF (SELECT COUNT(dosen.nidn) FROM dosen WHERE dosen.nidn = Nidn) > 0 THEN
		SET @message_text = CONCAT('Nidn ', Nidn, ' Telah terdaftar');
		SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = @message_text;   
     
    ELSE
		INSERT INTO `dosen` (`nidn`, `nama`, `kd_fakultas`, `email`, `password`) VALUES (Nidn, Nama, Fak, Email, (SHA2(Pass, 256)));
	END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `dosenHapusKuis` (IN `kdSoal` VARCHAR(8))  NO SQL
BEGIN
	DELETE FROM soal WHERE soal.kd_soal = kdSoal;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `dosenLihatNilai` (IN `KdSoal` VARCHAR(8))  NO SQL
BEGIN
	SELECT mahasiswa.nim, mahasiswa.nama, riwayat.nilai, riwayat.tgl_tes FROM riwayat INNER JOIN user ON riwayat.user_id = user.user_id INNER JOIN mahasiswa ON user.nim = mahasiswa.nim WHERE riwayat.kd_soal = KdSoal;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `dosenLogin` (IN `Email` VARCHAR(50), IN `Pass` VARCHAR(50))  NO SQL
BEGIN
SELECT * FROM dosen d INNER JOIN fakultas f ON d.kd_fakultas = f.kd_fakultas WHERE d.email = Email AND d.password = SHA2(Pass,256);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `dosenRecentKuis` (IN `KdDosen` VARCHAR(20))  NO SQL
BEGIN
	SELECT * FROM soal WHERE soal.kd_dosen = KdDosen;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `dosenTambahKuis` (IN `Nama` VARCHAR(50), IN `Dosen` VARCHAR(20))  NO SQL
BEGIN
	SET @tmp = (SELECT genKodeSoal());
	INSERT INTO `soal` (`kd_soal`,`nama`, `tgl_input`, `kd_dosen`) VALUES (@tmp, Nama, NOW(), Dosen);
    SELECT @tmp; 
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `dosenTambahSoal` (IN `KodeInduk` VARCHAR(8), IN `Soal` VARCHAR(200), IN `Jawaban` VARCHAR(200), IN `OpsiA` VARCHAR(200), IN `OpsiB` VARCHAR(200), IN `OpsiC` VARCHAR(200), IN `Skor` INT(2))  NO SQL
INSERT INTO `soal_detail` (`kd_detail`, `kd_induk`, `soal`, `jawaban`, `opsi_1`, `opsi_2`, `opsi_3`, `skor`) VALUES ((SELECT genKodeSoalDetail()), KodeInduk, Soal, Jawaban, OpsiA, OpsiB, OpsiC, Skor)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `userAmbilQuiz` (IN `kdUser` VARCHAR(6), IN `kdSoal` VARCHAR(8))  NO SQL
INSERT INTO `riwayat` (`kd_riwayat`, `kd_soal`, `user_id`, `nilai`, `tgl_tes`) VALUES ((SELECT genKodeRiwayat()), kdSoal, kdUser, -1, NOW())$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `userAmbilSoal` (IN `kdSoal` VARCHAR(8))  NO SQL
BEGIN
	SELECT * FROM soal_detail WHERE soal_detail.kd_induk = kdSoal;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `userCariKuis` (IN `kdSoal` VARCHAR(8), IN `userId` VARCHAR(6))  NO SQL
BEGIN
	SELECT s.kd_soal, s.nama, s.tgl_input, d.nama FROM soal s INNER JOIN dosen d ON s.kd_dosen = d.nidn WHERE s.kd_soal = kdSoal AND s.kd_soal NOT IN (SELECT riwayat.kd_soal FROM riwayat WHERE riwayat.user_id = userId);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `userDaftar` (IN `Nim` VARCHAR(16), IN `Nama` VARCHAR(40), IN `Prodi` VARCHAR(6), IN `Email` VARCHAR(25), IN `Pass` VARCHAR(256))  NO SQL
BEGIN
	IF (SELECT COUNT(mahasiswa.nim) FROM mahasiswa WHERE mahasiswa.nim = Nim) > 0 THEN
		SET @message_text = CONCAT('Nim ', Nim, ' Telah terdaftar');
		SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = @message_text;   
    ELSEIF (SELECT COUNT(user.email) FROM user WHERE user.email = Email) > 0 THEN
    	SET @message_text = CONCAT('Email ', Email, ' Telah terdaftar');
		SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = @message_text; 
    ELSE
		INSERT INTO `mahasiswa` (`nim`, `nama`, `kd_prodi`) VALUES (Nim, Nama, Prodi);
        INSERT INTO `user` (`user_id`, `email`, `password`, `nim`) VALUES ((SELECT genUserId()), Email, (SHA2(Pass, 256)), Nim);
	END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `userGetRiwayat` (IN `UserID` VARCHAR(6))  NO SQL
BEGIN
	select d.nama, s.nama, r.tgl_tes, r.nilai from riwayat r inner join soal s on r.kd_soal = s.kd_soal inner join dosen d on s.kd_dosen = d.nidn WHERE r.user_id = UserID;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `userHitungSoal` (IN `kdSoal` VARCHAR(8))  NO SQL
BEGIN
	SELECT COUNT(soal_detail.kd_detail) FROM soal_detail WHERE soal_detail.kd_induk = kdSoal;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `userLogin` (IN `Email` VARCHAR(25), IN `Pass` VARCHAR(25))  NO SQL
BEGIN
SELECT * FROM user u INNER JOIN mahasiswa m ON u.nim = m.nim INNER JOIN prodi p ON m.kd_prodi = p.kd_prodi WHERE u.email = Email AND u.password = SHA2(Pass,256);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `userTambahRiwayat` (IN `kdSoal` VARCHAR(8), IN `UserID` VARCHAR(6), IN `Nilai` INT(3))  NO SQL
BEGIN
	INSERT INTO `riwayat` (`kd_riwayat`, `kd_soal`, `user_id`, `nilai`, `tgl_tes`) VALUES ((SELECT genKodeRiwayat()), kdSoal, UserID, Nilai, NOW());
END$$

--
-- Functions
--
CREATE DEFINER=`root`@`localhost` FUNCTION `genKodeRiwayat` () RETURNS VARCHAR(8) CHARSET latin1 NO SQL
BEGIN
    DECLARE kdRiwayat varchar(8);
    
    SELECT COUNT(`kd_riwayat`) INTO @trig FROM (SELECT `kd_riwayat` FROM `riwayat` ORDER BY `kd_riwayat` DESC LIMIT 1) as X;
    
    IF @trig = 0 THEN SET @pad = "00001";
    ELSE 
    	SELECT SUBSTRING(`kd_riwayat`,4) INTO @tmp FROM riwayat ORDER BY kd_riwayat DESC LIMIT 1;
        IF (@tmp + 1) >= 10000 THEN SET @pad = CONCAT("",@tmp+1);
        ELSEIF (@tmp + 1) >= 1000 THEN SET @pad = CONCAT("0",@tmp+1);
		ELSEIF (@tmp + 1) >= 100 THEN SET @pad = CONCAT("00",@tmp+1);
        ELSEIF (@tmp + 1) >= 10 THEN SET @pad = CONCAT("000",@tmp+1);
		ELSE SET @pad = CONCAT("0000",@tmp+1);
    	END IF;
    END IF;
    
    SET kdRiwayat = CONCAT("H-",@pad);
    
    RETURN kdRiwayat;
END$$

CREATE DEFINER=`root`@`localhost` FUNCTION `genKodeSoal` () RETURNS VARCHAR(8) CHARSET latin1 NO SQL
BEGIN
    DECLARE kodeSoal VARCHAR(8) DEFAULT "" ;
    WHILE LENGTH(kodeSoal) = 0 DO
        SELECT concat(substring('abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789', rand()*36+1, 1),
                substring('abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789', rand()*36+1, 1),
                substring('abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789', rand()*36+1, 1),
                substring('abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789', rand()*36+1, 1),
                substring('abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789', rand()*36+1, 1),
                substring('abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789', rand()*36+1, 1),
                substring('abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789', rand()*36+1, 1),
                substring('abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789', rand()*36+1, 1),
                substring('abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789', rand()*36+1, 1),
                substring('abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789', rand()*36+1, 1)       
                ) into @newKodeSoal;
    
        SET @rcount = -1;
        SELECT COUNT(*) INTO @rcount FROM `soal` WHERE `kd_soal` = @newKodeSoal ;
    
        IF @rcount = 0 THEN
            SET kodeSoal = @newKodeSoal ;
        ELSE
        	SET kodeSoal = (SELECT genKodeSoal());
        END IF ;
    END WHILE ;
 
    RETURN kodeSoal ;
    END$$

CREATE DEFINER=`root`@`localhost` FUNCTION `genKodeSoalDetail` () RETURNS VARCHAR(9) CHARSET latin1 NO SQL
BEGIN
    DECLARE soalDetail varchar(9);
    
    SELECT COUNT(`kd_detail`) INTO @trig FROM (SELECT `kd_detail` FROM `soal_detail` ORDER BY `kd_detail` DESC LIMIT 1) as X;
    
    IF @trig = 0 THEN SET @pad = "00001";
    ELSE 
    	SELECT SUBSTRING(`kd_detail`,4) INTO @tmp FROM soal_detail ORDER BY kd_detail DESC LIMIT 1;
        IF (@tmp + 1) >= 10000 THEN SET @pad = CONCAT("",@tmp+1);
        ELSEIF (@tmp + 1) >= 1000 THEN SET @pad = CONCAT("0",@tmp+1);
		ELSEIF (@tmp + 1) >= 100 THEN SET @pad = CONCAT("00",@tmp+1);
        ELSEIF (@tmp + 1) >= 10 THEN SET @pad = CONCAT("000",@tmp+1);
		ELSE SET @pad = CONCAT("0000",@tmp+1);
    	END IF;
    END IF;
    
    SET soalDetail = CONCAT("S-",@pad);
    
    RETURN soalDetail;
END$$

CREATE DEFINER=`root`@`localhost` FUNCTION `genUserId` () RETURNS VARCHAR(6) CHARSET latin1 NO SQL
BEGIN
    DECLARE userId varchar(10);
    
    SELECT COUNT(`user_id`) INTO @trig FROM (SELECT `user_id` FROM `user` ORDER BY `user_id` DESC LIMIT 1) as X;
    
    IF @trig = 0 THEN SET @pad = "0001";
    ELSE 
    	SELECT SUBSTRING(`user_id`,4) INTO @tmp FROM user ORDER BY user_id DESC LIMIT 1;
        IF (@tmp + 1) >= 1000 THEN SET @pad = CONCAT("",@tmp+1);
        ELSEIF (@tmp + 1) >= 100 THEN SET @pad = CONCAT("0",@tmp+1);
		ELSEIF (@tmp + 1) >= 10 THEN SET @pad = CONCAT("00",@tmp+1);
		ELSE SET @pad = CONCAT("000",@tmp+1);
    	END IF;
    END IF;
    
    SET userId = CONCAT("U-",@pad);
    
    RETURN userId;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `dosen`
--

CREATE TABLE `dosen` (
  `nidn` varchar(20) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `kd_fakultas` varchar(6) NOT NULL,
  `email` varchar(30) NOT NULL,
  `password` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dosen`
--

INSERT INTO `dosen` (`nidn`, `nama`, `kd_fakultas`, `email`, `password`) VALUES
('123123', 'Ferry Rotinsulu', 'FK-001', 'dosen', '090b235e9eb8f197f2dd927937222c570396d971222d9009a9189e2b6cc0a2c1'),
('4242', 'Mayang', 'FK-001', 'ayang', '090b235e9eb8f197f2dd927937222c570396d971222d9009a9189e2b6cc0a2c1');

-- --------------------------------------------------------

--
-- Table structure for table `fakultas`
--

CREATE TABLE `fakultas` (
  `kd_fakultas` varchar(6) NOT NULL,
  `nama` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `fakultas`
--

INSERT INTO `fakultas` (`kd_fakultas`, `nama`) VALUES
('FK-001', 'Fakultas Teknik'),
('FK-002', 'Kedokteran');

-- --------------------------------------------------------

--
-- Table structure for table `mahasiswa`
--

CREATE TABLE `mahasiswa` (
  `nim` varchar(16) NOT NULL,
  `nama` varchar(40) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `no_hp` varchar(13) NOT NULL,
  `kd_prodi` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mahasiswa`
--

INSERT INTO `mahasiswa` (`nim`, `nama`, `tgl_lahir`, `no_hp`, `kd_prodi`) VALUES
('111', 'Irwan', '0000-00-00', '', 'PD-001'),
('165150207113002', 'Faiz', '0000-00-00', '', 'PD-003'),
('222', 'Bagas', '0000-00-00', '', 'PD-002'),
('333', 'Faiz A', '0000-00-00', '', 'PD-001'),
('6666', 'eggi', '0000-00-00', '', 'PD-001');

-- --------------------------------------------------------

--
-- Table structure for table `prodi`
--

CREATE TABLE `prodi` (
  `kd_prodi` varchar(6) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `kd_fakultas` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `prodi`
--

INSERT INTO `prodi` (`kd_prodi`, `nama`, `kd_fakultas`) VALUES
('PD-001', 'Teknik Elektro', 'FK-001'),
('PD-002', 'Teknik Fisika', 'FK-001'),
('PD-003', 'Kebidanan', 'FK-002'),
('PD-004', 'Pendidikan Dokter', 'FK-002');

-- --------------------------------------------------------

--
-- Table structure for table `riwayat`
--

CREATE TABLE `riwayat` (
  `kd_riwayat` varchar(8) NOT NULL,
  `kd_soal` varchar(8) NOT NULL,
  `user_id` varchar(6) NOT NULL,
  `nilai` int(3) NOT NULL,
  `tgl_tes` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `riwayat`
--

INSERT INTO `riwayat` (`kd_riwayat`, `kd_soal`, `user_id`, `nilai`, `tgl_tes`) VALUES
('H-00002', 'zesdKzuv', 'U-0002', 120, '2018-10-25'),
('H-00003', 'zesdKzuv', 'U-0001', 20, '2018-10-25'),
('H-00004', 'zesdKzuv', 'U-0004', 20, '2018-10-25'),
('H-00005', 'lymBBtmd', 'U-0004', 30, '2018-10-26'),
('H-00006', 'lymBBtmd', 'U-0001', 40, '2018-10-26'),
('H-00007', 'lymBBtmd', 'U-0002', 10, '2018-10-26'),
('H-00008', 'lymBBtmd', 'U-0005', 20, '2018-10-26');

-- --------------------------------------------------------

--
-- Table structure for table `soal`
--

CREATE TABLE `soal` (
  `kd_soal` varchar(8) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `tgl_input` date NOT NULL,
  `kd_dosen` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `soal`
--

INSERT INTO `soal` (`kd_soal`, `nama`, `tgl_input`, `kd_dosen`) VALUES
('FGIIIFtc', 'Sistem Pakar', '2018-10-24', '123123'),
('gffjGyzr', 'Quiz 1', '2018-10-23', '123123'),
('lymBBtmd', 'COBA 3', '2018-10-26', '4242'),
('zEecHrtl', 'Quiz Coba 6', '2018-10-26', '4242'),
('zesdKzuv', 'coba2', '2018-10-24', '123123');

-- --------------------------------------------------------

--
-- Table structure for table `soal_detail`
--

CREATE TABLE `soal_detail` (
  `kd_detail` varchar(9) NOT NULL,
  `kd_induk` varchar(8) NOT NULL,
  `soal` varchar(200) NOT NULL,
  `jawaban` varchar(200) NOT NULL,
  `opsi_1` varchar(200) NOT NULL,
  `opsi_2` varchar(200) NOT NULL,
  `opsi_3` varchar(200) NOT NULL,
  `skor` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `soal_detail`
--

INSERT INTO `soal_detail` (`kd_detail`, `kd_induk`, `soal`, `jawaban`, `opsi_1`, `opsi_2`, `opsi_3`, `skor`) VALUES
('S-00005', 'gffjGyzr', 'LALA ?', 'L', 'a', 'aa', 'aaa', 10),
('S-00006', 'gffjGyzr', 'LELE ?', 'E', 'b', 'bb', 'bbb', 10),
('S-00007', 'FGIIIFtc', 'LALA ?', 'L', 'a', 'aa', 'aaa', 10),
('S-00008', 'FGIIIFtc', 'LELE ?', 'E', 'b', 'bb', 'bbb', 10),
('S-00009', 'zesdKzuv', '2+2', '4', 'a', 'aa', 'aaa', 10),
('S-00010', 'zesdKzuv', '2+3', '5', 'b', 'bb', 'bbb', 10),
('S-00011', 'zesdKzuv', '2+4', '6', 'b', 'bb', 'bbb', 10),
('S-00012', 'zesdKzuv', '2+5', '7', 'b', 'bb', 'bbb', 10),
('S-00013', 'zesdKzuv', '2+6', '8', 'b', 'bb', 'bbb', 10),
('S-00014', 'zesdKzuv', '2+7', '9', 'b', 'bb', 'bbb', 10),
('S-00015', 'zesdKzuv', '2+8', '10', 'b', 'bb', 'bbb', 10),
('S-00016', 'zesdKzuv', '2+1', '3', 'b', 'bb', 'bbb', 10),
('S-00017', 'zesdKzuv', '2+0', '2', 'b', 'bb', 'bbb', 10),
('S-00018', 'zesdKzuv', '3+3', '6', 'b', 'bb', 'bbb', 10),
('S-00019', 'zesdKzuv', '3+1', '4', 'b', 'bb', 'bbb', 10),
('S-00020', 'zesdKzuv', '3+2', '5', 'b', 'bb', 'bbb', 10),
('S-00021', 'zesdKzuv', '3+4', '7', 'b', 'bb', 'bbb', 10),
('S-00022', 'zesdKzuv', '3+5', '8', 'b', 'bb', 'bbb', 10),
('S-00023', 'zesdKzuv', '3+6', '9', 'b', 'bb', 'bbb', 10),
('S-00024', 'zesdKzuv', '3+7', '10', 'b', 'bb', 'bbb', 10),
('S-00025', 'zesdKzuv', '3+8', '11', 'b', 'bb', 'bbb', 10),
('S-00026', 'zesdKzuv', '3+9', '12', 'b', 'bb', 'bbb', 10),
('S-00027', 'zesdKzuv', '5+5', '10', 'b', 'bb', 'bbb', 10),
('S-00028', 'zesdKzuv', '5+6', '11', 'b', 'bb', 'bbb', 10),
('S-00029', 'lymBBtmd', '2+2', '4', 'a', 'aa', 'aaa', 10),
('S-00030', 'lymBBtmd', '2+3', '5', 'b', 'bb', 'bbb', 10),
('S-00031', 'lymBBtmd', '2+4', '6', 'b', 'bb', 'bbb', 10),
('S-00032', 'lymBBtmd', '2+5', '7', 'b', 'bb', 'bbb', 10),
('S-00033', 'lymBBtmd', '2+6', '8', 'b', 'bb', 'bbb', 10),
('S-00034', 'lymBBtmd', '2+7', '9', 'b', 'bb', 'bbb', 10),
('S-00035', 'lymBBtmd', '2+8', '10', 'b', 'bb', 'bbb', 10),
('S-00036', 'lymBBtmd', '2+1', '3', 'b', 'bb', 'bbb', 10),
('S-00037', 'lymBBtmd', '2+0', '2', 'b', 'bb', 'bbb', 10),
('S-00038', 'lymBBtmd', '3+3', '6', 'b', 'bb', 'bbb', 10),
('S-00039', 'lymBBtmd', '3+1', '4', 'b', 'bb', 'bbb', 10),
('S-00040', 'lymBBtmd', '3+2', '5', 'b', 'bb', 'bbb', 10),
('S-00041', 'lymBBtmd', '3+4', '7', 'b', 'bb', 'bbb', 10),
('S-00042', 'lymBBtmd', '3+5', '8', 'b', 'bb', 'bbb', 10),
('S-00043', 'lymBBtmd', '3+6', '9', 'b', 'bb', 'bbb', 10),
('S-00044', 'lymBBtmd', '3+7', '10', 'b', 'bb', 'bbb', 10),
('S-00045', 'lymBBtmd', '3+8', '11', 'b', 'bb', 'bbb', 10),
('S-00046', 'lymBBtmd', '3+9', '12', 'b', 'bb', 'bbb', 10),
('S-00047', 'lymBBtmd', '5+5', '10', 'b', 'bb', 'bbb', 10),
('S-00048', 'lymBBtmd', '5+6', '11', 'b', 'bb', 'bbb', 10),
('S-00049', 'zEecHrtl', '2+2', '4', 'a', 'aa', 'aaa', 10),
('S-00050', 'zEecHrtl', '2+3', '5', 'b', 'bb', 'bbb', 10),
('S-00051', 'zEecHrtl', '2+4', '6', 'b', 'bb', 'bbb', 10),
('S-00052', 'zEecHrtl', '2+5', '7', 'b', 'bb', 'bbb', 10),
('S-00053', 'zEecHrtl', '2+6', '8', 'b', 'bb', 'bbb', 10),
('S-00054', 'zEecHrtl', '2+7', '9', 'b', 'bb', 'bbb', 10),
('S-00055', 'zEecHrtl', '2+8', '10', 'b', 'bb', 'bbb', 10),
('S-00056', 'zEecHrtl', '2+1', '3', 'b', 'bb', 'bbb', 10),
('S-00057', 'zEecHrtl', '2+0', '2', 'b', 'bb', 'bbb', 10),
('S-00058', 'zEecHrtl', '3+3', '6', 'b', 'bb', 'bbb', 10),
('S-00059', 'zEecHrtl', '3+1', '4', 'b', 'bb', 'bbb', 10),
('S-00060', 'zEecHrtl', '3+2', '5', 'b', 'bb', 'bbb', 10),
('S-00061', 'zEecHrtl', '3+4', '7', 'b', 'bb', 'bbb', 10),
('S-00062', 'zEecHrtl', '3+5', '8', 'b', 'bb', 'bbb', 10),
('S-00063', 'zEecHrtl', '3+6', '9', 'b', 'bb', 'bbb', 10),
('S-00064', 'zEecHrtl', '3+7', '10', 'b', 'bb', 'bbb', 10),
('S-00065', 'zEecHrtl', '3+8', '11', 'b', 'bb', 'bbb', 10),
('S-00066', 'zEecHrtl', '3+9', '12', 'b', 'bb', 'bbb', 10),
('S-00067', 'zEecHrtl', '5+5', '10', 'b', 'bb', 'bbb', 10),
('S-00068', 'zEecHrtl', '5+6', '11', 'b', 'bb', 'bbb', 10);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `user_id` varchar(6) NOT NULL,
  `email` varchar(25) NOT NULL,
  `password` varchar(256) NOT NULL,
  `nim` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_id`, `email`, `password`, `nim`) VALUES
('U-0001', 'irwan', '090b235e9eb8f197f2dd927937222c570396d971222d9009a9189e2b6cc0a2c1', '111'),
('U-0002', 'bagas', '090b235e9eb8f197f2dd927937222c570396d971222d9009a9189e2b6cc0a2c1', '222'),
('U-0003', 'Faiz@student.ub.ac.id', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', '165150207113002'),
('U-0004', 'faiz', '090b235e9eb8f197f2dd927937222c570396d971222d9009a9189e2b6cc0a2c1', '333'),
('U-0005', 'eggi', '090b235e9eb8f197f2dd927937222c570396d971222d9009a9189e2b6cc0a2c1', '6666');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `dosen`
--
ALTER TABLE `dosen`
  ADD PRIMARY KEY (`nidn`),
  ADD KEY `kd_fakultas` (`kd_fakultas`);

--
-- Indexes for table `fakultas`
--
ALTER TABLE `fakultas`
  ADD PRIMARY KEY (`kd_fakultas`);

--
-- Indexes for table `mahasiswa`
--
ALTER TABLE `mahasiswa`
  ADD PRIMARY KEY (`nim`),
  ADD KEY `kd_prodi` (`kd_prodi`);

--
-- Indexes for table `prodi`
--
ALTER TABLE `prodi`
  ADD PRIMARY KEY (`kd_prodi`),
  ADD KEY `kd_fakultas` (`kd_fakultas`);

--
-- Indexes for table `riwayat`
--
ALTER TABLE `riwayat`
  ADD PRIMARY KEY (`kd_riwayat`),
  ADD KEY `kd_soal` (`kd_soal`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `soal`
--
ALTER TABLE `soal`
  ADD PRIMARY KEY (`kd_soal`),
  ADD KEY `kd_dosen` (`kd_dosen`);

--
-- Indexes for table `soal_detail`
--
ALTER TABLE `soal_detail`
  ADD PRIMARY KEY (`kd_detail`),
  ADD KEY `kd_induk` (`kd_induk`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`),
  ADD KEY `nim` (`nim`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `dosen`
--
ALTER TABLE `dosen`
  ADD CONSTRAINT `fk_kd_fakultas2` FOREIGN KEY (`kd_fakultas`) REFERENCES `fakultas` (`kd_fakultas`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `mahasiswa`
--
ALTER TABLE `mahasiswa`
  ADD CONSTRAINT `fk_kd_prodi` FOREIGN KEY (`kd_prodi`) REFERENCES `prodi` (`kd_prodi`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `prodi`
--
ALTER TABLE `prodi`
  ADD CONSTRAINT `fk_kd_fakultas` FOREIGN KEY (`kd_fakultas`) REFERENCES `fakultas` (`kd_fakultas`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `riwayat`
--
ALTER TABLE `riwayat`
  ADD CONSTRAINT `fk_kd_soal` FOREIGN KEY (`kd_soal`) REFERENCES `soal` (`kd_soal`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_user_id` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `soal`
--
ALTER TABLE `soal`
  ADD CONSTRAINT `fk_kd_dosen` FOREIGN KEY (`kd_dosen`) REFERENCES `dosen` (`nidn`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `soal_detail`
--
ALTER TABLE `soal_detail`
  ADD CONSTRAINT `fk_kd_induk` FOREIGN KEY (`kd_induk`) REFERENCES `soal` (`kd_soal`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `fk_nim_mahasiswa` FOREIGN KEY (`nim`) REFERENCES `mahasiswa` (`nim`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
