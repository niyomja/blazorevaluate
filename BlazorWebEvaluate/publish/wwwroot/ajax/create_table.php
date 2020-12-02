<?php
include('inc.ini.php');

//include('dev.ini.php');

try {
    $conn = new PDO("mysql:host=".$servername.";dbname=".$database, $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
  
    $sql = "CREATE TABLE `pdo_persons` (
        `personal_id` int(11) NOT NULL AUTO_INCREMENT,
        `full_name` text NOT NULL,
        `security_code` text NOT NULL,
        PRIMARY KEY (`personal_id`)
      ) DEFAULT CHARSET=utf8;";

    $conn->exec($sql);

    $sql2 = "CREATE TABLE `pdo_evaluates` (
        `Id` int(11) NOT NULL AUTO_INCREMENT,
        `full_name` text NOT NULL,
        `top_level` text NOT NULL,
        `businessAcu_level1_c1` int(11) NOT NULL,
        `businessAcu_level1_c2` int(11) NOT NULL,
        `businessAcu_level1_c3` int(11) NOT NULL,
        `businessAcu_level1_c4` int(11) NOT NULL,
        `businessAcu_level3_c1` int(11) NOT NULL,
        `businessAcu_level3_c2` int(11) NOT NULL,
        `businessAcu_level3_c3` int(11) NOT NULL,
        `businessAcu_level3_c4` int(11) NOT NULL,
        `businessAcu_level5_c1` int(11) NOT NULL,
        `businessAcu_level5_c2` int(11) NOT NULL,
        `businessAcu_level5_c3` int(11) NOT NULL,
        `businessAcu_level5_c4` int(11) NOT NULL,
        `initiative_level1_c1` int(11) NOT NULL,
        `initiative_level1_c2` int(11) NOT NULL,
        `initiative_level1_c3` int(11) NOT NULL,
        `initiative_level3_c1` int(11) NOT NULL,
        `initiative_level3_c2` int(11) NOT NULL,
        `initiative_level3_c3` int(11) NOT NULL,
        `initiative_level3_c4` int(11) NOT NULL,
        `initiative_level3_c5` int(11) NOT NULL,
        `initiative_level5_c1` int(11) NOT NULL,
        `initiative_level5_c2` int(11) NOT NULL,
        `initiative_level5_c3` int(11) NOT NULL,
        `collaboration_level1_c1` int(11) NOT NULL,
        `collaboration_level1_c2` int(11) NOT NULL,
        `collaboration_level1_c3` int(11) NOT NULL,
        `collaboration_level3_c1` int(11) NOT NULL,
        `collaboration_level3_c2` int(11) NOT NULL,
        `collaboration_level3_c3` int(11) NOT NULL,
        `collaboration_level3_c4` int(11) NOT NULL,
        `collaboration_level5_c1` int(11) NOT NULL,
        `collaboration_level5_c2` int(11) NOT NULL,
        `collaboration_level5_c3` int(11) NOT NULL,
        `collaboration_level5_c4` int(11) NOT NULL,
        `serviceExcellence_level1_c1` int(11) NOT NULL,
        `serviceExcellence_level1_c2` int(11) NOT NULL,
        `serviceExcellence_level1_c3` int(11) NOT NULL,
        `serviceExcellence_level3_c1` int(11) NOT NULL,
        `serviceExcellence_level3_c2` int(11) NOT NULL,
        `serviceExcellence_level3_c3` int(11) NOT NULL,
        `serviceExcellence_level5_c1` int(11) NOT NULL,
        `serviceExcellence_level5_c2` int(11) NOT NULL,
        `serviceExcellence_level5_c3` int(11) NOT NULL,
        `serviceExcellence_level5_c4` int(11) NOT NULL,
        `serviceExcellence_level5_c5` int(11) NOT NULL,
        `safetyAndSecurity_level1_c1` int(11) NOT NULL,
        `safetyAndSecurity_level1_c2` int(11) NOT NULL,
        `safetyAndSecurity_level1_c3` int(11) NOT NULL,
        `safetyAndSecurity_level3_c1` int(11) NOT NULL,
        `safetyAndSecurity_level3_c2` int(11) NOT NULL,
        `safetyAndSecurity_level3_c3` int(11) NOT NULL,
        `safetyAndSecurity_level3_c4` int(11) NOT NULL,
        `safetyAndSecurity_level5_c1` int(11) NOT NULL,
        `safetyAndSecurity_level5_c2` int(11) NOT NULL,
        `safetyAndSecurity_level5_c3` int(11) NOT NULL,
        `safetyAndSecurity_level5_c4` int(11) NOT NULL,
        `digitalLiteracy_level1_c1` int(11) NOT NULL,
        `digitalLiteracy_level1_c2` int(11) NOT NULL,
        `digitalLiteracy_level1_c3` int(11) NOT NULL,
        `digitalLiteracy_level3_c1` int(11) NOT NULL,
        `digitalLiteracy_level3_c2` int(11) NOT NULL,
        `digitalLiteracy_level3_c3` int(11) NOT NULL,
        `digitalLiteracy_level3_c4` int(11) NOT NULL,
        `digitalLiteracy_level5_c1` int(11) NOT NULL,
        `digitalLiteracy_level5_c2` int(11) NOT NULL,
        `digitalLiteracy_level5_c3` int(11) NOT NULL,
        `digitalLiteracy_level5_c4` int(11) NOT NULL,
        `person_id` int(11) NOT NULL,
        PRIMARY KEY (`Id`),
        KEY `IX_Evaluates_person_id` (`person_id`),
        CONSTRAINT `FK_Evaluates_Persons_person_id` FOREIGN KEY (`person_id`) REFERENCES `pdo_persons` (`personal_id`) ON DELETE CASCADE
      ) DEFAULT CHARSET=utf8;";

    $conn->exec($sql2);

    echo "execute command successfully";

    $conn->close();
}catch (PDOException $e) {
    echo "Connection failed: " . $e->getMessage();
}

?>