<?php
class Ordenes_ElPancito
{
    private $_dbname = "DB_ElPancito";
    private $_TableName = "Ordenes_ElPancito";
    private $_PrimaryKeyName = "CodigoOrden";
    private $_TimeStampName = "TiempoOrden";
    private $_DBConnection;
    private $_Table;
    function __construct($Fecha)
    {
        $this->_TableName = "$this->_TableName" . "_$Fecha";
        $this->_DBConnection = new DBConnection(
            servername,
            username,
            password,
            $this->_dbname,
            $this->_TableName,
            $this->_PrimaryKeyName,
            $this->_TimeStampName,
            true,
            "CREATE TABLE IF NOT EXISTS `DB_ElPancito`.`$this->_TableName` ( 
            `CodigoOrden` INT(8) NOT NULL , 
            `TiempoOrden` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP , 
            `CodigoProducto` INT(8) NOT NULL , 
            `PrecioProducto` DECIMAL(8,2) NOT NULL , 
            `CantidadProducto` INT(3) NOT NULL ,
            PRIMARY KEY (CodigoOrden, CodigoProducto));"
        );
        $this->UpdateNow();
    }
    function Last()
    {
        if ($this->_DBConnection->Count() != 0) {
            return $this->_Table[$this->Keys()[$this->Count() - 1]];
        } else {
            return null;
        }
        return null;
    }
    function Index($Codigo)
    {
        if ($this->_DBConnection->Count() != 0) {
            return $this->_Table[$Codigo];
        } else {
            return null;
        }
        return null;
    }
    function Keys()
    {
        if ($this->_DBConnection->Count() != 0) {
            return array_keys($this->_Table);
        } else {
            return null;
        }
        return null;
    }
    function Count()
    {
        if ($this->_DBConnection->Count() != 0) {
            return count($this->_Table);
        } else {
            return 0;
        }
        return 0;
    }
    function Add($Codigo, $Precio, $Cantidad, $Crear = false, $Tiempo = "#NoData-?")
    {
        if ($this->_DBConnection->Count() != 0) {
            $Orden = $this->_DBConnection->GetField("0 AND CodigoProducto = 0", "CantidadProducto");
            if ($Crear) {
                $Orden++;
                $this->_DBConnection->SetField("0 AND CodigoProducto = 0", "CantidadProducto", $Orden, false, "#NoData-?", true);
            }
        } else {
            $this->_DBConnection->SetField("0 AND CodigoProducto = 0", "CantidadProducto", 1, false, "#NoData-?", true);
            $Orden = 1;
        }
        $Successfully = $this->_DBConnection->InsertRow($Orden, "CodigoProducto, PrecioProducto, CantidadProducto", "$Codigo, $Precio, $Cantidad", $Tiempo);
        $this->_Table[$Orden] = new Orden_ElPancito($this->_DBConnection, $Orden);
        return $Successfully;
    }
    function Remove($Codigo)
    {
        if ($this->_DBConnection->Count() != 0) {
            unset($this->_Table[$Codigo]);
            return $this->_DBConnection->DeleteRow($Codigo);
        } else {
            return false;
        }
        return false;
    }
    function UpdateNow()
    {
        if ($this->_DBConnection->Count() != 0) {
            $this->_Table = null;
            foreach ($this->_DBConnection->GetField("#Distinct", $this->_PrimaryKeyName, true) as $Orden) {
                $this->_Table[$Orden] = new Orden_ElPancito($this->_DBConnection, $Orden);
            }
        } else {
            $this->_DBConnection->InsertRow(0, "CodigoProducto, PrecioProducto, CantidadProducto", "0, 0, 0");
        }
    }
}
class Orden_ElPancito
{
    private $_DBConnection;
    private $_Orden;
    private $_Productos;
    function __construct($DBConnection, $Orden)
    {
        $this->_DBConnection = $DBConnection;
        $this->_Orden = $Orden;
        $this->UpdateNow();
    }
    function Index($Index)
    {
        return $this->_Productos[$Index];
    }
    function Orden()
    {
        return $this->_Orden;
    }
    function Count()
    {
        return count($this->_Productos);
    }
    function Add($Producto, $Precio, $Cantidad)
    {
        $Successfully = $this->_DBConnection->InsertRow($this->_Orden, "CodigoProducto, PrecioProducto, CantidadProducto", "$Producto, $Precio, $Cantidad");
        if ($Successfully) {
            $this->_Productos[count($this->_Productos)] = new Producto_De_Orden_ElPancito($this->_DBConnection, $this->_Orden, $Producto);
        }
        return $Successfully;
    }
    function Remove($Index)
    {
        $Successfully = $this->_DBConnection->DeleteRow("$this->_Orden AND CodigoProducto = " . $this->_Productos[$Index]->Producto());
        if ($Successfully) {
            $this->UpdateNow();
        }
        return $Successfully;
    }
    function UpdateNow()
    {
        $this->_Productos = null;
        $counter = 0;
        foreach ($this->_DBConnection->GetField($this->_Orden, "CodigoProducto", true, "CodigoOrden", "TiempoOrden") as $Producto) {
            $this->_Productos[$counter++] = new Producto_De_Orden_ElPancito($this->_DBConnection, $this->_Orden, $Producto);
        }
    }
}
class Producto_De_Orden_ElPancito
{
    private $_DBConnection;
    private $_Orden;
    private $_Producto;
    private $_Precio = 0;
    private $_Cantidad = 0;
    private $_Tiempo = null;
    private $_PrecioIsUpdate = false;
    private $_CantidadIsUpdate = false;
    private $_TiempoIsUpdate = false;
    function __construct($DBConnection, $Orden, $Producto)
    {
        $this->_DBConnection = $DBConnection;
        $this->_Orden = $Orden;
        $this->_Producto = $Producto;
    }
    function Producto()
    {
        return $this->_Producto;
    }
    function Precio($Precio = "#NoData-?")
    {
        if ($Precio == "#NoData-?") {
            if ($this->_PrecioIsUpdate) {
                return $this->_Precio;
            } else {
                $this->_PrecioIsUpdate = true;
                return $this->_Precio = $this->_DBConnection->GetField("$this->_Orden AND CodigoProducto = $this->_Producto", "PrecioProducto");
            }
        } else {
            $this->_PrecioIsUpdate = false;
            return $this->_DBConnection->SetField("$this->_Orden AND CodigoProducto = $this->_Producto", "PrecioProducto", $Precio, false, "#NoData-?", true);
        }
    }
    function Cantidad($Cantidad = "#NoData-?")
    {
        if ($Cantidad == "#NoData-?") {
            if ($this->_CantidadIsUpdate) {
                return $this->_Cantidad;
            } else {
                $this->_CantidadIsUpdate = true;
                return $this->_Cantidad = $this->_DBConnection->GetField("$this->_Orden AND CodigoProducto = $this->_Producto", "CantidadProducto");
            }
        } else {
            $this->_CantidadIsUpdate = false;
            return $this->_DBConnection->SetField("$this->_Orden AND CodigoProducto = $this->_Producto", "CantidadProducto", $Cantidad, false, "#NoData-?", true);
        }
    }
    function Tiempo()
    {
        if ($this->_TiempoIsUpdate) {
            return $this->_Tiempo;
        } else {
            $this->_TiempoIsUpdate = true;
            return $this->_Tiempo = $this->_DBConnection->GetField("$this->_Orden AND CodigoProducto = $this->_Producto", "TiempoOrden");
        }
    }
}
