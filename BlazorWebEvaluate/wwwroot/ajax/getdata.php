<?php
header("Content-Type: application/json;charset=UTF-8");

include('inc.ini.php');

//include('dev.ini.php');

try {
    $conn = new PDO("mysql:host=$servername;dbname=$database;charset=utf8", $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    $conn->setAttribute(PDO::ATTR_STRINGIFY_FETCHES, false);

    if (isset($_GET['assessor_code'])) {
        $stmt = $conn->prepare("SELECT * FROM `aot_evaluates` WHERE assessor_code=:assessor_code ORDER BY `full_name` ASC");
        $stmt->bindParam(":assessor_code", $assessor_code);
        $assessor_code = $_GET['assessor_code'];
    }else{
        $stmt = $conn->prepare("SELECT * FROM `aot_evaluates` WHERE assessor_code='' ORDER BY `full_name` ASC");
    }
    $stmt->execute();
  
    // set the resulting array to associative
    $result = $stmt->setFetchMode(PDO::FETCH_ASSOC);

    $data = $stmt->fetchAll();

    echo json_encode($data);

    $conn = null;
} catch (PDOException $e) {
    echo json_encode([]);
}