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

        $conn = new PDO("mysql:host=$servername;dbname=$database;charset=utf8", $username, $password);
        // set the PDO error mode to exception
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

        // prepare sql and bind parameters
        $stmt = $conn->prepare("INSERT INTO `aot_evaluates` 
        (
        `assessor_code`,
        `full_name`,
        `top_level`,
        `leadership_level1_c1`,
        `leadership_level1_c2`,
        `leadership_level1_c3`,
        `leadership_level3_c1`,
        `leadership_level3_c2`,
        `leadership_level3_c3`,
        `leadership_level5_c1`,
        `leadership_level5_c2`,
        `leadership_level5_c3`,
        `leadership_level5_c4`,
        `businessManagement_level1_c1`,
        `businessManagement_level1_c2`,
        `businessManagement_level1_c3`,
        `businessManagement_level1_c4`,
        `businessManagement_level3_c1`,
        `businessManagement_level3_c2`,
        `businessManagement_level3_c3`,
        `businessManagement_level5_c1`,
        `businessManagement_level5_c2`,
        `businessManagement_level5_c3`,
        `businessManagement_level5_c4`,
        `changeCatalyst_level1_c1`,
        `changeCatalyst_level1_c2`,
        `changeCatalyst_level1_c3`,
        `changeCatalyst_level1_c4`,
        `changeCatalyst_level1_c5`,
        `changeCatalyst_level3_c1`,
        `changeCatalyst_level3_c2`,
        `changeCatalyst_level3_c3`,
        `changeCatalyst_level3_c4`,
        `changeCatalyst_level3_c5`,
        `changeCatalyst_level5_c1`,
        `changeCatalyst_level5_c2`,
        `changeCatalyst_level5_c3`,
        `changeCatalyst_level5_c4`,
        `changeCatalyst_level5_c5`,
        `cSRforSustainable_level1_c1`,
        `cSRforSustainable_level1_c2`,
        `cSRforSustainable_level1_c3`,
        `cSRforSustainable_level1_c4`,
        `cSRforSustainable_level3_c1`,
        `cSRforSustainable_level3_c2`,
        `cSRforSustainable_level3_c3`,
        `cSRforSustainable_level3_c4`,
        `cSRforSustainable_level5_c1`,
        `cSRforSustainable_level5_c2`,
        `cSRforSustainable_level5_c3`,
        `cSRforSustainable_level5_c4`)
        VALUES(
        :assessor_code,
        :full_name,
        :top_level,
        :leadership_level1_c1,
        :leadership_level1_c2,
        :leadership_level1_c3,
        :leadership_level3_c1,
        :leadership_level3_c2,
        :leadership_level3_c3,
        :leadership_level5_c1,
        :leadership_level5_c2,
        :leadership_level5_c3,
        :leadership_level5_c4,
        :businessManagement_level1_c1,
        :businessManagement_level1_c2,
        :businessManagement_level1_c3,
        :businessManagement_level1_c4,
        :businessManagement_level3_c1,
        :businessManagement_level3_c2,
        :businessManagement_level3_c3,
        :businessManagement_level5_c1,
        :businessManagement_level5_c2,
        :businessManagement_level5_c3,
        :businessManagement_level5_c4,
        :changeCatalyst_level1_c1,
        :changeCatalyst_level1_c2,
        :changeCatalyst_level1_c3,
        :changeCatalyst_level1_c4,
        :changeCatalyst_level1_c5,
        :changeCatalyst_level3_c1,
        :changeCatalyst_level3_c2,
        :changeCatalyst_level3_c3,
        :changeCatalyst_level3_c4,
        :changeCatalyst_level3_c5,
        :changeCatalyst_level5_c1,
        :changeCatalyst_level5_c2,
        :changeCatalyst_level5_c3,
        :changeCatalyst_level5_c4,
        :changeCatalyst_level5_c5,
        :cSRforSustainable_level1_c1,
        :cSRforSustainable_level1_c2,
        :cSRforSustainable_level1_c3,
        :cSRforSustainable_level1_c4,
        :cSRforSustainable_level3_c1,
        :cSRforSustainable_level3_c2,
        :cSRforSustainable_level3_c3,
        :cSRforSustainable_level3_c4,
        :cSRforSustainable_level5_c1,
        :cSRforSustainable_level5_c2,
        :cSRforSustainable_level5_c3,
        :cSRforSustainable_level5_c4)");

        $stmt->bindParam(":assessor_code", $assessor_code);
        $stmt->bindParam(':full_name', $full_name);
        $stmt->bindParam(':top_level', $level);

        $stmt->bindParam(":leadership_level1_c1", $leadership_level1_c1);
        $stmt->bindParam(":leadership_level1_c2", $leadership_level1_c2);
        $stmt->bindParam(":leadership_level1_c3", $leadership_level1_c3);
        $stmt->bindParam(":leadership_level3_c1", $leadership_level3_c1);
        $stmt->bindParam(":leadership_level3_c2", $leadership_level3_c2);
        $stmt->bindParam(":leadership_level3_c3", $leadership_level3_c3);
        $stmt->bindParam(":leadership_level5_c1", $leadership_level5_c1);
        $stmt->bindParam(":leadership_level5_c2", $leadership_level5_c2);
        $stmt->bindParam(":leadership_level5_c3", $leadership_level5_c3);
        $stmt->bindParam(":leadership_level5_c4", $leadership_level5_c4);

        $stmt->bindParam(":businessManagement_level1_c1", $businessManagement_level1_c1);
        $stmt->bindParam(":businessManagement_level1_c2", $businessManagement_level1_c2);
        $stmt->bindParam(":businessManagement_level1_c3", $businessManagement_level1_c3);
        $stmt->bindParam(":businessManagement_level1_c4", $businessManagement_level1_c4);
        $stmt->bindParam(":businessManagement_level3_c1", $businessManagement_level3_c1);
        $stmt->bindParam(":businessManagement_level3_c2", $businessManagement_level3_c2);
        $stmt->bindParam(":businessManagement_level3_c3", $businessManagement_level3_c3);
        $stmt->bindParam(":businessManagement_level5_c1", $businessManagement_level5_c1);
        $stmt->bindParam(":businessManagement_level5_c2", $businessManagement_level5_c2);
        $stmt->bindParam(":businessManagement_level5_c3", $businessManagement_level5_c3);
        $stmt->bindParam(":businessManagement_level5_c4", $businessManagement_level5_c4);

        $stmt->bindParam(":changeCatalyst_level1_c1", $changeCatalyst_level1_c1);
        $stmt->bindParam(":changeCatalyst_level1_c2", $changeCatalyst_level1_c2);
        $stmt->bindParam(":changeCatalyst_level1_c3", $changeCatalyst_level1_c3);
        $stmt->bindParam(":changeCatalyst_level1_c4", $changeCatalyst_level1_c4);
        $stmt->bindParam(":changeCatalyst_level1_c5", $changeCatalyst_level1_c5);
        $stmt->bindParam(":changeCatalyst_level3_c1", $changeCatalyst_level3_c1);
        $stmt->bindParam(":changeCatalyst_level3_c2", $changeCatalyst_level3_c2);
        $stmt->bindParam(":changeCatalyst_level3_c3", $changeCatalyst_level3_c3);
        $stmt->bindParam(":changeCatalyst_level3_c4", $changeCatalyst_level3_c4);
        $stmt->bindParam(":changeCatalyst_level3_c5", $changeCatalyst_level3_c5);
        $stmt->bindParam(":changeCatalyst_level5_c1", $changeCatalyst_level5_c1);
        $stmt->bindParam(":changeCatalyst_level5_c2", $changeCatalyst_level5_c2);
        $stmt->bindParam(":changeCatalyst_level5_c3", $changeCatalyst_level5_c3);
        $stmt->bindParam(":changeCatalyst_level5_c4", $changeCatalyst_level5_c4);
        $stmt->bindParam(":changeCatalyst_level5_c5", $changeCatalyst_level5_c5);

        $stmt->bindParam(":cSRforSustainable_level1_c1", $cSRforSustainable_level1_c1);
        $stmt->bindParam(":cSRforSustainable_level1_c2", $cSRforSustainable_level1_c2);
        $stmt->bindParam(":cSRforSustainable_level1_c3", $cSRforSustainable_level1_c3);
        $stmt->bindParam(":cSRforSustainable_level1_c4", $cSRforSustainable_level1_c4);
        $stmt->bindParam(":cSRforSustainable_level3_c1", $cSRforSustainable_level3_c1);
        $stmt->bindParam(":cSRforSustainable_level3_c2", $cSRforSustainable_level3_c2);
        $stmt->bindParam(":cSRforSustainable_level3_c3", $cSRforSustainable_level3_c3);
        $stmt->bindParam(":cSRforSustainable_level3_c4", $cSRforSustainable_level3_c4);
        $stmt->bindParam(":cSRforSustainable_level5_c1", $cSRforSustainable_level5_c1);
        $stmt->bindParam(":cSRforSustainable_level5_c2", $cSRforSustainable_level5_c2);
        $stmt->bindParam(":cSRforSustainable_level5_c3", $cSRforSustainable_level5_c3);
        $stmt->bindParam(":cSRforSustainable_level5_c4", $cSRforSustainable_level5_c4);

        // insert a row
        $assessor_code = intval($data->assessor->code);
        $full_name = $data->full_name;
        $level = $data->level;

        $leadership_level1_c1 = $data->leadership->level1->c1 == "true" ? 1:0;
        $leadership_level1_c2 = $data->leadership->level1->c2 == "true" ? 1:0;
        $leadership_level1_c3 = $data->leadership->level1->c3 == "true" ? 1:0;
        $leadership_level3_c1 = $data->leadership->level3->c1 == "true" ? 1:0;
        $leadership_level3_c2 = $data->leadership->level3->c2 == "true" ? 1:0;
        $leadership_level3_c3 = $data->leadership->level3->c3 == "true" ? 1:0;
        $leadership_level5_c1 = $data->leadership->level5->c1 == "true" ? 1:0;
        $leadership_level5_c2 = $data->leadership->level5->c2 == "true" ? 1:0;
        $leadership_level5_c3 = $data->leadership->level5->c3 == "true" ? 1:0;
        $leadership_level5_c4 = $data->leadership->level5->c4 == "true" ? 1:0;

        $businessManagement_level1_c1 = $data->businessManagement->level1->c1 == "true" ? 1:0;
        $businessManagement_level1_c2 = $data->businessManagement->level1->c2 == "true" ? 1:0;
        $businessManagement_level1_c3 = $data->businessManagement->level1->c3 == "true" ? 1:0;
        $businessManagement_level1_c4 = $data->businessManagement->level1->c4 == "true" ? 1:0;
        $businessManagement_level3_c1 = $data->businessManagement->level3->c1 == "true" ? 1:0;
        $businessManagement_level3_c2 = $data->businessManagement->level3->c2 == "true" ? 1:0;
        $businessManagement_level3_c3 = $data->businessManagement->level3->c3 == "true" ? 1:0;
        $businessManagement_level5_c1 = $data->businessManagement->level5->c1 == "true" ? 1:0;
        $businessManagement_level5_c2 = $data->businessManagement->level5->c2 == "true" ? 1:0;
        $businessManagement_level5_c3 = $data->businessManagement->level5->c3 == "true" ? 1:0;
        $businessManagement_level5_c4 = $data->businessManagement->level5->c4 == "true" ? 1:0;

        $changeCatalyst_level1_c1 = $data->changeCatalyst->level1->c1 == "true" ? 1:0;
        $changeCatalyst_level1_c2 = $data->changeCatalyst->level1->c2 == "true" ? 1:0;
        $changeCatalyst_level1_c3 = $data->changeCatalyst->level1->c3 == "true" ? 1:0;
        $changeCatalyst_level1_c4 = $data->changeCatalyst->level1->c4 == "true" ? 1:0;
        $changeCatalyst_level1_c5 = $data->changeCatalyst->level1->c5 == "true" ? 1:0;
        $changeCatalyst_level3_c1 = $data->changeCatalyst->level3->c1 == "true" ? 1:0;
        $changeCatalyst_level3_c2 = $data->changeCatalyst->level3->c2 == "true" ? 1:0;
        $changeCatalyst_level3_c3 = $data->changeCatalyst->level3->c3 == "true" ? 1:0;
        $changeCatalyst_level3_c4 = $data->changeCatalyst->level3->c4 == "true" ? 1:0;
        $changeCatalyst_level3_c5 = $data->changeCatalyst->level3->c5 == "true" ? 1:0;
        $changeCatalyst_level5_c1 = $data->changeCatalyst->level5->c1 == "true" ? 1:0;
        $changeCatalyst_level5_c2 = $data->changeCatalyst->level5->c2 == "true" ? 1:0;
        $changeCatalyst_level5_c3 = $data->changeCatalyst->level5->c3 == "true" ? 1:0;
        $changeCatalyst_level5_c4 = $data->changeCatalyst->level5->c4 == "true" ? 1:0;
        $changeCatalyst_level5_c5 = $data->changeCatalyst->level5->c5 == "true" ? 1:0;

        $cSRforSustainable_level1_c1 = $data->cSRforSustainable->level1->c1 == "true" ? 1:0;
        $cSRforSustainable_level1_c2 = $data->cSRforSustainable->level1->c2 == "true" ? 1:0;
        $cSRforSustainable_level1_c3 = $data->cSRforSustainable->level1->c3 == "true" ? 1:0;
        $cSRforSustainable_level1_c4 = $data->cSRforSustainable->level1->c4 == "true" ? 1:0;
        $cSRforSustainable_level3_c1 = $data->cSRforSustainable->level3->c1 == "true" ? 1:0;
        $cSRforSustainable_level3_c2 = $data->cSRforSustainable->level3->c2 == "true" ? 1:0;
        $cSRforSustainable_level3_c3 = $data->cSRforSustainable->level3->c3 == "true" ? 1:0;
        $cSRforSustainable_level3_c4 = $data->cSRforSustainable->level3->c4 == "true" ? 1:0;
        $cSRforSustainable_level5_c1 = $data->cSRforSustainable->level5->c1 == "true" ? 1:0;
        $cSRforSustainable_level5_c2 = $data->cSRforSustainable->level5->c2 == "true" ? 1:0;
        $cSRforSustainable_level5_c3 = $data->cSRforSustainable->level5->c3 == "true" ? 1:0;
        $cSRforSustainable_level5_c4 = $data->cSRforSustainable->level5->c4 == "true" ? 1:0;

        $stmt->execute();

        echo json_encode(["success"=>true, "data"=>$data]);
    } catch (PDOException $e) {
        echo json_encode(["success"=>false, "message"=>$e->getMessage()]);
    }
      
    $conn = null;
} else {
    echo json_encode(null);
}