-- phpMyAdmin SQL Dump
-- version 4.8.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 13 Jul 2021 pada 10.11
-- Versi server: 10.1.33-MariaDB
-- Versi PHP: 7.2.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `accounting`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_attedance_list`
--

CREATE TABLE `tbl_attedance_list` (
  `no_employee` varchar(16) NOT NULL,
  `employee_name` varchar(30) NOT NULL,
  `position` varchar(15) NOT NULL,
  `attedance` varchar(15) NOT NULL,
  `timetowork` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_attedance_list`
--

INSERT INTO `tbl_attedance_list` (`no_employee`, `employee_name`, `position`, `attedance`, `timetowork`) VALUES
('2345678910112765', 'Very', 'ADMINISTRASI', 'HADIR', '2021-07-13'),
('3603122567892222', 'Samosir', 'ADMINISTRASI', 'HADIR', '2021-07-14'),
('3603122712970003', 'Saman', 'KEPALA BAGIAN', 'HADIR', '2021-07-12'),
('3603122712987654', 'Aman', 'ADMINISTRASI', 'HADIR', '2021-07-10'),
('3765123459876543', 'Dodi', 'ADMINISTRASI', 'HADIR', '2021-07-10');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_buy_or_sell`
--

CREATE TABLE `tbl_buy_or_sell` (
  `no_product` varchar(16) NOT NULL,
  `product_name` varchar(30) NOT NULL,
  `amount` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `buy` int(11) NOT NULL,
  `sell` int(11) NOT NULL,
  `employees` varchar(30) NOT NULL,
  `total` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_buy_or_sell`
--

INSERT INTO `tbl_buy_or_sell` (`no_product`, `product_name`, `amount`, `price`, `buy`, `sell`, `employees`, `total`) VALUES
('PR0001', 'Karet', 12, 8000, 10, 10, 'Angga', 8000),
('PR0002', 'Balam', 100, 8000, 70, 70, 'Samin', 56000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_new_employee`
--

CREATE TABLE `tbl_new_employee` (
  `no_employee` varchar(16) NOT NULL,
  `employee_name` varchar(30) NOT NULL,
  `position` varchar(15) NOT NULL,
  `date_started` date NOT NULL,
  `departement` varchar(15) NOT NULL,
  `basic_pay` int(11) NOT NULL,
  `positional_allowance` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_new_employee`
--

INSERT INTO `tbl_new_employee` (`no_employee`, `employee_name`, `position`, `date_started`, `departement`, `basic_pay`, `positional_allowance`) VALUES
('2345678912345678', 'Andri', 'ACCOUNTING', '2021-07-19', 'FINANCE', 4000000, 'LAPTOP'),
('3603122712960003', 'Jaka', 'OPERATOR', '2021-07-19', 'ASSEMBELING', 420000, 'BPJS');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_payment_slip`
--

CREATE TABLE `tbl_payment_slip` (
  `no_slip` varchar(16) NOT NULL,
  `no_employee` varchar(16) NOT NULL,
  `employee_name` varchar(30) NOT NULL,
  `position` varchar(15) NOT NULL,
  `date_started` date NOT NULL,
  `departement` varchar(15) NOT NULL,
  `basic_pay` varchar(15) NOT NULL,
  `overtime` varchar(15) NOT NULL,
  `positional_allowance` varchar(15) NOT NULL,
  `intensive_attendance` varchar(15) NOT NULL,
  `orther_allowance` varchar(15) NOT NULL,
  `bonus` varchar(15) NOT NULL,
  `attendance` varchar(15) NOT NULL,
  `orther_salary` varchar(15) NOT NULL,
  `jamsostek` varchar(15) NOT NULL,
  `pph` varchar(15) NOT NULL,
  `orther_jamsostek` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_payment_slip`
--

INSERT INTO `tbl_payment_slip` (`no_slip`, `no_employee`, `employee_name`, `position`, `date_started`, `departement`, `basic_pay`, `overtime`, `positional_allowance`, `intensive_attendance`, `orther_allowance`, `bonus`, `attendance`, `orther_salary`, `jamsostek`, `pph`, `orther_jamsostek`) VALUES
('SL0001', '3603122712960003', 'Alex', 'ACCOUNTING', '2021-07-19', 'HUMAN RESOURCE ', '4000000', '5000', 'BPJS', '500', '0', '2000', '1000', '0', '200000', '88500', '0'),
('SL0002', '2345678912345678', 'Very', 'ACCOUNTING', '2021-07-19', 'FINANCE', '4000000', '2000', 'BPJS', '1200', '0', '5000', '2000', '0', '200000', '90200', '0');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_product`
--

CREATE TABLE `tbl_product` (
  `no_product` varchar(15) NOT NULL,
  `product_name` varchar(30) NOT NULL,
  `amount` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `product_in` varchar(30) NOT NULL,
  `product_out` varchar(30) NOT NULL,
  `employees_input` varchar(30) NOT NULL,
  `total_product` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_product`
--

INSERT INTO `tbl_product` (`no_product`, `product_name`, `amount`, `price`, `product_in`, `product_out`, `employees_input`, `total_product`) VALUES
('PR0001', 'Karet', 100, 8000, '90', '12', 'Saleh', 189),
('PR0002', 'Balam', 80, 8000, '60', '20', 'Jajang', 138);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_user`
--

CREATE TABLE `tbl_user` (
  `username` varchar(15) NOT NULL,
  `password` varchar(15) NOT NULL,
  `status` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_user`
--

INSERT INTO `tbl_user` (`username`, `password`, `status`) VALUES
('finance', 'finance', 'FINANCE'),
('hrd', 'hrd', 'HRD'),
('jajang', 'jajang', 'PRODUKSI'),
('produksi', 'produksi', 'PRODUKSI'),
('umum', 'umum', 'UMUM');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_attedance_list`
--
ALTER TABLE `tbl_attedance_list`
  ADD PRIMARY KEY (`no_employee`);

--
-- Indeks untuk tabel `tbl_buy_or_sell`
--
ALTER TABLE `tbl_buy_or_sell`
  ADD PRIMARY KEY (`no_product`);

--
-- Indeks untuk tabel `tbl_new_employee`
--
ALTER TABLE `tbl_new_employee`
  ADD PRIMARY KEY (`no_employee`);

--
-- Indeks untuk tabel `tbl_payment_slip`
--
ALTER TABLE `tbl_payment_slip`
  ADD PRIMARY KEY (`no_slip`);

--
-- Indeks untuk tabel `tbl_product`
--
ALTER TABLE `tbl_product`
  ADD PRIMARY KEY (`no_product`);

--
-- Indeks untuk tabel `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
