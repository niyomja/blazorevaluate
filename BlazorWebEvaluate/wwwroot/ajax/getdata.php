<?php
header("Content-Type: application/json;charset=UTF-8");

include('inc.ini.php');

//include('dev.ini.php');

try {
    $conn = new PDO("mysql:host=$servername;dbname=$database", $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    $stmt = $conn->prepare("SELECT * FROM `dev_evaluates` ORDER BY `full_name` ASC");
    $stmt->execute();
  
    // set the resulting array to associative
    $result = $stmt->setFetchMode(PDO::FETCH_ASSOC);

    $data = $stmt->fetchAll();
    
    print(json_encode($data, JSON_NUMERIC_CHECK));
} catch (PDOException $e) {
    echo json_encode([]);
}
$conn = null;


function cast_query_results($result): array
{
    if ($result === false)
      return null;

    $data = array();
    $fields = $result->fetch_fields();
    while ($row = $result->fetch_assoc()) {
      foreach ($fields as $field) {
        $fieldName = $field->name;
        $fieldValue = $row[$fieldName];
        if (!is_null($fieldValue))
            switch ($field->type) {
              case 3:
                $row[$fieldName] = (int)$fieldValue;
                break;
              case 4:
                $row[$fieldName] = (float)$fieldValue;
                break;
              // Add other type conversions as desired.
              // Strings are already strings, so don't need to be touched.
            }
      }
      array_push($data, $row);
    }

    return $data;
}