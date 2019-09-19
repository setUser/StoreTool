<?php
class DBConnection
{
    protected $_servername;
    protected $_username;
    protected $_password;
    protected $_dbname;
    protected $_TableName;
    protected $_PrimaryKeyName;
    protected $_TimeStampName;
    function __construct($servername, $username, $password, $dbname, $TableName, $PrimaryKeyName, $TimeStampName, $CreateTable = false, $TableStructureQuery = "")
    {
        $this->_servername = $servername;
        $this->_username = $username;
        $this->_password = $password;
        $this->_dbname = $dbname;
        $this->_TableName = $TableName;
        $this->_PrimaryKeyName = $PrimaryKeyName;
        $this->_TimeStampName = $TimeStampName;
        if ($CreateTable) {
            $conn = new mysqli($this->_servername, $this->_username, $this->_password, $this->_dbname);
            if ($conn->connect_error) {
                die($conn->connect_error);
            };
            $conn->query($TableStructureQuery);
            $conn->close();
        }
    }
    function Count()
    {
        $conn = new mysqli($this->_servername, $this->_username, $this->_password, $this->_dbname);
        if ($conn->connect_error) {
            die($conn->connect_error);
        };
        $result = $conn->query("SELECT COUNT($this->_PrimaryKeyName) FROM $this->_TableName;");
        $Count = $result->fetch_assoc();
        $conn->close();
        return (int)$Count["COUNT($this->_PrimaryKeyName)"];
    }
    function Keys()
    {
        $Keys = null;
        $conn = new mysqli($this->_servername, $this->_username, $this->_password, $this->_dbname);
        if ($conn->connect_error) {
            die($conn->connect_error);
        };
        $result = $conn->query("SELECT $this->_PrimaryKeyName FROM $this->_TableName ORDER BY $this->_PrimaryKeyName;");
        $counter = 0;
        while ($row = $result->fetch_assoc()) {
            $Keys[$counter++] = $row["$this->_PrimaryKeyName"];
        }
        $conn->close();
        return $Keys;
    }
    function InsertRow($Key, $Columns = "#NoData-?", $Values = "#NoData-?", $Time = "#NoData-?")
    {
        $FColumns = "";
        $FValores = "";
        if ($Columns != "#NoData-?" || $Values != "#NoData-?") {
            $FColumns = ", $Columns";
            $FValores = ", $Values";
        }
        $conn = new mysqli($this->_servername, $this->_username, $this->_password, $this->_dbname);
        if ($conn->connect_error) {
            die($conn->connect_error);
        };
        if ($Time == "#NoData-?") {
            $Time = "CURRENT_TIMESTAMP";
        }
        $Successfully = $conn->query("INSERT INTO $this->_TableName ($this->_PrimaryKeyName, $this->_TimeStampName $FColumns)
        VALUES ($Key, $Time $FValores);");
        $conn->close();
        return $Successfully;
    }
    function DeleteRow($Key)
    {
        $conn = new mysqli($this->_servername, $this->_username, $this->_password, $this->_dbname);
        if ($conn->connect_error) {
            die($conn->connect_error);
        };
        $Successfully = $conn->query("DELETE FROM $this->_TableName WHERE $this->_PrimaryKeyName = $Key;");
        $conn->close();
        return $Successfully;
    }
    function SetField($Key, $Column, $Value, $Time = false, $KeyName = "#NoData-?", $ComplexKey = false)
    {
        $FKey = $Key;
        $FKeyName = $KeyName;
        if (!is_numeric($Key) && !$ComplexKey) {
            $FKey = "'$Key'";
        }
        if ($KeyName == "#NoData-?") {
            $FKeyName = $this->_PrimaryKeyName;
        }
        $FValue = $Value;
        if (!is_numeric($Value)) {
            $FValue = "'$Value'";
        }
        $conn = new mysqli($this->_servername, $this->_username, $this->_password, $this->_dbname);
        if ($conn->connect_error) {
            die($conn->connect_error);
        };
        $FTime = "";
        if ($Time) {
            $FTime = ", $this->_TimeStampName = CURRENT_TIMESTAMP";
        }
        $Successfully = $conn->query("UPDATE $this->_TableName SET $Column = $FValue $FTime WHERE $FKeyName = $FKey;");
        $conn->close();
        return $Successfully;
    }
    function GetField($Key, $Column, $ReturnArray = false, $KeyName = "#NoData-?", $OrderBy =  "#NoData-?")
    {
        $FKey = $Key;
        $FKeyName = $KeyName;
        $FOrderBy = $OrderBy;
        if (!is_numeric($Key)) {
            $FKey = "'$Key'";
        }
        if ($KeyName == "#NoData-?") {
            $FKeyName = $this->_PrimaryKeyName;
        }
        $FColumn = "$Column";
        $Where = "WHERE $FKeyName = $FKey";
        if ($Key == "#Distinct") {
            $FColumn = "DISTINCT($Column)";
            $Where = "";
        }
        if ($OrderBy == "#NoData-?") {
            $FOrderBy = $Column;
        }
        $Fields = null;
        $conn = new mysqli($this->_servername, $this->_username, $this->_password, $this->_dbname);
        if ($conn->connect_error) {
            die($conn->connect_error);
        };
        $result = $conn->query("SELECT $FColumn FROM $this->_TableName $Where ORDER BY $FOrderBy;");
        $counter = 0;
        while ($row = $result->fetch_assoc()) {
            $Fields[$counter++] = $row["$Column"];
        }
        $conn->close();
        if ($ReturnArray) {
            return $Fields;
        } else {
            return $Fields[0];
        }
    }
}
