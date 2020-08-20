<?php
include('inc.ini.php');

//include('dev.ini.php');

try {
    $conn = new PDO("mysql:host=".$servername.";dbname=".$database, $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
  
    $sql = "";

    $conn->exec($sql);

    echo "execute command successfully";

    $conn->close();
}catch (PDOException $e) {
    echo "Connection failed: " . $e->getMessage();
}

?>