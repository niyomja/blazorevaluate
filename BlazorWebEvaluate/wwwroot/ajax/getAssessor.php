<?php
header("Content-Type: application/json;charset=UTF-8");

include('inc.ini.php');

//include('dev.ini.php');

if(isset($_GET['code'])){
    try {
        $conn = new PDO("mysql:host=$servername;dbname=$database;charset=utf8", $username, $password);
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

        $stmt = $conn->prepare("SELECT * FROM `aot_employees` WHERE `code`=:code");

        $stmt->bindParam(':code', $code);

        $code = $_GET['code'];

        $stmt->execute();
      
        // set the resulting array to associative

        $result = $stmt->setFetchMode(PDO::FETCH_ASSOC);
    
        $data = $stmt->fetch();
        
        echo json_encode($data);
    
        $conn = null;
    } catch (PDOException $e) {
        $data = ["code"=>"", "full_name"=>"", "division"=>"", "level"=>""];
        echo json_encode($data);
    }
}else{
    echo json_encode([]);
}
?>