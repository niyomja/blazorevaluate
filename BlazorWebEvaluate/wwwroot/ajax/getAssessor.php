<?php
header("Content-Type: application/json;charset=UTF-8");

include('inc.ini.php');

//include('dev.ini.php');

if(isset($_GET['full_name']) && isset($_GET['secret_code'])){
    try {
        $conn = new PDO("mysql:host=$servername;dbname=$database", $username, $password);
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

        $stmt = $conn->prepare("SELECT `personal_id` as `id`,  `full_name`, `security_code` as `secret_code` FROM `pdo_persons` WHERE `full_name`=:full_name AND `security_code`=:security_code");

        $stmt->bindParam(':full_name', $full_name);
        $stmt->bindParam(':security_code', $security_code);

        $full_name = $_GET['full_name'];
        $security_code = $_GET['secret_code'];

        $stmt->execute();
      
        // set the resulting array to associative
        $result = $stmt->setFetchMode(PDO::FETCH_ASSOC);
    
        $data = $stmt->fetch();

        if(!$data){
            $stmt2 = $conn->prepare("INSERT INTO pdo_persons (full_name, security_code) VALUES (:full_name, :security_code)");

            $stmt2->bindParam(':full_name', $full_name);
            $stmt2->bindParam(':security_code', $security_code);

            $full_name = $_GET['full_name'];
            $secret_code = $_GET['secret_code'];

            $stmt2->execute();

            $last_id = $conn->lastInsertId();

            $data = ['id'=>$last_id, 'full_name'=>$full_name, 'secret_code'=> $secret_code];
        }
        
        echo json_encode($data);
    
        $conn = null;
    } catch (PDOException $e) {
        $data = ['id'=>0, 'full_name'=>"", 'secret_code'=>""];
        echo json_encode($data);
    }
}else{
    echo json_encode([]);
}
?>