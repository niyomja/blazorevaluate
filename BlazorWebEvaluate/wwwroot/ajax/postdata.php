<?php
header('Content-Type: application/json');

include('inc.ini.php');

//include('dev.ini.php');

 $json_data = @file_get_contents('php://input');

if ($json_data) {
    try {
        $data = @json_decode($json_data);

        if (!$data) {
            echo json_encode(["success"=>false, "message"=>"Data not null!"]);
            exit;
        }

        $conn = new PDO("mysql:host=$servername;dbname=$database", $username, $password);
        // set the PDO error mode to exception
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

        // prepare sql and bind parameters
        $stmt = $conn->prepare("INSERT INTO `dev_evaluates` 
        (
        `full_name`,
        `top_level`,
        `businessacu_level1_c1`,
        `businessacu_level1_c2`,
        `businessacu_level1_c3`,
        `businessacu_level1_c4`,
        `businessacu_level3_c1`,
        `businessacu_level3_c2`,
        `businessacu_level3_c3`,
        `businessacu_level3_c4`,
        `businessacu_level5_c1`,
        `businessacu_level5_c2`,
        `businessacu_level5_c3`,
        `businessacu_level5_c4`,
        `initiative_level1_c1`,
        `initiative_level1_c2`,
        `initiative_level1_c3`,
        `initiative_level3_c1`,
        `initiative_level3_c2`,
        `initiative_level3_c3`,
        `initiative_level3_c4`,
        `initiative_level3_c5`,
        `initiative_level5_c1`,
        `initiative_level5_c2`,
        `initiative_level5_c3`,
        `collaboration_level1_c1`,
        `collaboration_level1_c2`,
        `collaboration_level1_c3`,
        `collaboration_level3_c1`,
        `collaboration_level3_c2`,
        `collaboration_level3_c3`,
        `collaboration_level3_c4`,
        `collaboration_level5_c1`,
        `collaboration_level5_c2`,
        `collaboration_level5_c3`,
        `collaboration_level5_c4`,
        `serviceexcellence_level1_c1`,
        `serviceexcellence_level1_c2`,
        `serviceexcellence_level1_c3`,
        `serviceexcellence_level3_c1`,
        `serviceexcellence_level3_c2`,
        `serviceexcellence_level3_c3`,
        `serviceexcellence_level5_c1`,
        `serviceexcellence_level5_c2`,
        `serviceexcellence_level5_c3`,
        `serviceexcellence_level5_c4`,
        `serviceexcellence_level5_c5`,
        `safetyandsecurity_level1_c1`,
        `safetyandsecurity_level1_c2`,
        `safetyandsecurity_level1_c3`,
        `safetyandsecurity_level3_c1`,
        `safetyandsecurity_level3_c2`,
        `safetyandsecurity_level3_c3`,
        `safetyandsecurity_level3_c4`,
        `safetyandsecurity_level5_c1`,
        `safetyandsecurity_level5_c2`,
        `safetyandsecurity_level5_c3`,
        `safetyandsecurity_level5_c4`,
        `digitalliteracy_level1_c1`,
        `digitalliteracy_level1_c2`,
        `digitalliteracy_level1_c3`,
        `digitalliteracy_level3_c1`,
        `digitalliteracy_level3_c2`,
        `digitalliteracy_level3_c3`,
        `digitalliteracy_level3_c4`,
        `digitalliteracy_level5_c1`,
        `digitalliteracy_level5_c2`,
        `digitalliteracy_level5_c3`,
        `digitalliteracy_level5_c4`)
        VALUES(
        :full_name,
        :top_level,
        :va1,
        :va2,
        :va3,
        :va31,
        :va4,
        :va5,
        :va6,
        :va7,
        :va8,
        :va9,
        :va10,
        :va11,
        :initiative_level1_c1,
        :initiative_level1_c2,
        :initiative_level1_c3,
        :initiative_level3_c1,
        :initiative_level3_c2,
        :initiative_level3_c3,
        :initiative_level3_c4,
        :initiative_level3_c5,
        :initiative_level5_c1,
        :initiative_level5_c2,
        :initiative_level5_c3,
        :collaboration_level1_c1,
        :collaboration_level1_c2,
        :collaboration_level1_c3,
        :collaboration_level3_c1,
        :collaboration_level3_c2,
        :collaboration_level3_c3,
        :collaboration_level3_c4,
        :collaboration_level5_c1,
        :collaboration_level5_c2,
        :collaboration_level5_c3,
        :collaboration_level5_c4,
        :serviceexcellence_level1_c1,
        :serviceexcellence_level1_c2,
        :serviceexcellence_level1_c3,
        :serviceexcellence_level3_c1,
        :serviceexcellence_level3_c2,
        :serviceexcellence_level3_c3,
        :serviceexcellence_level5_c1,
        :serviceexcellence_level5_c2,
        :serviceexcellence_level5_c3,
        :serviceexcellence_level5_c4,
        :serviceexcellence_level5_c5,
        :safetyandsecurity_level1_c1,
        :safetyandsecurity_level1_c2,
        :safetyandsecurity_level1_c3,
        :safetyandsecurity_level3_c1,
        :safetyandsecurity_level3_c2,
        :safetyandsecurity_level3_c3,
        :safetyandsecurity_level3_c4,
        :safetyandsecurity_level5_c1,
        :safetyandsecurity_level5_c2,
        :safetyandsecurity_level5_c3,
        :safetyandsecurity_level5_c4,
        :digitalliteracy_level1_c1,
        :digitalliteracy_level1_c2,
        :digitalliteracy_level1_c3,
        :digitalliteracy_level3_c1,
        :digitalliteracy_level3_c2,
        :digitalliteracy_level3_c3,
        :digitalliteracy_level3_c4,
        :digitalliteracy_level5_c1,
        :digitalliteracy_level5_c2,
        :digitalliteracy_level5_c3,
        :digitalliteracy_level5_c4)");

        $stmt->bindParam(':full_name', $data->full_name);
        $stmt->bindParam(':top_level', $data->level);

        $stmt->bindParam(":va1", $businessAcu_level1_c1);
        $stmt->bindParam(":va2", $businessAcu_level1_c2);
        $stmt->bindParam(":va3", $businessAcu_level1_c3);
        $stmt->bindParam(":va31", $businessAcu_level1_c4);

        $stmt->bindParam(":va4", $businessAcu_level3_c1);
        $stmt->bindParam(":va5", $businessAcu_level3_c2);
        $stmt->bindParam(":va6", $businessAcu_level3_c3);
        $stmt->bindParam(":va7", $businessAcu_level3_c4);
        $stmt->bindParam(":va8", $businessAcu_level5_c1);
        $stmt->bindParam(":va9", $businessAcu_level5_c2);
        $stmt->bindParam(":va10", $businessAcu_level5_c3);
        $stmt->bindParam(":va11", $businessAcu_level5_c4);

        $stmt->bindParam(":initiative_level1_c1", $initiative_level1_c1);
        $stmt->bindParam(":initiative_level1_c2", $initiative_level1_c2);
        $stmt->bindParam(":initiative_level1_c3", $initiative_level1_c3);
        $stmt->bindParam(":initiative_level3_c1", $initiative_level3_c1);
        $stmt->bindParam(":initiative_level3_c2", $initiative_level3_c2);
        $stmt->bindParam(":initiative_level3_c3", $initiative_level3_c3);
        $stmt->bindParam(":initiative_level3_c4", $initiative_level3_c4);
        $stmt->bindParam(":initiative_level3_c5", $initiative_level3_c5);
        $stmt->bindParam(":initiative_level5_c1", $initiative_level5_c1);
        $stmt->bindParam(":initiative_level5_c2", $initiative_level5_c2);
        $stmt->bindParam(":initiative_level5_c3", $initiative_level5_c3);

        $stmt->bindParam(":collaboration_level1_c1", $collaboration_level1_c1);
        $stmt->bindParam(":collaboration_level1_c2", $collaboration_level1_c2);
        $stmt->bindParam(":collaboration_level1_c3", $collaboration_level1_c3);
        $stmt->bindParam(":collaboration_level3_c1", $collaboration_level3_c1);
        $stmt->bindParam(":collaboration_level3_c2", $collaboration_level3_c2);
        $stmt->bindParam(":collaboration_level3_c3", $collaboration_level3_c3);
        $stmt->bindParam(":collaboration_level3_c4", $collaboration_level3_c4);
        $stmt->bindParam(":collaboration_level5_c1", $collaboration_level5_c1);
        $stmt->bindParam(":collaboration_level5_c2", $collaboration_level5_c2);
        $stmt->bindParam(":collaboration_level5_c3", $collaboration_level5_c3);
        $stmt->bindParam(":collaboration_level5_c4", $collaboration_level5_c4);

        $stmt->bindParam(":serviceexcellence_level1_c1", $serviceexcellence_level1_c1);
        $stmt->bindParam(":serviceexcellence_level1_c2", $serviceexcellence_level1_c2);
        $stmt->bindParam(":serviceexcellence_level1_c3", $serviceexcellence_level1_c3);

        $stmt->bindParam(":serviceexcellence_level3_c1", $serviceexcellence_level3_c1);
        $stmt->bindParam(":serviceexcellence_level3_c2", $serviceexcellence_level3_c2);
        $stmt->bindParam(":serviceexcellence_level3_c3", $serviceexcellence_level3_c3);

        $stmt->bindParam(":serviceexcellence_level5_c1", $serviceexcellence_level5_c1);
        $stmt->bindParam(":serviceexcellence_level5_c2", $serviceexcellence_level5_c2);
        $stmt->bindParam(":serviceexcellence_level5_c3", $serviceexcellence_level5_c3);
        $stmt->bindParam(":serviceexcellence_level5_c4", $serviceexcellence_level5_c4);
        $stmt->bindParam(":serviceexcellence_level5_c5", $serviceexcellence_level5_c5);

        $stmt->bindParam(":safetyandsecurity_level1_c1", $safetyandsecurity_level1_c1);
        $stmt->bindParam(":safetyandsecurity_level1_c2", $safetyandsecurity_level1_c2);
        $stmt->bindParam(":safetyandsecurity_level1_c3", $safetyandsecurity_level1_c3);
        $stmt->bindParam(":safetyandsecurity_level3_c1", $safetyandsecurity_level3_c1);
        $stmt->bindParam(":safetyandsecurity_level3_c2", $safetyandsecurity_level3_c2);
        $stmt->bindParam(":safetyandsecurity_level3_c3", $safetyandsecurity_level3_c3);
        $stmt->bindParam(":safetyandsecurity_level3_c4", $safetyandsecurity_level3_c4);
        $stmt->bindParam(":safetyandsecurity_level5_c1", $safetyandsecurity_level5_c1);
        $stmt->bindParam(":safetyandsecurity_level5_c2", $safetyandsecurity_level5_c2);
        $stmt->bindParam(":safetyandsecurity_level5_c3", $safetyandsecurity_level5_c3);
        $stmt->bindParam(":safetyandsecurity_level5_c4", $safetyandsecurity_level5_c4);

        $stmt->bindParam(":digitalliteracy_level1_c1", $digitalliteracy_level1_c1);
        $stmt->bindParam(":digitalliteracy_level1_c2", $digitalliteracy_level1_c2);
        $stmt->bindParam(":digitalliteracy_level1_c3", $digitalliteracy_level1_c3);
        $stmt->bindParam(":digitalliteracy_level3_c1", $digitalliteracy_level3_c1);
        $stmt->bindParam(":digitalliteracy_level3_c2", $digitalliteracy_level3_c2);
        $stmt->bindParam(":digitalliteracy_level3_c3", $digitalliteracy_level3_c3);
        $stmt->bindParam(":digitalliteracy_level3_c4", $digitalliteracy_level3_c4);
        $stmt->bindParam(":digitalliteracy_level5_c1", $digitalliteracy_level5_c1);
        $stmt->bindParam(":digitalliteracy_level5_c2", $digitalliteracy_level5_c2);
        $stmt->bindParam(":digitalliteracy_level5_c3", $digitalliteracy_level5_c3);
        $stmt->bindParam(":digitalliteracy_level5_c4", $digitalliteracy_level5_c4);


        // insert a row
        $full_name = $data->full_name;
        $level = $data->level;
        $businessAcu_level1_c1 = $data->businessAcu->level1->c1;
        $businessAcu_level1_c2 = $data->businessAcu->level1->c2;
        $businessAcu_level1_c3 = $data->businessAcu->level1->c3;
        $businessAcu_level1_c4 = $data->businessAcu->level1->c4;
        $businessAcu_level3_c1 = $data->businessAcu->level3->c1;
        $businessAcu_level3_c2 = $data->businessAcu->level3->c2;
        $businessAcu_level3_c3 = $data->businessAcu->level3->c3;
        $businessAcu_level3_c4 = $data->businessAcu->level3->c4;
        $businessAcu_level5_c1 = $data->businessAcu->level5->c1;
        $businessAcu_level5_c2 = $data->businessAcu->level5->c2;
        $businessAcu_level5_c3 = $data->businessAcu->level5->c3;
        $businessAcu_level5_c4 = $data->businessAcu->level5->c4;

        $initiative_level1_c1 = $data->initiative->level1->c1;
        $initiative_level1_c2 = $data->initiative->level1->c2;
        $initiative_level1_c3 = $data->initiative->level1->c3;
        $initiative_level3_c1 = $data->initiative->level3->c1;
        $initiative_level3_c2 = $data->initiative->level3->c2;
        $initiative_level3_c3 = $data->initiative->level3->c3;
        $initiative_level3_c4 = $data->initiative->level3->c4;
        $initiative_level3_c5 = $data->initiative->level3->c5;
        $initiative_level5_c1 = $data->initiative->level5->c1;
        $initiative_level5_c2 = $data->initiative->level5->c2;
        $initiative_level5_c3 = $data->initiative->level5->c3;

        $collaboration_level1_c1 = $data->collaboration->level1->c1;
        $collaboration_level1_c2 = $data->collaboration->level1->c2;
        $collaboration_level1_c3 = $data->collaboration->level1->c3;
        $collaboration_level3_c1 = $data->collaboration->level3->c1;
        $collaboration_level3_c2 = $data->collaboration->level3->c2;
        $collaboration_level3_c3 = $data->collaboration->level3->c3;
        $collaboration_level3_c4 = $data->collaboration->level3->c4;
        $collaboration_level5_c1 = $data->collaboration->level5->c1;
        $collaboration_level5_c2 = $data->collaboration->level5->c2;
        $collaboration_level5_c3 = $data->collaboration->level5->c3;
        $collaboration_level5_c4 = $data->collaboration->level5->c4;

        $serviceexcellence_level1_c1 = $data->serviceExcellence->level1->c1;
        $serviceexcellence_level1_c2 = $data->serviceExcellence->level1->c2;
        $serviceexcellence_level1_c3 = $data->serviceExcellence->level1->c3;
        $serviceexcellence_level3_c1 = $data->serviceExcellence->level3->c1;
        $serviceexcellence_level3_c2 = $data->serviceExcellence->level3->c2;
        $serviceexcellence_level3_c3 = $data->serviceExcellence->level3->c3;
        $serviceexcellence_level5_c1 = $data->serviceExcellence->level5->c1;
        $serviceexcellence_level5_c2 = $data->serviceExcellence->level5->c2;
        $serviceexcellence_level5_c3 = $data->serviceExcellence->level5->c3;
        $serviceexcellence_level5_c4 = $data->serviceExcellence->level5->c4;
        $serviceexcellence_level5_c5 = $data->serviceExcellence->level5->c5;

        $safetyandsecurity_level1_c1 = $data->safetyAndSecurity->level1->c1;
        $safetyandsecurity_level1_c2 = $data->safetyAndSecurity->level1->c2;
        $safetyandsecurity_level1_c3 = $data->safetyAndSecurity->level1->c3;
        $safetyandsecurity_level3_c1 = $data->safetyAndSecurity->level3->c1;
        $safetyandsecurity_level3_c2 = $data->safetyAndSecurity->level3->c2;
        $safetyandsecurity_level3_c3 = $data->safetyAndSecurity->level3->c3;
        $safetyandsecurity_level3_c4 = $data->safetyAndSecurity->level3->c4;
        $safetyandsecurity_level5_c1 = $data->safetyAndSecurity->level5->c1;
        $safetyandsecurity_level5_c2 = $data->safetyAndSecurity->level5->c2;
        $safetyandsecurity_level5_c3 = $data->safetyAndSecurity->level5->c3;
        $safetyandsecurity_level5_c4 = $data->safetyAndSecurity->level5->c4;

        $digitalliteracy_level1_c1 = $data->digitalLiteracy->level1->c1;
        $digitalliteracy_level1_c2 = $data->digitalLiteracy->level1->c2;
        $digitalliteracy_level1_c3 = $data->digitalLiteracy->level1->c3;
        $digitalliteracy_level3_c1 = $data->digitalLiteracy->level3->c1;
        $digitalliteracy_level3_c2 = $data->digitalLiteracy->level3->c2;
        $digitalliteracy_level3_c3 = $data->digitalLiteracy->level3->c3;
        $digitalliteracy_level3_c4 = $data->digitalLiteracy->level3->c4;
        $digitalliteracy_level5_c1 = $data->digitalLiteracy->level5->c1;
        $digitalliteracy_level5_c2 = $data->digitalLiteracy->level5->c2;
        $digitalliteracy_level5_c3 = $data->digitalLiteracy->level5->c3;
        $digitalliteracy_level5_c4 = $data->digitalLiteracy->level5->c4;

        $stmt->execute();

        echo json_encode(["success"=>true, "data"=>$data]);
    } catch (PDOException $e) {
        echo json_encode(["success"=>false, "message"=>$e->getMessage()]);
    }
      
    $conn = null;
} else {
    echo json_encode(null);
}