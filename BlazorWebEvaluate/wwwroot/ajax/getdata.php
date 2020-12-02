<?php
header("Content-Type: application/json;charset=UTF-8");

include('inc.ini.php');

//include('dev.ini.php');

try {
    $conn = new PDO("mysql:host=$servername;dbname=$database", $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

    if (isset($_GET['person_id'])) {
        $stmt = $conn->prepare("SELECT * FROM `pdo_evaluates` WHERE person_id=:person_id ORDER BY `full_name` ASC");
        $stmt->bindParam(":person_id", $person_id);
        $person_id = $_GET['person_id'];
    }else{
        $stmt = $conn->prepare("SELECT * FROM `pdo_evaluates` WHERE person_id=0 ORDER BY `full_name` ASC");
    }
    $stmt->execute();
  
    // set the resulting array to associative
    $result = $stmt->setFetchMode(PDO::FETCH_ASSOC);

    $data = $stmt->fetchAll();
    
    echo json_encode($data, JSON_NUMERIC_CHECK);

    $conn = null;
} catch (PDOException $e) {
    echo json_encode([]);
}