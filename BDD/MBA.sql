-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Jeu 13 Avril 2017 à 16:38
-- Version du serveur :  10.1.16-MariaDB
-- Version de PHP :  5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `mba`
--

-- --------------------------------------------------------

--
-- Structure de la table `oeuvre`
--

CREATE TABLE `oeuvre` (
  `id` int(6) NOT NULL,
  `titre` varchar(255) CHARACTER SET utf8 NOT NULL,
  `auteur` varchar(256) CHARACTER SET utf8 NOT NULL,
  `description` text CHARACTER SET utf8 NOT NULL,
  `url_img` varchar(256) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `oeuvre`
--

INSERT INTO `oeuvre` (`id`, `titre`, `auteur`, `description`, `url_img`) VALUES
(136, 'Enlèvement des filles de Leucippe', 'Pablo PICASSO', 'Matière et technique : Eau-forte et pointe sèche sur papier. \r\n	Mesures : Hauteur de la feuille en mm 363 ; Largeur de la feuille en mm 472 ; Hauteur de la planche en mm 223 ; Largeur de la planche en mm 330 \r\n	Inscriptions / marques : [Signé en bas à droite au crayon dans la marge] PICASSO [Numéroté en bas à gauche sous la cuvette] 42/50 [Daté en haut à droite dans la planche à l&amp;amp;amp;apos;envers] 23.5.68.I \r\n	Numéro d&amp;amp;amp;apos;inventaire : Bx 1974.2.1. \r\n	Historique : - Ancienne collection de Madame Louise LEIRIS, donnée pour la vente au profit de l&amp;amp;amp;apos;U.N.I.C.E.F., Bordeaux, 20 décembre 1973. \r\n	Mode d&amp;amp;amp;apos;acquisition Achat à la vente U.N.I.C.E.F., Bordeaux, 20 décembre 1973. ', 'http://collections-musees.bordeaux.fr/ow4/mba/images/002-049-370.JPG'),
(137, 'Olga lisant', 'Pablo PICASSO', 'Matière et technique : Huile sur toile \r\nMesures : Hauteur sans cadre en cm 100 ; Largeur sans cadre en cm 73 ; Hauteur avec cadre en cm 106 ; Largeur avec cadre en cm 79 ; \r\nInscriptions / marques : \r\nNuméro d&amp;amp;amp;apos;inventaire : MP 1990-7. Autre numéro : : Bx D 1991.9.1 \r\nHistorique : - Ancienne collection de l&amp;amp;amp;apos;artiste. - Ancienne collection Jacqueline Picasso, 1973. - Ancienne collection Catherine Hutin-Blay, 1986. - Dation à l&amp;amp;amp;apos;Etat, 1990. \r\nMode d&amp;amp;amp;apos;acquisition Affectation de la Direction des Musées de France, dépôt à durée indéterminée, 1991. ', 'http://collections-musees.bordeaux.fr/ow4/mba/images/014-099-3064.JPG'),
(138, 'Tête d&amp;amp;amp;apos;homme', 'Ferdinand Victor Léon ROYBET', 'Matière et technique : Huile sur bois. \r\nMesures : Hauteur sans cadre en cm 61 ; Largeur sans cadre en cm 50 ; Hauteur avec cadre en cm 84,8 ; Largeur avec cadre en cm 72,6 ; \r\nInscriptions / marques : [Signé en haut à droite] F. Roybet \r\nNuméro d&amp;amp;amp;apos;inventaire : Bx E 1448. Autre numéro : : Bx M 6339 \r\nHistorique : - Ancienne collection de madame Mainda . \r\nMode d&amp;amp;amp;apos;acquisition Legs Mainda, 1932.', 'http://collections-musees.bordeaux.fr/ow4/mba/images/012-031-2421.JPG'),
(139, 'Sainte Anne et la Vierge enfant', 'Charles-Victor-Eugène LEFEBVRE', 'Matière et technique : Huile sur toile \r\nMesures : Hauteur sans cadre en cm 102 ; Largeur sans cadre en cm 102,5 \r\nInscriptions / marques : [Signé en bas à droite] : C. Lefebvre \r\nNuméro d&amp;amp;amp;apos;inventaire : FNAC PFH-4887. Autre numéro : : Bx E 782, : Bx M 6578 \r\nMode d&amp;amp;amp;apos;acquisition Envoi de l&amp;amp;amp;apos;Etat, 22 mai 1883.', 'http://collections-musees.bordeaux.fr/ow4/mba/images/M8079-6980.JPG'),
(140, 'Scène romantique', 'Ferdinand Victor Léon ROYBET', 'Matière et technique : Eau-forte sur papier. \r\nMesures : Hauteur de la feuille en mm 182 ; Largeur de la feuille en mm 272 ; Hauteur de la planche en mm 125 ; Largeur de la planche en mm 171 \r\nInscriptions / marques : ( Signé en bas à droite et monogrammé à l&amp;amp;amp;apos;envers dans la planche] F. Roybet et R.F. \r\nNuméro d&amp;amp;amp;apos;inventaire : Bx M 8079. \r\nMode d&amp;amp;amp;apos;acquisition Mode et date d&amp;amp;amp;apos;acquisition inconnus.', 'http://collections-musees.bordeaux.fr/ow4/mba/images/010-010-2106.JPG'),
(141, 'Maraîchères', 'Victor-Gabriel GILBERT', 'Matière et technique : Huile sur toile \r\nMesures : Hauteur sans cadre en cm 102 ; Largeur sans cadre en cm 102,5 \r\nInscriptions / marques : [Signé en bas à droite] : C. Lefebvre \r\nNuméro d&amp;amp;amp;apos;inventaire : FNAC PFH-4887. Autre numéro : : Bx E 782, : Bx M 6578 \r\nMode d&amp;amp;amp;apos;acquisition Envoi de l&amp;amp;amp;apos;Etat, 22 mai 1883.', 'http://collections-musees.bordeaux.fr/ow4/mba/images/M1484-10215.JPG'),
(142, 'Arabes en embuscade', 'Théophile-Victor DESCLAUX', 'Matière et technique : Aquatinte sur papier \r\nMesures : Hauteur de la feuille en mm 660 ; Largeur de la feuille en mm 835 ; Hauteur de la planche en mm 440 ; Largeur de la planche en mm 575 \r\nInscriptions / marques : (Titré en bas au centre] ARABES EN EMBUSCADE (Inscription en bas à gauche] Peint par Philippoteaux (Inscription en bas à droite] Gravé par Desclaux (Inscription en bas à gauche] PARIS Publié par GOUPIL et Cie 19 Boulevard Montmartre [Inscription en bas à droite] New York - Published by GOUPIL et Cie 289 Broadway \r\nNuméro d&amp;amp;amp;apos;inventaire : Bx M 1484. \r\nHistorique : \r\nMode d&amp;amp;amp;apos;acquisition Legs Bonie, 1895.', 'http://collections-musees.bordeaux.fr/ow4/mba/images/037-1_02-8132.JPG');

-- --------------------------------------------------------

--
-- Structure de la table `oeuvreparsondage`
--

CREATE TABLE `oeuvreparsondage` (
  `id` int(6) NOT NULL,
  `titre` varchar(255) CHARACTER SET utf8 NOT NULL,
  `auteur` varchar(256) CHARACTER SET utf8 NOT NULL,
  `description` text CHARACTER SET utf8 NOT NULL,
  `url_img` varchar(256) CHARACTER SET utf8 NOT NULL,
  `sondage_id` int(4) NOT NULL,
  `nb_votes` int(8) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `oeuvreparsondage`
--

INSERT INTO `oeuvreparsondage` (`id`, `titre`, `auteur`, `description`, `url_img`, `sondage_id`, `nb_votes`) VALUES
(1, 'Cour intérieure d''une maison arabe à Alger', 'ABD AL-BARI', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://collections-musees.bordeaux.fr/ow4/mba/images/1532-6312.JPG', 1, 0),
(2, 'Portrait de magistrat', 'ALAUX', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://collections-musees.bordeaux.fr/ow4/mba/images/2007057-9607.JPG', 1, 0),
(3, 'L''accordéoniste', 'Maurice ALBE', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://collections-musees.bordeaux.fr/ow4/mba/images/8107-4178.JPG', 1, 0),
(4, 'Le Beau jardin ', 'Walid', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://www.tourismebretagne.com/var/crtbre/storage/images/media/images/a-faire/visiter/histoire-patrimoine/parcs-et-jardins/jardin-du-botrain-mur-de-bretagne/3984444-1-fre-FR/jardin-du-botrain-mur-de-bretagne_large_rwd.jpg', 1, 0),
(5, 'Le cheval', 'Maxcence', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://carlalapassiondeschevaux.unblog.fr/files/2012/07/cheval_l0ve1.jpg', 1, 0),
(6, 'Au dessus du soleil ', 'Didine', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://img.over-blog.com/500x332/5/49/79/88/numero/soleil.jpg', 2, 0),
(7, 'Le joueur', 'Loann', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://cdn.sports.fr/images/media/football/football/4600930-3-fre-FR/Football.jpg', 2, 0),
(8, 'Chambre secrète', 'Kan', 'Phasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', 'http://www.hotel-terrasses-dubailli.com/wp-content/uploads/sites/299/2015/04/TBS-Chambre-Villa-27m%C2%B2-vue-mer.jpg', 2, 0);

-- --------------------------------------------------------

--
-- Structure de la table `sondage`
--

CREATE TABLE `sondage` (
  `id` int(4) NOT NULL,
  `titre` varchar(255) CHARACTER SET utf8 NOT NULL,
  `description` text CHARACTER SET utf8 NOT NULL,
  `date_debut` datetime NOT NULL,
  `date_fin` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `sondage`
--

INSERT INTO `sondage` (`id`, `titre`, `description`, `date_debut`, `date_fin`) VALUES
(1, 'Concours mois de Mai', ' Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tempus quam justo, non ullamcorper magna consequat non. Curabitur euismod dolor sed metus pretium, vel maximus velit accumsan. In sem metus, sollicitudin varius ornare a, porta euismod elit. In non vehicula urna. Nulla et vestibulum quam. Vivamus quis nibh nunc. Suspendisse sit amet mi pellentesque, ullamcorper turpis nec, lobortis dui. Sed diam tortor, interdum nec interdum ac, faucibus eu risus. Nunc sollicitudin enim purus, id congue metus fermentum sed. Vestibulum viverra elit non vehicula porta. Donec aliquet vitae libero non vulputate. Phasellus velit ipsum, sollicitudin in urna sit amet, congue dictum arcu. Aenean in ornare risus. Donec maximus, urna sit amet accumsan feugiat, felis mi lobortis felis, eu interdum felis diam molestie quam. Integer molestie, odio nec vehicula aliquam, erat sapien volutpat nibh, vitae hendrerit est neque eu leo. Proin tempus lacus id massa luctus mollis.\r\n\r\nPhasellus bibendum metus sed lacinia sagittis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam dapibus nisl vitae tellus tempus, vel tempus mi hendrerit. Pellentesque a diam consequat, fringilla ante non, aliquet diam. In ut iaculis dolor. Etiam a varius justo. Donec ultrices nec orci vitae dignissim. Nunc placerat suscipit purus ac congue. Aliquam molestie, libero ac laoreet convallis, lectus justo feugiat odio, ut scelerisque turpis massa nec felis. ', '2017-02-01 00:00:00', '2017-02-28 01:20:00'),
(2, 'Festival histoire medieval', 'C''est la fete mardi 5 décembre au musée !', '2017-02-08 11:30:00', '2017-05-31 20:51:00');

--
-- Index pour les tables exportées
--

--
-- Index pour la table `oeuvre`
--
ALTER TABLE `oeuvre`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `titre` (`titre`),
  ADD UNIQUE KEY `titre_2` (`titre`);

--
-- Index pour la table `oeuvreparsondage`
--
ALTER TABLE `oeuvreparsondage`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `titre` (`titre`),
  ADD UNIQUE KEY `titre_2` (`titre`),
  ADD KEY `sondage_id` (`sondage_id`);

--
-- Index pour la table `sondage`
--
ALTER TABLE `sondage`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `titre` (`titre`),
  ADD UNIQUE KEY `titre_2` (`titre`),
  ADD UNIQUE KEY `titre_3` (`titre`),
  ADD UNIQUE KEY `titre_4` (`titre`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `oeuvre`
--
ALTER TABLE `oeuvre`
  MODIFY `id` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=143;
--
-- AUTO_INCREMENT pour la table `oeuvreparsondage`
--
ALTER TABLE `oeuvreparsondage`
  MODIFY `id` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT pour la table `sondage`
--
ALTER TABLE `sondage`
  MODIFY `id` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `oeuvreparsondage`
--
ALTER TABLE `oeuvreparsondage`
  ADD CONSTRAINT `OeuvreParSondage_ibfk_1` FOREIGN KEY (`sondage_id`) REFERENCES `sondage` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
