<?php
include('inc.ini.php');

//include('dev.ini.php');

try {
    $conn = new PDO("mysql:host=".$servername.";dbname=".$database, $username, $password.";charset=utf8");
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
  
    $sql = "CREATE TABLE `aot_employees` (
        `code` varchar(20) NOT NULL DEFAULT '',
        `full_name` varchar(255) NOT NULL DEFAULT '',
         `division` varchar(255) NOT NULL,
        `level` varchar(20) NOT NULL DEFAULT '',
        PRIMARY KEY (`code`),
         UNIQUE KEY `employees_code_unique` (`code`)
        ) DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;";

    $conn->exec($sql);

    $sql2 = "CREATE TABLE `aot_evaluates` (
        `Id` int(11) NOT NULL AUTO_INCREMENT,
        `full_name` text NOT NULL,
        `top_level` text NOT NULL,

        `assessor_code` varchar(20) NOT NULL DEFAULT '',

        `leadership_level1_c1` tinyint(1) NOT NULL,
        `leadership_level1_c2` tinyint(1) NOT NULL,
        `leadership_level1_c3` tinyint(1) NOT NULL,
        `leadership_level3_c1` tinyint(1) NOT NULL,
        `leadership_level3_c2` tinyint(1) NOT NULL,
        `leadership_level3_c3` tinyint(1) NOT NULL,
        `leadership_level5_c1` tinyint(1) NOT NULL,
        `leadership_level5_c2` tinyint(1) NOT NULL,
        `leadership_level5_c3` tinyint(1) NOT NULL,
        `leadership_level5_c4` tinyint(1) NOT NULL,

        `businessManagement_level1_c1` tinyint(1) NOT NULL,
        `businessManagement_level1_c2` tinyint(1) NOT NULL,
        `businessManagement_level1_c3` tinyint(1) NOT NULL,
        `businessManagement_level1_c4` tinyint(1) NOT NULL,
        `businessManagement_level3_c1` tinyint(1) NOT NULL,
        `businessManagement_level3_c2` tinyint(1) NOT NULL,
        `businessManagement_level3_c3` tinyint(1) NOT NULL,
        `businessManagement_level5_c1` tinyint(1) NOT NULL,
        `businessManagement_level5_c2` tinyint(1) NOT NULL,
        `businessManagement_level5_c3` tinyint(1) NOT NULL,
        `businessManagement_level5_c4` tinyint(1) NOT NULL,

        `changeCatalyst_level1_c1` tinyint(1) NOT NULL,
        `changeCatalyst_level1_c2` tinyint(1) NOT NULL,
        `changeCatalyst_level1_c3` tinyint(1) NOT NULL,
        `changeCatalyst_level1_c4` tinyint(1) NOT NULL,
        `changeCatalyst_level1_c5` tinyint(1) NOT NULL,
        `changeCatalyst_level3_c1` tinyint(1) NOT NULL,
        `changeCatalyst_level3_c2` tinyint(1) NOT NULL,
        `changeCatalyst_level3_c3` tinyint(1) NOT NULL,
        `changeCatalyst_level3_c4` tinyint(1) NOT NULL,
        `changeCatalyst_level3_c5` tinyint(1) NOT NULL,
        `changeCatalyst_level5_c1` tinyint(1) NOT NULL,
        `changeCatalyst_level5_c2` tinyint(1) NOT NULL,
        `changeCatalyst_level5_c3` tinyint(1) NOT NULL,
        `changeCatalyst_level5_c4` tinyint(1) NOT NULL,
        `changeCatalyst_level5_c5` tinyint(1) NOT NULL,

        `cSRforSustainable_level1_c1` tinyint(1) NOT NULL,
        `cSRforSustainable_level1_c2` tinyint(1) NOT NULL,
        `cSRforSustainable_level1_c3` tinyint(1) NOT NULL,
        `cSRforSustainable_level1_c4` tinyint(1) NOT NULL,
        `cSRforSustainable_level3_c1` tinyint(1) NOT NULL,
        `cSRforSustainable_level3_c2` tinyint(1) NOT NULL,
        `cSRforSustainable_level3_c3` tinyint(1) NOT NULL,
        `cSRforSustainable_level3_c4` tinyint(1) NOT NULL,
        `cSRforSustainable_level5_c1` tinyint(1) NOT NULL,
        `cSRforSustainable_level5_c2` tinyint(1) NOT NULL,
        `cSRforSustainable_level5_c3` tinyint(1) NOT NULL,
        `cSRforSustainable_level5_c4` tinyint(1) NOT NULL,
        PRIMARY KEY (`Id`)
        ) DEFAULT CHARSET=utf8;";

    $conn->exec($sql2);

    echo "execute command successfully";

    //$conn->close();
}catch (PDOException $e) {
    echo "Connection failed: " . $e->getMessage();
}

?>