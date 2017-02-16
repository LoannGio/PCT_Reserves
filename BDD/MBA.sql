-- phpMyAdmin SQL Dump
-- version 4.5.4.1deb2ubuntu2
-- http://www.phpmyadmin.net
--
-- Client :  localhost
-- Généré le :  Jeu 16 Février 2017 à 16:27
-- Version du serveur :  5.7.17-0ubuntu0.16.04.1
-- Version de PHP :  7.0.13-0ubuntu0.16.04.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `MBA`
--

-- --------------------------------------------------------

--
-- Structure de la table `Oeuvre`
--

CREATE TABLE `Oeuvre` (
  `id` int(6) NOT NULL,
  `titre` varchar(64) CHARACTER SET utf8 NOT NULL,
  `auteur` varchar(64) CHARACTER SET utf8 NOT NULL,
  `url_img` varchar(256) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `OeuvreParSondage`
--

CREATE TABLE `OeuvreParSondage` (
  `id` int(6) NOT NULL,
  `titre` varchar(64) CHARACTER SET utf8 NOT NULL,
  `auteur` varchar(64) CHARACTER SET utf8 NOT NULL,
  `url_img` varchar(256) CHARACTER SET utf8 NOT NULL,
  `sondage_id` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `Sondage`
--

CREATE TABLE `Sondage` (
  `id` int(4) NOT NULL,
  `titre` varchar(64) CHARACTER SET utf8 NOT NULL,
  `description` text CHARACTER SET utf8 NOT NULL,
  `date_debut` datetime NOT NULL,
  `date_fin` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Index pour les tables exportées
--

--
-- Index pour la table `Oeuvre`
--
ALTER TABLE `Oeuvre`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `OeuvreParSondage`
--
ALTER TABLE `OeuvreParSondage`
  ADD PRIMARY KEY (`id`),
  ADD KEY `sondage_id` (`sondage_id`);

--
-- Index pour la table `Sondage`
--
ALTER TABLE `Sondage`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `Oeuvre`
--
ALTER TABLE `Oeuvre`
  MODIFY `id` int(6) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `OeuvreParSondage`
--
ALTER TABLE `OeuvreParSondage`
  MODIFY `id` int(6) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `Sondage`
--
ALTER TABLE `Sondage`
  MODIFY `id` int(4) NOT NULL AUTO_INCREMENT;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `OeuvreParSondage`
--
ALTER TABLE `OeuvreParSondage`
  ADD CONSTRAINT `OeuvreParSondage_ibfk_1` FOREIGN KEY (`sondage_id`) REFERENCES `Sondage` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
