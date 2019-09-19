<?php
class Productos_ElPancito
{
    private $_dbname = "DB_ElPancito";
    private $_TableName = "Productos_ElPancito";
    private $_PrimaryKeyName = "CodigoProducto";
    private $_TimeStampName = "UltimaModificacionProducto";
    private $_DBConnection;
    private $_Table;
    function CategoryModel()
    {
        if ($this->_DBConnection->Count() != 0) {
            $Categorias[0] = "Todo";
            $counter = 1;
            foreach ($this->_DBConnection->GetField("#Distinct", "CategoriaProducto", true) as $Categoria) {
                $Categorias[$counter++] = $Categoria;
            }
            return $Categorias;
        } else {
            return null;
        }
        return null;
    }
    function KeysModel()
    {
        if ($this->_DBConnection->Count() != 0) {
            foreach ($this->CategoryModel() as $Categoria) {
                $Keys = null;
                $counter = 0;
                foreach (array_keys($this->_Table) as $Key) {
                    if ($this->_Table[$Key]->Categoria() == $Categoria) {
                        $Keys[$counter++] = $Key;
                    }
                }
                $_KeysTable[$Categoria] = $Keys;
            }
            $_KeysTable["Todo"] = array_keys($this->_Table);
            return $_KeysTable;
        } else {
            return null;
        }
        return null;
    }
    function TableModel()
    {
        if ($this->_DBConnection->Count() != 0) {
            foreach ($this->_Table as $Key => $Value) {
                $_ModelTable[$Key]["Categoria"] = $Value->Categoria();
                $_ModelTable[$Key]["Nombre"] = $Value->Nombre();
                $_ModelTable[$Key]["Precio"] = $Value->Precio();
            }
            return $_ModelTable;
        }
        return null;
    }
    //---------------------------------------------------------------------------------------------------------------------
    function __construct()
    {
        $this->_DBConnection = new DBConnection(servername, username, password, $this->_dbname, $this->_TableName, $this->_PrimaryKeyName, $this->_TimeStampName);
        $this->UpdateNow(false);
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
    function Keys($Categoria = "#NoData-?")
    {
        if ($this->_DBConnection->Count() != 0) {
            if ($Categoria == "#NoData-?") {
                return array_keys($this->_Table);
            } else {
                $Keys = null;
                $counter = 0;
                foreach (array_keys($this->_Table) as $Key) {
                    if ($this->_Table[$Key]->Categoria() == $Categoria) {
                        $Keys[$counter++] = $Key;
                    }
                }
                return $Keys;
            }
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
    function Add($Codigo, $Categoria = "Sin Categoria", $Nombre = "Sin Nombre", $Precio = 0)
    {
        $this->_Table[$Codigo] = new Producto_ElPancito($this->_DBConnection, $Codigo, $Categoria, $Nombre);
        return $this->_DBConnection->InsertRow($Codigo, "CategoriaProducto, NombreProducto, PrecioProducto", "'$Categoria', '$Nombre', $Precio");
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
            foreach ($this->_DBConnection->Keys() as $Codigo) {
                $this->_Table[$Codigo] = new Producto_ElPancito($this->_DBConnection, $Codigo);
            }
        }
    }
}
class Producto_ElPancito
{
    private $_DBConnection;
    private $_Codigo;
    private $_Categoria = "";
    private $_Nombre = "";
    private $_Precio = 0;
    private $_UltimaModificacion = null;
    private $_CategoriaIsUpdate = false;
    private $_NombreIsUpdate = false;
    private $_PrecioIsUpdate = false;
    private $_UltimaModificacionIsUpdate = false;
    function __construct($DBConnection, $Codigo, $Categoria = "#NoData-?", $Nombre = "#NoData-?")
    {
        $this->_DBConnection = $DBConnection;
        $this->_Codigo = $Codigo;
        if ($Categoria != "#NoData-?") {
            $this->_Category = $Categoria;
            $this->_CategoriaIsUpdate = true;
        }
        if ($Nombre != "#NoData-?") {
            $this->_Nombre = $Nombre;
            $this->_NombreIsUpdate = true;
        }
    }
    function Codigo()
    {
        return $this->_Codigo;
    }
    function Categoria($Categoria = "#NoData-?")
    {
        if ($Categoria == "#NoData-?") {
            if ($this->_CategoriaIsUpdate) {
                return $this->_Categoria;
            } else {
                $this->_CategoriaIsUpdate = true;
                return $this->_Categoria = $this->_DBConnection->GetField($this->_Codigo, "CategoriaProducto");
            }
        } else {
            $this->_CategoriaIsUpdate = false;
            $this->_UltimaModificacionIsUpdate = false;
            return $this->_DBConnection->SetField($this->_Codigo, "CategoriaProducto", $Categoria, true);
        }
    }
    function Nombre($Nombre = "#NoData-?")
    {
        if ($Nombre == "#NoData-?") {
            if ($this->_NombreIsUpdate) {
                return $this->_Nombre;
            } else {
                $this->_NombreIsUpdate = true;
                return $this->_Nombre = $this->_DBConnection->GetField($this->_Codigo, "NombreProducto");
            }
        } else {
            $this->_NombreIsUpdate = false;
            $this->_UltimaModificacionIsUpdate = false;
            return $this->_DBConnection->SetField($this->_Codigo, "NombreProducto", $Nombre, true);
        }
    }
    function Precio($Precio = "#NoData-?")
    {
        if ($Precio == "#NoData-?") {
            if ($this->_PrecioIsUpdate) {
                return $this->_Precio;
            } else {
                $this->_PrecioIsUpdate = true;
                return $this->_Precio = $this->_DBConnection->GetField($this->_Codigo, "PrecioProducto");
            }
        } else {
            $this->_PrecioIsUpdate = false;
            $this->_UltimaModificacionIsUpdate = false;
            return $this->_DBConnection->SetField($this->_Codigo, "PrecioProducto", $Precio, true);
        }
    }
    function UltimaModificacion()
    {
        if ($this->_UltimaModificacionIsUpdate) {
            return $this->_UltimaModificacion;
        } else {
            $this->_UltimaModificacionIsUpdate = true;
            return $this->_UltimaModificacion = $this->_DBConnection->GetField($this->_Codigo, "UltimaModificacionProducto");
        }
    }
}
