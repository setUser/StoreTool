<?php
$root = realpath($_SERVER["DOCUMENT_ROOT"]);
require($root . '/Resources/host.php');
require($root . '/src/Connection.php');
require($root . '/Model/Productos.php');
require($root . '/Model/Ordenes.php');

date_default_timezone_set("America/Costa_Rica");
$Productos = new Productos_ElPancito();
$Ordenes = new Ordenes_ElPancito(date("Y_m"));
///////////////////////////////////////////////////////////////////////
if (!isset($_POST["RequestType"])) {
    require('./View/Store/index.html');
    $CategoryModel = $Productos->CategoryModel();
    $ProductsKeyModel = $Productos->KeysModel();
    $ProductsModel = $Productos->TableModel();

    if ($CategoryModel != null && $ProductsKeyModel != null && $ProductsModel != null) {
        echo "<script>var CategoryModel = " . json_encode($CategoryModel, JSON_INVALID_UTF8_SUBSTITUTE | JSON_PRETTY_PRINT) . ";</script>";
        echo "<script>var ProductsKeyModel = " . json_encode($ProductsKeyModel, JSON_INVALID_UTF8_SUBSTITUTE | JSON_PRETTY_PRINT) . ";</script>";
        echo "<script>var ProductsModel = " . json_encode($ProductsModel, JSON_INVALID_UTF8_SUBSTITUTE | JSON_PRETTY_PRINT) . ";</script>";
    } else {
        echo "<script>alert('Fallo al Cargar Modelos de la Base de Datos');</script";
    }
    ///////////////////////////////////////////////////////////////////////
} else {
    if ($_POST["RequestType"] == "UploadOrder") {
        $CurrentOrderJSON = $_POST["CurrentOrder"];
        $CurrentOrderArray = json_decode($CurrentOrderJSON);
        $NewOrder = true;
        foreach ($CurrentOrderArray as $ProductJSON) {
            $Product = json_decode($ProductJSON);
            $ProductKey = $Product->ProductKey;
            $ProductPrice = $Productos->Index((int)$ProductKey)->Precio();
            $ProductQuantity = $Product->ProductQuantity;
            if ($NewOrder) {
                $Ordenes->Add((int)$ProductKey, (float)$ProductPrice, (int)$ProductQuantity, true);
                $NewOrder = false;
            } else {
                $Ordenes->Add((int)$ProductKey, (float)$ProductPrice, (int)$ProductQuantity);
            }
        }
        echo "Orden #" . $Ordenes->Last()->Orden() . " Guardada el " . $Ordenes->Last()->Index(0)->Tiempo();
    }
}