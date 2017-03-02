-- phpMyAdmin SQL Dump
-- version 4.5.4.1deb2ubuntu2
-- http://www.phpmyadmin.net
--
-- Client :  localhost
-- Généré le :  Jeu 02 Mars 2017 à 15:46
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
  `description` text CHARACTER SET utf8 NOT NULL,
  `url_img` varchar(256) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `Oeuvre`
--

INSERT INTO `Oeuvre` (`id`, `titre`, `auteur`, `description`, `url_img`) VALUES
(1, 'Cour intérieure d\'une maison arabe à Alger', 'ABD AL-BARI', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://collections-musees.bordeaux.fr/ow4/mba/images/1532-6312.JPG'),
(2, 'Portrait de magistrat', 'ALAUX', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://collections-musees.bordeaux.fr/ow4/mba/images/2007057-9607.JPG'),
(3, 'L\'accordéoniste', 'Maurice ALBE', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://collections-musees.bordeaux.fr/ow4/mba/images/8107-4178.JPG'),
(4, 'Le Beau jardin ', 'Walid', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://www.tourismebretagne.com/var/crtbre/storage/images/media/images/a-faire/visiter/histoire-patrimoine/parcs-et-jardins/jardin-du-botrain-mur-de-bretagne/3984444-1-fre-FR/jardin-du-botrain-mur-de-bretagne_large_rwd.jpg'),
(5, 'Le cheval', 'Maxcence', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://carlalapassiondeschevaux.unblog.fr/files/2012/07/cheval_l0ve1.jpg'),
(6, 'Au dessus du soleil ', 'Didine', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://img.over-blog.com/500x332/5/49/79/88/numero/soleil.jpg'),
(7, 'Le joueur', 'Loann', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://cdn.sports.fr/images/media/football/football/4600930-3-fre-FR/Football.jpg'),
(8, 'Chambre secrète', 'Kan', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://www.hotel-terrasses-dubailli.com/wp-content/uploads/sites/299/2015/04/TBS-Chambre-Villa-27m%C2%B2-vue-mer.jpg');

-- --------------------------------------------------------

--
-- Structure de la table `OeuvreParSondage`
--

CREATE TABLE `OeuvreParSondage` (
  `id` int(6) NOT NULL,
  `titre` varchar(64) CHARACTER SET utf8 NOT NULL,
  `auteur` varchar(64) CHARACTER SET utf8 NOT NULL,
  `description` text CHARACTER SET utf8 NOT NULL,
  `url_img` varchar(256) CHARACTER SET utf8 NOT NULL,
  `sondage_id` int(4) NOT NULL,
  `nb_votes` int(8) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `OeuvreParSondage`
--

INSERT INTO `OeuvreParSondage` (`id`, `titre`, `auteur`, `description`, `url_img`, `sondage_id`, `nb_votes`) VALUES
(1, 'Cour intérieure d\'une maison arabe à Alger', 'ABD AL-BARI', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://collections-musees.bordeaux.fr/ow4/mba/images/1532-6312.JPG', 1, 0),
(2, 'Portrait de magistrat', 'ALAUX', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://collections-musees.bordeaux.fr/ow4/mba/images/2007057-9607.JPG', 1, 0),
(3, 'L\'accordéoniste', 'Maurice ALBE', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://collections-musees.bordeaux.fr/ow4/mba/images/8107-4178.JPG', 1, 0),
(4, 'Le Beau jardin ', 'Walid', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://www.tourismebretagne.com/var/crtbre/storage/images/media/images/a-faire/visiter/histoire-patrimoine/parcs-et-jardins/jardin-du-botrain-mur-de-bretagne/3984444-1-fre-FR/jardin-du-botrain-mur-de-bretagne_large_rwd.jpg', 1, 0),
(5, 'Le cheval', 'Maxcence', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://carlalapassiondeschevaux.unblog.fr/files/2012/07/cheval_l0ve1.jpg', 1, 0),
(6, 'Au dessus du soleil ', 'Didine', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://img.over-blog.com/500x332/5/49/79/88/numero/soleil.jpg', 2, 0),
(7, 'Le joueur', 'Loann', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://cdn.sports.fr/images/media/football/football/4600930-3-fre-FR/Football.jpg', 2, 0),
(8, 'Chambre secrète', 'Kan', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://www.hotel-terrasses-dubailli.com/wp-content/uploads/sites/299/2015/04/TBS-Chambre-Villa-27m%C2%B2-vue-mer.jpg', 2, 0);

-- --------------------------------------------------------

--
-- Structure de la table `Sondage`
--

CREATE TABLE `Sondage` (
  `id` int(4) NOT NULL,
  `titre` varchar(64) CHARACTER SET utf8 NOT NULL,
  `description` text CHARACTER SET utf8 NOT NULL,
  `date_debut` datetime NOT NULL,
  `date_fin` datetime NOT NULL,
  `en_cours` int(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `Sondage`
--

INSERT INTO `Sondage` (`id`, `titre`, `description`, `date_debut`, `date_fin`, `en_cours`) VALUES
(1, 'Concours mois de Mai', ' Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tempus quam justo, non ullamcorper magna consequat non. Curabitur euismod dolor sed metus pretium, vel maximus velit accumsan. In sem metus, sollicitudin varius ornare a, porta euismod elit. In non vehicula urna. Nulla et vestibulum quam. Vivamus quis nibh nunc. Suspendisse sit amet mi pellentesque, ullamcorper turpis nec, lobortis dui. Sed diam tortor, interdum nec interdum ac, faucibus eu risus. Nunc sollicitudin enim purus, id congue metus fermentum sed. Vestibulum viverra elit non vehicula porta. Donec aliquet vitae libero non vulputate. Phasellus velit ipsum, sollicitudin in urna sit amet, congue dictum arcu. Aenean in ornare risus. Donec maximus, urna sit amet accumsan feugiat, felis mi lobortis felis, eu interdum felis diam molestie quam. Integer molestie, odio nec vehicula aliquam, erat sapien volutpat nibh, vitae hendrerit est neque eu leo. Proin tempus lacus id massa luctus mollis.\r\n\r\nPhasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', '2017-02-01 00:00:00', '2017-02-28 01:20:00', 0),
(2, 'Festival histoire medieval', 'C\'est la fete mardi 5 décembre au musée !', '2017-02-08 11:30:00', '2017-05-31 20:51:00', 0);

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
  MODIFY `id` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT pour la table `OeuvreParSondage`
--
ALTER TABLE `OeuvreParSondage`
  MODIFY `id` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT pour la table `Sondage`
--
ALTER TABLE `Sondage`
  MODIFY `id` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
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
