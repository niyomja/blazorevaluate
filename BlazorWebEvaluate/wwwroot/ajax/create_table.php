<?php
include('inc.ini.php');

//include('dev.ini.php');

try {
    $conn = new PDO("mysql:host=".$servername.";dbname=".$database, $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
  
    $sql = "CREATE TABLE `dev_evaluates` (
        `id` int(11) NOT NULL AUTO_INCREMENT,
        `full_name` varchar(255) NOT NULL,
        `top_level` varchar(20) NOT NULL,
        `businessAcu_level1_c1` tinyint(1) NOT NULL DEFAULT 0,
        `businessAcu_level1_c2` tinyint(1) NOT NULL DEFAULT 0,
        `businessAcu_level1_c3` tinyint(1) NOT NULL DEFAULT 0,
        `businessAcu_level1_c4` tinyint(1) NOT NULL DEFAULT 0,
        `businessAcu_level3_c1` tinyint(1) NOT NULL DEFAULT 0,
        `businessAcu_level3_c2` tinyint(1) NOT NULL DEFAULT 0,
        `businessAcu_level3_c3` tinyint(1) NOT NULL DEFAULT 0,
        `businessAcu_level3_c4` tinyint(1) NOT NULL DEFAULT 0,
        `businessAcu_level5_c1` tinyint(1) NOT NULL DEFAULT 0,
        `businessAcu_level5_c2` tinyint(1) NOT NULL DEFAULT 0,
        `businessAcu_level5_c3` tinyint(1) NOT NULL DEFAULT 0,
        `businessAcu_level5_c4` tinyint(1) NOT NULL DEFAULT 0,
        `initiative_level1_c1` tinyint(1) NOT NULL DEFAULT 0,
        `initiative_level1_c2` tinyint(1) NOT NULL DEFAULT 0,
        `initiative_level1_c3` tinyint(1) NOT NULL DEFAULT 0,
        `initiative_level3_c1` tinyint(1) NOT NULL DEFAULT 0,
        `initiative_level3_c2` tinyint(1) NOT NULL DEFAULT 0,
        `initiative_level3_c3` tinyint(1) NOT NULL DEFAULT 0,
        `initiative_level3_c4` tinyint(1) NOT NULL DEFAULT 0,
        `initiative_level3_c5` tinyint(1) NOT NULL DEFAULT 0,
        `initiative_level5_c1` tinyint(1) NOT NULL DEFAULT 0,
        `initiative_level5_c2` tinyint(1) NOT NULL DEFAULT 0,
        `initiative_level5_c3` tinyint(1) NOT NULL DEFAULT 0,
        `collaboration_level1_c1` tinyint(1) NOT NULL DEFAULT 0,
        `collaboration_level1_c2` tinyint(1) NOT NULL DEFAULT 0,
        `collaboration_level1_c3` tinyint(1) NOT NULL DEFAULT 0,
        `collaboration_level3_c1` tinyint(1) NOT NULL DEFAULT 0,
        `collaboration_level3_c2` tinyint(1) NOT NULL DEFAULT 0,
        `collaboration_level3_c3` tinyint(1) NOT NULL DEFAULT 0,
        `collaboration_level3_c4` tinyint(1) NOT NULL DEFAULT 0,
        `collaboration_level5_c1` tinyint(1) NOT NULL DEFAULT 0,
        `collaboration_level5_c2` tinyint(1) NOT NULL DEFAULT 0,
        `collaboration_level5_c3` tinyint(1) NOT NULL DEFAULT 0,
        `collaboration_level5_c4` tinyint(1) NOT NULL DEFAULT 0,
        `serviceExcellence_level1_c1` tinyint(1) NOT NULL DEFAULT 0,
        `serviceExcellence_level1_c2` tinyint(1) NOT NULL DEFAULT 0,
        `serviceExcellence_level1_c3` tinyint(1) NOT NULL DEFAULT 0,
        `serviceExcellence_level3_c1` tinyint(1) NOT NULL DEFAULT 0,
        `serviceExcellence_level3_c2` tinyint(1) NOT NULL DEFAULT 0,
        `serviceExcellence_level3_c3` tinyint(1) NOT NULL DEFAULT 0,
        `serviceExcellence_level5_c1` tinyint(1) NOT NULL DEFAULT 0,
        `serviceExcellence_level5_c2` tinyint(1) NOT NULL DEFAULT 0,
        `serviceExcellence_level5_c3` tinyint(1) NOT NULL DEFAULT 0,
        `serviceExcellence_level5_c4` tinyint(1) NOT NULL DEFAULT 0,
        `serviceExcellence_level5_c5` tinyint(1) NOT NULL DEFAULT 0,
        `safetyAndSecurity_level1_c1` tinyint(1) NOT NULL DEFAULT 0,
        `safetyAndSecurity_level1_c2` tinyint(1) NOT NULL DEFAULT 0,
        `safetyAndSecurity_level1_c3` tinyint(1) NOT NULL DEFAULT 0,
        `safetyAndSecurity_level3_c1` tinyint(1) NOT NULL DEFAULT 0,
        `safetyAndSecurity_level3_c2` tinyint(1) NOT NULL DEFAULT 0,
        `safetyAndSecurity_level3_c3` tinyint(1) NOT NULL DEFAULT 0,
        `safetyAndSecurity_level3_c4` tinyint(1) NOT NULL DEFAULT 0,
        `safetyAndSecurity_level5_c1` tinyint(1) NOT NULL DEFAULT 0,
        `safetyAndSecurity_level5_c2` tinyint(1) NOT NULL DEFAULT 0,
        `safetyAndSecurity_level5_c3` tinyint(1) NOT NULL DEFAULT 0,
        `safetyAndSecurity_level5_c4` tinyint(1) NOT NULL DEFAULT 0,
        `digitalLiteracy_level1_c1` tinyint(1) NOT NULL DEFAULT 0,
        `digitalLiteracy_level1_c2` tinyint(1) NOT NULL DEFAULT 0,
        `digitalLiteracy_level1_c3` tinyint(1) NOT NULL DEFAULT 0,
        `digitalLiteracy_level3_c1` tinyint(1) NOT NULL DEFAULT 0,
        `digitalLiteracy_level3_c2` tinyint(1) NOT NULL DEFAULT 0,
        `digitalLiteracy_level3_c3` tinyint(1) NOT NULL DEFAULT 0,
        `digitalLiteracy_level3_c4` tinyint(1) NOT NULL DEFAULT 0,
        `digitalLiteracy_level5_c1` tinyint(1) NOT NULL DEFAULT 0,
        `digitalLiteracy_level5_c2` tinyint(1) NOT NULL DEFAULT 0,
        `digitalLiteracy_level5_c3` tinyint(1) NOT NULL DEFAULT 0,
        `digitalLiteracy_level5_c4` tinyint(1) NOT NULL DEFAULT 0,
        PRIMARY KEY (`id`),
        UNIQUE KEY `id_UNIQUE` (`id`)
      )DEFAULT CHARSET=utf8;";

    $conn->exec($sql);

    echo "execute command successfully";

    $conn->close();
}catch (PDOException $e) {
    echo "Connection failed: " . $e->getMessage();
}

?>